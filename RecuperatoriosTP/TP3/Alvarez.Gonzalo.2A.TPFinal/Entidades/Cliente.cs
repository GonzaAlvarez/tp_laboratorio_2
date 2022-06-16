using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        #region Atributos
        private int id;
        private static int nextId;
        private string nombre;
        private string apellido;
        private int idProducto;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad Id, Devuelve el valor del atributo id
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }
        }

        /// <summary>
        /// Propiedad Nombre, Devuelve el valor del atributo nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// Propiedad Apellido, Devuelve el valor del atributo apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        /// <summary>
        /// Propiedad IdProducto, Devuelve el valor del atributo idProducto
        /// </summary>
        public int IdProducto
        {
            get
            {
                return this.idProducto;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor estatico, le da el valor 1 al atributo nextId
        /// </summary>
        static Cliente()
        {
            Cliente.nextId = 1;
        }

        /// <summary>
        /// Constructor parametrizado, le da valor a los atributos de la clase (posee id autoincremental)
        /// </summary>
        /// <param name="nombre">Nombre del cliente</param>
        /// <param name="apellido">Apellido del cliente</param>
        /// <param name="idProducto">Id del producto comprado</param>
        public Cliente(string nombre, string apellido, int idProducto)
        {
            this.id = nextId;
            Cliente.nextId++;
            this.nombre = nombre;
            this.apellido = apellido;
            this.idProducto = idProducto;
        }
        #endregion
    }
}
