namespace GenerarQr
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.GenerarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.pbCodigoBarras = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ImportarBtn = new System.Windows.Forms.Button();
            this.ExportarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigoBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Barras";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(59, 85);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(190, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // GenerarBtn
            // 
            this.GenerarBtn.Location = new System.Drawing.Point(298, 85);
            this.GenerarBtn.Name = "GenerarBtn";
            this.GenerarBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerarBtn.TabIndex = 2;
            this.GenerarBtn.Text = "Generar";
            this.GenerarBtn.UseVisualStyleBackColor = true;
            this.GenerarBtn.Click += new System.EventHandler(this.GenerarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(391, 84);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 23);
            this.GuardarBtn.TabIndex = 3;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // pbCodigoBarras
            // 
            this.pbCodigoBarras.Location = new System.Drawing.Point(59, 125);
            this.pbCodigoBarras.Name = "pbCodigoBarras";
            this.pbCodigoBarras.Size = new System.Drawing.Size(432, 208);
            this.pbCodigoBarras.TabIndex = 4;
            this.pbCodigoBarras.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(543, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 321);
            this.dataGridView1.TabIndex = 6;
            // 
            // ImportarBtn
            // 
            this.ImportarBtn.Location = new System.Drawing.Point(298, 24);
            this.ImportarBtn.Name = "ImportarBtn";
            this.ImportarBtn.Size = new System.Drawing.Size(75, 23);
            this.ImportarBtn.TabIndex = 7;
            this.ImportarBtn.Text = "Importar";
            this.ImportarBtn.UseVisualStyleBackColor = true;
            this.ImportarBtn.Click += new System.EventHandler(this.ImportarBtn_Click);
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(391, 23);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(75, 23);
            this.ExportarBtn.TabIndex = 8;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 363);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.ImportarBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pbCodigoBarras);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.GenerarBtn);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigoBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button GenerarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.PictureBox pbCodigoBarras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ImportarBtn;
        private System.Windows.Forms.Button ExportarBtn;
    }
}

