namespace AppLicitaciones
{
    partial class Catalogos_ClavesReferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogos_ClavesReferencias));
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Referencias = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btn_editar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btn_eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.txt_pag_pdf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pag_cat = new System.Windows.Forms.TextBox();
            this.cmb_unidad = new System.Windows.Forms.ComboBox();
            this.dataunidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licitacionesDataSet = new AppLicitaciones.LicitacionesDataSet();
            this.data_unidadesTableAdapter = new AppLicitaciones.LicitacionesDataSetTableAdapters.data_unidadesTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_conteo = new System.Windows.Forms.Label();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagpdfColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagcatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Referencias)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataunidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Unidad de Venta:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(436, 38);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(548, 153);
            this.txt_descripcion.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Descripcion:";
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(88, 38);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(308, 26);
            this.txt_clave.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Clave/Codigo/Referencia";
            // 
            // DGV_Referencias
            // 
            this.DGV_Referencias.AllowUserToAddRows = false;
            this.DGV_Referencias.AllowUserToDeleteRows = false;
            this.DGV_Referencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Referencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.claveColumn,
            this.descripcionColumn,
            this.unidadColumn,
            this.pagpdfColumn,
            this.pagcatColumn,
            this.updatedColumn});
            this.DGV_Referencias.Location = new System.Drawing.Point(70, 197);
            this.DGV_Referencias.Name = "DGV_Referencias";
            this.DGV_Referencias.ReadOnly = true;
            this.DGV_Referencias.Size = new System.Drawing.Size(914, 354);
            this.DGV_Referencias.TabIndex = 15;
            this.DGV_Referencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Referencias_CellClick);
            this.DGV_Referencias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Referencias_CellDoubleClick);
            this.DGV_Referencias.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_Referencias_CellFormatting);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.toolStripLabel2,
            this.btn_editar,
            this.toolStripLabel4,
            this.btn_eliminar,
            this.toolStripLabel3,
            this.toolStripLabel5,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(55, 591);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_guardar
            // 
            this.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(52, 54);
            this.btn_guardar.Text = "toolStripButton2";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(52, 15);
            this.toolStripLabel2.Text = "Nuevo";
            // 
            // btn_editar
            // 
            this.btn_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(52, 54);
            this.btn_editar.Text = "toolStripButton5";
            this.btn_editar.ToolTipText = "Editar";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(52, 15);
            this.toolStripLabel4.Text = "Editar";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(52, 54);
            this.btn_eliminar.Text = "toolStripButton3";
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(52, 15);
            this.toolStripLabel3.Text = "Eliminar";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(52, 15);
            this.toolStripLabel5.Text = "Buscar";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 54);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // txt_pag_pdf
            // 
            this.txt_pag_pdf.Location = new System.Drawing.Point(88, 165);
            this.txt_pag_pdf.Name = "txt_pag_pdf";
            this.txt_pag_pdf.Size = new System.Drawing.Size(148, 26);
            this.txt_pag_pdf.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Pagina en PDF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Pagina en Catálogo:";
            // 
            // txt_pag_cat
            // 
            this.txt_pag_cat.Location = new System.Drawing.Point(248, 165);
            this.txt_pag_cat.Name = "txt_pag_cat";
            this.txt_pag_cat.Size = new System.Drawing.Size(148, 26);
            this.txt_pag_cat.TabIndex = 26;
            // 
            // cmb_unidad
            // 
            this.cmb_unidad.DataSource = this.dataunidadesBindingSource;
            this.cmb_unidad.DisplayMember = "unidad";
            this.cmb_unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_unidad.FormattingEnabled = true;
            this.cmb_unidad.Location = new System.Drawing.Point(88, 100);
            this.cmb_unidad.Name = "cmb_unidad";
            this.cmb_unidad.Size = new System.Drawing.Size(308, 28);
            this.cmb_unidad.TabIndex = 27;
            this.cmb_unidad.ValueMember = "unidad";
            // 
            // dataunidadesBindingSource
            // 
            this.dataunidadesBindingSource.DataMember = "data_unidades";
            this.dataunidadesBindingSource.DataSource = this.licitacionesDataSet;
            // 
            // licitacionesDataSet
            // 
            this.licitacionesDataSet.DataSetName = "LicitacionesDataSet";
            this.licitacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data_unidadesTableAdapter
            // 
            this.data_unidadesTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(889, 563);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Referencias";
            // 
            // lbl_conteo
            // 
            this.lbl_conteo.AutoSize = true;
            this.lbl_conteo.Location = new System.Drawing.Point(805, 563);
            this.lbl_conteo.Name = "lbl_conteo";
            this.lbl_conteo.Size = new System.Drawing.Size(51, 20);
            this.lbl_conteo.TabIndex = 28;
            this.lbl_conteo.Text = "label1";
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "#";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 50;
            // 
            // claveColumn
            // 
            this.claveColumn.HeaderText = "Clave";
            this.claveColumn.Name = "claveColumn";
            this.claveColumn.ReadOnly = true;
            // 
            // descripcionColumn
            // 
            this.descripcionColumn.HeaderText = "Descripcion";
            this.descripcionColumn.Name = "descripcionColumn";
            this.descripcionColumn.ReadOnly = true;
            this.descripcionColumn.Width = 320;
            // 
            // unidadColumn
            // 
            this.unidadColumn.HeaderText = "Unidad";
            this.unidadColumn.Name = "unidadColumn";
            this.unidadColumn.ReadOnly = true;
            this.unidadColumn.Width = 150;
            // 
            // pagpdfColumn
            // 
            this.pagpdfColumn.HeaderText = "Pag. PDF";
            this.pagpdfColumn.Name = "pagpdfColumn";
            this.pagpdfColumn.ReadOnly = true;
            // 
            // pagcatColumn
            // 
            this.pagcatColumn.HeaderText = "Pag. Cat";
            this.pagcatColumn.Name = "pagcatColumn";
            this.pagcatColumn.ReadOnly = true;
            // 
            // updatedColumn
            // 
            this.updatedColumn.HeaderText = "Actualizado";
            this.updatedColumn.Name = "updatedColumn";
            this.updatedColumn.ReadOnly = true;
            this.updatedColumn.Visible = false;
            // 
            // Catalogos_ClavesReferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 591);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_conteo);
            this.Controls.Add(this.cmb_unidad);
            this.Controls.Add(this.txt_pag_cat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pag_pdf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Referencias);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Catalogos_ClavesReferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogos_ClavesReferencias";
            this.Load += new System.EventHandler(this.Catalogos_ClavesReferencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Referencias)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataunidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Referencias;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btn_editar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btn_eliminar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TextBox txt_pag_pdf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pag_cat;
        private System.Windows.Forms.ComboBox cmb_unidad;
        private LicitacionesDataSet licitacionesDataSet;
        private System.Windows.Forms.BindingSource dataunidadesBindingSource;
        private LicitacionesDataSetTableAdapters.data_unidadesTableAdapter data_unidadesTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_conteo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagpdfColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagcatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedColumn;
    }
}