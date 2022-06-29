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
        private void btnGenerarTicket_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == String.Empty || txtApellido.Text == String.Empty)
            {
                MessageBox.Show("No deben quedar campos vacios!" ,"Error");
            }
            else
            {
                try
                {
                    Archivo archivo = new Archivo();
                    string ticket;
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"Cliente: {txtApellido.Text} {txtNombre.Text}");
                    sb.AppendLine($"Producto vendido:");

                    if (this.producto is Instrumento)
                    {
                        Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text, this.producto.Id);
                        this.pathTicket = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"ticket{cliente.Id}.txt");
                        sb.AppendLine($"{this.producto.ToString()}");
                        ticket = sb.ToString();
                        archivo.Escribir(ticket, pathTicket);
                        MessageBox.Show("Producto vendido correctamente! Ticket generado", "Venta exitosa");
                    }

                    if (this.producto is Electrodomestico)
                    {
                        Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text, this.producto.Id);
                        this.pathTicket = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"ticket{cliente.Id}.txt");
                        sb.AppendLine($"{this.producto.ToString()}");
                        ticket = sb.ToString();
                        archivo.Escribir(ticket, pathTicket);
                        MessageBox.Show("Producto vendido correctamente! Ticket generado", "Venta exitosa");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                finally
                {
                    this.Close();
                    this.txtNombre.Text = "";
                    this.txtApellido.Text = "";
                    this.rtbProducto.Text = "";
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion
    }
}
