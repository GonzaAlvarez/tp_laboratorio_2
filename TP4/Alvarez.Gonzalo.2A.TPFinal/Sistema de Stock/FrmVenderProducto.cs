using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;

namespace Sistema_de_Stock
{
    public partial class FrmVenderProducto : Form
    {
        #region Atributos
        private Producto producto;
        private string pathTicket;
        #endregion

        #region Constructores
        public FrmVenderProducto()
        {
            InitializeComponent();
        }

        public FrmVenderProducto(Producto producto) : this()
        {
            this.producto = producto;
            rtbProducto.Text = producto.ToString();
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Vende el producto seleccionado al cliente ingresado,
        /// genera el ticket correspondiente a la compra en un archivo .txt,
        /// elimina el producto vendido de todos los lugares necesarios.
        /// Ademas agrega al cliente a la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerarTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == String.Empty || txtApellido.Text == String.Empty)
                {
                    MessageBox.Show("No deben quedar campos vacios!", "Error");
                }
                else
                {
                    //Cliente
                    Cliente cliente = null;
                    int idCliente = int.Parse(txtIdCliente.Text);
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    foreach (Cliente c in ConexionBD.CargarClientes())
                    {
                        if (c.Id == idCliente)
                        {
                            throw new IdExistenteException("Ese ID ya existe en la base de datos, verifique la base de datos y pruebe con un id inexistente!"); //Aplico excepcion propia
                        }
                    }

                    //Ticket
                    Archivo archivo = new Archivo();
                    string ticket;
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"Fecha y hora de la operacion: {DateTime.Now}\n");
                    sb.AppendLine($"Cliente:");
                    sb.AppendLine($"ID: {idCliente}");
                    sb.AppendLine($"Nombre: {txtNombre.Text}\nApellido: {txtApellido.Text}\n");
                    sb.Append($"Producto vendido:");

                    if (this.producto is Instrumento)
                    {
                        cliente = new Cliente(idCliente, nombre, apellido);
                        this.pathTicket = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"ticket{cliente.Id}.txt");
                        sb.AppendLine($"{ExtensionMostrarTicket.MostrarProductoTicket(this.producto.ToString())}"); //Aplico Metodo de Extension
                        ticket = sb.ToString();
                        archivo.Escribir(ticket, pathTicket);
                        MessageBox.Show("Producto vendido correctamente! Ticket generado", "Venta exitosa");
                    }

                    if (this.producto is Electrodomestico)
                    {
                        cliente = new Cliente(idCliente, nombre, apellido);
                        this.pathTicket = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"ticket{cliente.Id}.txt");
                        sb.AppendLine($"{ExtensionMostrarTicket.MostrarProductoTicket(this.producto.ToString())}"); // Aplico Metodo de Extension
                         ticket = sb.ToString();
                        archivo.Escribir(ticket, pathTicket);
                        MessageBox.Show("Producto vendido correctamente! Ticket generado", "Venta exitosa");
                    }

                    ConexionBD.GuardarCliente(cliente);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (IdExistenteException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                this.Close();
                this.txtIdCliente.Text = "";
                this.txtNombre.Text = "";
                this.txtApellido.Text = "";
                this.rtbProducto.Text = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                this.DialogResult = DialogResult.Cancel;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion
    }
}
