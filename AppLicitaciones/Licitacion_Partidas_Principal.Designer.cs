namespace AppLicitaciones
{
    partial class Licitacion_Partidas_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licitacion_Partidas_Principal));
            this.dgvPartidas = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBasesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.btn_tecnica = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDoc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPartidas
            // 
            this.dgvPartidas.AllowUserToAddRows = false;
            this.dgvPartidas.AllowUserToDeleteRows = false;
            this.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.numColumn,
            this.nombColumn,
            this.specColumn,
            this.idBasesColumn});
            this.dgvPartidas.Location = new System.Drawing.Point(15, 102);
            this.dgvPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPartidas.MultiSelect = false;
            this.dgvPartidas.Name = "dgvPartidas";
            this.dgvPartidas.ReadOnly = true;
            this.dgvPartidas.RowHeadersVisible = false;
            this.dgvPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartidas.Size = new System.Drawing.Size(779, 419);
            this.dgvPartidas.TabIndex = 0;
            this.dgvPartidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartidas_CellClick);
            this.dgvPartidas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPartidas_CellFormatting);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "#";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 75;
            // 
            // numColumn
            // 
            this.numColumn.HeaderText = "Numero";
            this.numColumn.Name = "numColumn";
            this.numColumn.ReadOnly = true;
            // 
            // nombColumn
            // 
            this.nombColumn.HeaderText = "Nombre";
            this.nombColumn.Name = "nombColumn";
            this.nombColumn.ReadOnly = true;
            this.nombColumn.Width = 250;
            // 
            // specColumn
            // 
            this.specColumn.HeaderText = "Especialidad";
            this.specColumn.Name = "specColumn";
            this.specColumn.ReadOnly = true;
            this.specColumn.Width = 150;
            // 
            // idBasesColumn
            // 
            this.idBasesColumn.HeaderText = "Licitación";
            this.idBasesColumn.Name = "idBasesColumn";
            this.idBasesColumn.ReadOnly = true;
            this.idBasesColumn.Width = 200;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.BackgroundImage")));
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Location = new System.Drawing.Point(15, 44);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(50, 50);
            this.btn_nuevo.TabIndex = 1;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_visualizar.BackgroundImage")));
            this.btn_visualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_visualizar.Location = new System.Drawing.Point(115, 44);
            this.btn_visualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(50, 50);
            this.btn_visualizar.TabIndex = 2;
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // btn_tecnica
            // 
            this.btn_tecnica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tecnica.BackgroundImage")));
            this.btn_tecnica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tecnica.Location = new System.Drawing.Point(215, 44);
            this.btn_tecnica.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tecnica.Name = "btn_tecnica";
            this.btn_tecnica.Size = new System.Drawing.Size(50, 50);
            this.btn_tecnica.TabIndex = 3;
            this.btn_tecnica.UseVisualStyleBackColor = true;
            this.btn_tecnica.Click += new System.EventHandler(this.btn_tecnica_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_borrar.BackgroundImage")));
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar.Location = new System.Drawing.Point(315, 44);
            this.btn_borrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(50, 50);
            this.btn_borrar.TabIndex = 4;
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nueva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Editar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ficha Tecnica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Borrar";
            // 
            // btnDoc
            // 
            this.btnDoc.BackgroundImage = global::AppLicitaciones.Iconos.android_folder;
            this.btnDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoc.Location = new System.Drawing.Point(744, 44);
            this.btnDoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(50, 50);
            this.btnDoc.TabIndex = 9;
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(741, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ver Doc.";
            // 
            // Licitacion_Partidas_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 534);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_tecnica);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.dgvPartidas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Licitacion_Partidas_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licitacion_Partidas_Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPartidas;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.Button btn_tecnica;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBasesColumn;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Label label5;
    }
}