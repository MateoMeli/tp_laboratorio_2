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
                Farmacia farmacia = new Farmacia(f1);
                Articulo a1 = new Articulo(Articulo.TipoProdcto.Analgesico, 1, "Anaflex");
                Articulo a2 = new Articulo(Articulo.TipoProdcto.Antibiotico, 2, "PenOral");
                Cliente c1 = new Cliente("Juli", "Garcia", a1, Cliente.FormaDePago.TarjetaJubilado);
                Cliente c2 = new Cliente("Mateo", "Meli", a1, Cliente.FormaDePago.Efectivo);
                farmacia += a1;
                farmacia += a2;
                farmacia += c1;
                farmacia += c2;
                Console.WriteLine(farmacia.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal");
            }

            Console.ReadKey();
        }
    }
}
