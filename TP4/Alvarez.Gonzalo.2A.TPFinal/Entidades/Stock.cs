using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Stock<T> where T : class
    {
        #region Atributos
        private List<T> stock;
        private int capacidadMaxima;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad Productos, devuelve una lista de productos.
        /// </summary>
        public List<T> Productos { get => this.stock; set => this.stock = value; }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor parametrizado, incializa la lista y asigna la capacidad maxima de stock
        /// </summary>
        /// <param name="capacidadMaxima">Cantidad total que se puede almacenar en stock</param>
        public Stock(int capacidadMaxima)
        {
            this.stock = new List<T>();
            this.capacidadMaxima = capacidadMaxima;
        }

        /// <summary>
        /// Constructor sin parametros, inicializa la lista y asigna en 100 la capacidad maxima del stock
        /// </summary>
        public Stock() : this(100) { }
        #endregion

        #region Métodos
        /// <summary>
        /// Metodo Mostrar, muestra los datos del objeto
        /// </summary>
        /// <returns>Devuelve el string generado con los datos del objeto</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                foreach (object p in this.stock)
                {
                    sb.Append($"\n{p}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="s">Clase Stock</param>
        /// <param name="p">Objeto</param>
        /// <returns>Devuelve true en caso de que los objetos sean iguales, falso en caso contrario</returns>
        public static bool operator ==(Stock<T> s, object p)
        {
            foreach (object prod in s.stock)
            {
                if (prod == p)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Stock<T> s, object p)
        {
            return !(s == p);
        }

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="s">Clase Stock</param>
        /// <param name="p">Objeto p</param>
        /// <returns>Añade un elemento al stock en caso de tener espacio, caso contrario se lanza una excepcion</returns>
        public static Stock<T> operator +(Stock<T> s, object p)
        {
            if (s.stock.Count < s.capacidadMaxima)
            {
                if (s != p)
                {
                    s.stock.Add((T)p);
                }
            }
            return s;
        }

        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="s">Clase Stock</param>
        /// <param name="p">Objeto p</param>
        /// <returns>Quita un elemento de la lista en caso de ser encontrado, caso contrario lanza una excepcion</returns>
        public static Stock<T> operator -(Stock<T> s, object p)
        {
            if (s == p)
            {
                s.stock.Remove((T)p);
            }
            return s;
        }
        #endregion
    }
}
