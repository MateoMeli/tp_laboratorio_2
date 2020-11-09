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
                return new Articulo((Articulo.TipoProducto)this.listBoxProducto.SelectedItem);
            }
        }
        public Cliente.FormaDePago Forma
        {
            get
            {
                return (Cliente.FormaDePago)this.listBoxTipoPago.SelectedItem;
            }
        }


        private void btnAceptar_OnClick(object sender, EventArgs e)
        {
            articulo = Producto;
            cliente = new Cliente(Nombre, Apellido, articulo, Forma);
            
        }
    }
}
