namespace AppLicitaciones
{
    partial class Registros_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros_Principal));
            this.DGVRegistros = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfcColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titularColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabrColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distintivaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genericaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emisionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimientoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_reg_nuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_reg_buscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btn_reg_claves = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.btn_reg_prorrogas = new System.Windows.Forms.ToolStripButton();
            this.btn_visualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tt_registros = new System.Windows.Forms.ToolStrip();
            this.lbl_conteo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRegistros)).BeginInit();
            this.tt_registros.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVRegistros
            // 
            this.DGVRegistros.AllowUserToAddRows = false;
            this.DGVRegistros.AllowUserToDeleteRows = false;
            this.DGVRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.numColumn,
            this.solColumn,
            this.rfcColumn,
            this.tipoColumn,
            this.titularColumn,
            this.fabrColumn,
            this.marcaColumn,
            this.paisColumn,
            this.distintivaColumn,
            this.genericaColumn,
            this.emisionColumn,
            this.vencimientoColumn,
            this.updatedColumn});
            this.DGVRegistros.Location = new System.Drawing.Point(84, 10);
            this.DGVRegistros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVRegistros.Name = "DGVRegistros";
            this.DGVRegistros.ReadOnly = true;
            this.DGVRegistros.RowHeadersVisible = false;
            this.DGVRegistros.Size = new System.Drawing.Size(1130, 506);
            this.DGVRegistros.TabIndex = 1;
            this.DGVRegistros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRegistros_CellClick);
            this.DGVRegistros.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVRegistros_CellFormatting);
            // 
            // idColumn
            // 
            this.idColumn.Frozen = true;
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
            // solColumn
            // 
            this.solColumn.HeaderText = "Solicitud";
            this.solColumn.Name = "solColumn";
            this.solColumn.ReadOnly = true;
            this.solColumn.Width = 125;
            // 
            // rfcColumn
            // 
            this.rfcColumn.HeaderText = "RFC";
            this.rfcColumn.Name = "rfcColumn";
            this.rfcColumn.ReadOnly = true;
            // 
            // tipoColumn
            // 
            this.tipoColumn.HeaderText = "Tipo";
            this.tipoColumn.Name = "tipoColumn";
            this.tipoColumn.ReadOnly = true;
            // 
            // titularColumn
            // 
            this.titularColumn.HeaderText = "Titular";
            this.titularColumn.Name = "titularColumn";
            this.titularColumn.ReadOnly = true;
            this.titularColumn.Width = 125;
            // 
            // fabrColumn
            // 
            this.fabrColumn.HeaderText = "Fabricante";
            this.fabrColumn.Name = "fabrColumn";
            this.fabrColumn.ReadOnly = true;
            this.fabrColumn.Width = 125;
            // 
            // marcaColumn
            // 
            this.marcaColumn.HeaderText = "Marca";
            this.marcaColumn.Name = "marcaColumn";
            this.marcaColumn.ReadOnly = true;
            this.marcaColumn.Width = 125;
            // 
            // paisColumn
            // 
            this.paisColumn.HeaderText = "Pais";
            this.paisColumn.Name = "paisColumn";
            this.paisColumn.ReadOnly = true;
            // 
            // distintivaColumn
            // 
            this.distintivaColumn.HeaderText = "Denom. Distintiva";
            this.distintivaColumn.Name = "distintivaColumn";
            this.distintivaColumn.ReadOnly = true;
            // 
            // genericaColumn
            // 
            this.genericaColumn.HeaderText = "Denom. Generica";
            this.genericaColumn.Name = "genericaColumn";
            this.genericaColumn.ReadOnly = true;
            // 
            // emisionColumn
            // 
            this.emisionColumn.HeaderText = "Emision";
            this.emisionColumn.Name = "emisionColumn";
            this.emisionColumn.ReadOnly = true;
            this.emisionColumn.Width = 125;
            // 
            // vencimientoColumn
            // 
            this.vencimientoColumn.HeaderText = "Vencimiento";
            this.vencimientoColumn.Name = "vencimientoColumn";
            this.vencimientoColumn.ReadOnly = true;
            this.vencimientoColumn.Width = 125;
            // 
            // updatedColumn
            // 
            this.updatedColumn.HeaderText = "Actualizado";
            this.updatedColumn.Name = "updatedColumn";
            this.updatedColumn.ReadOnly = true;
            this.updatedColumn.Visible = false;
            // 
            // btn_reg_nuevo
            // 
            this.btn_reg_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_reg_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_reg_nuevo.Image")));
            this.btn_reg_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reg_nuevo.Name = "btn_reg_nuevo";
            this.btn_reg_nuevo.Size = new System.Drawing.Size(88, 54);
            this.btn_reg_nuevo.Text = "Nuevo";
            this.btn_reg_nuevo.Click += new System.EventHandler(this.btn_reg_nuevo_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(88, 15);
            this.toolStripLabel1.Text = "Nuevo";
            // 
            // btn_reg_buscar
            // 
            this.btn_reg_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_reg_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_reg_buscar.Image")));
            this.btn_reg_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reg_buscar.Name = "btn_reg_buscar";
            this.btn_reg_buscar.Size = new System.Drawing.Size(88, 54);
            this.btn_reg_buscar.Text = "toolStripButton4";
            this.btn_reg_buscar.Click += new System.EventHandler(this.btn_reg_buscar_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(88, 15);
            this.toolStripLabel5.Text = "Buscar";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(88, 15);
            this.toolStripLabel6.Text = "Claves/Codigos";
            // 
            // btn_reg_claves
            // 
            this.btn_reg_claves.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_reg_claves.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_reg_claves.Image = ((System.Drawing.Image)(resources.GetObject("btn_reg_claves.Image")));
            this.btn_reg_claves.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reg_claves.Name = "btn_reg_claves";
            this.btn_reg_claves.Size = new System.Drawing.Size(88, 54);
            this.btn_reg_claves.Text = "toolStripButton6";
            this.btn_reg_claves.Click += new System.EventHandler(this.btn_reg_claves_Click);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(88, 15);
            this.toolStripLabel7.Text = "Prórrogas";
            // 
            // btn_reg_prorrogas
            // 
            this.btn_reg_prorrogas.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_reg_prorrogas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_reg_prorrogas.Image = ((System.Drawing.Image)(resources.GetObject("btn_reg_prorrogas.Image")));
            this.btn_reg_prorrogas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reg_prorrogas.Name = "btn_reg_prorrogas";
            this.btn_reg_prorrogas.Size = new System.Drawing.Size(88, 54);
            this.btn_reg_prorrogas.Text = "toolStripButton7";
            this.btn_reg_prorrogas.Click += new System.EventHandler(this.btn_reg_prorrogas_Click);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_visualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_visualizar.Image")));
            this.btn_visualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(88, 54);
            this.btn_visualizar.Text = "toolStripButton1";
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(88, 15);
            this.toolStripLabel3.Text = "Visualizar";
            // 
            // tt_registros
            // 
            this.tt_registros.Dock = System.Windows.Forms.DockStyle.Left;
            this.tt_registros.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tt_registros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_reg_nuevo,
            this.toolStripLabel1,
            this.btn_reg_buscar,
            this.toolStripLabel5,
            this.toolStripLabel6,
            this.btn_reg_claves,
            this.toolStripLabel7,
            this.btn_reg_prorrogas,
            this.btn_visualizar,
            this.toolStripLabel3});
            this.tt_registros.Location = new System.Drawing.Point(0, 0);
            this.tt_registros.Name = "tt_registros";
            this.tt_registros.Size = new System.Drawing.Size(91, 549);
            this.tt_registros.Stretch = true;
            this.tt_registros.TabIndex = 0;
            this.tt_registros.Text = "Herramientas";
            // 
            // lbl_conteo
            // 
            this.lbl_conteo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_conteo.AutoSize = true;
            this.lbl_conteo.Location = new System.Drawing.Point(1013, 524);
            this.lbl_conteo.Name = "lbl_conteo";
            this.lbl_conteo.Size = new System.Drawing.Size(45, 16);
            this.lbl_conteo.TabIndex = 2;
            this.lbl_conteo.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1085, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registros Sanitarios";
            // 
            // Registros_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_conteo);
            this.Controls.Add(this.DGVRegistros);
            this.Controls.Add(this.tt_registros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registros_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.DGVRegistros)).EndInit();
            this.tt_registros.ResumeLayout(false);
            this.tt_registros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVRegistros;
        private System.Windows.Forms.ToolStripButton btn_reg_nuevo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_reg_buscar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton btn_reg_claves;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripButton btn_reg_prorrogas;
        private System.Windows.Forms.ToolStripButton btn_visualizar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStrip tt_registros;
        private System.Windows.Forms.Label lbl_conteo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfcColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titularColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabrColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distintivaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genericaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emisionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimientoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedColumn;
    }
}