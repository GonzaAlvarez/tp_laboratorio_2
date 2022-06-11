using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class IdExistenteException : Exception
    {
        public IdExistenteException(string mensaje) : base(mensaje)
        {

        }

        public IdExistenteException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
