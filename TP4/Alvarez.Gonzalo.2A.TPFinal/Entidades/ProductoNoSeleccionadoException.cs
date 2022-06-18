using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoNoSeleccionadoException : Exception
    {
        #region Contructores
        public ProductoNoSeleccionadoException(string mensaje) :base(mensaje)
        {

        }

        public ProductoNoSeleccionadoException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
        #endregion
    }
}
