using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Productos;
using Excepciones;
using System.Threading;

namespace VistaForm
{
    public partial class FarmaciaElPepe : Form
    {
        private Farmacia farmacia;
        private Venta venta;


        public FarmaciaElPepe()
        {
            InitializeComponent();
            Farmaceutico farmaceutico = new Farmaceutico("Meli", "Mateo", 169882);
            Farmacia f1 = new Farmacia(farmaceutico);
            this.farmacia = f1;
            this.textBoxPresentacion.Text = $"{Farmacia.NombreFarmacia} {this.farmacia.Farmaceutico.ToString()}";
        }

        private void btnIngresar_OnClick(object sender, EventArgs e)
        {
            this.venta = new Venta(this.farmacia);
            this.venta.ShowDialog();
        }

        private void btnCerrar_OnClick(object sender, EventArgs e)
        {
            DialogResult mensaje = new DialogResult();
            mensaje = MessageBox.Show("Desea salir del programa?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(mensaje == DialogResult.Yes)
                Close();
        }

    }
}
