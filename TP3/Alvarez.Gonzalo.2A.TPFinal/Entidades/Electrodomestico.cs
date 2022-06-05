using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Electrodomestico : Producto
    {
        #region Atributos
        private ETipoElectrodomestico tipoElectrodomestico;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad TipoElectrodomestico, devuelve el valor del atributo de tipoElectrodomestico
        /// </summary>
        public string TipoElectrodomestico
        {
            get
            {
                return this.tipoElectrodomestico.ToString();
            }
            set
            {
                this.tipoElectrodomestico = value == "Celular" ? ETipoElectrodomestico.Celular
                                          : value == "Televisor" ? ETipoElectrodomestico.Televisor 
                                          : value == "Lavarropa" ? ETipoElectrodomestico.Lavarropa 
                                          : ETipoElectrodomestico.Heladera;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructo parametrizado de Electrodomestico
        /// </summary>
        /// <param name="id">Id del producto</param>
        /// <param name="precio">Precio del producto</param>
        /// <param name="marca">Marca del producto</param>
        /// <param name="tipoElectrodomestico">Tipo de Electrodomestico</param>
        public Electrodomestico(int id, double precio, string marca, ETipoElectrodomestico tipoElectrodomestico)
            : base(id, precio, marca)
        {
            this.tipoElectrodomestico = tipoElectrodomestico;
        }

        /// <summary>
        /// Constructor sin parametros, inicializa los valores en 0, marca vacío y tipoElectrodomestico en celular
        /// </summary>
        public Electrodomestico() : this(0, 0, "", ETipoElectrodomestico.Celular) { }
        #endregion

        #region Métodos
        /// <summary>
        /// Metodo mostrar, muestra los datos de Electrodomestico
        /// </summary>
        /// <returns>Devuelve un string con los datos del Electrodomestico</returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ToString()}\t\t\t{this.tipoElectrodomestico}");
            return sb.ToString();
        }
        #endregion

        #region Sobrecarga
        /// <summary>
        /// Verifica el id y marca de ambos electrodomesticos
        /// </summary>
        /// <param name="a">Electrodomestico a</param>
        /// <param name="b">Electrodomestico b</param>
        /// <returns>Devuelve true si son iguales, false si no lo son</returns>
        public static bool operator ==(Electrodomestico a, Electrodomestico b)
        {
            if(a.Id == b.Id && a.Marca == b.Marca)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica el id y marca de ambos electrodomesticos
        /// </summary>
        /// <param name="a">Electrodomestico a</param>
        /// <param name="b">Electrodomestico b</param>
        /// <returns>Devuelve false si son iguales, true si no lo son</returns>
        public static bool operator !=(Electrodomestico a, Electrodomestico b)
        {
            return !(a == b);
        }
        #endregion

        #region Sobrescritura
        /// <summary>
        /// Sobrescritura del metodo ToString()
        /// </summary>
        /// <returns>Devuelve el metodo Mostrar con los datos del objeto</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
