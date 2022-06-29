using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoNoSeleccionadoException : Exception
    {
        public ProductoNoSeleccionadoException(string mensaje) :base(mensaje)
        {

        }

        public ProductoNoSeleccionadoException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
