namespace AppLicitaciones
{
    partial class Buscar_Cucops_Vinculacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_filtrar = new System.Windows.Forms.TextBox();
            this.dgvCucops = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.pnl_tags = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCucops)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar:";
            // 
            // txt_filtrar
            // 
            this.txt_filtrar.Location = new System.Drawing.Point(64, 8);
            this.txt_filtrar.Name = "txt_filtrar";
            this.txt_filtrar.Size = new System.Drawing.Size(490, 22);
            this.txt_filtrar.TabIndex = 2;
            // 
            // dgvCucops
            // 
            this.dgvCucops.AllowUserToAddRows = false;
            this.dgvCucops.AllowUserToDeleteRows = false;
            this.dgvCucops.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCucops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCucops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.claveColumn,
            this.descColumn,
            this.detailsColumn});
            this.dgvCucops.Location = new System.Drawing.Point(12, 36);
            this.dgvCucops.Name = "dgvCucops";
            this.dgvCucops.ReadOnly = true;
            this.dgvCucops.RowHeadersVisible = false;
            this.dgvCucops.Size = new System.Drawing.Size(1126, 485);
            this.dgvCucops.TabIndex = 0;
            this.dgvCucops.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCucops_CellClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "#";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // claveColumn
            // 
            this.claveColumn.HeaderText = "Clave";
            this.claveColumn.Name = "claveColumn";
            this.claveColumn.ReadOnly = true;
            this.claveColumn.Width = 250;
            // 
            // descColumn
            // 
            this.descColumn.HeaderText = "Descripcion";
            this.descColumn.Name = "descColumn";
            this.descColumn.ReadOnly = true;
            this.descColumn.Width = 600;
            // 
            // detailsColumn
            // 
            this.detailsColumn.HeaderText = "Detalles";
            this.detailsColumn.Name = "detailsColumn";
            this.detailsColumn.ReadOnly = true;
            this.detailsColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detailsColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.detailsColumn.Text = "Ver";
            this.detailsColumn.UseColumnTextForButtonValue = true;
            this.detailsColumn.Width = 150;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(560, 8);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrar.TabIndex = 3;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // pnl_tags
            // 
            this.pnl_tags.Location = new System.Drawing.Point(641, 7);
            this.pnl_tags.Name = "pnl_tags";
            this.pnl_tags.Size = new System.Drawing.Size(497, 24);
            this.pnl_tags.TabIndex = 4;
            // 
            // Buscar_Cucops_Vinculacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 533);
            this.Controls.Add(this.pnl_tags);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.txt_filtrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCucops);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Buscar_Cucops_Vinculacion";
            this.Text = "Buscar_Cucops_Vinculacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCucops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_filtrar;
        private System.Windows.Forms.DataGridView dgvCucops;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descColumn;
        private System.Windows.Forms.DataGridViewButtonColumn detailsColumn;
        private System.Windows.Forms.Panel pnl_tags;
    }
}