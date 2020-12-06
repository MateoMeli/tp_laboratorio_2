using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Excepciones;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DatoInvalidoException))]
        public void TestAgregarClienteConNombreInvalido()
        {
            Cliente c = new Cliente("123", "Perez", new Productos.Articulo(Productos.Articulo.TipoProducto.Analgesico), Cliente.FormaDePago.Efectivo);
        }

        [TestMethod]
        public void TstExtension()
        {
            Cliente c = new Cliente("Mateo", "Perez", new Productos.Articulo(Productos.Articulo.TipoProducto.Analgesico), Cliente.FormaDePago.Efectivo);
            string a = c.PrimeraLetraNombre();
            Assert.IsTrue(a == "o");
        }
    }
}
