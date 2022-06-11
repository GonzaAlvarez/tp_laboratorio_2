using System;
using System.Text;

namespace Entidades
{
    public class Instrumento : Producto
    {
        #region Atributos
        private ETipoInstrumento tipoInstrumento;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad TipoInstrumento, devuelve un string dependiendo el valor del atributo tipoInstrumento 
        /// </summary>
        public string TipoInstrumento
        {
            get
            {
                return this.tipoInstrumento == ETipoInstrumento.Guitarra ? "Guitarra" : "Saxo";
            }
            set
            {
                this.tipoInstrumento = value == "Saxo" ? ETipoInstrumento.Saxo : ETipoInstrumento.Guitarra;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructo parametrizado, se usa el base para asignar los valores al producto
        /// </summary>
        /// <param name="id">id del producto</param>
        /// <param name="precio">precio del producto</param>
        /// <param name="marca">nombre del producto</param>
        /// <param name="tipoInstrumento">tipo de Instrumento</param>
        public Instrumento(int id, double precio, string marca, ETipoInstrumento tipoInstrumento)
            : base(id, precio, marca)
        {
            this.tipoInstrumento = tipoInstrumento;
        }

        /// <summary>
        /// Constructor sin parametros, inicializa los valores en 0, marca vacío y tipoInstrumento en guitarra
        /// </summary>
        public Instrumento() : this(0, 0, "", ETipoInstrumento.Guitarra) { }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo mostrar, muestra los datos del Instrumento
        /// </summary>
        /// <returns>Devuelve un string con los datos del instrumento</returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ToString()}Tipo Instrumento: {this.TipoInstrumento}");
            return sb.ToString();
        }
        #endregion

        #region Sobrecarga
        /// <summary>
        /// Verifica el id y marca de ambos instrumentos
        /// </summary>
        /// <param name="a">Instrumento a</param>
        /// <param name="b">Instrumento b</param>
        /// <returns>Devuelve true si son iguales, false si no lo son</returns>
        public static bool operator ==(Instrumento a, Instrumento b)
        {
            if(a.Id == b.Id && a.Marca == b.Marca)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica el id y marca de ambos instrumentos
        /// </summary>
        /// <param name="a">Instrumento a</param>
        /// <param name="b">Instrumento b</param>
        /// <returns>Devuelve false si son iguales, true si no lo son</returns>
        public static bool operator !=(Instrumento a, Instrumento b)
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
