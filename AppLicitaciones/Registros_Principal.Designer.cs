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
            this.components = new System.ComponentModel.Container();
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
            this.DGVRegistros = new System.Windows.Forms.DataGridView();
            this.idregistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroregistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerosolicitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denomdistintivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denomgenericaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratadocomercioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaemisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechavencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrossanitariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licitacionesDataSet = new AppLicitaciones.LicitacionesDataSet();
            this.registros_sanitariosTableAdapter = new AppLicitaciones.LicitacionesDataSetTableAdapters.registros_sanitariosTableAdapter();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tt_registros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrossanitariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).BeginInit();
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
            // DGVRegistros
            // 
            this.DGVRegistros.AllowUserToAddRows = false;
            this.DGVRegistros.AllowUserToDeleteRows = false;
            this.DGVRegistros.AutoGenerateColumns = false;
            this.DGVRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idregistroDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.numeroregistroDataGridViewTextBoxColumn,
            this.numerosolicitudDataGridViewTextBoxColumn,
            this.titularDataGridViewTextBoxColumn,
            this.denomdistintivaDataGridViewTextBoxColumn,
            this.denomgenericaDataGridViewTextBoxColumn,
            this.fabricanteDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.nacionalidadDataGridViewTextBoxColumn,
            this.tratadocomercioDataGridViewTextBoxColumn,
            this.fechaemisionDataGridViewTextBoxColumn,
            this.fechavencimientoDataGridViewTextBoxColumn});
            this.DGVRegistros.DataSource = this.registrossanitariosBindingSource;
            this.DGVRegistros.Location = new System.Drawing.Point(95, 13);
            this.DGVRegistros.Name = "DGVRegistros";
            this.DGVRegistros.ReadOnly = true;
            this.DGVRegistros.RowHeadersVisible = false;
            this.DGVRegistros.Size = new System.Drawing.Size(1243, 704);
            this.DGVRegistros.TabIndex = 1;
            // 
            // idregistroDataGridViewTextBoxColumn
            // 
            this.idregistroDataGridViewTextBoxColumn.DataPropertyName = "id_registro";
            this.idregistroDataGridViewTextBoxColumn.HeaderText = "#";
            this.idregistroDataGridViewTextBoxColumn.Name = "idregistroDataGridViewTextBoxColumn";
            this.idregistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroregistroDataGridViewTextBoxColumn
            // 
            this.numeroregistroDataGridViewTextBoxColumn.DataPropertyName = "numero_registro";
            this.numeroregistroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroregistroDataGridViewTextBoxColumn.Name = "numeroregistroDataGridViewTextBoxColumn";
            this.numeroregistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numerosolicitudDataGridViewTextBoxColumn
            // 
            this.numerosolicitudDataGridViewTextBoxColumn.DataPropertyName = "numero_solicitud";
            this.numerosolicitudDataGridViewTextBoxColumn.HeaderText = "Solicitud";
            this.numerosolicitudDataGridViewTextBoxColumn.Name = "numerosolicitudDataGridViewTextBoxColumn";
            this.numerosolicitudDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titularDataGridViewTextBoxColumn
            // 
            this.titularDataGridViewTextBoxColumn.DataPropertyName = "titular";
            this.titularDataGridViewTextBoxColumn.HeaderText = "Titular";
            this.titularDataGridViewTextBoxColumn.Name = "titularDataGridViewTextBoxColumn";
            this.titularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // denomdistintivaDataGridViewTextBoxColumn
            // 
            this.denomdistintivaDataGridViewTextBoxColumn.DataPropertyName = "denom_distintiva";
            this.denomdistintivaDataGridViewTextBoxColumn.HeaderText = "Distintiva";
            this.denomdistintivaDataGridViewTextBoxColumn.Name = "denomdistintivaDataGridViewTextBoxColumn";
            this.denomdistintivaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // denomgenericaDataGridViewTextBoxColumn
            // 
            this.denomgenericaDataGridViewTextBoxColumn.DataPropertyName = "denom_generica";
            this.denomgenericaDataGridViewTextBoxColumn.HeaderText = "Generica";
            this.denomgenericaDataGridViewTextBoxColumn.Name = "denomgenericaDataGridViewTextBoxColumn";
            this.denomgenericaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fabricanteDataGridViewTextBoxColumn
            // 
            this.fabricanteDataGridViewTextBoxColumn.DataPropertyName = "fabricante";
            this.fabricanteDataGridViewTextBoxColumn.HeaderText = "Fabricante";
            this.fabricanteDataGridViewTextBoxColumn.Name = "fabricanteDataGridViewTextBoxColumn";
            this.fabricanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nacionalidadDataGridViewTextBoxColumn
            // 
            this.nacionalidadDataGridViewTextBoxColumn.DataPropertyName = "nacionalidad";
            this.nacionalidadDataGridViewTextBoxColumn.HeaderText = "Nacionalidad";
            this.nacionalidadDataGridViewTextBoxColumn.Name = "nacionalidadDataGridViewTextBoxColumn";
            this.nacionalidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tratadocomercioDataGridViewTextBoxColumn
            // 
            this.tratadocomercioDataGridViewTextBoxColumn.DataPropertyName = "tratado_comercio";
            this.tratadocomercioDataGridViewTextBoxColumn.HeaderText = "TLC";
            this.tratadocomercioDataGridViewTextBoxColumn.Name = "tratadocomercioDataGridViewTextBoxColumn";
            this.tratadocomercioDataGridViewTextBoxColumn.ReadOnly = true;
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
            // registrossanitariosBindingSource
            // 
            this.registrossanitariosBindingSource.DataMember = "registros_sanitarios";
            this.registrossanitariosBindingSource.DataSource = this.licitacionesDataSet;
            // 
            // licitacionesDataSet
            // 
            this.licitacionesDataSet.DataSetName = "LicitacionesDataSet";
            this.licitacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registros_sanitariosTableAdapter
            // 
            this.registros_sanitariosTableAdapter.ClearBeforeFill = true;
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
            this.Load += new System.EventHandler(this.Registros_Principal_Load);
            this.tt_registros.ResumeLayout(false);
            this.tt_registros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrossanitariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).EndInit();
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
        private LicitacionesDataSet licitacionesDataSet;
        private System.Windows.Forms.BindingSource registrossanitariosBindingSource;
        private LicitacionesDataSetTableAdapters.registros_sanitariosTableAdapter registros_sanitariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idregistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroregistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerosolicitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denomdistintivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denomgenericaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tratadocomercioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaemisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechavencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    }
}