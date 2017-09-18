namespace AppLicitaciones
{
    partial class Licitaciones_Princpial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licitaciones_Princpial));
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_nueva = new System.Windows.Forms.ToolStripButton();
            this.btn_activas = new System.Windows.Forms.ToolStripButton();
            this.btn_historico = new System.Windows.Forms.ToolStripButton();
            this.btn_todas = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAvances = new System.Windows.Forms.Panel();
            this.lbl_cat = new System.Windows.Forms.LinkLabel();
            this.lbl_cert = new System.Windows.Forms.LinkLabel();
            this.lbl_reg = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_licitacion = new System.Windows.Forms.ComboBox();
            this.panelEventos = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.licitacionesDataSet = new AppLicitaciones.LicitacionesDataSet();
            this.licitacionbasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licitacion_basesTableAdapter = new AppLicitaciones.LicitacionesDataSetTableAdapters.licitacion_basesTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.panelAvances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionbasesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(81, 15);
            this.toolStripLabel1.Text = "Nueva";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(81, 15);
            this.toolStripLabel6.Text = "Activas";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(81, 15);
            this.toolStripLabel5.Text = "Terminadas";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nueva,
            this.toolStripLabel1,
            this.btn_activas,
            this.toolStripLabel6,
            this.btn_historico,
            this.toolStripLabel5,
            this.btn_todas,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(84, 533);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_nueva
            // 
            this.btn_nueva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_nueva.Image = ((System.Drawing.Image)(resources.GetObject("btn_nueva.Image")));
            this.btn_nueva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nueva.Name = "btn_nueva";
            this.btn_nueva.Size = new System.Drawing.Size(81, 54);
            this.btn_nueva.Text = "toolStripButton1";
            this.btn_nueva.Click += new System.EventHandler(this.btn_nuevas_Click);
            // 
            // btn_activas
            // 
            this.btn_activas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_activas.Image = ((System.Drawing.Image)(resources.GetObject("btn_activas.Image")));
            this.btn_activas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_activas.Name = "btn_activas";
            this.btn_activas.Size = new System.Drawing.Size(81, 54);
            this.btn_activas.Text = "toolStripButton2";
            this.btn_activas.Click += new System.EventHandler(this.btn_activas_Click);
            // 
            // btn_historico
            // 
            this.btn_historico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_historico.Image = ((System.Drawing.Image)(resources.GetObject("btn_historico.Image")));
            this.btn_historico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_historico.Name = "btn_historico";
            this.btn_historico.Size = new System.Drawing.Size(81, 54);
            this.btn_historico.Text = "toolStripButton3";
            this.btn_historico.Click += new System.EventHandler(this.btn_historico_Click);
            // 
            // btn_todas
            // 
            this.btn_todas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_todas.Image = ((System.Drawing.Image)(resources.GetObject("btn_todas.Image")));
            this.btn_todas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_todas.Name = "btn_todas";
            this.btn_todas.Size = new System.Drawing.Size(81, 54);
            this.btn_todas.Text = "toolStripButton1";
            this.btn_todas.Click += new System.EventHandler(this.btn_todas_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(81, 15);
            this.toolStripLabel2.Text = "Todas las Licit.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(715, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proximos Eventos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Progreso de Licitaciones Activas";
            // 
            // panelAvances
            // 
            this.panelAvances.Controls.Add(this.lbl_cat);
            this.panelAvances.Controls.Add(this.lbl_cert);
            this.panelAvances.Controls.Add(this.lbl_reg);
            this.panelAvances.Controls.Add(this.label9);
            this.panelAvances.Controls.Add(this.label8);
            this.panelAvances.Controls.Add(this.label7);
            this.panelAvances.Controls.Add(this.label6);
            this.panelAvances.Controls.Add(this.label5);
            this.panelAvances.Controls.Add(this.label4);
            this.panelAvances.Controls.Add(this.cmb_licitacion);
            this.panelAvances.Location = new System.Drawing.Point(91, 33);
            this.panelAvances.Name = "panelAvances";
            this.panelAvances.Size = new System.Drawing.Size(621, 488);
            this.panelAvances.TabIndex = 6;
            // 
            // lbl_cat
            // 
            this.lbl_cat.AutoSize = true;
            this.lbl_cat.Location = new System.Drawing.Point(248, 134);
            this.lbl_cat.Name = "lbl_cat";
            this.lbl_cat.Size = new System.Drawing.Size(69, 16);
            this.lbl_cat.TabIndex = 9;
            this.lbl_cat.TabStop = true;
            this.lbl_cat.Text = "linkLabel3";
            // 
            // lbl_cert
            // 
            this.lbl_cert.AutoSize = true;
            this.lbl_cert.Location = new System.Drawing.Point(451, 134);
            this.lbl_cert.Name = "lbl_cert";
            this.lbl_cert.Size = new System.Drawing.Size(69, 16);
            this.lbl_cert.TabIndex = 8;
            this.lbl_cert.TabStop = true;
            this.lbl_cert.Text = "linkLabel2";
            // 
            // lbl_reg
            // 
            this.lbl_reg.AutoSize = true;
            this.lbl_reg.Location = new System.Drawing.Point(48, 134);
            this.lbl_reg.Name = "lbl_reg";
            this.lbl_reg.Size = new System.Drawing.Size(69, 16);
            this.lbl_reg.TabIndex = 7;
            this.lbl_reg.TabStop = true;
            this.lbl_reg.Text = "linkLabel1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "% de certificados Aceptables";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "% de catálogos Aceptables";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "% de Registros Aceptables";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Certificados de calidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Catálogos de productos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Registros Sanitarios:";
            // 
            // cmb_licitacion
            // 
            this.cmb_licitacion.DataSource = this.licitacionbasesBindingSource;
            this.cmb_licitacion.DisplayMember = "numero_licitacion";
            this.cmb_licitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_licitacion.FormattingEnabled = true;
            this.cmb_licitacion.Location = new System.Drawing.Point(146, 3);
            this.cmb_licitacion.Name = "cmb_licitacion";
            this.cmb_licitacion.Size = new System.Drawing.Size(305, 24);
            this.cmb_licitacion.TabIndex = 0;
            this.cmb_licitacion.ValueMember = "id_bases";
            this.cmb_licitacion.SelectedIndexChanged += new System.EventHandler(this.cmb_licitacion_SelectedIndexChanged);
            // 
            // panelEventos
            // 
            this.panelEventos.AutoScroll = true;
            this.panelEventos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelEventos.Location = new System.Drawing.Point(718, 33);
            this.panelEventos.Name = "panelEventos";
            this.panelEventos.Size = new System.Drawing.Size(300, 488);
            this.panelEventos.TabIndex = 5;
            this.panelEventos.WrapContents = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Avance de los Proyectos:";
            // 
            // licitacionesDataSet
            // 
            this.licitacionesDataSet.DataSetName = "LicitacionesDataSet";
            this.licitacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // licitacionbasesBindingSource
            // 
            this.licitacionbasesBindingSource.DataMember = "licitacion_bases";
            this.licitacionbasesBindingSource.DataSource = this.licitacionesDataSet;
            // 
            // licitacion_basesTableAdapter
            // 
            this.licitacion_basesTableAdapter.ClearBeforeFill = true;
            // 
            // Licitaciones_Princpial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 533);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelAvances);
            this.Controls.Add(this.panelEventos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Licitaciones_Princpial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licitaciones_Princpial";
            this.Load += new System.EventHandler(this.Licitaciones_Princpial_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelAvances.ResumeLayout(false);
            this.panelAvances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionbasesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btn_nueva;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_activas;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton btn_historico;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_todas;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelAvances;
        private System.Windows.Forms.ComboBox cmb_licitacion;
        private System.Windows.Forms.FlowLayoutPanel panelEventos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lbl_cat;
        private System.Windows.Forms.LinkLabel lbl_cert;
        private System.Windows.Forms.LinkLabel lbl_reg;
        private LicitacionesDataSet licitacionesDataSet;
        private System.Windows.Forms.BindingSource licitacionbasesBindingSource;
        private LicitacionesDataSetTableAdapters.licitacion_basesTableAdapter licitacion_basesTableAdapter;
    }
}