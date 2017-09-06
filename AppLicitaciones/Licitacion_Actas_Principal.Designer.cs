namespace AppLicitaciones
{
    partial class Licitacion_Actas_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licitacion_Actas_Principal));
            this.dgvActas = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emisionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archivoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date_emision = new System.Windows.Forms.DateTimePicker();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.datatiposactaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licitacionesDataSet = new AppLicitaciones.LicitacionesDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btn_editar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_borrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btn_archivo = new System.Windows.Forms.Button();
            this.data_tipos_actaTableAdapter = new AppLicitaciones.LicitacionesDataSetTableAdapters.data_tipos_actaTableAdapter();
            this.lbl_archivo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatiposactaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvActas
            // 
            this.dgvActas.AllowUserToAddRows = false;
            this.dgvActas.AllowUserToDeleteRows = false;
            this.dgvActas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.tipoColumn,
            this.descColumn,
            this.emisionColumn,
            this.archivoColumn});
            this.dgvActas.Location = new System.Drawing.Point(61, 194);
            this.dgvActas.MultiSelect = false;
            this.dgvActas.Name = "dgvActas";
            this.dgvActas.ReadOnly = true;
            this.dgvActas.RowHeadersVisible = false;
            this.dgvActas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActas.Size = new System.Drawing.Size(622, 452);
            this.dgvActas.TabIndex = 0;
            this.dgvActas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActas_CellClick);
            this.dgvActas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActas_CellDoubleClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "#";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 50;
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
            this.descColumn.Width = 250;
            // 
            // emisionColumn
            // 
            this.emisionColumn.HeaderText = "Fecha de Emision";
            this.emisionColumn.Name = "emisionColumn";
            this.emisionColumn.ReadOnly = true;
            this.emisionColumn.Width = 150;
            // 
            // archivoColumn
            // 
            this.archivoColumn.HeaderText = "Archivo";
            this.archivoColumn.Name = "archivoColumn";
            this.archivoColumn.ReadOnly = true;
            this.archivoColumn.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Acta:";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(189, 43);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(277, 67);
            this.txt_desc.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Descripcion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fecha de Emision:";
            // 
            // date_emision
            // 
            this.date_emision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_emision.Location = new System.Drawing.Point(186, 116);
            this.date_emision.Name = "date_emision";
            this.date_emision.Size = new System.Drawing.Size(277, 22);
            this.date_emision.TabIndex = 16;
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DataSource = this.datatiposactaBindingSource;
            this.cmb_tipo.DisplayMember = "nombre";
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(189, 13);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(277, 24);
            this.cmb_tipo.TabIndex = 17;
            this.cmb_tipo.ValueMember = "id";
            // 
            // datatiposactaBindingSource
            // 
            this.datatiposactaBindingSource.DataMember = "data_tipos_acta";
            this.datatiposactaBindingSource.DataSource = this.licitacionesDataSet;
            // 
            // licitacionesDataSet
            // 
            this.licitacionesDataSet.DataSetName = "LicitacionesDataSet";
            this.licitacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Archivo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo,
            this.toolStripLabel2,
            this.btn_editar,
            this.toolStripLabel1,
            this.btn_borrar,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(50, 661);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Image")));
            this.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(47, 44);
            this.btn_nuevo.Text = "toolStripButton1";
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(47, 15);
            this.toolStripLabel2.Text = "Agregar";
            // 
            // btn_editar
            // 
            this.btn_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(47, 44);
            this.btn_editar.Text = "toolStripButton2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 15);
            this.toolStripLabel1.Text = "Editar";
            // 
            // btn_borrar
            // 
            this.btn_borrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_borrar.Image")));
            this.btn_borrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(47, 44);
            this.btn_borrar.Text = "toolStripButton3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(47, 15);
            this.toolStripLabel3.Text = "Borrar";
            // 
            // btn_archivo
            // 
            this.btn_archivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_archivo.Location = new System.Drawing.Point(64, 138);
            this.btn_archivo.Name = "btn_archivo";
            this.btn_archivo.Size = new System.Drawing.Size(50, 50);
            this.btn_archivo.TabIndex = 20;
            this.btn_archivo.UseVisualStyleBackColor = true;
            this.btn_archivo.Click += new System.EventHandler(this.btn_archivo_Click);
            // 
            // data_tipos_actaTableAdapter
            // 
            this.data_tipos_actaTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_archivo
            // 
            this.lbl_archivo.Location = new System.Drawing.Point(186, 146);
            this.lbl_archivo.Name = "lbl_archivo";
            this.lbl_archivo.Size = new System.Drawing.Size(435, 42);
            this.lbl_archivo.TabIndex = 21;
            this.lbl_archivo.TabStop = true;
            this.lbl_archivo.Text = "(Vacio)";
            this.lbl_archivo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_archivo_LinkClicked);
            // 
            // Licitacion_Actas_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 661);
            this.Controls.Add(this.lbl_archivo);
            this.Controls.Add(this.btn_archivo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.date_emision);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvActas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Licitacion_Actas_Principal";
            this.Text = "Licitacion_Actas_Principal";
            this.Load += new System.EventHandler(this.Licitacion_Actas_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatiposactaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_emision;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
        private System.Windows.Forms.ToolStripButton btn_editar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_borrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Button btn_archivo;
        private LicitacionesDataSet licitacionesDataSet;
        private System.Windows.Forms.BindingSource datatiposactaBindingSource;
        private LicitacionesDataSetTableAdapters.data_tipos_actaTableAdapter data_tipos_actaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emisionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn archivoColumn;
        private System.Windows.Forms.LinkLabel lbl_archivo;
    }
}