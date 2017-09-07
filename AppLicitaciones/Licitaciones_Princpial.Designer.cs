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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.label1.Location = new System.Drawing.Point(594, 14);
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
            this.panelAvances.Controls.Add(this.comboBox1);
            this.panelAvances.Location = new System.Drawing.Point(91, 33);
            this.panelAvances.Name = "panelAvances";
            this.panelAvances.Size = new System.Drawing.Size(492, 488);
            this.panelAvances.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.licitacionbasesBindingSource;
            this.comboBox1.DisplayMember = "numero_licitacion";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(305, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "id_bases";
            // 
            // panelEventos
            // 
            this.panelEventos.AutoScroll = true;
            this.panelEventos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelEventos.Location = new System.Drawing.Point(594, 33);
            this.panelEventos.Name = "panelEventos";
            this.panelEventos.Size = new System.Drawing.Size(424, 488);
            this.panelEventos.TabIndex = 5;
            this.panelEventos.WrapContents = false;
            this.panelEventos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEventos_Paint);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Licitaciones_Princpial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licitaciones_Princpial";
            this.Load += new System.EventHandler(this.Licitaciones_Princpial_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelAvances.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel panelEventos;
        private System.Windows.Forms.Label label3;
        private LicitacionesDataSet licitacionesDataSet;
        private System.Windows.Forms.BindingSource licitacionbasesBindingSource;
        private LicitacionesDataSetTableAdapters.licitacion_basesTableAdapter licitacion_basesTableAdapter;
    }
}