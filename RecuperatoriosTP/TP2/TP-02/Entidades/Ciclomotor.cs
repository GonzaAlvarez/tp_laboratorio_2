using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region Constructores
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) :base(chasis, marca, color)
        {

        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
            set
            {
                this.Tamanio = ETamanio.Chico;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra los datos de Ciclomotor
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO: {this.Tamanio}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
