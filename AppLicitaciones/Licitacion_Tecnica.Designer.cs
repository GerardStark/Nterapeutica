namespace AppLicitaciones
{
    partial class Licitacion_Tecnica
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idSubColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPartParentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numSubColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomSubColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idItemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSubParentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descItemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofertaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Procedimientos y Subpartidas";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSubColumn,
            this.idPartParentColumn,
            this.numSubColumn,
            this.nomSubColumn});
            this.dataGridView2.Location = new System.Drawing.Point(12, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(454, 180);
            this.dataGridView2.TabIndex = 3;
            // 
            // idSubColumn
            // 
            this.idSubColumn.HeaderText = "#";
            this.idSubColumn.Name = "idSubColumn";
            this.idSubColumn.ReadOnly = true;
            this.idSubColumn.Width = 50;
            // 
            // idPartParentColumn
            // 
            this.idPartParentColumn.HeaderText = "Partida";
            this.idPartParentColumn.Name = "idPartParentColumn";
            this.idPartParentColumn.ReadOnly = true;
            // 
            // numSubColumn
            // 
            this.numSubColumn.HeaderText = "No.";
            this.numSubColumn.Name = "numSubColumn";
            this.numSubColumn.ReadOnly = true;
            this.numSubColumn.Width = 50;
            // 
            // nomSubColumn
            // 
            this.nomSubColumn.HeaderText = "Nombre";
            this.nomSubColumn.Name = "nomSubColumn";
            this.nomSubColumn.ReadOnly = true;
            this.nomSubColumn.Width = 250;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItemColumn,
            this.idSubParentColumn,
            this.unidadColumn,
            this.descItemColumn,
            this.ofertaColumn});
            this.dataGridView3.Location = new System.Drawing.Point(12, 216);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(1255, 375);
            this.dataGridView3.TabIndex = 4;
            // 
            // idItemColumn
            // 
            this.idItemColumn.HeaderText = "#";
            this.idItemColumn.Name = "idItemColumn";
            this.idItemColumn.ReadOnly = true;
            // 
            // idSubParentColumn
            // 
            this.idSubParentColumn.HeaderText = "Subpartida";
            this.idSubParentColumn.Name = "idSubParentColumn";
            this.idSubParentColumn.ReadOnly = true;
            // 
            // unidadColumn
            // 
            this.unidadColumn.HeaderText = "Unidad de Venta";
            this.unidadColumn.Name = "unidadColumn";
            this.unidadColumn.ReadOnly = true;
            this.unidadColumn.Width = 150;
            // 
            // descItemColumn
            // 
            this.descItemColumn.HeaderText = "Descripcion";
            this.descItemColumn.Name = "descItemColumn";
            this.descItemColumn.ReadOnly = true;
            this.descItemColumn.Width = 450;
            // 
            // ofertaColumn
            // 
            this.ofertaColumn.HeaderText = "Item Ofertado";
            this.ofertaColumn.Name = "ofertaColumn";
            this.ofertaColumn.ReadOnly = true;
            this.ofertaColumn.Width = 450;
            // 
            // Licitacion_Tecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 603);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Licitacion_Tecnica";
            this.Text = "Licitacion_Tecnica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSubColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPartParentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSubColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSubColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSubParentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descItemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ofertaColumn;
    }
}