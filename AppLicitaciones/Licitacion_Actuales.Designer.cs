namespace AppLicitaciones
{
    partial class Licitacion_Actuales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licitacion_Actuales));
            this.dgv_licitaciones = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unicompColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoExpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_visualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_tecnica = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btn_economica = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_calendario = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_licitaciones)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_licitaciones
            // 
            this.dgv_licitaciones.AllowUserToAddRows = false;
            this.dgv_licitaciones.AllowUserToDeleteRows = false;
            this.dgv_licitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_licitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.numColumn,
            this.unicompColumn,
            this.entidadColumn,
            this.specColumn,
            this.expColumn,
            this.tipoExpColumn,
            this.descColumn,
            this.updatedColumn});
            this.dgv_licitaciones.Location = new System.Drawing.Point(82, 12);
            this.dgv_licitaciones.MultiSelect = false;
            this.dgv_licitaciones.Name = "dgv_licitaciones";
            this.dgv_licitaciones.ReadOnly = true;
            this.dgv_licitaciones.RowHeadersVisible = false;
            this.dgv_licitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_licitaciones.Size = new System.Drawing.Size(655, 585);
            this.dgv_licitaciones.TabIndex = 6;
            this.dgv_licitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_licitaciones_CellClick);
            this.dgv_licitaciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_licitaciones_CellFormatting);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "#";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 50;
            // 
            // numColumn
            // 
            this.numColumn.HeaderText = "Numero";
            this.numColumn.Name = "numColumn";
            this.numColumn.ReadOnly = true;
            this.numColumn.Width = 125;
            // 
            // unicompColumn
            // 
            this.unicompColumn.HeaderText = "Unidad Compradora";
            this.unicompColumn.Name = "unicompColumn";
            this.unicompColumn.ReadOnly = true;
            this.unicompColumn.Width = 175;
            // 
            // entidadColumn
            // 
            this.entidadColumn.HeaderText = "Entidad F.";
            this.entidadColumn.Name = "entidadColumn";
            this.entidadColumn.ReadOnly = true;
            this.entidadColumn.Width = 150;
            // 
            // specColumn
            // 
            this.specColumn.HeaderText = "Especialidad";
            this.specColumn.Name = "specColumn";
            this.specColumn.ReadOnly = true;
            this.specColumn.Width = 150;
            // 
            // expColumn
            // 
            this.expColumn.HeaderText = "Expendiente";
            this.expColumn.Name = "expColumn";
            this.expColumn.ReadOnly = true;
            this.expColumn.Width = 150;
            // 
            // tipoExpColumn
            // 
            this.tipoExpColumn.HeaderText = "Tipo de Exp.";
            this.tipoExpColumn.Name = "tipoExpColumn";
            this.tipoExpColumn.ReadOnly = true;
            this.tipoExpColumn.Width = 150;
            // 
            // descColumn
            // 
            this.descColumn.HeaderText = "Descripcion";
            this.descColumn.Name = "descColumn";
            this.descColumn.ReadOnly = true;
            this.descColumn.Width = 215;
            // 
            // updatedColumn
            // 
            this.updatedColumn.HeaderText = "Actualizado en";
            this.updatedColumn.Name = "updatedColumn";
            this.updatedColumn.ReadOnly = true;
            this.updatedColumn.Visible = false;
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_visualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_visualizar.Image")));
            this.btn_visualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(76, 54);
            this.btn_visualizar.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(76, 15);
            this.toolStripLabel1.Text = "Visualizar";
            // 
            // btn_tecnica
            // 
            this.btn_tecnica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_tecnica.Image = ((System.Drawing.Image)(resources.GetObject("btn_tecnica.Image")));
            this.btn_tecnica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_tecnica.Name = "btn_tecnica";
            this.btn_tecnica.Size = new System.Drawing.Size(76, 54);
            this.btn_tecnica.Text = "toolStripButton2";
            this.btn_tecnica.Click += new System.EventHandler(this.btn_tecnica_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(76, 15);
            this.toolStripLabel2.Text = "Ficha Tecnica";
            // 
            // btn_economica
            // 
            this.btn_economica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_economica.Image = ((System.Drawing.Image)(resources.GetObject("btn_economica.Image")));
            this.btn_economica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_economica.Name = "btn_economica";
            this.btn_economica.Size = new System.Drawing.Size(76, 54);
            this.btn_economica.Text = "toolStripButton1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(76, 15);
            this.toolStripLabel3.Text = "Economica";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_visualizar,
            this.toolStripLabel1,
            this.btn_tecnica,
            this.toolStripLabel2,
            this.btn_economica,
            this.toolStripLabel3,
            this.btn_calendario,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(79, 609);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(743, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(528, 228);
            this.treeView1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(743, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(829, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 50);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(915, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 50);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_calendario
            // 
            this.btn_calendario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_calendario.Image = ((System.Drawing.Image)(resources.GetObject("btn_calendario.Image")));
            this.btn_calendario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_calendario.Name = "btn_calendario";
            this.btn_calendario.Size = new System.Drawing.Size(76, 54);
            this.btn_calendario.Text = "toolStripButton1";
            this.btn_calendario.Click += new System.EventHandler(this.btn_calendario_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(76, 15);
            this.toolStripLabel4.Text = "Calendario";
            // 
            // Licitacion_Actuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 609);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_licitaciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Licitacion_Actuales";
            this.Text = "Licitacion_Actuales";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_licitaciones)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_licitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unicompColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoExpColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedColumn;
        private System.Windows.Forms.ToolStripButton btn_visualizar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_tecnica;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btn_economica;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripButton btn_calendario;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
    }
}