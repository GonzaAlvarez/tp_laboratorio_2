using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class ConexionBD
    {
        #region Atributo
        private static string conexion;
        #endregion

        #region Constructores
        /// <summary>
        /// Le da valor al atributo estatico conexion
        /// </summary>
        static ConexionBD()
        {
            ConexionBD.conexion = "Server=.;Database=TP_FINAL_DB;Trusted_Connection=True;";
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Carga los productos almacenados en una base de datos.
        /// </summary>
        /// <returns>Retorna la lista de productos</returns>
        public static List<Producto> CargarProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            try
            {
                string query = "select * from Productos";

                using (SqlConnection connection = new SqlConnection(ConexionBD.conexion))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.GetString(2) == "Guitarra" || reader.GetString(2) == "Saxo")
                        {
                            int id = int.Parse(reader["id"].ToString());
                            float precio = float.Parse(reader["precio"].ToString());
                            string marca = reader["marca"].ToString();
                            string tipoInst = reader["tipo"].ToString();

                            if (tipoInst == "Guitarra")
                            {
                                Instrumento inst = new Instrumento(id, Convert.ToDouble(precio), marca, ETipoInstrumento.Guitarra);
                                listaProductos.Add(inst);
                            }
                            else
                            {
                                Instrumento inst = new Instrumento(id, Convert.ToDouble(precio), marca, ETipoInstrumento.Saxo);
                                listaProductos.Add(inst);
                            }
                        }
                        else
                        {
                            int id = int.Parse(reader["id"].ToString());
                            float precio = float.Parse(reader["precio"].ToString());
                            string marca = reader["marca"].ToString();
                            string tipoElect = reader["tipo"].ToString();

                            if (tipoElect == "Celular")
                            {
                                Electrodomestico elect = new Electrodomestico(id, Convert.ToDouble(precio), marca, ETipoElectrodomestico.Celular);
                                listaProductos.Add(elect);
                            }
                            if (tipoElect == "Televisor")
                            {
                                Electrodomestico elect = new Electrodomestico(id, Convert.ToDouble(precio), marca, ETipoElectrodomestico.Televisor);
                                listaProductos.Add(elect);
                            }
                            if (tipoElect == "Heladera")
                            {
                                Electrodomestico elect = new Electrodomestico(id, Convert.ToDouble(precio), marca, ETipoElectrodomestico.Heladera);
                                listaProductos.Add(elect);
                            }
                            if (tipoElect == "Lavarropa")
                            {
                                Electrodomestico elect = new Electrodomestico(id, Convert.ToDouble(precio), marca, ETipoElectrodomestico.Lavarropa);
                                listaProductos.Add(elect);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return listaProductos;
        }

        /// <summary>
        /// Guarda un producto en la base de datos
        /// </summary>
        /// <param name="p">Producto</param>
        public static void GuardarProducto(Producto p)
        {
            string query = "insert into Productos (id, marca, tipo, precio) values (@id, @marca, @tipo, @precio)";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(ConexionBD.conexion);
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if(p is Electrodomestico)
                {
                    Electrodomestico elect = (Electrodomestico)p;
                    cmd.Parameters.AddWithValue("id", elect.Id);
                    cmd.Parameters.AddWithValue("marca", elect.Marca);
                    cmd.Parameters.AddWithValue("tipo", elect.TipoElectrodomestico);
                    cmd.Parameters.AddWithValue("precio", elect.Precio);
                    cmd.ExecuteNonQuery();
                }

                if(p is Instrumento)
                {
                    Instrumento inst = (Instrumento)p;
                    cmd.Parameters.AddWithValue("id", inst.Id);
                    cmd.Parameters.AddWithValue("marca", inst.Marca);
                    cmd.Parameters.AddWithValue("tipo", inst.TipoInstrumento);
                    cmd.Parameters.AddWithValue("precio", inst.Precio);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Elimina un producto de la base de datos a partir de su id
        /// </summary>
        /// <param name="id">id del producto a eliminar</param>
        public static void EliminarProductoPorId(int id)
        {
            string query = "delete from Productos where id=@id";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionBD.conexion))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Carga los clientes almacenados en una base de datos.
        /// </summary>
        /// <returns>Retorna la lista de clientes</returns>
        public static List<Cliente> CargarClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            try
            {
                string query = "select * from Clientes";

                using (SqlConnection connection = new SqlConnection(ConexionBD.conexion))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id"].ToString());
                        string nombre = reader["nombre"].ToString();
                        string apellido = reader["apellido"].ToString();
                        Cliente cliente = new Cliente(id, nombre, apellido);
                        listaClientes.Add(cliente);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return listaClientes;
        }

        /// <summary>
        /// Guarda un cliente en la base de datos
        /// </summary>
        /// <param name="c"></param>
        public static void GuardarCliente(Cliente c)
        {
            string query = "insert into Clientes (id, nombre, apellido) values (@id, @nombre, @apellido)";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(ConexionBD.conexion);
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id", c.Id);
                cmd.Parameters.AddWithValue("nombre", c.Nombre);
                cmd.Parameters.AddWithValue("apellido", c.Apellido);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Elimina un cliente (y en caso de existir, los mensajes relacionados a el)
        /// de la base de datos a partir de su id
        /// </summary>
        /// <param name="id">id del cliente a eliminar</param>
        public static void EliminarClientePorId(int id)
        {
            string query = "delete Mensajes from Mensajes join Clientes on Mensajes.id_cliente = @id;" +
                "delete from Clientes where id=@id";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionBD.conexion))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("id", id);
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
