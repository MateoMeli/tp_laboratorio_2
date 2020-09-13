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

namespace MiCalculadora
{
    public partial class LaCalculadora : System.Windows.Forms.Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
        }        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOperar_click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();            
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            return Calculadora.Operar(num1, num2, operador);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero();
            string resultado = num1.BinarioDecimal(lblResultado.Text);
            this.lblResultado.Text = resultado;
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero();
            string resultado = num1.DecimalBinario(lblResultado.ToString());
            this.lblResultado.Text = resultado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "";
        }
    }
}
