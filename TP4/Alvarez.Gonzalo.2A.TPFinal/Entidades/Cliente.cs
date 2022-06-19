using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class Cliente
    {
        #region Atributos
        private int id;
        private string nombre;
        private string apellido;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad Id, Devuelve el valor del atributo id
        /// </summary>
        public int Id { get => this.id; }

        /// <summary>
        /// Propiedad Nombre, Devuelve el valor del atributo nombre
        /// </summary>
        public string Nombre { get => this.nombre; }

        /// <summary>
        /// Propiedad Apellido, Devuelve el valor del atributo apellido
        /// </summary>
        public string Apellido { get => this.apellido; }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor parametrizado, le da valor a los atributos de la clase
        /// </summary>
        /// <param name="id">Id del cliente</param>
        /// <param name="nombre">Nombre del cliente</param>
        /// <param name="apellido">Apellido del cliente</param>
        public Cliente(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Recibe un mensaje y lo almacena en la base de datos vinculandolo al cliente correspondiente
        /// </summary>
        /// <param name="sender">Mensaje</param>
        public void RecibirMensaje(Mensaje sender)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=.;Database=TP_FINAL_DB;Trusted_Connection=True;"))
                {
                    string query = "insert into Mensajes (contenido, id_cliente) values (@contenido, @id_cliente)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("contenido", sender.Contenido);
                    cmd.Parameters.AddWithValue("id_cliente", this.Id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
