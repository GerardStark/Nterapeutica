namespace AppLicitaciones
{
    partial class Certificados_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Certificados_Principal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_buscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btn_visualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.DGV_certificados = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabrColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idiomaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimientoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archivoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_conteo = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_certificados)).BeginInit();
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
            this.btn_visualizar,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(57, 691);
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
            this.btn_nuevo.Size = new System.Drawing.Size(54, 54);
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 15);
            this.toolStripLabel1.Text = "Nuevo";
            // 
            // btn_buscar
            // 
            this.btn_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(54, 54);
            this.btn_buscar.Text = "toolStripButton4";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(54, 15);
            this.toolStripLabel5.Text = "Buscar";
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_visualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_visualizar.Image")));
            this.btn_visualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(54, 54);
            this.btn_visualizar.Text = "toolStripButton1";
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(54, 15);
            this.toolStripLabel3.Text = "Visualizar";
            // 
            // DGV_certificados
            // 
            this.DGV_certificados.AllowUserToAddRows = false;
            this.DGV_certificados.AllowUserToDeleteRows = false;
            this.DGV_certificados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_certificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_certificados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.numColumn,
            this.tipoColumn,
            this.descColumn,
            this.fabrColumn,
            this.idiomaColumn,
            this.vencimientoColumn,
            this.archivoColumn,
            this.tradColumn,
            this.updatedColumn});
            this.DGV_certificados.Location = new System.Drawing.Point(60, 12);
            this.DGV_certificados.Name = "DGV_certificados";
            this.DGV_certificados.ReadOnly = true;
            this.DGV_certificados.RowHeadersVisible = false;
            this.DGV_certificados.Size = new System.Drawing.Size(1204, 635);
            this.DGV_certificados.TabIndex = 2;
            this.DGV_certificados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_certificados_CellClick);
            this.DGV_certificados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_certificados_CellFormatting);
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
            this.numColumn.HeaderText = "Clave";
            this.numColumn.Name = "numColumn";
            this.numColumn.ReadOnly = true;
            this.numColumn.Width = 150;
            // 
            // tipoColumn
            // 
            this.tipoColumn.HeaderText = "Tipo";
            this.tipoColumn.Name = "tipoColumn";
            this.tipoColumn.ReadOnly = true;
            this.tipoColumn.Width = 150;
            // 
            // descColumn
            // 
            this.descColumn.HeaderText = "Descripcion";
            this.descColumn.Name = "descColumn";
            this.descColumn.ReadOnly = true;
            this.descColumn.Width = 200;
            // 
            // fabrColumn
            // 
            this.fabrColumn.HeaderText = "Fabricante";
            this.fabrColumn.Name = "fabrColumn";
            this.fabrColumn.ReadOnly = true;
            this.fabrColumn.Width = 150;
            // 
            // idiomaColumn
            // 
            this.idiomaColumn.HeaderText = "Idioma";
            this.idiomaColumn.Name = "idiomaColumn";
            this.idiomaColumn.ReadOnly = true;
            this.idiomaColumn.Width = 125;
            // 
            // vencimientoColumn
            // 
            this.vencimientoColumn.HeaderText = "Vencimiento";
            this.vencimientoColumn.Name = "vencimientoColumn";
            this.vencimientoColumn.ReadOnly = true;
            this.vencimientoColumn.Width = 125;
            // 
            // archivoColumn
            // 
            this.archivoColumn.HeaderText = "Archivo";
            this.archivoColumn.Name = "archivoColumn";
            this.archivoColumn.ReadOnly = true;
            this.archivoColumn.Width = 125;
            // 
            // tradColumn
            // 
            this.tradColumn.HeaderText = "Traduccion";
            this.tradColumn.Name = "tradColumn";
            this.tradColumn.ReadOnly = true;
            this.tradColumn.Width = 125;
            // 
            // updatedColumn
            // 
            this.updatedColumn.HeaderText = "Actualizado";
            this.updatedColumn.Name = "updatedColumn";
            this.updatedColumn.ReadOnly = true;
            this.updatedColumn.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1185, 662);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Certificados";
            // 
            // lbl_conteo
            // 
            this.lbl_conteo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_conteo.AutoSize = true;
            this.lbl_conteo.Location = new System.Drawing.Point(1098, 662);
            this.lbl_conteo.Name = "lbl_conteo";
            this.lbl_conteo.Size = new System.Drawing.Size(51, 20);
            this.lbl_conteo.TabIndex = 4;
            this.lbl_conteo.Text = "label1";
            // 
            // Certificados_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 691);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_conteo);
            this.Controls.Add(this.DGV_certificados);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Certificados_Principal";
            this.Text = "Panel Principal de Certificados de Calidad";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_certificados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_buscar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.DataGridView DGV_certificados;
        private System.Windows.Forms.ToolStripButton btn_visualizar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_conteo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabrColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idiomaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimientoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn archivoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedColumn;
    }
}