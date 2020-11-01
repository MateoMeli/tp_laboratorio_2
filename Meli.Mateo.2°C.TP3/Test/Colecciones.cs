using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Clases_Instanciables;

namespace Test
{
    [TestClass]
    public class Colecciones
    {
        [TestMethod]
        public void ListaProfesores()
        {
            Universidad uni = new Universidad();

            bool val = uni.Instructores != null;

            Assert.IsTrue(val);
        }
    }
}
