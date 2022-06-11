
namespace Sistema_de_Stock
{
    partial class FrmVenderProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGenerarTicket = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rtbProducto = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(7, 88);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(161, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(7, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(7, 70);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnGenerarTicket
            // 
            this.btnGenerarTicket.Location = new System.Drawing.Point(29, 142);
            this.btnGenerarTicket.Name = "btnGenerarTicket";
            this.btnGenerarTicket.Size = new System.Drawing.Size(136, 37);
            this.btnGenerarTicket.TabIndex = 1;
            this.btnGenerarTicket.Text = "Generar Ticket";
            this.btnGenerarTicket.UseVisualStyleBackColor = true;
            this.btnGenerarTicket.Click += new System.EventHandler(this.btnGenerarTicket_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(29, 185);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 37);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rtbProducto
            // 
            this.rtbProducto.Enabled = false;
            this.rtbProducto.Location = new System.Drawing.Point(220, 31);
            this.rtbProducto.Name = "rtbProducto";
            this.rtbProducto.Size = new System.Drawing.Size(346, 105);
            this.rtbProducto.TabIndex = 3;
            this.rtbProducto.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Producto seleccionado:";
            // 
            // FrmVenderProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGenerarTicket);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVenderProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vender Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGenerarTicket;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RichTextBox rtbProducto;
        private System.Windows.Forms.Label label1;
    }
}