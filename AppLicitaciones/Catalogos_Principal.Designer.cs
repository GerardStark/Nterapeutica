namespace AppLicitaciones
{
    partial class Catalogos_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogos_Principal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_buscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btn_claves = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.btn_traducciones = new System.Windows.Forms.ToolStripButton();
            this.btn_visualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.DGV_Catalogos = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricanteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idiomaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Catalogos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo,
            this.toolStripLabel1,
            this.btn_buscar,
            this.toolStripLabel5,
            this.toolStripLabel6,
            this.btn_claves,
            this.toolStripLabel7,
            this.btn_traducciones,
            this.btn_visualizar,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(91, 671);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Image")));
            this.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(88, 54);
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(88, 15);
            this.toolStripLabel1.Text = "Nuevo";
            // 
            // btn_buscar
            // 
            this.btn_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(88, 54);
            this.btn_buscar.Text = "toolStripButton4";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
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
            // btn_claves
            // 
            this.btn_claves.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_claves.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_claves.Image = ((System.Drawing.Image)(resources.GetObject("btn_claves.Image")));
            this.btn_claves.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_claves.Name = "btn_claves";
            this.btn_claves.Size = new System.Drawing.Size(88, 54);
            this.btn_claves.Text = "toolStripButton6";
            this.btn_claves.Click += new System.EventHandler(this.btn_claves_Click);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(88, 15);
            this.toolStripLabel7.Text = "Traducciones";
            // 
            // btn_traducciones
            // 
            this.btn_traducciones.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_traducciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_traducciones.Image = ((System.Drawing.Image)(resources.GetObject("btn_traducciones.Image")));
            this.btn_traducciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_traducciones.Name = "btn_traducciones";
            this.btn_traducciones.Size = new System.Drawing.Size(88, 54);
            this.btn_traducciones.Text = "toolStripButton7";
            this.btn_traducciones.Click += new System.EventHandler(this.btn_traducciones_Click);
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
            // DGV_Catalogos
            // 
            this.DGV_Catalogos.AllowUserToAddRows = false;
            this.DGV_Catalogos.AllowUserToDeleteRows = false;
            this.DGV_Catalogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Catalogos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nombreColumn,
            this.tipoColumn,
            this.yearColumn,
            this.especialidadColumn,
            this.fabricanteColumn,
            this.idiomaColumn});
            this.DGV_Catalogos.Location = new System.Drawing.Point(95, 12);
            this.DGV_Catalogos.Name = "DGV_Catalogos";
            this.DGV_Catalogos.ReadOnly = true;
            this.DGV_Catalogos.Size = new System.Drawing.Size(1243, 649);
            this.DGV_Catalogos.TabIndex = 2;
            this.DGV_Catalogos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Catalogos_CellClick);
            this.DGV_Catalogos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_Catalogos_CellFormatting);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "#";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 25;
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre";
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.ReadOnly = true;
            this.nombreColumn.Width = 200;
            // 
            // tipoColumn
            // 
            this.tipoColumn.HeaderText = "Tipo";
            this.tipoColumn.Name = "tipoColumn";
            this.tipoColumn.ReadOnly = true;
            this.tipoColumn.Width = 175;
            // 
            // yearColumn
            // 
            this.yearColumn.HeaderText = "Año";
            this.yearColumn.Name = "yearColumn";
            this.yearColumn.ReadOnly = true;
            this.yearColumn.Width = 200;
            // 
            // especialidadColumn
            // 
            this.especialidadColumn.HeaderText = "Especialidad";
            this.especialidadColumn.Name = "especialidadColumn";
            this.especialidadColumn.ReadOnly = true;
            this.especialidadColumn.Width = 200;
            // 
            // fabricanteColumn
            // 
            this.fabricanteColumn.HeaderText = "Fabricante";
            this.fabricanteColumn.Name = "fabricanteColumn";
            this.fabricanteColumn.ReadOnly = true;
            this.fabricanteColumn.Width = 200;
            // 
            // idiomaColumn
            // 
            this.idiomaColumn.HeaderText = "Idioma";
            this.idiomaColumn.Name = "idiomaColumn";
            this.idiomaColumn.ReadOnly = true;
            this.idiomaColumn.Width = 200;
            // 
            // Catalogos_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 671);
            this.Controls.Add(this.DGV_Catalogos);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Catalogos_Principal";
            this.Text = "Panel Principal de Catálogos de Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Catalogos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_buscar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton btn_claves;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripButton btn_traducciones;
        private System.Windows.Forms.DataGridView DGV_Catalogos;
        private System.Windows.Forms.ToolStripButton btn_visualizar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricanteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idiomaColumn;
    }
}