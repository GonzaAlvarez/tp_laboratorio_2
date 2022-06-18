using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtensionMostrarTicket
    {
        /// <summary>
        /// Modifica el metodo ToString() para mostrarlo de una mejor manera
        /// al crear el ticket
        /// </summary>
        /// <param name="str">Recibe un ToString() de un producto</param>
        /// <returns>Retorna la cadena modificada</returns>
        public static string MostrarProductoTicket(this string str)
        {
            string[] datos = str.Split('.');
            StringBuilder sb = new StringBuilder();

            sb.Append(datos[1]);
            sb.Append(datos[3]);
            sb.Append(datos[2]);

            return sb.ToString();
        }
    }
}
