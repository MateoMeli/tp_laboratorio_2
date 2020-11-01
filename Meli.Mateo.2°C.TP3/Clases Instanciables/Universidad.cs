using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

using Excepciones;

namespace Clases_Instanciables
{
    public class Universidad
    {
        public enum EClases
        {
            Programacion, Laboratorio, Legislacion, SPD
        }

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }

        public Jornada this[int i]
        {
            get
            {
                return this.Jornadas[i];
            }
            set
            {
                this.Jornadas[i] = value;
            }
        }
        #endregion
        private string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Jornada j in uni.Jornadas)
            {
                sb.AppendLine("JORNADA:");
                sb.Append(j.ToString());
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos(this);
        }

        public static bool operator ==(Universidad uni, Profesor profe)
        {
            foreach (Profesor p in uni.Instructores)
            {
                if(profe == p)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Universidad uni, Profesor profe)
        {
            return !(uni == profe);
        }

        public static bool operator ==(Universidad uni, Alumno alu)
        {
            foreach (Alumno p in uni.Alumnos)
            {
                if (alu == p)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Universidad uni, Alumno alu)
        {
            return !(uni == alu);
        }

        public static Profesor operator ==(Universidad uni, EClases clase)
        {
            foreach(Profesor p in uni.Instructores)
            {
                if(p == clase)
                {
                    return p;
                }
            }
            throw new SinProfesorException();
        }

        public static Profesor operator !=(Universidad uni, EClases clase)
        {
            foreach(Profesor p in uni.Instructores)
            {
                if(p != clase)
                {
                    return p;
                }
            }
            throw new SinProfesorException();
        }

        public static Universidad operator +(Universidad uni, EClases clase)
        {
            Profesor p = uni == clase;
            if(p == clase)
            {
                Jornada j = new Jornada(clase, p);
                foreach(Alumno a in uni.Alumnos)
                {
                    if(j == a)
                    {
                        j += a;
                    }
                }
                uni.Jornadas.Add(j);
            }
            return uni;
        }

        public static Universidad operator +(Universidad uni, Alumno a)
        {
            if(uni == a)
            {
                throw new AlumnoRepetidoException();
            }
            else
            {
                uni.Alumnos.Add(a);
            }
            return uni;
        }

        public static Universidad operator +(Universidad uni, Profesor a)
        {
            if (!uni.Instructores.Contains(a))
            {
                uni.Instructores.Add(a);
            }
            return uni;
        }

        public Universidad Leer()
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            Universidad uni;
            xml.Leer("Universidad.xml", out uni);
            return uni;
        }

        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            return xml.Guardar("Universidad.xml", uni);
        }
    }
}
