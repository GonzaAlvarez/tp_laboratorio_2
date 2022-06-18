
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargarProducto));
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
            this.cboInstrumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.cboInstrumentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboInstrumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInstrumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboInstrumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboInstrumentos.ForeColor = System.Drawing.Color.White;
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
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProducto.ForeColor = System.Drawing.Color.White;
            this.lblProducto.Location = new System.Drawing.Point(161, 98);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(120, 15);
            this.lblProducto.TabIndex = 22;
            this.lblProducto.Text = "Tipo de Producto:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(111)))), ((int)(((byte)(94)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(176, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 32);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(111)))), ((int)(((byte)(94)))));
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(12, 145);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 32);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboElectrodomestico
            // 
            this.cboElectrodomestico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.cboElectrodomestico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboElectrodomestico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboElectrodomestico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboElectrodomestico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboElectrodomestico.ForeColor = System.Drawing.Color.White;
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
            this.gboProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.gboProducto.Controls.Add(this.rbInstrumento);
            this.gboProducto.Controls.Add(this.rbElectrodomestico);
            this.gboProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gboProducto.ForeColor = System.Drawing.Color.White;
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
            this.rbInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbInstrumento.ForeColor = System.Drawing.Color.White;
            this.rbInstrumento.Location = new System.Drawing.Point(6, 47);
            this.rbInstrumento.Name = "rbInstrumento";
            this.rbInstrumento.Size = new System.Drawing.Size(101, 19);
            this.rbInstrumento.TabIndex = 1;
            this.rbInstrumento.TabStop = true;
            this.rbInstrumento.Text = "Instrumento";
            this.rbInstrumento.UseVisualStyleBackColor = true;
            this.rbInstrumento.CheckedChanged += new System.EventHandler(this.rbInstrumento_CheckedChanged);
            // 
            // rbElectrodomestico
            // 
            this.rbElectrodomestico.AutoSize = true;
            this.rbElectrodomestico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbElectrodomestico.ForeColor = System.Drawing.Color.White;
            this.rbElectrodomestico.Location = new System.Drawing.Point(6, 22);
            this.rbElectrodomestico.Name = "rbElectrodomestico";
            this.rbElectrodomestico.Size = new System.Drawing.Size(136, 19);
            this.rbElectrodomestico.TabIndex = 0;
            this.rbElectrodomestico.TabStop = true;
            this.rbElectrodomestico.Text = "Electrodomestico";
            this.rbElectrodomestico.UseVisualStyleBackColor = true;
            this.rbElectrodomestico.CheckedChanged += new System.EventHandler(this.rbElectrodomestico_CheckedChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.ForeColor = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(12, 116);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 21);
            this.txtPrecio.TabIndex = 17;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMarca.ForeColor = System.Drawing.Color.White;
            this.txtMarca.Location = new System.Drawing.Point(12, 72);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 21);
            this.txtMarca.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(12, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 21);
            this.txtId.TabIndex = 15;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(12, 98);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 15);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(12, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 15);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Marca";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "ID";
            // 
            // FrmCargarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
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
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCargarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Producto";
            this.Load += new System.EventHandler(this.FrmCargarProducto_Load);
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