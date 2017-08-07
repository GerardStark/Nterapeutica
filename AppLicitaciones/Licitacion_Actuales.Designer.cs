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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_visualizar = new System.Windows.Forms.ToolStripButton();
            this.btn_tecnica = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unicompColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoExpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_economica = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
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
            this.dgv_licitaciones.Name = "dgv_licitaciones";
            this.dgv_licitaciones.ReadOnly = true;
            this.dgv_licitaciones.RowHeadersVisible = false;
            this.dgv_licitaciones.Size = new System.Drawing.Size(1169, 585);
            this.dgv_licitaciones.TabIndex = 6;
            this.dgv_licitaciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_licitaciones_CellFormatting);
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
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(79, 609);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
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
            // btn_tecnica
            // 
            this.btn_tecnica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_tecnica.Image = ((System.Drawing.Image)(resources.GetObject("btn_tecnica.Image")));
            this.btn_tecnica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_tecnica.Name = "btn_tecnica";
            this.btn_tecnica.Size = new System.Drawing.Size(76, 54);
            this.btn_tecnica.Text = "toolStripButton2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(76, 15);
            this.toolStripLabel1.Text = "Visualizar";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(76, 15);
            this.toolStripLabel2.Text = "Ficha Tecnica";
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
            // Licitacion_Actuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 609);
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_visualizar;
        private System.Windows.Forms.ToolStripButton btn_tecnica;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unicompColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoExpColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedColumn;
        private System.Windows.Forms.ToolStripButton btn_economica;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    }
}