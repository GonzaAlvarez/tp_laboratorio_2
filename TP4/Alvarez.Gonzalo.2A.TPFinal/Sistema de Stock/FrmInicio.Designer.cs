
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.lblRecaudacion = new System.Windows.Forms.Label();
            this.btnVenderProducto = new System.Windows.Forms.Button();
            this.btnGuardarStockJson = new System.Windows.Forms.Button();
            this.dtStock = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardarStockXml = new System.Windows.Forms.Button();
            this.btnCargarStockXml = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.btnCargarBD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaYHora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnListaClientesBD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecaudacion
            // 
            this.lblRecaudacion.AutoSize = true;
            this.lblRecaudacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecaudacion.ForeColor = System.Drawing.Color.White;
            this.lblRecaudacion.Location = new System.Drawing.Point(14, 346);
            this.lblRecaudacion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRecaudacion.Name = "lblRecaudacion";
            this.lblRecaudacion.Size = new System.Drawing.Size(139, 24);
            this.lblRecaudacion.TabIndex = 18;
            this.lblRecaudacion.Text = "Recaudacion:";
            // 
            // btnVenderProducto
            // 
            this.btnVenderProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenderProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(111)))), ((int)(((byte)(94)))));
            this.btnVenderProducto.FlatAppearance.BorderSize = 2;
            this.btnVenderProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenderProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVenderProducto.ForeColor = System.Drawing.Color.White;
            this.btnVenderProducto.Location = new System.Drawing.Point(14, 124);
            this.btnVenderProducto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnVenderProducto.Name = "btnVenderProducto";
            this.btnVenderProducto.Size = new System.Drawing.Size(139, 35);
            this.btnVenderProducto.TabIndex = 17;
            this.btnVenderProducto.Text = "Vender Producto";
            this.btnVenderProducto.UseVisualStyleBackColor = true;
            this.btnVenderProducto.Click += new System.EventHandler(this.btnVenderProducto_Click);
            // 
            // btnGuardarStockJson
            // 
            this.btnGuardarStockJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarStockJson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(111)))), ((int)(((byte)(94)))));
            this.btnGuardarStockJson.FlatAppearance.BorderSize = 2;
            this.btnGuardarStockJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarStockJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarStockJson.ForeColor = System.Drawing.Color.White;
            this.btnGuardarStockJson.Location = new System.Drawing.Point(427, 295);
            this.btnGuardarStockJson.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGuardarStockJson.Name = "btnGuardarStockJson";
            this.btnGuardarStockJson.Size = new System.Drawing.Size(110, 44);
            this.btnGuardarStockJson.TabIndex = 16;
            this.btnGuardarStockJson.Text = "Guardar Stock JSON";
            this.btnGuardarStockJson.UseVisualStyleBackColor = true;
            this.btnGuardarStockJson.Click += new System.EventHandler(this.btnGuardarStockJson_Click);
            // 
            // dtStock
            // 
            this.dtStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtStock.ColumnHeadersHeight = 25;
            this.dtStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtStock.EnableHeadersVisualStyles = false;
            this.dtStock.GridColor = System.Drawing.Color.SteelBlue;
            this.dtStock.Location = new System.Drawing.Point(184, 12);
            this.dtStock.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtStock.Name = "dtStock";
            this.dtStock.ReadOnly = true;
            this.dtStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtStock.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtStock.RowTemplate.Height = 25;
            this.dtStock.Size = new System.Drawing.Size(473, 277);
            this.dtStock.TabIndex = 15;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(111)))), ((int)(((byte)(94)))));
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(547, 295);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 44);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardarStockXml
            // 
            this.btnGuardarStockXml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarStockXml.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(111)))), ((int)(((byte)(94)))));
            this.btnGuardarStockXml.FlatAppearance.BorderSize = 2;
            this.btnGuardarStockXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarStockXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarStockXml.ForeColor = System.Drawing.Color.White;
            this.btnGuardarStockXml.Location = new System.Drawing.Point(187, 295);
            this.btnGuardarStockXml.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGuardarStockXml.Name = "btnGuardarStockXml";
            this.btnGuardarStockXml.Size = new System.Drawing.Size(110, 44);
            this.btnGuardarStockXml.TabIndex = 13;
            this.btnGuardarStockXml.Text = "Guardar Stock XML";
            this.btnGuardarStockXml.UseVisualStyleBackColor = true;
            this.btnGuardarStockXml.Click += new System.EventHandler(this.btnGuardarStockXml_Click);
            // 
            // btnCargarStockXml
            // 
            this.btnCargarStockXml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarStockXml.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(111)))), ((int)(((byte)(94)))));
            this.btnCargarStockXml.FlatAppearance.BorderSize = 2;
            this.btnCargarStockXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarStockXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarStockXml.ForeColor = System.Drawing.Color.White;
            this.btnCargarStockXml.Location = new System.Drawing.Point(307, 295);
            this.btnCargarStockXml.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCargarStockXml.Name = "btnCargarStockXml";
            this.btnCargarStockXml.Size = new System.Drawing.Size(110, 44);
            this.btnCargarStockXml.TabIndex = 12;
            this.btnCargarStockXml.Text = "Cargar Stock XML";
            this.btnCargarStockXml.UseVisualStyleBackColor = true;
            this.btnCargarStockXml.Click += new System.EventHandler(this.btnCargarStockXml_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(111)))), ((int)(((byte)(94)))));
            this.btnEliminarProducto.FlatAppearance.BorderSize = 2;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProducto.Location = new System.Drawing.Point(14, 83);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(139, 35);
            this.btnEliminarProducto.TabIndex = 11;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnCargarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(111)))), ((int)(((byte)(94)))));
            this.btnCargarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarProducto.ForeColor = System.Drawing.Color.White;
            this.btnCargarProducto.Location = new System.Drawing.Point(14, 42);
            this.btnCargarProducto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(139, 35);
            this.btnCargarProducto.TabIndex = 10;
            this.btnCargarProducto.Text = "Cargar Producto";
            this.btnCargarProducto.UseVisualStyleBackColor = false;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // btnCargarBD
            // 
            this.btnCargarBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarBD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(111)))), ((int)(((byte)(94)))));
            this.btnCargarBD.FlatAppearance.BorderSize = 2;
            this.btnCargarBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarBD.ForeColor = System.Drawing.Color.White;
            this.btnCargarBD.Location = new System.Drawing.Point(14, 180);
            this.btnCargarBD.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCargarBD.Name = "btnCargarBD";
            this.btnCargarBD.Size = new System.Drawing.Size(139, 44);
            this.btnCargarBD.TabIndex = 21;
            this.btnCargarBD.Text = "Cargar Stock  Base de Datos";
            this.btnCargarBD.UseVisualStyleBackColor = true;
            this.btnCargarBD.Click += new System.EventHandler(this.btnCargarBD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "----------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "----------------------------";
            // 
            // lblFechaYHora
            // 
            this.lblFechaYHora.AutoSize = true;
            this.lblFechaYHora.ForeColor = System.Drawing.Color.White;
            this.lblFechaYHora.Location = new System.Drawing.Point(6, 12);
            this.lblFechaYHora.Name = "lblFechaYHora";
            this.lblFechaYHora.Size = new System.Drawing.Size(145, 15);
            this.lblFechaYHora.TabIndex = 26;
            this.lblFechaYHora.Text = "dd/mm/yyyy hh/mm/ss";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "----------------------------";
            // 
            // btnListaClientesBD
            // 
            this.btnListaClientesBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaClientesBD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(111)))), ((int)(((byte)(94)))));
            this.btnListaClientesBD.FlatAppearance.BorderSize = 2;
            this.btnListaClientesBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaClientesBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListaClientesBD.ForeColor = System.Drawing.Color.White;
            this.btnListaClientesBD.Location = new System.Drawing.Point(14, 245);
            this.btnListaClientesBD.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnListaClientesBD.Name = "btnListaClientesBD";
            this.btnListaClientesBD.Size = new System.Drawing.Size(139, 44);
            this.btnListaClientesBD.TabIndex = 28;
            this.btnListaClientesBD.Text = "Lista de Clientes Base de Datos";
            this.btnListaClientesBD.UseVisualStyleBackColor = true;
            this.btnListaClientesBD.Click += new System.EventHandler(this.btnListaClientesBD_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(666, 379);
            this.Controls.Add(this.btnListaClientesBD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFechaYHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarBD);
            this.Controls.Add(this.lblRecaudacion);
            this.Controls.Add(this.btnVenderProducto);
            this.Controls.Add(this.btnGuardarStockJson);
            this.Controls.Add(this.dtStock);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardarStockXml);
            this.Controls.Add(this.btnCargarStockXml);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnCargarProducto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Stock y Venta al Cliente";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
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
        private System.Windows.Forms.Button btnCargarBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaYHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnListaClientesBD;
    }
}

