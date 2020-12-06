using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades;
using Excepciones;
using Productos;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Farmaceutico f1 = new Farmaceutico("Candela", "Garcia", 123456);
                Farmacia farmacia = new Farmacia(f1);
                Articulo a1 = new Articulo(Articulo.TipoProducto.Analgesico);
                Articulo a2 = new Articulo(Articulo.TipoProducto.Crema);
                Cliente c1 = new Cliente("Juli", "Garcia", a1, Cliente.FormaDePago.TarjetaJubilado);
                Cliente c2 = new Cliente("Mateo", "Meli", a2, Cliente.FormaDePago.Efectivo);
                farmacia += c1;
                farmacia += c2;
                Console.WriteLine(farmacia.ToString());
                //las demas funcionalidades se encuentran en los formularios
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal");
            }

            Console.ReadKey();
        }
    }
}
