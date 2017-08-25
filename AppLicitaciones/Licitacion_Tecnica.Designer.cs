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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licitacion_Tecnica));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProcedimientos = new System.Windows.Forms.DataGridView();
            this.idSubColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPartParentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numSubColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomSubColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.idItemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSubParentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descItemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofertaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_proc_nuevo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_proc_editar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_item_nuevo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_oferta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_proc_borrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_preguntas_ja = new System.Windows.Forms.Button();
            this.btn_item_borrar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_item_editar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
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
            // dgvProcedimientos
            // 
            this.dgvProcedimientos.AllowUserToAddRows = false;
            this.dgvProcedimientos.AllowUserToDeleteRows = false;
            this.dgvProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcedimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSubColumn,
            this.idPartParentColumn,
            this.numSubColumn,
            this.nomSubColumn});
            this.dgvProcedimientos.Location = new System.Drawing.Point(12, 28);
            this.dgvProcedimientos.MultiSelect = false;
            this.dgvProcedimientos.Name = "dgvProcedimientos";
            this.dgvProcedimientos.ReadOnly = true;
            this.dgvProcedimientos.RowHeadersVisible = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcedimientos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProcedimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcedimientos.Size = new System.Drawing.Size(454, 180);
            this.dgvProcedimientos.TabIndex = 3;
            this.dgvProcedimientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcedimientos_CellClick);
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
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItemColumn,
            this.idSubParentColumn,
            this.unidadColumn,
            this.descItemColumn,
            this.ofertaColumn});
            this.dgvItems.Location = new System.Drawing.Point(12, 240);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(1255, 351);
            this.dgvItems.TabIndex = 4;
            this.dgvItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellClick);
            this.dgvItems.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvItems_CellFormatting);
            // 
            // idItemColumn
            // 
            this.idItemColumn.HeaderText = "#";
            this.idItemColumn.Name = "idItemColumn";
            this.idItemColumn.ReadOnly = true;
            this.idItemColumn.Width = 75;
            // 
            // idSubParentColumn
            // 
            this.idSubParentColumn.HeaderText = "Subpartida";
            this.idSubParentColumn.Name = "idSubParentColumn";
            this.idSubParentColumn.ReadOnly = true;
            this.idSubParentColumn.Width = 125;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Items de cada Procedimiento/Subpartida";
            // 
            // btn_proc_nuevo
            // 
            this.btn_proc_nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_proc_nuevo.BackgroundImage")));
            this.btn_proc_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_proc_nuevo.Location = new System.Drawing.Point(487, 16);
            this.btn_proc_nuevo.Name = "btn_proc_nuevo";
            this.btn_proc_nuevo.Size = new System.Drawing.Size(50, 50);
            this.btn_proc_nuevo.TabIndex = 6;
            this.btn_proc_nuevo.UseVisualStyleBackColor = true;
            this.btn_proc_nuevo.Click += new System.EventHandler(this.btn_proc_nuevo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(491, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Agregar";
            // 
            // btn_proc_editar
            // 
            this.btn_proc_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_proc_editar.BackgroundImage")));
            this.btn_proc_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_proc_editar.Location = new System.Drawing.Point(487, 85);
            this.btn_proc_editar.Name = "btn_proc_editar";
            this.btn_proc_editar.Size = new System.Drawing.Size(50, 50);
            this.btn_proc_editar.TabIndex = 8;
            this.btn_proc_editar.UseVisualStyleBackColor = true;
            this.btn_proc_editar.Click += new System.EventHandler(this.btn_proc_editar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Editar";
            // 
            // btn_item_nuevo
            // 
            this.btn_item_nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_item_nuevo.BackgroundImage")));
            this.btn_item_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_item_nuevo.Location = new System.Drawing.Point(650, 168);
            this.btn_item_nuevo.Name = "btn_item_nuevo";
            this.btn_item_nuevo.Size = new System.Drawing.Size(50, 50);
            this.btn_item_nuevo.TabIndex = 10;
            this.btn_item_nuevo.UseVisualStyleBackColor = true;
            this.btn_item_nuevo.Click += new System.EventHandler(this.btn_item_nuevo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(647, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nuevo item";
            // 
            // btn_oferta
            // 
            this.btn_oferta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_oferta.BackgroundImage")));
            this.btn_oferta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_oferta.Location = new System.Drawing.Point(794, 168);
            this.btn_oferta.Name = "btn_oferta";
            this.btn_oferta.Size = new System.Drawing.Size(50, 50);
            this.btn_oferta.TabIndex = 14;
            this.btn_oferta.UseVisualStyleBackColor = true;
            this.btn_oferta.Click += new System.EventHandler(this.btn_oferta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(785, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Item Ofertado";
            // 
            // btn_proc_borrar
            // 
            this.btn_proc_borrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_proc_borrar.BackgroundImage")));
            this.btn_proc_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_proc_borrar.Location = new System.Drawing.Point(485, 156);
            this.btn_proc_borrar.Name = "btn_proc_borrar";
            this.btn_proc_borrar.Size = new System.Drawing.Size(50, 50);
            this.btn_proc_borrar.TabIndex = 16;
            this.btn_proc_borrar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(494, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Borrar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(880, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "JA";
            // 
            // btn_preguntas_ja
            // 
            this.btn_preguntas_ja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_preguntas_ja.BackgroundImage")));
            this.btn_preguntas_ja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_preguntas_ja.Location = new System.Drawing.Point(864, 168);
            this.btn_preguntas_ja.Name = "btn_preguntas_ja";
            this.btn_preguntas_ja.Size = new System.Drawing.Size(50, 50);
            this.btn_preguntas_ja.TabIndex = 18;
            this.btn_preguntas_ja.UseVisualStyleBackColor = true;
            // 
            // btn_item_borrar
            // 
            this.btn_item_borrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_item_borrar.BackgroundImage")));
            this.btn_item_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_item_borrar.Location = new System.Drawing.Point(933, 168);
            this.btn_item_borrar.Name = "btn_item_borrar";
            this.btn_item_borrar.Size = new System.Drawing.Size(50, 50);
            this.btn_item_borrar.TabIndex = 20;
            this.btn_item_borrar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(942, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Borrar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(729, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Editar";
            // 
            // btn_item_editar
            // 
            this.btn_item_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_item_editar.BackgroundImage")));
            this.btn_item_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_item_editar.Location = new System.Drawing.Point(723, 168);
            this.btn_item_editar.Name = "btn_item_editar";
            this.btn_item_editar.Size = new System.Drawing.Size(50, 50);
            this.btn_item_editar.TabIndex = 22;
            this.btn_item_editar.UseVisualStyleBackColor = true;
            this.btn_item_editar.Click += new System.EventHandler(this.btn_item_editar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1180, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Asignar a Todos";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1197, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Licitacion_Tecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 603);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_item_editar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_item_borrar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_preguntas_ja);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_proc_borrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_oferta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_item_nuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_proc_editar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_proc_nuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.dgvProcedimientos);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Licitacion_Tecnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licitacion_Tecnica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProcedimientos;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSubColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPartParentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSubColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSubColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_proc_nuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_proc_editar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_item_nuevo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_oferta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_proc_borrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_preguntas_ja;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSubParentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descItemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ofertaColumn;
        private System.Windows.Forms.Button btn_item_borrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_item_editar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}