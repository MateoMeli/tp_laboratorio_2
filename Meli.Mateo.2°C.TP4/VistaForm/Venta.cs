using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Windows.Forms;
using Productos;
using Excepciones;
using System.IO;

namespace VistaForm
{
    public partial class Venta : Form
    {
        private Cliente cliente;
        private Articulo articulo;
        public Venta()
        {
            InitializeComponent();
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


        private void BtnAceptar_OnClick(object sender, EventArgs e)
        {
            try
            {
                articulo = Producto;
                cliente = new Cliente(Nombre, Apellido, articulo, Forma);
                this.richTextBoxVentas.Text = cliente.ToString();
                this.btnTicket.Visible = true;
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
                    string rutaCompletarda = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string rutaCompleta = rutaCompletarda + @"\" + "Ticket.txt";
                    streamWriter = new StreamWriter(rutaCompleta, false);
                    streamWriter.WriteLine(cliente.ToString());
                }
            }
            finally
            {
                if (streamWriter != null)
                    streamWriter.Close();
            }
            
        }
    }
    
}
