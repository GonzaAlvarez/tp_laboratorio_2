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
    public partial class FrmCargarProducto : Form
    {
        #region Atributos
        public Stock<Producto> stock;
        #endregion

        #region Constructores
        public FrmCargarProducto()
        {
            InitializeComponent();
        }

        public FrmCargarProducto(Stock<Producto> stock) : this()
        {
            this.stock = stock;
        }
        #endregion

        #region Metodos
        private void Agregar()
        {
            try
            {
                Producto p = null;
                int id = int.Parse(txtId.Text);
                string nombre = txtMarca.Text;
                double precio = double.Parse(txtPrecio.Text);

                if (rbElectrodomestico.Checked)
                {
                    string tipoElect = cboElectrodomestico.Text;
                    ETipoElectrodomestico tipoElectrodomestico = tipoElect == "Celular" ? ETipoElectrodomestico.Celular :
                        tipoElect == "Televisor" ? ETipoElectrodomestico.Televisor : tipoElect == "Lavarropa" ?
                        ETipoElectrodomestico.Lavarropa : ETipoElectrodomestico.Heladera;
                    p = new Electrodomestico(id, precio, nombre, tipoElectrodomestico);
                }
                if (rbInstrumento.Checked)
                {
                    string tipoInst = cboInstrumentos.Text;
                    ETipoInstrumento tipoInstrumento = tipoInst == "Guitarra" ? ETipoInstrumento.Guitarra : ETipoInstrumento.Saxo;
                    p = new Instrumento(id, precio, nombre, tipoInstrumento);
                }
                this.stock += p;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
            finally
            {
                this.Close();
                this.txtId.Text = "";
                this.txtMarca.Text = "";
                this.txtPrecio.Text = "";
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CheckTipoStatus()
        {
            if (rbElectrodomestico.Checked)
            {
                cboElectrodomestico.Visible = true;
                cboInstrumentos.Visible = false;
            }
            else
            {
                cboInstrumentos.Visible = true;
                cboElectrodomestico.Visible = false;
            }
        }

        #endregion

        #region Eventos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void rbElectrodomestico_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckTipoStatus();
        }

        private void rbInstrumento_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckTipoStatus();
        }
        #endregion
    }
}
