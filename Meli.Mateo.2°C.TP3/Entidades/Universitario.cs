using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region Constructores
        public Universitario() { }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) 
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion


        #region Metodos

        /// <summary>
        /// Devuelve en un string formateado los datos del Universitario
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine();
            sb.AppendLine($"LEGAJO: {this.legajo}");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Universitario;
        }

        public static bool operator ==(Universitario uni1, Universitario uni2)
        {
            return uni1.Equals(uni2) && uni1.legajo == uni2.legajo || uni1.DNI == uni2.DNI;
        }

        public static bool operator !=(Universitario uni1, Universitario uni2)
        {
            return !(uni1 == uni2);
        }

        protected abstract string ParticiparEnClase();
        #endregion
    }
}
