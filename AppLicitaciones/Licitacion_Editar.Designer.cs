namespace AppLicitaciones
{
    partial class Licitacion_Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licitacion_Editar));
            this.cmb_tipo_exp = new System.Windows.Forms.ComboBox();
            this.auxtiposexpedienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licitacionesDataSet = new AppLicitaciones.LicitacionesDataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tipo_contrato = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_correo_operador = new System.Windows.Forms.TextBox();
            this.txt_nombre_operador = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_num_expediente = new System.Windows.Forms.TextBox();
            this.txt_duracion_contrato = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_archivo = new System.Windows.Forms.Label();
            this.cmb_entidad = new System.Windows.Forms.ComboBox();
            this.auxentidadesfederativasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_unidad_compradora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_cancelar = new System.Windows.Forms.ToolStripButton();
            this.btn_archivo = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aux_entidades_federativasTableAdapter = new AppLicitaciones.LicitacionesDataSetTableAdapters.aux_entidades_federativasTableAdapter();
            this.aux_tipos_expedienteTableAdapter = new AppLicitaciones.LicitacionesDataSetTableAdapters.aux_tipos_expedienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.auxtiposexpedienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auxentidadesfederativasBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_tipo_exp
            // 
            this.cmb_tipo_exp.DataSource = this.auxtiposexpedienteBindingSource;
            this.cmb_tipo_exp.DisplayMember = "tipo_expediente";
            this.cmb_tipo_exp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_exp.FormattingEnabled = true;
            this.cmb_tipo_exp.Location = new System.Drawing.Point(159, 168);
            this.cmb_tipo_exp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_tipo_exp.Name = "cmb_tipo_exp";
            this.cmb_tipo_exp.Size = new System.Drawing.Size(488, 24);
            this.cmb_tipo_exp.TabIndex = 48;
            this.cmb_tipo_exp.ValueMember = "id";
            // 
            // auxtiposexpedienteBindingSource
            // 
            this.auxtiposexpedienteBindingSource.DataMember = "aux_tipos_expediente";
            this.auxtiposexpedienteBindingSource.DataSource = this.licitacionesDataSet;
            // 
            // licitacionesDataSet
            // 
            this.licitacionesDataSet.DataSetName = "LicitacionesDataSet";
            this.licitacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 66;
            this.label12.Text = "Descripcion:";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(159, 247);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(488, 22);
            this.txt_desc.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Tipo de Contrato:";
            // 
            // txt_tipo_contrato
            // 
            this.txt_tipo_contrato.Location = new System.Drawing.Point(159, 93);
            this.txt_tipo_contrato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tipo_contrato.Name = "txt_tipo_contrato";
            this.txt_tipo_contrato.Size = new System.Drawing.Size(488, 22);
            this.txt_tipo_contrato.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 16);
            this.label11.TabIndex = 64;
            this.label11.Text = "Correo del Operador:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 16);
            this.label10.TabIndex = 63;
            this.label10.Text = "Nombre del Operador:";
            // 
            // txt_correo_operador
            // 
            this.txt_correo_operador.Location = new System.Drawing.Point(159, 221);
            this.txt_correo_operador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_correo_operador.Name = "txt_correo_operador";
            this.txt_correo_operador.Size = new System.Drawing.Size(488, 22);
            this.txt_correo_operador.TabIndex = 50;
            // 
            // txt_nombre_operador
            // 
            this.txt_nombre_operador.Location = new System.Drawing.Point(159, 195);
            this.txt_nombre_operador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre_operador.Name = "txt_nombre_operador";
            this.txt_nombre_operador.Size = new System.Drawing.Size(488, 22);
            this.txt_nombre_operador.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "Tipo de Expediente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 61;
            this.label8.Text = "# de Expediente:";
            // 
            // txt_num_expediente
            // 
            this.txt_num_expediente.Location = new System.Drawing.Point(159, 144);
            this.txt_num_expediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_num_expediente.Name = "txt_num_expediente";
            this.txt_num_expediente.Size = new System.Drawing.Size(488, 22);
            this.txt_num_expediente.TabIndex = 47;
            // 
            // txt_duracion_contrato
            // 
            this.txt_duracion_contrato.Location = new System.Drawing.Point(159, 119);
            this.txt_duracion_contrato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_duracion_contrato.Name = "txt_duracion_contrato";
            this.txt_duracion_contrato.Size = new System.Drawing.Size(488, 22);
            this.txt_duracion_contrato.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "Duracion del Contrato:";
            // 
            // lbl_archivo
            // 
            this.lbl_archivo.Location = new System.Drawing.Point(159, 270);
            this.lbl_archivo.Name = "lbl_archivo";
            this.lbl_archivo.Size = new System.Drawing.Size(322, 66);
            this.lbl_archivo.TabIndex = 59;
            this.lbl_archivo.Text = "(Vacio)";
            // 
            // cmb_entidad
            // 
            this.cmb_entidad.DataSource = this.auxentidadesfederativasBindingSource;
            this.cmb_entidad.DisplayMember = "nombre_estado";
            this.cmb_entidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_entidad.FormattingEnabled = true;
            this.cmb_entidad.Location = new System.Drawing.Point(159, 62);
            this.cmb_entidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_entidad.Name = "cmb_entidad";
            this.cmb_entidad.Size = new System.Drawing.Size(488, 24);
            this.cmb_entidad.TabIndex = 43;
            this.cmb_entidad.ValueMember = "id";
            // 
            // auxentidadesfederativasBindingSource
            // 
            this.auxentidadesfederativasBindingSource.DataMember = "aux_entidades_federativas";
            this.auxentidadesfederativasBindingSource.DataSource = this.licitacionesDataSet;
            // 
            // txt_unidad_compradora
            // 
            this.txt_unidad_compradora.Location = new System.Drawing.Point(159, 35);
            this.txt_unidad_compradora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_unidad_compradora.Name = "txt_unidad_compradora";
            this.txt_unidad_compradora.Size = new System.Drawing.Size(488, 22);
            this.txt_unidad_compradora.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Archivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Entidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Unidad Compradora:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.btn_cancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 357);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(664, 57);
            this.toolStrip1.TabIndex = 54;
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
            // 
            // btn_archivo
            // 
            this.btn_archivo.Location = new System.Drawing.Point(66, 288);
            this.btn_archivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_archivo.Name = "btn_archivo";
            this.btn_archivo.Size = new System.Drawing.Size(88, 25);
            this.btn_archivo.TabIndex = 52;
            this.btn_archivo.Text = "Cambiar";
            this.btn_archivo.UseVisualStyleBackColor = true;
            this.btn_archivo.Click += new System.EventHandler(this.btn_archivo_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(159, 10);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(488, 22);
            this.txt_numero.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Numero:";
            // 
            // aux_entidades_federativasTableAdapter
            // 
            this.aux_entidades_federativasTableAdapter.ClearBeforeFill = true;
            // 
            // aux_tipos_expedienteTableAdapter
            // 
            this.aux_tipos_expedienteTableAdapter.ClearBeforeFill = true;
            // 
            // Licitacion_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 414);
            this.Controls.Add(this.cmb_tipo_exp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tipo_contrato);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_correo_operador);
            this.Controls.Add(this.txt_nombre_operador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_num_expediente);
            this.Controls.Add(this.txt_duracion_contrato);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_archivo);
            this.Controls.Add(this.cmb_entidad);
            this.Controls.Add(this.txt_unidad_compradora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_archivo);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Licitacion_Editar";
            this.Text = "Licitacion_Editar";
            this.Load += new System.EventHandler(this.Licitacion_Editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.auxtiposexpedienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auxentidadesfederativasBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_tipo_exp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tipo_contrato;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_correo_operador;
        private System.Windows.Forms.TextBox txt_nombre_operador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_num_expediente;
        private System.Windows.Forms.TextBox txt_duracion_contrato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_archivo;
        private System.Windows.Forms.ComboBox cmb_entidad;
        private System.Windows.Forms.TextBox txt_unidad_compradora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripButton btn_cancelar;
        private System.Windows.Forms.Button btn_archivo;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label1;
        private LicitacionesDataSet licitacionesDataSet;
        private System.Windows.Forms.BindingSource auxentidadesfederativasBindingSource;
        private LicitacionesDataSetTableAdapters.aux_entidades_federativasTableAdapter aux_entidades_federativasTableAdapter;
        private System.Windows.Forms.BindingSource auxtiposexpedienteBindingSource;
        private LicitacionesDataSetTableAdapters.aux_tipos_expedienteTableAdapter aux_tipos_expedienteTableAdapter;
    }
}