﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        #region Atributos
        private int id;
        private double precio;
        private string marca;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad Id, devuelve el valor del atributo id
        /// </summary>
        public int Id { get => this.id; set => this.id = value; }

        /// <summary>
        /// Propiedad Precio, devuelve el valor del atributo precio
        /// </summary>
        public double Precio { get => this.precio; set => this.precio = value; }

        /// <summary>
        /// Propiedad Marca, devuelve el valor del atributo marca
        /// </summary>
        public string Marca { get => this.marca; set => this.marca = value; }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor producto parametrizado, asigna el valor a los atributos de la clase
        /// </summary>
        /// <param name="id">Id del producto</param>
        /// <param name="precio">Precio del producto</param>
        /// <param name="marca">Nombre del producto</param>
        public Producto(int id, double precio, string marca)
        {
            this.id = id;
            this.precio = precio;
            this.marca = marca;
        }

        /// <summary>
        /// Contructor producto sin parametros
        /// inicializa los valores en caso de no ser inicializados
        /// </summary>
        public Producto() : this(0, 0, "") { }
        #endregion

        #region Metodos
        /// <summary>
        /// Crea una cadena con los datos del producto ingresado
        /// </summary>
        /// <param name="p">Producto</param>
        /// <returns>Retorna la cadena creada</returns>
        private static string Mostrar(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.AppendLine($"ID: {p.id}.");
                sb.AppendLine($"Marca: {p.marca}.");
                sb.AppendLine($"Precio: ${p.precio}.");
            }
            catch (Exception)
            {
                throw;
            }
            return sb.ToString();
        }
        #endregion

        #region Sobrecarga
        /// <summary>
        /// Verifica el id de ambos productos
        /// </summary>
        /// <param name="a">Producto a</param>
        /// <param name="b">Producto b</param>
        /// <returns>Retorna true si son iguales, false si no lo son</returns>
        public static bool operator ==(Producto a, Producto b)
        {
            if(a.id == b.id)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica el id de ambos productos
        /// </summary>
        /// <param name="a">Producto a</param>
        /// <param name="b">Producto b></param>
        /// <returns>Retorna false si son iguales, true si no lo son</returns>
        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }
        #endregion

        #region sobrescritura
        /// <summary>
        /// Sobrescritura del metodo ToString()
        /// </summary>
        /// <returns>Retorna la cadena creada por el metodo Mostrar</returns>
        public override string ToString()
        {
            return Mostrar(this);
        }

        /// <summary>
        /// Sobrescritura del Equals
        /// </summary>
        /// <param name="obj">Objeto a verificar</param>
        /// <returns>Retorna true si el objeto es un producto, de lo contrario retorna false</returns>
        public override bool Equals(object obj)
        {
            return (Producto)obj == this;
        }
        #endregion
    }
}
