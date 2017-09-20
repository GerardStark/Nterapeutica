namespace AppLicitaciones
{
    partial class Licitacion_Items_Nuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licitacion_Items_Nuevo));
            this.tt_reg_nuevo = new System.Windows.Forms.ToolStrip();
            this.btn_reg_descartar = new System.Windows.Forms.ToolStripButton();
            this.btn_reg_guardar = new System.Windows.Forms.ToolStripButton();
            this.txt_limpiar_campos = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.cmb_cont = new System.Windows.Forms.ComboBox();
            this.dataunidadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.licitacionesDataSet = new AppLicitaciones.LicitacionesDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.dataunidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.data_unidadesTableAdapter = new AppLicitaciones.LicitacionesDataSetTableAdapters.data_unidadesTableAdapter();
            this.infoAd = new System.Windows.Forms.FlowLayoutPanel();
            this.chk_sccb = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_clave_esp = new System.Windows.Forms.TextBox();
            this.txt_clave_gen = new System.Windows.Forms.TextBox();
            this.txt_clave_gpo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_clave_var = new System.Windows.Forms.TextBox();
            this.txt_clave_dif = new System.Windows.Forms.TextBox();
            this.tt_reg_nuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataunidadesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataunidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tt_reg_nuevo
            // 
            this.tt_reg_nuevo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tt_reg_nuevo.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tt_reg_nuevo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_reg_descartar,
            this.btn_reg_guardar,
            this.txt_limpiar_campos});
            this.tt_reg_nuevo.Location = new System.Drawing.Point(0, 537);
            this.tt_reg_nuevo.Name = "tt_reg_nuevo";
            this.tt_reg_nuevo.Size = new System.Drawing.Size(549, 57);
            this.tt_reg_nuevo.TabIndex = 30;
            this.tt_reg_nuevo.Text = "Menú";
            // 
            // btn_reg_descartar
            // 
            this.btn_reg_descartar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_reg_descartar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_reg_descartar.Image = ((System.Drawing.Image)(resources.GetObject("btn_reg_descartar.Image")));
            this.btn_reg_descartar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reg_descartar.Name = "btn_reg_descartar";
            this.btn_reg_descartar.Size = new System.Drawing.Size(54, 54);
            this.btn_reg_descartar.Text = "Descartar";
            this.btn_reg_descartar.Click += new System.EventHandler(this.btn_reg_descartar_Click);
            // 
            // btn_reg_guardar
            // 
            this.btn_reg_guardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_reg_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_reg_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_reg_guardar.Image")));
            this.btn_reg_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reg_guardar.Name = "btn_reg_guardar";
            this.btn_reg_guardar.Size = new System.Drawing.Size(54, 54);
            this.btn_reg_guardar.Text = "Guardar";
            this.btn_reg_guardar.Click += new System.EventHandler(this.btn_reg_guardar_Click);
            // 
            // txt_limpiar_campos
            // 
            this.txt_limpiar_campos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txt_limpiar_campos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.txt_limpiar_campos.Image = ((System.Drawing.Image)(resources.GetObject("txt_limpiar_campos.Image")));
            this.txt_limpiar_campos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txt_limpiar_campos.Name = "txt_limpiar_campos";
            this.txt_limpiar_campos.Size = new System.Drawing.Size(54, 54);
            this.txt_limpiar_campos.Text = "Limpiar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Maximo:";
            // 
            // txt_max
            // 
            this.txt_max.Location = new System.Drawing.Point(360, 233);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(121, 22);
            this.txt_max.TabIndex = 65;
            this.txt_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlynumbers);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Minimo:";
            // 
            // txt_min
            // 
            this.txt_min.Location = new System.Drawing.Point(360, 205);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(121, 22);
            this.txt_min.TabIndex = 63;
            this.txt_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlynumbers);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "Contenedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 61;
            this.label8.Text = "Cantidad:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(122, 242);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(121, 22);
            this.txt_cantidad.TabIndex = 57;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlynumbers);
            // 
            // cmb_cont
            // 
            this.cmb_cont.DataSource = this.dataunidadesBindingSource1;
            this.cmb_cont.DisplayMember = "unidad";
            this.cmb_cont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cont.FormattingEnabled = true;
            this.cmb_cont.Location = new System.Drawing.Point(122, 274);
            this.cmb_cont.Name = "cmb_cont";
            this.cmb_cont.Size = new System.Drawing.Size(121, 24);
            this.cmb_cont.TabIndex = 58;
            this.cmb_cont.ValueMember = "id";
            // 
            // dataunidadesBindingSource1
            // 
            this.dataunidadesBindingSource1.DataMember = "data_unidades";
            this.dataunidadesBindingSource1.DataSource = this.licitacionesDataSet;
            // 
            // licitacionesDataSet
            // 
            this.licitacionesDataSet.DataSetName = "LicitacionesDataSet";
            this.licitacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "Unidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "Presentación:";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DataSource = this.dataunidadesBindingSource;
            this.cmb_tipo.DisplayMember = "unidad";
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(122, 208);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(121, 24);
            this.cmb_tipo.TabIndex = 56;
            this.cmb_tipo.ValueMember = "id";
            // 
            // dataunidadesBindingSource
            // 
            this.dataunidadesBindingSource.DataMember = "data_unidades";
            this.dataunidadesBindingSource.DataSource = this.licitacionesDataSet;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(100, 80);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(437, 79);
            this.txt_descripcion.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "#:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(100, 13);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(121, 22);
            this.txt_numero.TabIndex = 67;
            // 
            // data_unidadesTableAdapter
            // 
            this.data_unidadesTableAdapter.ClearBeforeFill = true;
            // 
            // infoAd
            // 
            this.infoAd.AutoScroll = true;
            this.infoAd.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.infoAd.Location = new System.Drawing.Point(12, 304);
            this.infoAd.Name = "infoAd";
            this.infoAd.Size = new System.Drawing.Size(525, 228);
            this.infoAd.TabIndex = 69;
            this.infoAd.Visible = false;
            this.infoAd.WrapContents = false;
            // 
            // chk_sccb
            // 
            this.chk_sccb.AutoSize = true;
            this.chk_sccb.Location = new System.Drawing.Point(451, 26);
            this.chk_sccb.Name = "chk_sccb";
            this.chk_sccb.Size = new System.Drawing.Size(72, 20);
            this.chk_sccb.TabIndex = 76;
            this.chk_sccb.Text = "S.C.C.B";
            this.chk_sccb.UseVisualStyleBackColor = true;
            this.chk_sccb.CheckedChanged += new System.EventHandler(this.chk_sccb_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 16);
            this.label5.TabIndex = 75;
            this.label5.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 16);
            this.label10.TabIndex = 74;
            this.label10.Text = ".";
            // 
            // txt_clave_esp
            // 
            this.txt_clave_esp.Location = new System.Drawing.Point(263, 52);
            this.txt_clave_esp.MaxLength = 4;
            this.txt_clave_esp.Name = "txt_clave_esp";
            this.txt_clave_esp.Size = new System.Drawing.Size(91, 22);
            this.txt_clave_esp.TabIndex = 72;
            this.txt_clave_esp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlynumbers);
            // 
            // txt_clave_gen
            // 
            this.txt_clave_gen.Location = new System.Drawing.Point(180, 52);
            this.txt_clave_gen.MaxLength = 3;
            this.txt_clave_gen.Name = "txt_clave_gen";
            this.txt_clave_gen.Size = new System.Drawing.Size(58, 22);
            this.txt_clave_gen.TabIndex = 71;
            this.txt_clave_gen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlynumbers);
            // 
            // txt_clave_gpo
            // 
            this.txt_clave_gpo.Location = new System.Drawing.Point(97, 52);
            this.txt_clave_gpo.MaxLength = 3;
            this.txt_clave_gpo.Name = "txt_clave_gpo";
            this.txt_clave_gpo.Size = new System.Drawing.Size(58, 22);
            this.txt_clave_gpo.TabIndex = 70;
            this.txt_clave_gpo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlynumbers);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 73;
            this.label11.Text = "Clave:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(357, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 16);
            this.label12.TabIndex = 77;
            this.label12.Text = ".";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(432, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 16);
            this.label13.TabIndex = 80;
            this.label13.Text = ".";
            // 
            // txt_clave_var
            // 
            this.txt_clave_var.Location = new System.Drawing.Point(449, 52);
            this.txt_clave_var.MaxLength = 3;
            this.txt_clave_var.Name = "txt_clave_var";
            this.txt_clave_var.Size = new System.Drawing.Size(58, 22);
            this.txt_clave_var.TabIndex = 79;
            this.txt_clave_var.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlynumbers);
            // 
            // txt_clave_dif
            // 
            this.txt_clave_dif.Location = new System.Drawing.Point(368, 52);
            this.txt_clave_dif.MaxLength = 3;
            this.txt_clave_dif.Name = "txt_clave_dif";
            this.txt_clave_dif.Size = new System.Drawing.Size(58, 22);
            this.txt_clave_dif.TabIndex = 78;
            this.txt_clave_dif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlynumbers);
            // 
            // Licitacion_Items_Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 594);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_clave_var);
            this.Controls.Add(this.txt_clave_dif);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chk_sccb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_clave_esp);
            this.Controls.Add(this.txt_clave_gen);
            this.Controls.Add(this.txt_clave_gpo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.infoAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.cmb_cont);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tt_reg_nuevo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Licitacion_Items_Nuevo";
            this.Text = "Licitacion_Items_Nuevo";
            this.Load += new System.EventHandler(this.Licitacion_Items_Nuevo_Load);
            this.tt_reg_nuevo.ResumeLayout(false);
            this.tt_reg_nuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataunidadesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataunidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tt_reg_nuevo;
        private System.Windows.Forms.ToolStripButton btn_reg_descartar;
        private System.Windows.Forms.ToolStripButton btn_reg_guardar;
        private System.Windows.Forms.ToolStripButton txt_limpiar_campos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.ComboBox cmb_cont;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_numero;
        private LicitacionesDataSet licitacionesDataSet;
        private System.Windows.Forms.BindingSource dataunidadesBindingSource;
        private LicitacionesDataSetTableAdapters.data_unidadesTableAdapter data_unidadesTableAdapter;
        private System.Windows.Forms.BindingSource dataunidadesBindingSource1;
        private System.Windows.Forms.FlowLayoutPanel infoAd;
        private System.Windows.Forms.CheckBox chk_sccb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_clave_esp;
        private System.Windows.Forms.TextBox txt_clave_gen;
        private System.Windows.Forms.TextBox txt_clave_gpo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_clave_var;
        private System.Windows.Forms.TextBox txt_clave_dif;
    }
}