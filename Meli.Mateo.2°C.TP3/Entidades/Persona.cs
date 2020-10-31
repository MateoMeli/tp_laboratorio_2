using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino, Extranjero
        }

        private string apellido;
        private int dni;
        private string nombre;
        private ENacionalidad nacionalidad;

        #region Propiedades

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

        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = ValidarDni(this.Nacionalidad, value);
            }
        }

        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

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

        public string StringToDNI
        {
            set
            {
                this.DNI = ValidarDni(this.Nacionalidad, value);
            }
        }

        #endregion

        #region Constructores
        public Persona() { }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Valida que el string no tenga caracteres invalidos para un nombre o apellido
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            string retorno = "";
            if(dato.Count() > 2 && !(dato.Any(char.IsDigit)))
            {
                return dato;
            }
            return retorno;
        }

        /// <summary>
        /// Valida el Dni ingresado como int segun la nacionalidad. Si el dni ingresado es invalido se arroja una excepcion
        /// de tipo DniInvalidoException. Si el dni es invalido para la nacionalidad ingresada se arroja una excepcion de 
        /// tipo NacionalidadInvalidaException
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dni)
        {
            if(dni >= 1 && dni <= 99999999)
            {
                if (nacionalidad == ENacionalidad.Argentino && dni >= 1 && dni <= 89999999)
                {
                    return dni;
                }
                else if (nacionalidad == ENacionalidad.Extranjero && dni >= 90000000 && dni <= 99999999)
                {
                    return dni;
                }
                else
                {
                    throw new NacionalidadInvalidaException("La nacionalidad no se condice con el numero de  DNI");
                }
            }
            else
            {
                throw new DniInvalidoException("Dni Invalido");
            }

            

            
        }

        /// <summary>
        /// Valida el Dni ingresado como string segun la nacionalidad. Si el dni ingresado es invalido se arroja una excepcion
        /// de tipo DniInvalidoException. Si el dni es invalido para la nacionalidad ingresada se arroja una excepcion de 
        /// tipo NacionalidadInvalidaException
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dni)
        {
            if (int.TryParse(dni, out int dniAux))
            {
                return ValidarDni(nacionalidad, dniAux);
            }
            else
            {
                throw new DniInvalidoException("Dni invalido");
            }

        }

        /// <summary>
        /// Sobreescritura del metodo ToString() que devuelve en string y formateado los datos de la persona menos el Dni
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"NOMBRE COMPLETO: {this.Apellido}, {this.Nombre}\n");
            sb.AppendLine($"NACIONALIDAD: {this.Nacionalidad}");
            return sb.ToString();
        }
        #endregion
    }
}
