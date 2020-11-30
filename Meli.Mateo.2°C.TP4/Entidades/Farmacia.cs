using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos;

namespace Entidades
{
    public class Farmacia : IBorrable<Cliente>
    {
        public static string NombreFarmacia = "FARMACIA MELI";
        private List<Cliente> clientes;
        private Farmaceutico farmaceutico;

        public List<Cliente> Clientes
        {
            get
            {
                return this.clientes;
            }
            set
            {
                this.clientes = value;
            }
        }

        public Farmaceutico Farmaceutico
        {
            get
            {
                return this.farmaceutico;
            }
            set
            {
                this.farmaceutico = value;
            }
        }
        private Farmacia()
        {
            this.Clientes = new List<Cliente>();
        }


        public Farmacia(Farmaceutico farmaceutico) : this()
        {
            this.Farmaceutico = farmaceutico;
        }

        public Farmacia(List<Cliente> clientes, Farmaceutico farm)
        {
            this.Clientes = clientes;
            this.Farmaceutico = farm;
        }

        public static bool operator ==(Farmacia f, Farmaceutico far)
        {
            return f.Farmaceutico == far;
        }

        public static bool operator !=(Farmacia f, Farmaceutico far)
        {
            return !(f == far);
        }

        public static Farmacia operator +(Farmacia f, Cliente c)
        {
            if (!f.Clientes.Contains(c))
            {
                f.Clientes.Add(c);
            }
            return f;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("FARMACIA");
            sb.AppendLine(this.Farmaceutico.ToString());
            sb.AppendLine("CLIENTES");
            foreach(Cliente c in this.Clientes)
            {
                sb.AppendLine(c.ToString());
            }
            return sb.ToString();
        }

        public bool Borrar()
        {
            if (clientes != null)
            {
                this.Clientes.Clear();
                return true;
            }
            return false;
        }
    }
}
