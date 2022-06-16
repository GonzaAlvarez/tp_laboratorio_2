using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivo<T> where T : class
    {
        public enum ETipoArchivo 
        { 
            XML,
            JSON 
        }

        /// <summary>
        /// Lee el archivo
        /// </summary>
        /// <param name="path">Ubicacion del archivo a leer</param>
        /// <returns>Devuelve el/los datos del archivo</returns>
        T Leer(string path);

        /// <summary>
        /// Escribe en el archivo si existe, crea el archivo con los datos escritos en caso de no existir
        /// </summary>
        /// <param name="dato">Dato a ingresar en el archivo</param>
        /// <param name="path">Ubicacion para guardar el archivo</param>
        void Escribir(T dato, string path);
    }
}
