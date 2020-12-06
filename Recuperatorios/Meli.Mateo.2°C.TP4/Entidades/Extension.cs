using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        public static string PrimeraLetraNombre(this Cliente a)
        {
            return a.Nombre.Substring(a.Nombre.Length - 1, 1);
        }
    }
}
