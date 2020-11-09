using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;
using Productos;

namespace ConsolaPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Farmaceutico f1 = new Farmaceutico("Candela", "Garcia", 123456);
                Console.WriteLine(f1.ToString());
                Articulo a1 = new Articulo(Articulo.TipoProdcto.Analgesico, 120f, 123, "Anaflex");
                Cliente c1 = new Cliente("Juli", "Garcia", a1, Cliente.FormaDePago.TarjetaJubilado);
                Console.WriteLine(a1.ToString());
                Console.WriteLine(c1.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal");
            }

            Console.ReadKey();
        }
    }
}
