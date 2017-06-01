namespace AppLicitaciones
{
    partial class Cucop_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cucop_Principal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_buscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btn_vincular = new System.Windows.Forms.ToolStripButton();
            this.btn_visualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.DGV_cucop = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nprodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificadoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_cucop)).BeginInit();
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
            this.btn_vincular,
            this.btn_visualizar,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(97, 691);
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
            this.btn_nuevo.Size = new System.Drawing.Size(94, 54);
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(94, 15);
            this.toolStripLabel1.Text = "Nuevo";
            // 
            // btn_buscar
            // 
            this.btn_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(94, 54);
            this.btn_buscar.Text = "toolStripButton4";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(94, 15);
            this.toolStripLabel5.Text = "Buscar";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(94, 15);
            this.toolStripLabel6.Text = "Vincular RECACE";
            // 
            // btn_vincular
            // 
            this.btn_vincular.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_vincular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_vincular.Image = ((System.Drawing.Image)(resources.GetObject("btn_vincular.Image")));
            this.btn_vincular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_vincular.Name = "btn_vincular";
            this.btn_vincular.Size = new System.Drawing.Size(94, 54);
            this.btn_vincular.Text = "toolStripButton6";
            this.btn_vincular.Click += new System.EventHandler(this.btn_vincular_Click);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_visualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_visualizar.Image")));
            this.btn_visualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(94, 54);
            this.btn_visualizar.Text = "toolStripButton1";
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(94, 15);
            this.toolStripLabel3.Text = "Visualizar";
            // 
            // DGV_cucop
            // 
            this.DGV_cucop.AllowUserToAddRows = false;
            this.DGV_cucop.AllowUserToDeleteRows = false;
            this.DGV_cucop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_cucop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.ngeColumn,
            this.nprodColumn,
            this.grupoColumn,
            this.codigoColumn,
            this.registroColumn,
            this.catalogoColumn,
            this.certificadoColumn});
            this.DGV_cucop.Location = new System.Drawing.Point(100, 12);
            this.DGV_cucop.Name = "DGV_cucop";
            this.DGV_cucop.ReadOnly = true;
            this.DGV_cucop.Size = new System.Drawing.Size(1243, 667);
            this.DGV_cucop.TabIndex = 2;
            this.DGV_cucop.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_cucop_RowHeaderMouseClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "#";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 25;
            // 
            // ngeColumn
            // 
            this.ngeColumn.HeaderText = "Nombre Generico";
            this.ngeColumn.Name = "ngeColumn";
            this.ngeColumn.ReadOnly = true;
            this.ngeColumn.Width = 200;
            // 
            // nprodColumn
            // 
            this.nprodColumn.HeaderText = "Nombre Producto";
            this.nprodColumn.Name = "nprodColumn";
            this.nprodColumn.ReadOnly = true;
            this.nprodColumn.Width = 200;
            // 
            // grupoColumn
            // 
            this.grupoColumn.HeaderText = "Grupo";
            this.grupoColumn.Name = "grupoColumn";
            this.grupoColumn.ReadOnly = true;
            this.grupoColumn.Width = 200;
            // 
            // codigoColumn
            // 
            this.codigoColumn.HeaderText = "Codigo";
            this.codigoColumn.Name = "codigoColumn";
            this.codigoColumn.ReadOnly = true;
            this.codigoColumn.Width = 200;
            // 
            // registroColumn
            // 
            this.registroColumn.HeaderText = "Registro Sanitario";
            this.registroColumn.Name = "registroColumn";
            this.registroColumn.ReadOnly = true;
            this.registroColumn.Width = 133;
            // 
            // catalogoColumn
            // 
            this.catalogoColumn.HeaderText = "Catalogo";
            this.catalogoColumn.Name = "catalogoColumn";
            this.catalogoColumn.ReadOnly = true;
            this.catalogoColumn.Width = 133;
            // 
            // certificadoColumn
            // 
            this.certificadoColumn.HeaderText = "Certificado";
            this.certificadoColumn.Name = "certificadoColumn";
            this.certificadoColumn.ReadOnly = true;
            this.certificadoColumn.Width = 133;
            // 
            // Cucop_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.DGV_cucop);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cucop_Principal";
            this.Text = "Panel Principal de Codigos de Cuadro Básico del IMSS";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_cucop)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btn_vincular;
        private System.Windows.Forms.DataGridView DGV_cucop;
        private System.Windows.Forms.ToolStripButton btn_visualizar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nprodColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalogoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificadoColumn;
    }
}