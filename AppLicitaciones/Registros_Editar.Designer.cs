namespace AppLicitaciones
{
    partial class Registros_Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros_Editar));
            this.tt_reg_editar = new System.Windows.Forms.ToolStrip();
            this.btn_reg_descartar = new System.Windows.Forms.ToolStripButton();
            this.btn_reg_guardar = new System.Windows.Forms.ToolStripButton();
            this.cmb_pais = new System.Windows.Forms.ComboBox();
            this.paisesorigenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licitacionesDataSet = new AppLicitaciones.LicitacionesDataSet();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rad_prorroga = new System.Windows.Forms.RadioButton();
            this.rad_modificacion = new System.Windows.Forms.RadioButton();
            this.rad_registro = new System.Windows.Forms.RadioButton();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_reg_archivo = new System.Windows.Forms.Label();
            this.date_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.date_emision = new System.Windows.Forms.DateTimePicker();
            this.txt_generica = new System.Windows.Forms.TextBox();
            this.btn_archivo = new System.Windows.Forms.Button();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_fabricante = new System.Windows.Forms.TextBox();
            this.txt_distintiva = new System.Windows.Forms.TextBox();
            this.txt_titular = new System.Windows.Forms.TextBox();
            this.txt_solicitud = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paises_origenTableAdapter = new AppLicitaciones.LicitacionesDataSetTableAdapters.paises_origenTableAdapter();
            this.tt_reg_editar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paisesorigenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tt_reg_editar
            // 
            this.tt_reg_editar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tt_reg_editar.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tt_reg_editar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_reg_descartar,
            this.btn_reg_guardar});
            this.tt_reg_editar.Location = new System.Drawing.Point(0, 464);
            this.tt_reg_editar.Name = "tt_reg_editar";
            this.tt_reg_editar.Size = new System.Drawing.Size(1029, 57);
            this.tt_reg_editar.TabIndex = 52;
            this.tt_reg_editar.Text = "Menú";
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
            // cmb_pais
            // 
            this.cmb_pais.DataSource = this.paisesorigenBindingSource;
            this.cmb_pais.DisplayMember = "nombre";
            this.cmb_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pais.FormattingEnabled = true;
            this.cmb_pais.Location = new System.Drawing.Point(707, 173);
            this.cmb_pais.Name = "cmb_pais";
            this.cmb_pais.Size = new System.Drawing.Size(288, 28);
            this.cmb_pais.TabIndex = 130;
            this.cmb_pais.ValueMember = "id_pais";
            // 
            // paisesorigenBindingSource
            // 
            this.paisesorigenBindingSource.DataMember = "paises_origen";
            this.paisesorigenBindingSource.DataSource = this.licitacionesDataSet;
            // 
            // licitacionesDataSet
            // 
            this.licitacionesDataSet.DataSetName = "LicitacionesDataSet";
            this.licitacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_rfc
            // 
            this.txt_rfc.Location = new System.Drawing.Point(211, 146);
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(290, 26);
            this.txt_rfc.TabIndex = 109;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 129;
            this.label9.Text = "RFC:";
            // 
            // rad_prorroga
            // 
            this.rad_prorroga.AutoSize = true;
            this.rad_prorroga.Location = new System.Drawing.Point(921, 133);
            this.rad_prorroga.Name = "rad_prorroga";
            this.rad_prorroga.Size = new System.Drawing.Size(88, 24);
            this.rad_prorroga.TabIndex = 122;
            this.rad_prorroga.TabStop = true;
            this.rad_prorroga.Text = "Prórroga";
            this.rad_prorroga.UseVisualStyleBackColor = true;
            // 
            // rad_modificacion
            // 
            this.rad_modificacion.AutoSize = true;
            this.rad_modificacion.Location = new System.Drawing.Point(800, 133);
            this.rad_modificacion.Name = "rad_modificacion";
            this.rad_modificacion.Size = new System.Drawing.Size(115, 24);
            this.rad_modificacion.TabIndex = 121;
            this.rad_modificacion.TabStop = true;
            this.rad_modificacion.Text = "Modificación";
            this.rad_modificacion.UseVisualStyleBackColor = true;
            // 
            // rad_registro
            // 
            this.rad_registro.AutoSize = true;
            this.rad_registro.Location = new System.Drawing.Point(707, 133);
            this.rad_registro.Name = "rad_registro";
            this.rad_registro.Size = new System.Drawing.Size(87, 24);
            this.rad_registro.TabIndex = 119;
            this.rad_registro.TabStop = true;
            this.rad_registro.Text = "Registro";
            this.rad_registro.UseVisualStyleBackColor = true;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(656, 131);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(43, 20);
            this.lbl_tipo.TabIndex = 128;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // lbl_reg_archivo
            // 
            this.lbl_reg_archivo.AutoSize = true;
            this.lbl_reg_archivo.Location = new System.Drawing.Point(520, 360);
            this.lbl_reg_archivo.Name = "lbl_reg_archivo";
            this.lbl_reg_archivo.Size = new System.Drawing.Size(60, 20);
            this.lbl_reg_archivo.TabIndex = 127;
            this.lbl_reg_archivo.Text = "label13";
            // 
            // date_vencimiento
            // 
            this.date_vencimiento.Location = new System.Drawing.Point(707, 266);
            this.date_vencimiento.Name = "date_vencimiento";
            this.date_vencimiento.Size = new System.Drawing.Size(288, 26);
            this.date_vencimiento.TabIndex = 125;
            // 
            // date_emision
            // 
            this.date_emision.Location = new System.Drawing.Point(707, 220);
            this.date_emision.Name = "date_emision";
            this.date_emision.Size = new System.Drawing.Size(288, 26);
            this.date_emision.TabIndex = 124;
            // 
            // txt_generica
            // 
            this.txt_generica.Location = new System.Drawing.Point(212, 312);
            this.txt_generica.Multiline = true;
            this.txt_generica.Name = "txt_generica";
            this.txt_generica.Size = new System.Drawing.Size(289, 110);
            this.txt_generica.TabIndex = 113;
            // 
            // btn_archivo
            // 
            this.btn_archivo.Location = new System.Drawing.Point(707, 311);
            this.btn_archivo.Name = "btn_archivo";
            this.btn_archivo.Size = new System.Drawing.Size(123, 36);
            this.btn_archivo.TabIndex = 126;
            this.btn_archivo.Text = "Buscar";
            this.btn_archivo.UseVisualStyleBackColor = true;
            this.btn_archivo.Click += new System.EventHandler(this.btn_archivo_Click);
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(707, 82);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(288, 26);
            this.txt_marca.TabIndex = 117;
            // 
            // txt_fabricante
            // 
            this.txt_fabricante.Location = new System.Drawing.Point(707, 35);
            this.txt_fabricante.Name = "txt_fabricante";
            this.txt_fabricante.Size = new System.Drawing.Size(288, 26);
            this.txt_fabricante.TabIndex = 115;
            // 
            // txt_distintiva
            // 
            this.txt_distintiva.Location = new System.Drawing.Point(211, 181);
            this.txt_distintiva.Multiline = true;
            this.txt_distintiva.Name = "txt_distintiva";
            this.txt_distintiva.Size = new System.Drawing.Size(290, 110);
            this.txt_distintiva.TabIndex = 112;
            // 
            // txt_titular
            // 
            this.txt_titular.Location = new System.Drawing.Point(210, 110);
            this.txt_titular.Name = "txt_titular";
            this.txt_titular.Size = new System.Drawing.Size(290, 26);
            this.txt_titular.TabIndex = 108;
            // 
            // txt_solicitud
            // 
            this.txt_solicitud.Location = new System.Drawing.Point(210, 70);
            this.txt_solicitud.Name = "txt_solicitud";
            this.txt_solicitud.Size = new System.Drawing.Size(290, 26);
            this.txt_solicitud.TabIndex = 106;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(211, 32);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(289, 26);
            this.txt_numero.TabIndex = 103;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(635, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 123;
            this.label12.Text = "Archivo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(528, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 20);
            this.label11.TabIndex = 120;
            this.label11.Text = "Fecha de Vencimiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 20);
            this.label10.TabIndex = 118;
            this.label10.Text = "Fecha de Emision:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(584, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 116;
            this.label8.Text = "Pais de Origen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(643, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 114;
            this.label7.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 111;
            this.label6.Text = "Fabricante:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 20);
            this.label5.TabIndex = 110;
            this.label5.Text = "Denominacion Generica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 107;
            this.label4.Text = "Denominacion Distintiva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "Titular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 104;
            this.label2.Text = "Solicitud:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 102;
            this.label1.Text = "Numero:";
            // 
            // paises_origenTableAdapter
            // 
            this.paises_origenTableAdapter.ClearBeforeFill = true;
            // 
            // Registros_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 521);
            this.Controls.Add(this.cmb_pais);
            this.Controls.Add(this.txt_rfc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rad_prorroga);
            this.Controls.Add(this.rad_modificacion);
            this.Controls.Add(this.rad_registro);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_reg_archivo);
            this.Controls.Add(this.date_vencimiento);
            this.Controls.Add(this.date_emision);
            this.Controls.Add(this.txt_generica);
            this.Controls.Add(this.btn_archivo);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.txt_fabricante);
            this.Controls.Add(this.txt_distintiva);
            this.Controls.Add(this.txt_titular);
            this.Controls.Add(this.txt_solicitud);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tt_reg_editar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Registros_Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Registro Sanitario";
            this.Load += new System.EventHandler(this.Registros_Editar_Load);
            this.tt_reg_editar.ResumeLayout(false);
            this.tt_reg_editar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paisesorigenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tt_reg_editar;
        private System.Windows.Forms.ToolStripButton btn_reg_descartar;
        private System.Windows.Forms.ToolStripButton btn_reg_guardar;
        private System.Windows.Forms.ComboBox cmb_pais;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rad_prorroga;
        private System.Windows.Forms.RadioButton rad_modificacion;
        private System.Windows.Forms.RadioButton rad_registro;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_reg_archivo;
        private System.Windows.Forms.DateTimePicker date_vencimiento;
        private System.Windows.Forms.DateTimePicker date_emision;
        private System.Windows.Forms.TextBox txt_generica;
        private System.Windows.Forms.Button btn_archivo;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_fabricante;
        private System.Windows.Forms.TextBox txt_distintiva;
        private System.Windows.Forms.TextBox txt_titular;
        private System.Windows.Forms.TextBox txt_solicitud;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private LicitacionesDataSet licitacionesDataSet;
        private System.Windows.Forms.BindingSource paisesorigenBindingSource;
        private LicitacionesDataSetTableAdapters.paises_origenTableAdapter paises_origenTableAdapter;
    }
}