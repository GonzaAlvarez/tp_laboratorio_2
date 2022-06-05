
namespace Sistema_de_Stock
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRecaudacion = new System.Windows.Forms.Label();
            this.btnVenderProducto = new System.Windows.Forms.Button();
            this.btnGuardarStockJson = new System.Windows.Forms.Button();
            this.dtStock = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardarStockXml = new System.Windows.Forms.Button();
            this.btnCargarStockXml = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecaudacion
            // 
            this.lblRecaudacion.AutoSize = true;
            this.lblRecaudacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecaudacion.Location = new System.Drawing.Point(11, 336);
            this.lblRecaudacion.Name = "lblRecaudacion";
            this.lblRecaudacion.Size = new System.Drawing.Size(112, 21);
            this.lblRecaudacion.TabIndex = 18;
            this.lblRecaudacion.Text = "Recaudacion:";
            // 
            // btnVenderProducto
            // 
            this.btnVenderProducto.Location = new System.Drawing.Point(12, 93);
            this.btnVenderProducto.Name = "btnVenderProducto";
            this.btnVenderProducto.Size = new System.Drawing.Size(123, 35);
            this.btnVenderProducto.TabIndex = 17;
            this.btnVenderProducto.Text = "Vender Producto";
            this.btnVenderProducto.UseVisualStyleBackColor = true;
            this.btnVenderProducto.Click += new System.EventHandler(this.btnVenderProducto_Click);
            // 
            // btnGuardarStockJson
            // 
            this.btnGuardarStockJson.Location = new System.Drawing.Point(428, 293);
            this.btnGuardarStockJson.Name = "btnGuardarStockJson";
            this.btnGuardarStockJson.Size = new System.Drawing.Size(123, 35);
            this.btnGuardarStockJson.TabIndex = 16;
            this.btnGuardarStockJson.Text = "Guardar Stock JSON";
            this.btnGuardarStockJson.UseVisualStyleBackColor = true;
            this.btnGuardarStockJson.Click += new System.EventHandler(this.btnGuardarStockJson_Click);
            // 
            // dtStock
            // 
            this.dtStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtStock.Location = new System.Drawing.Point(161, 12);
            this.dtStock.Name = "dtStock";
            this.dtStock.ReadOnly = true;
            this.dtStock.RowTemplate.Height = 25;
            this.dtStock.Size = new System.Drawing.Size(525, 275);
            this.dtStock.TabIndex = 15;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(557, 293);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 35);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardarStockXml
            // 
            this.btnGuardarStockXml.Location = new System.Drawing.Point(170, 293);
            this.btnGuardarStockXml.Name = "btnGuardarStockXml";
            this.btnGuardarStockXml.Size = new System.Drawing.Size(123, 35);
            this.btnGuardarStockXml.TabIndex = 13;
            this.btnGuardarStockXml.Text = "Guardar Stock XML";
            this.btnGuardarStockXml.UseVisualStyleBackColor = true;
            this.btnGuardarStockXml.Click += new System.EventHandler(this.btnGuardarStockXml_Click);
            // 
            // btnCargarStockXml
            // 
            this.btnCargarStockXml.Location = new System.Drawing.Point(299, 293);
            this.btnCargarStockXml.Name = "btnCargarStockXml";
            this.btnCargarStockXml.Size = new System.Drawing.Size(123, 35);
            this.btnCargarStockXml.TabIndex = 12;
            this.btnCargarStockXml.Text = "Cargar Stock XML";
            this.btnCargarStockXml.UseVisualStyleBackColor = true;
            this.btnCargarStockXml.Click += new System.EventHandler(this.btnCargarStockXml_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(12, 53);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(123, 35);
            this.btnEliminarProducto.TabIndex = 11;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.Location = new System.Drawing.Point(12, 12);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(123, 35);
            this.btnCargarProducto.TabIndex = 10;
            this.btnCargarProducto.Text = "Cargar Producto";
            this.btnCargarProducto.UseVisualStyleBackColor = true;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 363);
            this.Controls.Add(this.lblRecaudacion);
            this.Controls.Add(this.btnVenderProducto);
            this.Controls.Add(this.btnGuardarStockJson);
            this.Controls.Add(this.dtStock);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardarStockXml);
            this.Controls.Add(this.btnCargarStockXml);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnCargarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Sotck";
            ((System.ComponentModel.ISupportInitialize)(this.dtStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecaudacion;
        private System.Windows.Forms.Button btnVenderProducto;
        private System.Windows.Forms.Button btnGuardarStockJson;
        private System.Windows.Forms.DataGridView dtStock;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardarStockXml;
        private System.Windows.Forms.Button btnCargarStockXml;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnCargarProducto;
    }
}

