using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Farmaceutico : Persona
    {
        private int matricula;

        public int Matricula
        {
            get
            {
                return this.matricula;
            }
            set
            {
                this.matricula = value;
            }
        }

        public Farmaceutico(string nombre, string apellido, int matricula) : base(nombre, apellido)
        {
            this.Matricula = matricula;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("FARMACEUTICO");
            sb.Append(base.ToString());
            sb.AppendLine($"MATRICULA: {this.Matricula}");
            return sb.ToString();
        }

        public static bool operator == (Farmaceutico f1, Farmaceutico f2)
        {
            return f1.Equals(f2) && f1.Matricula == f2.Matricula;
        }

        public static bool operator !=(Farmaceutico f1, Farmaceutico f2)
        {
            return !(f1 == f2);
        }
    }
}
