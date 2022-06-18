using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Sistema_de_Stock
{
    public partial class FrmClientes : Form
    {
        #region Atributos
        private List<Cliente> clientes;
        private Mensaje mensajeElectrodomestico;
        private Mensaje mensajeInstrumento;
        #endregion

        #region Constructores
        public FrmClientes()
        {
            InitializeComponent();
            InitializeDataClientes();
            mensajeElectrodomestico = new Mensaje("No te olvides de visitar nuestra tienda, hay electrodomesticos disponibles esperandote!");
            mensajeInstrumento = new Mensaje("No te olvides de visitar nuestra tienda, hay instrumentos disponibles esperandote!");
        }
        #endregion

        #region Eventos
        private void InitializeDataClientes()
        {
            try
            {
                dtClientes.ColumnCount = 3;
                dtClientes.Columns[0].Name = "Id";
                dtClientes.Columns[1].Name = "Nombre";
                dtClientes.Columns[2].Name = "Apellido";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Actualizar()
        {
            try
            {
                dtClientes.Rows.Clear();
                foreach (Cliente c in this.clientes)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dtClientes);
                    fila.Cells[0].Value = c.Id;
                    fila.Cells[1].Value = c.Nombre;
                    fila.Cells[2].Value = c.Apellido;
                    dtClientes.Rows.Add(fila);
                    dtClientes.Sort(dtClientes.Columns[0], ListSortDirection.Ascending);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            this.clientes = ConexionBD.CargarClientes();
            Actualizar();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dtClientes.CurrentRow.Cells["id"].Value);
                if (this.clientes.Count > 0)
                {
                    foreach (Cliente c in this.clientes)
                    {
                        if (c.Id == id)
                        {
                            this.clientes.Remove(c);
                            ConexionBD.EliminarClientePorId(c.Id);
                            dtClientes.Rows.Remove(dtClientes.CurrentRow);
                            MessageBox.Show("Cliente eliminado de la base de datos", "Exito");
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe haber al menos un cliente para poder eliminar!", "Advertencia");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnMensajeElct_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dtClientes.CurrentRow.Cells["id"].Value);
                if (this.clientes.Count > 0)
                {
                    foreach (Cliente c in this.clientes)
                    {
                        if (c.Id == id)
                        {
                            mensajeElectrodomestico.MensajeEnviado += c.RecibirMensaje;
                            mensajeElectrodomestico.EnviarMensaje();
                            MessageBox.Show("Mensaje enviado con exito!", "Enviado");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe haber al menos un cliente para poder enviar mensaje!", "Advertencia");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message ,"Error");
            }
        }

        private void btnMensajeInst_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dtClientes.CurrentRow.Cells["id"].Value);
                if(this.clientes.Count > 0)
                {
                    foreach (Cliente c in this.clientes)
                    {
                        if (c.Id == id)
                        {
                            mensajeInstrumento.MensajeEnviado += c.RecibirMensaje;
                            mensajeInstrumento.EnviarMensaje();
                            MessageBox.Show("Mensaje enviado con exito!", "Enviado");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe haber al menos un cliente para poder enviar mensaje!", "Advertencia");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion
    }
}
