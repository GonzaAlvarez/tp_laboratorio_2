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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Limpia los operandos, operador y resultado.
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = String.Empty;
            txtNumero2.Text = String.Empty;
            cmbOperador.SelectedIndex = 0;
            lblResultado.Text = "0";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (cmbOperador.Text == " ")
            {
                cmbOperador.Text = "+";
            }
            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            if(resultado == double.MinValue)
            {
                lblResultado.Text = "Valor invalido";
            }
            else
            {
                lblResultado.Text = resultado.ToString();
            }
            lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {lblResultado.Text}");
        }

        /// <summary>
        /// Realiza una operacion dependiendo del operador que recibe por parametro.
        /// </summary>
        /// <param name="numero1">Recibe un numero de tipo Operando.</param>
        /// <param name="numero2">Recibe un numero de tipo Operando.</param>
        /// <param name="operador">Recibe un operador de tipo char.</param>
        /// <returns>Retorna el resultado de la operacion.</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);

            double resultado = Calculadora.Operar(num1, num2, Convert.ToChar(operador));
            return resultado;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(lblResultado.Text == "Valor invalido")
            {
                lblResultado.Text = "0";
            }
            else
            {
                string binario = Operando.DecimalBinario(Convert.ToDouble(lblResultado.Text));
                lblResultado.Text = binario;
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "Valor invalido")
            {
                lblResultado.Text = "0";
            }
            else
            {
                string numero = Operando.BinarioDecimal(lblResultado.Text);
                lblResultado.Text = numero;
            }
        }
    }
}
