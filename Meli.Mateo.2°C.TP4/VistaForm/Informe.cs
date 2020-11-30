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

namespace VistaForm
{

    public delegate void Informar(Cliente c);
    public partial class Informe : Form
    {
        public event Informar Añadir;
        private List<Cliente> clientes;
        private InformeDAO informeDao;
        public Informe()
        {
            InitializeComponent();
            informeDao = new InformeDAO();
            this.clientes = new List<Cliente>();
            this.Añadir += this.Sumando;
        }
         public List<Cliente> Atendidos
        {
            get
            {
                return this.clientes;
            }
        }
        public void Agregar(Cliente c)
        {
            if (!object.ReferenceEquals(this.Añadir, null))
            {
                this.Añadir(c);
            }
        }
        public RichTextBox RTB
        {
            get
            {
                return this.rtbInforme;
            }
        }

        public void Sumando(Cliente c)
        {
            this.Atendidos.Add(c);
        }

        public string Imprimir()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Cliente c in Atendidos)
            {
                sb.AppendLine(c.ToString());
            }
            return sb.ToString();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            this.clientes = informeDao.ListarProductos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            informeDao.InsertarProducto(Atendidos);
        }
    }
}
