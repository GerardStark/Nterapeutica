namespace AppLicitaciones
{
    partial class Registros_ClavesReferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros_ClavesReferencias));
            this.DGV_Referencias = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btn_editar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btn_eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmb_unidad = new System.Windows.Forms.ComboBox();
            this.dataunidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licitacionesDataSet = new AppLicitaciones.LicitacionesDataSet();
            this.data_unidadesTableAdapter = new AppLicitaciones.LicitacionesDataSetTableAdapters.data_unidadesTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_conteo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Referencias)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataunidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Referencias
            // 
            this.DGV_Referencias.AllowUserToAddRows = false;
            this.DGV_Referencias.AllowUserToDeleteRows = false;
            this.DGV_Referencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Referencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Referencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.claveColumn,
            this.descripcionColumn,
            this.unidadColumn,
            this.updatedColumn});
            this.DGV_Referencias.Location = new System.Drawing.Point(58, 145);
            this.DGV_Referencias.Name = "DGV_Referencias";
            this.DGV_Referencias.ReadOnly = true;
            this.DGV_Referencias.Size = new System.Drawing.Size(714, 406);
            this.DGV_Referencias.TabIndex = 1;
            this.DGV_Referencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Referencias_CellClick);
            this.DGV_Referencias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Referencias_CellDoubleClick);
            this.DGV_Referencias.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_Referencias_CellFormatting);
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
            // updatedColumn
            // 
            this.updatedColumn.HeaderText = "Actualizado";
            this.updatedColumn.Name = "updatedColumn";
            this.updatedColumn.ReadOnly = true;
            this.updatedColumn.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Unidad de Venta:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(464, 44);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(308, 89);
            this.txt_descripcion.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripcion:";
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(116, 44);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(308, 26);
            this.txt_clave.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Clave/Codigo/Referencia";
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
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(55, 594);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmb_unidad
            // 
            this.cmb_unidad.DataSource = this.dataunidadesBindingSource;
            this.cmb_unidad.DisplayMember = "unidad";
            this.cmb_unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_unidad.FormattingEnabled = true;
            this.cmb_unidad.Location = new System.Drawing.Point(116, 107);
            this.cmb_unidad.Name = "cmb_unidad";
            this.cmb_unidad.Size = new System.Drawing.Size(308, 28);
            this.cmb_unidad.TabIndex = 13;
            this.cmb_unidad.ValueMember = "id";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(677, 565);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Referencias";
            // 
            // lbl_conteo
            // 
            this.lbl_conteo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_conteo.AutoSize = true;
            this.lbl_conteo.Location = new System.Drawing.Point(593, 565);
            this.lbl_conteo.Name = "lbl_conteo";
            this.lbl_conteo.Size = new System.Drawing.Size(51, 20);
            this.lbl_conteo.TabIndex = 14;
            this.lbl_conteo.Text = "label1";
            // 
            // Registros_ClavesReferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 594);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_conteo);
            this.Controls.Add(this.cmb_unidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Referencias);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Registros_ClavesReferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de las Rerefencias, Claves o Codigos de los Registros Sanitarios";
            this.Load += new System.EventHandler(this.Registros_ClavesReferencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Referencias)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataunidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Referencias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btn_editar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btn_eliminar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox cmb_unidad;
        private LicitacionesDataSet licitacionesDataSet;
        private System.Windows.Forms.BindingSource dataunidadesBindingSource;
        private LicitacionesDataSetTableAdapters.data_unidadesTableAdapter data_unidadesTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_conteo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedColumn;
    }
}