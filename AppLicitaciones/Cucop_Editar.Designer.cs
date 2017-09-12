namespace AppLicitaciones
{
    partial class Cucop_Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cucop_Editar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_cancelar = new System.Windows.Forms.ToolStripButton();
            this.btn_descartar = new System.Windows.Forms.ToolStripButton();
            this.chk_sccb = new System.Windows.Forms.CheckBox();
            this.cmb_spec = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.cmb_cont = new System.Windows.Forms.ComboBox();
            this.dataunidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licitacionesDataSet = new AppLicitaciones.LicitacionesDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_clave_esp = new System.Windows.Forms.TextBox();
            this.txt_clave_gen = new System.Windows.Forms.TextBox();
            this.txt_clave_gpo = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data_unidadesTableAdapter = new AppLicitaciones.LicitacionesDataSetTableAdapters.data_unidadesTableAdapter();
            this.dataunidadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataunidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataunidadesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.btn_cancelar,
            this.btn_descartar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 365);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(552, 57);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(54, 54);
            this.btn_guardar.Text = "toolStripButton1";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(54, 54);
            this.btn_cancelar.Text = "toolStripButton2";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_descartar
            // 
            this.btn_descartar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_descartar.Image = ((System.Drawing.Image)(resources.GetObject("btn_descartar.Image")));
            this.btn_descartar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_descartar.Name = "btn_descartar";
            this.btn_descartar.Size = new System.Drawing.Size(54, 54);
            this.btn_descartar.Text = "toolStripButton3";
            // 
            // chk_sccb
            // 
            this.chk_sccb.AutoSize = true;
            this.chk_sccb.Location = new System.Drawing.Point(386, 29);
            this.chk_sccb.Name = "chk_sccb";
            this.chk_sccb.Size = new System.Drawing.Size(84, 24);
            this.chk_sccb.TabIndex = 36;
            this.chk_sccb.Text = "S.C.C.B";
            this.chk_sccb.UseVisualStyleBackColor = true;
            this.chk_sccb.CheckedChanged += new System.EventHandler(this.chk_sccb_CheckedChanged);
            // 
            // cmb_spec
            // 
            this.cmb_spec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_spec.FormattingEnabled = true;
            this.cmb_spec.Location = new System.Drawing.Point(234, 169);
            this.cmb_spec.Name = "cmb_spec";
            this.cmb_spec.Size = new System.Drawing.Size(257, 28);
            this.cmb_spec.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Contenedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Cantidad:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(273, 286);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(121, 26);
            this.txt_cantidad.TabIndex = 28;
            // 
            // cmb_cont
            // 
            this.cmb_cont.DataSource = this.dataunidadesBindingSource1;
            this.cmb_cont.DisplayMember = "unidad";
            this.cmb_cont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cont.FormattingEnabled = true;
            this.cmb_cont.Location = new System.Drawing.Point(273, 318);
            this.cmb_cont.Name = "cmb_cont";
            this.cmb_cont.Size = new System.Drawing.Size(121, 28);
            this.cmb_cont.TabIndex = 29;
            this.cmb_cont.ValueMember = "id";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Tipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Presentación:";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DataSource = this.dataunidadesBindingSource;
            this.cmb_tipo.DisplayMember = "unidad";
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(273, 252);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(121, 28);
            this.cmb_tipo.TabIndex = 27;
            this.cmb_tipo.ValueMember = "id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = ".";
            // 
            // txt_clave_esp
            // 
            this.txt_clave_esp.Location = new System.Drawing.Point(288, 24);
            this.txt_clave_esp.MaxLength = 4;
            this.txt_clave_esp.Name = "txt_clave_esp";
            this.txt_clave_esp.Size = new System.Drawing.Size(91, 26);
            this.txt_clave_esp.TabIndex = 22;
            // 
            // txt_clave_gen
            // 
            this.txt_clave_gen.Location = new System.Drawing.Point(205, 24);
            this.txt_clave_gen.MaxLength = 3;
            this.txt_clave_gen.Name = "txt_clave_gen";
            this.txt_clave_gen.Size = new System.Drawing.Size(58, 26);
            this.txt_clave_gen.TabIndex = 21;
            // 
            // txt_clave_gpo
            // 
            this.txt_clave_gpo.Location = new System.Drawing.Point(122, 24);
            this.txt_clave_gpo.MaxLength = 3;
            this.txt_clave_gpo.Name = "txt_clave_gpo";
            this.txt_clave_gpo.Size = new System.Drawing.Size(58, 26);
            this.txt_clave_gpo.TabIndex = 20;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(122, 56);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(409, 107);
            this.txt_desc.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Clave:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Especialidad:";
            // 
            // data_unidadesTableAdapter
            // 
            this.data_unidadesTableAdapter.ClearBeforeFill = true;
            // 
            // dataunidadesBindingSource1
            // 
            this.dataunidadesBindingSource1.DataMember = "data_unidades";
            this.dataunidadesBindingSource1.DataSource = this.licitacionesDataSet;
            // 
            // Cucop_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 422);
            this.Controls.Add(this.chk_sccb);
            this.Controls.Add(this.cmb_spec);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.cmb_cont);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_clave_esp);
            this.Controls.Add(this.txt_clave_gen);
            this.Controls.Add(this.txt_clave_gpo);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cucop_Editar";
            this.Text = "Cucop_Editar";
            this.Load += new System.EventHandler(this.Cucop_Editar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataunidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataunidadesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripButton btn_cancelar;
        private System.Windows.Forms.ToolStripButton btn_descartar;
        private System.Windows.Forms.CheckBox chk_sccb;
        private System.Windows.Forms.ComboBox cmb_spec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.ComboBox cmb_cont;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_clave_esp;
        private System.Windows.Forms.TextBox txt_clave_gen;
        private System.Windows.Forms.TextBox txt_clave_gpo;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private LicitacionesDataSet licitacionesDataSet;
        private System.Windows.Forms.BindingSource dataunidadesBindingSource;
        private LicitacionesDataSetTableAdapters.data_unidadesTableAdapter data_unidadesTableAdapter;
        private System.Windows.Forms.BindingSource dataunidadesBindingSource1;
    }
}