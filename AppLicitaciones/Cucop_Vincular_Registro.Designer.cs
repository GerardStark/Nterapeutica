﻿namespace AppLicitaciones
{
    partial class Cucop_Vincular_Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cucop_Vincular_Registro));
            this.dgv_vinculados = new System.Windows.Forms.DataGridView();
            this.idvincregColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numvincregColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_registros = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titularColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabrColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_buscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btn_agregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btn_quitar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btn_info = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_registros = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.licitacionesDataSet = new AppLicitaciones.LicitacionesDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vinculados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vinculados
            // 
            this.dgv_vinculados.AllowUserToAddRows = false;
            this.dgv_vinculados.AllowUserToDeleteRows = false;
            this.dgv_vinculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vinculados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvincregColumn,
            this.numvincregColumn});
            this.dgv_vinculados.Location = new System.Drawing.Point(12, 47);
            this.dgv_vinculados.Name = "dgv_vinculados";
            this.dgv_vinculados.ReadOnly = true;
            this.dgv_vinculados.Size = new System.Drawing.Size(320, 540);
            this.dgv_vinculados.TabIndex = 0;
            this.dgv_vinculados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vinculados_CellClick);
            this.dgv_vinculados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_vinculados_CellFormatting);
            // 
            // idvincregColumn
            // 
            this.idvincregColumn.HeaderText = "#";
            this.idvincregColumn.Name = "idvincregColumn";
            this.idvincregColumn.ReadOnly = true;
            this.idvincregColumn.Width = 25;
            // 
            // numvincregColumn
            // 
            this.numvincregColumn.HeaderText = "Numero";
            this.numvincregColumn.Name = "numvincregColumn";
            this.numvincregColumn.ReadOnly = true;
            this.numvincregColumn.Width = 250;
            // 
            // dgv_registros
            // 
            this.dgv_registros.AllowUserToAddRows = false;
            this.dgv_registros.AllowUserToDeleteRows = false;
            this.dgv_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.numeroColumn,
            this.titularColumn,
            this.distColumn,
            this.generColumn,
            this.fabrColumn,
            this.paisColumn});
            this.dgv_registros.Location = new System.Drawing.Point(427, 47);
            this.dgv_registros.Name = "dgv_registros";
            this.dgv_registros.ReadOnly = true;
            this.dgv_registros.Size = new System.Drawing.Size(819, 540);
            this.dgv_registros.TabIndex = 1;
            this.dgv_registros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_registros_CellClick);
            this.dgv_registros.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_registros_CellFormatting);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "#";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 50;
            // 
            // numeroColumn
            // 
            this.numeroColumn.HeaderText = "Numero";
            this.numeroColumn.Name = "numeroColumn";
            this.numeroColumn.ReadOnly = true;
            this.numeroColumn.Width = 125;
            // 
            // titularColumn
            // 
            this.titularColumn.HeaderText = "Titular";
            this.titularColumn.Name = "titularColumn";
            this.titularColumn.ReadOnly = true;
            this.titularColumn.Width = 125;
            // 
            // distColumn
            // 
            this.distColumn.HeaderText = "Distintiva";
            this.distColumn.Name = "distColumn";
            this.distColumn.ReadOnly = true;
            // 
            // generColumn
            // 
            this.generColumn.HeaderText = "Generica";
            this.generColumn.Name = "generColumn";
            this.generColumn.ReadOnly = true;
            // 
            // fabrColumn
            // 
            this.fabrColumn.HeaderText = "Fabricante";
            this.fabrColumn.Name = "fabrColumn";
            this.fabrColumn.ReadOnly = true;
            // 
            // paisColumn
            // 
            this.paisColumn.HeaderText = "Pais";
            this.paisColumn.Name = "paisColumn";
            this.paisColumn.ReadOnly = true;
            this.paisColumn.Width = 175;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_buscar,
            this.toolStripLabel6,
            this.btn_agregar,
            this.toolStripLabel5,
            this.btn_quitar,
            this.toolStripLabel4,
            this.btn_info,
            this.toolStripLabel3,
            this.toolStripSeparator1,
            this.btn_guardar,
            this.toolStripLabel2,
            this.toolStripButton1,
            this.toolStripLabel1,
            this.btn_registros,
            this.toolStripLabel7});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(342, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(75, 561);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_buscar
            // 
            this.btn_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(73, 54);
            this.btn_buscar.Text = "toolStripButton6";
            this.btn_buscar.ToolTipText = "Buscar";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(73, 15);
            this.toolStripLabel6.Text = "Buscar";
            // 
            // btn_agregar
            // 
            this.btn_agregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(73, 54);
            this.btn_agregar.Text = "toolStripButton1";
            this.btn_agregar.ToolTipText = "Agregar";
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(73, 15);
            this.toolStripLabel5.Text = "Agregar";
            // 
            // btn_quitar
            // 
            this.btn_quitar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_quitar.Image = ((System.Drawing.Image)(resources.GetObject("btn_quitar.Image")));
            this.btn_quitar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(73, 54);
            this.btn_quitar.Text = "toolStripButton2";
            this.btn_quitar.ToolTipText = "Quitar";
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(73, 15);
            this.toolStripLabel4.Text = "Remover";
            // 
            // btn_info
            // 
            this.btn_info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_info.Image = ((System.Drawing.Image)(resources.GetObject("btn_info.Image")));
            this.btn_info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(73, 54);
            this.btn_info.Text = "toolStripButton3";
            this.btn_info.ToolTipText = "Ver información";
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(73, 15);
            this.toolStripLabel3.Text = "Info";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(73, 6);
            // 
            // btn_guardar
            // 
            this.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(73, 54);
            this.btn_guardar.Text = "toolStripButton4";
            this.btn_guardar.ToolTipText = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(73, 15);
            this.toolStripLabel2.Text = "Terminar";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 54);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(73, 15);
            this.toolStripLabel1.Text = "Referencias";
            // 
            // btn_registros
            // 
            this.btn_registros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_registros.Image = ((System.Drawing.Image)(resources.GetObject("btn_registros.Image")));
            this.btn_registros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_registros.Name = "btn_registros";
            this.btn_registros.Size = new System.Drawing.Size(73, 54);
            this.btn_registros.Text = "toolStripButton2";
            this.btn_registros.Click += new System.EventHandler(this.btn_registros_Click);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(73, 15);
            this.toolStripLabel7.Text = "Ir a Registros";
            // 
            // licitacionesDataSet
            // 
            this.licitacionesDataSet.DataSetName = "LicitacionesDataSet";
            this.licitacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vinculos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(780, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Registros Sanitarios";
            // 
            // Cucop_Vincular_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 602);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_registros);
            this.Controls.Add(this.dgv_vinculados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cucop_Vincular_Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cucop_Vincular_Registro";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vinculados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vinculados;
        private System.Windows.Forms.DataGridView dgv_registros;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvincregColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numvincregColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_agregar;
        private System.Windows.Forms.ToolStripButton btn_quitar;
        private System.Windows.Forms.ToolStripButton btn_info;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripButton btn_buscar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private LicitacionesDataSet licitacionesDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titularColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabrColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_registros;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
    }
}