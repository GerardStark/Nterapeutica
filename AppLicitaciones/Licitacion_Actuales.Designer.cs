﻿namespace AppLicitaciones
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
            this.btn_visualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_calendario = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btn_partidas = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btn_actas = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.updatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoExpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unicompColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_licitaciones = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_licitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_visualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_visualizar.Image")));
            this.btn_visualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(62, 44);
            this.btn_visualizar.Text = "toolStripButton1";
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(62, 15);
            this.toolStripLabel1.Text = "Visualizar";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_visualizar,
            this.toolStripLabel1,
            this.btn_calendario,
            this.toolStripLabel4,
            this.btn_partidas,
            this.toolStripLabel5,
            this.btn_actas,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(65, 487);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_calendario
            // 
            this.btn_calendario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_calendario.Image = ((System.Drawing.Image)(resources.GetObject("btn_calendario.Image")));
            this.btn_calendario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_calendario.Name = "btn_calendario";
            this.btn_calendario.Size = new System.Drawing.Size(62, 44);
            this.btn_calendario.Text = "toolStripButton1";
            this.btn_calendario.Click += new System.EventHandler(this.btn_calendario_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(62, 15);
            this.toolStripLabel4.Text = "Calendario";
            // 
            // btn_partidas
            // 
            this.btn_partidas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_partidas.Image = ((System.Drawing.Image)(resources.GetObject("btn_partidas.Image")));
            this.btn_partidas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_partidas.Name = "btn_partidas";
            this.btn_partidas.Size = new System.Drawing.Size(62, 44);
            this.btn_partidas.Text = "toolStripButton1";
            this.btn_partidas.Click += new System.EventHandler(this.btn_partidas_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(62, 15);
            this.toolStripLabel5.Text = "Partidas";
            // 
            // btn_actas
            // 
            this.btn_actas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_actas.Image = ((System.Drawing.Image)(resources.GetObject("btn_actas.Image")));
            this.btn_actas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_actas.Name = "btn_actas";
            this.btn_actas.Size = new System.Drawing.Size(62, 44);
            this.btn_actas.Text = "toolStripButton1";
            this.btn_actas.Click += new System.EventHandler(this.btn_actas_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(62, 15);
            this.toolStripLabel2.Text = "Actas";
            // 
            // updatedColumn
            // 
            this.updatedColumn.HeaderText = "Actualizado en";
            this.updatedColumn.Name = "updatedColumn";
            this.updatedColumn.ReadOnly = true;
            this.updatedColumn.Visible = false;
            // 
            // descColumn
            // 
            this.descColumn.HeaderText = "Descripcion";
            this.descColumn.Name = "descColumn";
            this.descColumn.ReadOnly = true;
            this.descColumn.Width = 215;
            // 
            // tipoExpColumn
            // 
            this.tipoExpColumn.HeaderText = "Tipo de Exp.";
            this.tipoExpColumn.Name = "tipoExpColumn";
            this.tipoExpColumn.ReadOnly = true;
            this.tipoExpColumn.Width = 150;
            // 
            // expColumn
            // 
            this.expColumn.HeaderText = "Expendiente";
            this.expColumn.Name = "expColumn";
            this.expColumn.ReadOnly = true;
            this.expColumn.Width = 150;
            // 
            // specColumn
            // 
            this.specColumn.HeaderText = "Especialidad";
            this.specColumn.Name = "specColumn";
            this.specColumn.ReadOnly = true;
            this.specColumn.Width = 150;
            // 
            // entidadColumn
            // 
            this.entidadColumn.HeaderText = "Entidad F.";
            this.entidadColumn.Name = "entidadColumn";
            this.entidadColumn.ReadOnly = true;
            this.entidadColumn.Width = 150;
            // 
            // unicompColumn
            // 
            this.unicompColumn.HeaderText = "Unidad Compradora";
            this.unicompColumn.Name = "unicompColumn";
            this.unicompColumn.ReadOnly = true;
            this.unicompColumn.Width = 175;
            // 
            // numColumn
            // 
            this.numColumn.HeaderText = "Numero";
            this.numColumn.Name = "numColumn";
            this.numColumn.ReadOnly = true;
            this.numColumn.Width = 125;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "#";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 50;
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
            this.dgv_licitaciones.Location = new System.Drawing.Point(73, 10);
            this.dgv_licitaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_licitaciones.MultiSelect = false;
            this.dgv_licitaciones.Name = "dgv_licitaciones";
            this.dgv_licitaciones.ReadOnly = true;
            this.dgv_licitaciones.RowHeadersVisible = false;
            this.dgv_licitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_licitaciones.Size = new System.Drawing.Size(1172, 468);
            this.dgv_licitaciones.TabIndex = 6;
            this.dgv_licitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_licitaciones_CellClick);
            this.dgv_licitaciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_licitaciones_CellFormatting);
            // 
            // Licitacion_Actuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 487);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_licitaciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Licitacion_Actuales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licitacion_Actuales";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_licitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton btn_visualizar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_calendario;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoExpColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unicompColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridView dgv_licitaciones;
        private System.Windows.Forms.ToolStripButton btn_partidas;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton btn_actas;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}