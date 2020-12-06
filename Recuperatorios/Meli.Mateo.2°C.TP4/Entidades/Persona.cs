using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;

        #region Propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }
        #endregion

        #region Validadores
        private string ValidarNombreApellido(string dato)
        {
            if (dato.Count() > 2 && !(dato.Any(char.IsDigit)))
            {
                return dato;
            }
            else
            {
                throw new DatoInvalidoException("Nombre o apellido invalido.");
            }
        }
        #endregion

        #region Constructores
        public Persona() { }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        #endregion

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre} {this.Apellido}");
            return sb.ToString();
        }
    }
}
