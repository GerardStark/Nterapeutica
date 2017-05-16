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
            this.tt_registros = new System.Windows.Forms.ToolStrip();
            this.btn_reg_nuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_reg_buscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btn_reg_claves = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.btn_reg_prorrogas = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.DGVRegistros = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titularColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabrColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlcColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emisionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimientoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt_registros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRegistros)).BeginInit();
            this.SuspendLayout();
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
            this.toolStripButton1,
            this.toolStripLabel3});
            this.tt_registros.Location = new System.Drawing.Point(0, 0);
            this.tt_registros.Name = "tt_registros";
            this.tt_registros.Size = new System.Drawing.Size(91, 729);
            this.tt_registros.Stretch = true;
            this.tt_registros.TabIndex = 0;
            this.tt_registros.Text = "Herramientas";
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
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(88, 54);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(88, 15);
            this.toolStripLabel3.Text = "Visualizar";
            // 
            // DGVRegistros
            // 
            this.DGVRegistros.AllowUserToAddRows = false;
            this.DGVRegistros.AllowUserToDeleteRows = false;
            this.DGVRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.numColumn,
            this.solColumn,
            this.tipoColumn,
            this.titularColumn,
            this.fabrColumn,
            this.marcaColumn,
            this.nacColumn,
            this.tlcColumn,
            this.emisionColumn,
            this.vencimientoColumn});
            this.DGVRegistros.Location = new System.Drawing.Point(95, 13);
            this.DGVRegistros.Name = "DGVRegistros";
            this.DGVRegistros.ReadOnly = true;
            this.DGVRegistros.Size = new System.Drawing.Size(1243, 704);
            this.DGVRegistros.TabIndex = 1;
            // 
            // idColumn
            // 
            this.idColumn.Frozen = true;
            this.idColumn.HeaderText = "#";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
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
            // nacColumn
            // 
            this.nacColumn.HeaderText = "Nacionalidad";
            this.nacColumn.Name = "nacColumn";
            this.nacColumn.ReadOnly = true;
            this.nacColumn.Width = 75;
            // 
            // tlcColumn
            // 
            this.tlcColumn.HeaderText = "TLC";
            this.tlcColumn.Name = "tlcColumn";
            this.tlcColumn.ReadOnly = true;
            // 
            // emisionColumn
            // 
            this.emisionColumn.HeaderText = "Emision";
            this.emisionColumn.Name = "emisionColumn";
            this.emisionColumn.ReadOnly = true;
            // 
            // vencimientoColumn
            // 
            this.vencimientoColumn.HeaderText = "Vencimiento";
            this.vencimientoColumn.Name = "vencimientoColumn";
            this.vencimientoColumn.ReadOnly = true;
            // 
            // Registros_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.DGVRegistros);
            this.Controls.Add(this.tt_registros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Registros_Principal";
            this.Text = "Panel Principal de Registros Sanitarios";
            this.tt_registros.ResumeLayout(false);
            this.tt_registros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tt_registros;
        private System.Windows.Forms.ToolStripButton btn_reg_nuevo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_reg_buscar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton btn_reg_claves;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripButton btn_reg_prorrogas;
        private System.Windows.Forms.DataGridView DGVRegistros;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titularColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabrColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlcColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emisionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimientoColumn;
    }
}