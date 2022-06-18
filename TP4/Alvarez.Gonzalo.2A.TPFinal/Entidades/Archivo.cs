using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class Archivo
    {
        #region Metodos
        /// <summary>
        /// Lee el archivo
        /// </summary>
        /// <param name="path">Ruta del archivo</param>
        /// <returns>El contenido del archivo</returns>
        public string Leer(string path)
        {
            string ret = "";
            try
            {
                using StreamReader sr = new StreamReader(path);
                while (!sr.EndOfStream)
                {
                    ret += $"{sr.ReadLine()}\n";
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ret;
        }

        /// <summary>
        /// Escribe en el archivo
        /// </summary>
        /// <param name="dato">Dato a agregar</param>
        /// <param name="path">Ruta del archivo</param>
        public void Escribir(string dato, string path)
        {
            try
            {
                using StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(dato);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        #endregion
    }
}
