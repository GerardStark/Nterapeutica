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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Certificados_Principal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcertificadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroidentificadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciondetalladaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaemisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechavencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idiomaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Traducido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificadoscalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licitacionesDataSet = new AppLicitaciones.LicitacionesDataSet();
            this.certificados_calidadTableAdapter = new AppLicitaciones.LicitacionesDataSetTableAdapters.certificados_calidadTableAdapter();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificadoscalidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripButton4,
            this.toolStripLabel5,
            this.toolStripLabel6,
            this.toolStripButton6,
            this.toolStripButton2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(78, 729);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(75, 54);
            this.toolStripButton1.Text = "Nuevo";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(75, 15);
            this.toolStripLabel1.Text = "Nuevo";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(75, 54);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(75, 15);
            this.toolStripLabel5.Text = "Buscar";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(75, 15);
            this.toolStripLabel6.Text = "Traducciones";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(75, 54);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcertificadoDataGridViewTextBoxColumn,
            this.numeroidentificadorDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.descripciondetalladaDataGridViewTextBoxColumn,
            this.fabricanteDataGridViewTextBoxColumn,
            this.fechaemisionDataGridViewTextBoxColumn,
            this.fechavencimientoDataGridViewTextBoxColumn,
            this.idiomaDataGridViewTextBoxColumn,
            this.Traducido});
            this.dataGridView1.DataSource = this.certificadoscalidadBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(95, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1243, 705);
            this.dataGridView1.TabIndex = 2;
            // 
            // idcertificadoDataGridViewTextBoxColumn
            // 
            this.idcertificadoDataGridViewTextBoxColumn.DataPropertyName = "id_certificado";
            this.idcertificadoDataGridViewTextBoxColumn.HeaderText = "#";
            this.idcertificadoDataGridViewTextBoxColumn.Name = "idcertificadoDataGridViewTextBoxColumn";
            this.idcertificadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroidentificadorDataGridViewTextBoxColumn
            // 
            this.numeroidentificadorDataGridViewTextBoxColumn.DataPropertyName = "numero_identificador";
            this.numeroidentificadorDataGridViewTextBoxColumn.HeaderText = "Numero/id";
            this.numeroidentificadorDataGridViewTextBoxColumn.Name = "numeroidentificadorDataGridViewTextBoxColumn";
            this.numeroidentificadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripciondetalladaDataGridViewTextBoxColumn
            // 
            this.descripciondetalladaDataGridViewTextBoxColumn.DataPropertyName = "descripcion_detallada";
            this.descripciondetalladaDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripciondetalladaDataGridViewTextBoxColumn.Name = "descripciondetalladaDataGridViewTextBoxColumn";
            this.descripciondetalladaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fabricanteDataGridViewTextBoxColumn
            // 
            this.fabricanteDataGridViewTextBoxColumn.DataPropertyName = "fabricante";
            this.fabricanteDataGridViewTextBoxColumn.HeaderText = "Fabricante";
            this.fabricanteDataGridViewTextBoxColumn.Name = "fabricanteDataGridViewTextBoxColumn";
            this.fabricanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaemisionDataGridViewTextBoxColumn
            // 
            this.fechaemisionDataGridViewTextBoxColumn.DataPropertyName = "fecha_emision";
            this.fechaemisionDataGridViewTextBoxColumn.HeaderText = "Emision";
            this.fechaemisionDataGridViewTextBoxColumn.Name = "fechaemisionDataGridViewTextBoxColumn";
            this.fechaemisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechavencimientoDataGridViewTextBoxColumn
            // 
            this.fechavencimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_vencimiento";
            this.fechavencimientoDataGridViewTextBoxColumn.HeaderText = "Vencimiento";
            this.fechavencimientoDataGridViewTextBoxColumn.Name = "fechavencimientoDataGridViewTextBoxColumn";
            this.fechavencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idiomaDataGridViewTextBoxColumn
            // 
            this.idiomaDataGridViewTextBoxColumn.DataPropertyName = "idioma";
            this.idiomaDataGridViewTextBoxColumn.HeaderText = "Idioma";
            this.idiomaDataGridViewTextBoxColumn.Name = "idiomaDataGridViewTextBoxColumn";
            this.idiomaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Traducido
            // 
            this.Traducido.HeaderText = "Traducido";
            this.Traducido.Name = "Traducido";
            this.Traducido.ReadOnly = true;
            // 
            // certificadoscalidadBindingSource
            // 
            this.certificadoscalidadBindingSource.DataMember = "certificados_calidad";
            this.certificadoscalidadBindingSource.DataSource = this.licitacionesDataSet;
            // 
            // licitacionesDataSet
            // 
            this.licitacionesDataSet.DataSetName = "LicitacionesDataSet";
            this.licitacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // certificados_calidadTableAdapter
            // 
            this.certificados_calidadTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(75, 54);
            this.toolStripButton2.Text = "toolStripButton1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(75, 15);
            this.toolStripLabel3.Text = "Visualizar";
            // 
            // Certificados_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Certificados_Principal";
            this.Text = "Panel Principal de Certificados de Calidad";
            this.Load += new System.EventHandler(this.Certificados_Principal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificadoscalidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LicitacionesDataSet licitacionesDataSet;
        private System.Windows.Forms.BindingSource certificadoscalidadBindingSource;
        private LicitacionesDataSetTableAdapters.certificados_calidadTableAdapter certificados_calidadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcertificadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroidentificadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciondetalladaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaemisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechavencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idiomaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Traducido;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    }
}