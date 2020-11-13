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
                Articulo nuevo = null;
                switch (this.listBoxProducto.SelectedItem.ToString())
                {
                    case "Analgesico":
                        nuevo = new Articulo(Articulo.TipoProducto.Analgesico);
                        break;
                    case "Crema":
                        nuevo = new Articulo(Articulo.TipoProducto.Crema);
                        break;
                    case "Antibiotico":
                        nuevo = new Articulo(Articulo.TipoProducto.Antibiotico);
                        break;
                }
                return nuevo;
            }
        }
        public Cliente.FormaDePago Forma
        {
            get
            {
                switch (this.listBoxTipoPago.SelectedItem.ToString())
                {
                    case "Tarjeta":
                        return Cliente.FormaDePago.Tarjeta;
                    case "TarjetaJubilado":
                        return Cliente.FormaDePago.TarjetaJubilado;
                    case "Efectivo":
                        return Cliente.FormaDePago.Efectivo;
                }
                return Cliente.FormaDePago.Efectivo;
            }
        }


        private void btnAceptar_OnClick(object sender, EventArgs e)
        {
            try
            {
                articulo = Producto;
                cliente = new Cliente(Nombre, Apellido, articulo, Forma);
                this.richTextBoxVentas.Text = cliente.ToString();
            }
            catch (DatoInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
