namespace AppLicitaciones
{
    partial class Cucop_Vinculos_Eliminar
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
            this.dgv_vinculos = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vinculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vinculos
            // 
            this.dgv_vinculos.AllowUserToAddRows = false;
            this.dgv_vinculos.AllowUserToDeleteRows = false;
            this.dgv_vinculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vinculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.optColumn,
            this.nombreColumn,
            this.btnEliminarColumn});
            this.dgv_vinculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_vinculos.Location = new System.Drawing.Point(0, 0);
            this.dgv_vinculos.Name = "dgv_vinculos";
            this.dgv_vinculos.ReadOnly = true;
            this.dgv_vinculos.RowHeadersVisible = false;
            this.dgv_vinculos.Size = new System.Drawing.Size(528, 522);
            this.dgv_vinculos.TabIndex = 0;
            this.dgv_vinculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vinculos_CellClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "#";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 50;
            // 
            // optColumn
            // 
            this.optColumn.HeaderText = "Opcion";
            this.optColumn.Name = "optColumn";
            this.optColumn.ReadOnly = true;
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre";
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.ReadOnly = true;
            this.nombreColumn.Width = 275;
            // 
            // btnEliminarColumn
            // 
            this.btnEliminarColumn.HeaderText = "Eliminar";
            this.btnEliminarColumn.Name = "btnEliminarColumn";
            this.btnEliminarColumn.ReadOnly = true;
            this.btnEliminarColumn.Text = "Eliminar";
            this.btnEliminarColumn.ToolTipText = "Eliminar";
            // 
            // Cucop_Vinculos_Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 522);
            this.Controls.Add(this.dgv_vinculos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cucop_Vinculos_Eliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cucop_Vinculos_Eliminar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cucop_Vinculos_Eliminar_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vinculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vinculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminarColumn;
    }
}