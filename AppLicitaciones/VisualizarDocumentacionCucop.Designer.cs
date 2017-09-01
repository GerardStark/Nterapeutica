namespace AppLicitaciones
{
    partial class VisualizarDocumentacionCucop
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_carta = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.dgvReg = new System.Windows.Forms.DataGridView();
            this.dgvCat = new System.Windows.Forms.DataGridView();
            this.dgvCer = new System.Windows.Forms.DataGridView();
            this.idregColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registros Sanitarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Catálogos de Productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(693, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Certificados de Calidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Carta de Apoyo:";
            // 
            // lbl_carta
            // 
            this.lbl_carta.AutoSize = true;
            this.lbl_carta.Location = new System.Drawing.Point(128, 34);
            this.lbl_carta.Name = "lbl_carta";
            this.lbl_carta.Size = new System.Drawing.Size(38, 16);
            this.lbl_carta.TabIndex = 8;
            this.lbl_carta.Text = "carta";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(128, 9);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(54, 16);
            this.lbl_nombre.TabIndex = 9;
            this.lbl_nombre.Text = "nombre";
            // 
            // dgvReg
            // 
            this.dgvReg.AllowUserToAddRows = false;
            this.dgvReg.AllowUserToDeleteRows = false;
            this.dgvReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idregColumn});
            this.dgvReg.Location = new System.Drawing.Point(20, 85);
            this.dgvReg.Name = "dgvReg";
            this.dgvReg.ReadOnly = true;
            this.dgvReg.RowHeadersVisible = false;
            this.dgvReg.Size = new System.Drawing.Size(240, 150);
            this.dgvReg.TabIndex = 10;
            // 
            // dgvCat
            // 
            this.dgvCat.AllowUserToAddRows = false;
            this.dgvCat.AllowUserToDeleteRows = false;
            this.dgvCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcatColumn});
            this.dgvCat.Location = new System.Drawing.Point(336, 85);
            this.dgvCat.Name = "dgvCat";
            this.dgvCat.ReadOnly = true;
            this.dgvCat.RowHeadersVisible = false;
            this.dgvCat.Size = new System.Drawing.Size(240, 150);
            this.dgvCat.TabIndex = 11;
            // 
            // dgvCer
            // 
            this.dgvCer.AllowUserToAddRows = false;
            this.dgvCer.AllowUserToDeleteRows = false;
            this.dgvCer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcerColumn});
            this.dgvCer.Location = new System.Drawing.Point(653, 85);
            this.dgvCer.Name = "dgvCer";
            this.dgvCer.ReadOnly = true;
            this.dgvCer.RowHeadersVisible = false;
            this.dgvCer.Size = new System.Drawing.Size(240, 150);
            this.dgvCer.TabIndex = 12;
            // 
            // idregColumn
            // 
            this.idregColumn.HeaderText = "Numero";
            this.idregColumn.Name = "idregColumn";
            this.idregColumn.ReadOnly = true;
            this.idregColumn.Width = 240;
            // 
            // idcatColumn
            // 
            this.idcatColumn.HeaderText = "Nombre";
            this.idcatColumn.Name = "idcatColumn";
            this.idcatColumn.ReadOnly = true;
            this.idcatColumn.Width = 240;
            // 
            // idcerColumn
            // 
            this.idcerColumn.HeaderText = "Numero";
            this.idcerColumn.Name = "idcerColumn";
            this.idcerColumn.ReadOnly = true;
            this.idcerColumn.Width = 240;
            // 
            // VisualizarDocumentacionCucop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCer);
            this.Controls.Add(this.dgvCat);
            this.Controls.Add(this.dgvReg);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_carta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisualizarDocumentacionCucop";
            this.Size = new System.Drawing.Size(930, 280);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_carta;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridView dgvReg;
        private System.Windows.Forms.DataGridView dgvCat;
        private System.Windows.Forms.DataGridView dgvCer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idregColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcerColumn;
    }
}
