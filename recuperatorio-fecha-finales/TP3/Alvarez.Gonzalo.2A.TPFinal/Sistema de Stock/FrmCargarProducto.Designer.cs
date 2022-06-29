
namespace Sistema_de_Stock
{
    partial class FrmCargarProducto
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
            this.cboInstrumentos = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboElectrodomestico = new System.Windows.Forms.ComboBox();
            this.gboProducto = new System.Windows.Forms.GroupBox();
            this.rbInstrumento = new System.Windows.Forms.RadioButton();
            this.rbElectrodomestico = new System.Windows.Forms.RadioButton();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.gboProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboInstrumentos
            // 
            this.cboInstrumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInstrumentos.FormattingEnabled = true;
            this.cboInstrumentos.Items.AddRange(new object[] {
            "Guitarra",
            "Saxo"});
            this.cboInstrumentos.Location = new System.Drawing.Point(161, 116);
            this.cboInstrumentos.Name = "cboInstrumentos";
            this.cboInstrumentos.Size = new System.Drawing.Size(148, 23);
            this.cboInstrumentos.TabIndex = 23;
            this.cboInstrumentos.Visible = false;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(161, 98);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(101, 15);
            this.lblProducto.TabIndex = 22;
            this.lblProducto.Text = "Tipo de Producto:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(176, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 32);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 145);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 32);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboElectrodomestico
            // 
            this.cboElectrodomestico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboElectrodomestico.FormattingEnabled = true;
            this.cboElectrodomestico.Items.AddRange(new object[] {
            "Celular",
            "Televisor",
            "Lavarropa",
            "Heladera"});
            this.cboElectrodomestico.Location = new System.Drawing.Point(161, 116);
            this.cboElectrodomestico.Name = "cboElectrodomestico";
            this.cboElectrodomestico.Size = new System.Drawing.Size(148, 23);
            this.cboElectrodomestico.TabIndex = 19;
            this.cboElectrodomestico.Visible = false;
            // 
            // gboProducto
            // 
            this.gboProducto.Controls.Add(this.rbInstrumento);
            this.gboProducto.Controls.Add(this.rbElectrodomestico);
            this.gboProducto.Location = new System.Drawing.Point(161, 9);
            this.gboProducto.Name = "gboProducto";
            this.gboProducto.Size = new System.Drawing.Size(148, 86);
            this.gboProducto.TabIndex = 18;
            this.gboProducto.TabStop = false;
            this.gboProducto.Text = "Producto";
            // 
            // rbInstrumento
            // 
            this.rbInstrumento.AutoSize = true;
            this.rbInstrumento.Location = new System.Drawing.Point(6, 47);
            this.rbInstrumento.Name = "rbInstrumento";
            this.rbInstrumento.Size = new System.Drawing.Size(90, 19);
            this.rbInstrumento.TabIndex = 1;
            this.rbInstrumento.TabStop = true;
            this.rbInstrumento.Text = "Instrumento";
            this.rbInstrumento.UseVisualStyleBackColor = true;
            this.rbInstrumento.CheckedChanged += new System.EventHandler(this.rbInstrumento_CheckedChanged);
            // 
            // rbElectrodomestico
            // 
            this.rbElectrodomestico.AutoSize = true;
            this.rbElectrodomestico.Location = new System.Drawing.Point(6, 22);
            this.rbElectrodomestico.Name = "rbElectrodomestico";
            this.rbElectrodomestico.Size = new System.Drawing.Size(117, 19);
            this.rbElectrodomestico.TabIndex = 0;
            this.rbElectrodomestico.TabStop = true;
            this.rbElectrodomestico.Text = "Electrodomestico";
            this.rbElectrodomestico.UseVisualStyleBackColor = true;
            this.rbElectrodomestico.CheckedChanged += new System.EventHandler(this.rbElectrodomestico_CheckedChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(12, 116);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 23);
            this.txtPrecio.TabIndex = 17;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(12, 72);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 23);
            this.txtMarca.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 23);
            this.txtId.TabIndex = 15;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 98);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(40, 15);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Marca";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "ID";
            // 
            // FrmCargarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 187);
            this.Controls.Add(this.cboInstrumentos);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboElectrodomestico);
            this.Controls.Add(this.gboProducto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCargarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Producto";
            this.gboProducto.ResumeLayout(false);
            this.gboProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboInstrumentos;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboElectrodomestico;
        private System.Windows.Forms.GroupBox gboProducto;
        private System.Windows.Forms.RadioButton rbInstrumento;
        private System.Windows.Forms.RadioButton rbElectrodomestico;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
    }
}