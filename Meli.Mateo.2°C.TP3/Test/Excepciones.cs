using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos;
using Excepciones;
using Clases_Instanciables;

namespace Test
{
    [TestClass]
    public class Excepciones
    {
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void DniInvalidoEx()
        {
            string dniFalso = "-1";
            Alumno a = new Alumno(1, "Pedro", "Martinez", dniFalso,
                EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void ArchivosEx()
        {
            string jornada;
            Texto text = new Texto();
            text.Leer("asd.txt", out jornada);
        }
    }
}
