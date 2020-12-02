using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Entidades;
using System.Windows.Forms;
using Productos;
using Excepciones;
using System.IO;

namespace VistaForm
{
    public partial class VentaForm : Form
    {
        private Cliente cliente;
        private Articulo articulo;
        private InformeForm informe;
        private Thread t;
        private Farmacia farmacia;
        private InformeDAO informeDao;
        public VentaForm(Farmacia f)
        {
            InitializeComponent();
            farmacia = f;
            informeDao = new InformeDAO();
            this.informe = new InformeForm();
        }
        public string Nombre
        {
            get
            {
                return this.textBoxNombre.Text;
            }
        }
        public string Apellido
        {
            get
            {
                return this.textBoxApellido.Text;
            }
        }
        public Articulo Producto
        {
            get
            { 
                if(this.listBoxProducto != null)
                {
                    switch (this.listBoxProducto.SelectedIndex)
                    {
                        case 0:
                            return new Articulo(Articulo.TipoProducto.Antibiotico);
                        case 1:
                            return new Articulo(Articulo.TipoProducto.Analgesico);
                        case 2:
                            return new Articulo(Articulo.TipoProducto.Crema);
                    }
                }
                throw new FormVentaException("Debe seleccionar el tipo de producto");
                
                
                
            }
        }
        public Cliente.FormaDePago Forma
        {
            get
            {
                if(this.listBoxTipoPago != null)
                {
                    switch (this.listBoxTipoPago.SelectedIndex)
                    {
                        case 0:
                            return Cliente.FormaDePago.Tarjeta;
                        case 1:
                            return Cliente.FormaDePago.TarjetaJubilado;
                        case 2:
                            return Cliente.FormaDePago.Efectivo;
                    }
                }
                throw new FormVentaException("Debe seleccionar la forma de pago");

            }
        }

        public Cliente Persona
        {
            get
            {
                return this.cliente;
            }
        }

        private void BtnAceptar_OnClick(object sender, EventArgs e)
        {
            try
            {
                articulo = Producto;
                cliente = new Cliente(Nombre, Apellido, articulo, Forma);
                this.richTextBoxVentas.Text = cliente.ToString();
                farmacia += cliente;
                t = new Thread(new ParameterizedThreadStart(informeDao.InsertarUnProducto));
                t.Start(cliente);
                informe.Agregar(cliente);
                if(cliente is Cliente)
                {
                    btnTicket.Visible = true;
                }
            }
            catch (DatoInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormVentaException ex)
            {
                MessageBox.Show(ex.Message);

            }catch (TicketException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnTicket_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = null;
            
            try
            {
                if(this.cliente != null)
                {
                    string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string rutaCompleta = ruta + @"\" + "Ticket" + $"{Apellido}" + ".txt";
                    streamWriter = new StreamWriter(rutaCompleta, false);
                    streamWriter.WriteLine(cliente.ToString());
                    MessageBox.Show("Ticket escrito con exito");
                }
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            informe.RTB.Text = informe.Imprimir();
            this.informe.ShowDialog();
        }

        private void Venta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t != null || t.IsAlive)
            {
                t.Abort();
            }
        }
    }
    
}
