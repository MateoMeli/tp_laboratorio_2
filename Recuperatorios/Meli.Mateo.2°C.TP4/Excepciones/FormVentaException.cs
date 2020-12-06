using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class FormVentaException : Exception
    {
        public FormVentaException(string mensaje) : base(mensaje) { }

        public FormVentaException(string mensaje, Exception inner) : base(mensaje, inner)
        { }
    }
}
