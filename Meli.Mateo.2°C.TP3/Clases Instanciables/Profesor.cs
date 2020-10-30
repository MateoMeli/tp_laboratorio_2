using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private Random random;

        private Profesor() 
        {
            this.random = new Random();
        }

        public Profesor() : this()
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad) 
        {
            
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine(ParticiparEnClase());
            return sb.ToString();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA:");
            foreach (Universidad.EClases clase in clasesDelDia)
            {
                sb.AppendLine(clase.ToString());
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        public static bool operator == (Profesor p, Universidad.EClases clase)
        {
            return p.clasesDelDia.Contains(clase);
        }

        public static bool operator !=(Profesor p, Universidad.EClases clase)
        {
            return !(p == clase);
        }

        private void _randomClases()
        {

        }
    }
}
