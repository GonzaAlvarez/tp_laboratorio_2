using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region Constructores
        public Suv(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {

        }
        #endregion

        #region Propiedades
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
            set
            {
                this.Tamanio = ETamanio.Grande;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra los datos de SUV
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO: {this.Tamanio}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
