﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Clases_Instanciables
{
    public class Jornada
    {
        private Profesor profesor;
        private List<Alumno> alumnos;
        private Universidad.EClases clase;

        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
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
                this.Alumnos = value;
            }
        }

        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        public Profesor Instructor
        {
            get
            {
                return this.profesor;
            }
            set
            {
                this.profesor = value;
            }
        }
        #endregion

        public static bool Guardar(Jornada jornada)
        {
            Texto text = new Texto();
            return text.Guardar("Jornada.txt", jornada.ToString());

        }

        public static string Leer()
        {
            string jornada;
            Texto text = new Texto();
            text.Leer("Jornada.txt", out jornada);
            return jornada;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CLASE DE {this.Clase} POR {this.Instructor}");
            sb.AppendLine();
            sb.AppendLine("ALUMNOS:");
            foreach (Alumno a in this.Alumnos)
            {
                sb.AppendLine(a.ToString());
            }
            return sb.ToString();
        }


        public static bool operator ==(Jornada j, Alumno a)
        {
            return a == j.Clase;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(j == a)
            {
                j.Alumnos.Add(a);
            }
            return j;
        }
    }
    
}
