using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mensaje
    {
        #region Delegado y Evento
        public delegate void DelegadoEnviarMensajeHandler (Mensaje sender);
        public event DelegadoEnviarMensajeHandler MensajeEnviado;
        #endregion

        #region Atributos
        private string contenido;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad Contenido, retorna un string dependiendo el valor del atributo contenido
        /// o asigna un valor a dicho atributo
        /// </summary>
        public string Contenido { get => this.contenido; set => this.contenido = value; }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor parametrizado, asigna valor al atributo contenido
        /// </summary>
        /// <param name="contenido"></param>
        public Mensaje(string contenido)
        {
            this.contenido = contenido;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Envia un mensaje mediante la utilizacion del evento MensajeEnviado.
        /// </summary>
        public void EnviarMensaje()
        {
            if(MensajeEnviado is not null)
            {
                MensajeEnviado.Invoke(this);
            }
        }
        #endregion
    }
}
