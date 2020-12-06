using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DatoInvalidoException : Exception
    {
        public DatoInvalidoException(string mensaje) : base(mensaje) { }
    }
}
