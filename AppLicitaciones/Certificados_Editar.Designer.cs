namespace AppLicitaciones
{
    partial class Certificados_Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Certificados_Editar));
            this.cmb_idioma = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_trad = new System.Windows.Forms.Label();
            this.lbl_archivo = new System.Windows.Forms.Label();
            this.btn_traduccion = new System.Windows.Forms.Button();
            this.btn_archivo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.date_emision = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tt_reg_nuevo = new System.Windows.Forms.ToolStrip();
            this.btn_reg_descartar = new System.Windows.Forms.ToolStripButton();
            this.btn_reg_guardar = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_fabricante = new System.Windows.Forms.TextBox();
            this.tt_reg_nuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_idioma
            // 
            this.cmb_idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_idioma.FormattingEnabled = true;
            this.cmb_idioma.Location = new System.Drawing.Point(208, 199);
            this.cmb_idioma.Name = "cmb_idioma";
            this.cmb_idioma.Size = new System.Drawing.Size(287, 28);
            this.cmb_idioma.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "Idioma:";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(207, 57);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(287, 28);
            this.cmb_tipo.TabIndex = 66;
            // 
            // lbl_trad
            // 
            this.lbl_trad.AutoSize = true;
            this.lbl_trad.Location = new System.Drawing.Point(214, 424);
            this.lbl_trad.Name = "lbl_trad";
            this.lbl_trad.Size = new System.Drawing.Size(59, 20);
            this.lbl_trad.TabIndex = 65;
            this.lbl_trad.Text = "(Vacio)";
            // 
            // lbl_archivo
            // 
            this.lbl_archivo.AutoSize = true;
            this.lbl_archivo.Location = new System.Drawing.Point(214, 361);
            this.lbl_archivo.Name = "lbl_archivo";
            this.lbl_archivo.Size = new System.Drawing.Size(59, 20);
            this.lbl_archivo.TabIndex = 64;
            this.lbl_archivo.Text = "(Vacio)";
            // 
            // btn_traduccion
            // 
            this.btn_traduccion.Location = new System.Drawing.Point(84, 420);
            this.btn_traduccion.Name = "btn_traduccion";
            this.btn_traduccion.Size = new System.Drawing.Size(124, 28);
            this.btn_traduccion.TabIndex = 63;
            this.btn_traduccion.Text = "Buscar";
            this.btn_traduccion.UseVisualStyleBackColor = true;
            this.btn_traduccion.Click += new System.EventHandler(this.btn_traduccion_Click);
            // 
            // btn_archivo
            // 
            this.btn_archivo.Location = new System.Drawing.Point(84, 357);
            this.btn_archivo.Name = "btn_archivo";
            this.btn_archivo.Size = new System.Drawing.Size(124, 28);
            this.btn_archivo.TabIndex = 62;
            this.btn_archivo.Text = "Buscar";
            this.btn_archivo.UseVisualStyleBackColor = true;
            this.btn_archivo.Click += new System.EventHandler(this.btn_archivo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Tipo:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(207, 91);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(287, 105);
            this.txt_descripcion.TabIndex = 59;
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(207, 27);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(287, 26);
            this.txt_clave.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Clave/Referencia:";
            // 
            // date_vencimiento
            // 
            this.date_vencimiento.Location = new System.Drawing.Point(206, 300);
            this.date_vencimiento.Name = "date_vencimiento";
            this.date_vencimiento.Size = new System.Drawing.Size(288, 26);
            this.date_vencimiento.TabIndex = 56;
            // 
            // date_emision
            // 
            this.date_emision.Location = new System.Drawing.Point(207, 268);
            this.date_emision.Name = "date_emision";
            this.date_emision.Size = new System.Drawing.Size(288, 26);
            this.date_emision.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "Fecha de Vencimiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 20);
            this.label10.TabIndex = 53;
            this.label10.Text = "Fecha de Emision:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Fabricante:";
            // 
            // tt_reg_nuevo
            // 
            this.tt_reg_nuevo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tt_reg_nuevo.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tt_reg_nuevo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_reg_descartar,
            this.btn_reg_guardar});
            this.tt_reg_nuevo.Location = new System.Drawing.Point(0, 483);
            this.tt_reg_nuevo.Name = "tt_reg_nuevo";
            this.tt_reg_nuevo.Size = new System.Drawing.Size(563, 57);
            this.tt_reg_nuevo.TabIndex = 69;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Archivo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 71;
            this.label7.Text = "Traduccion:";
            // 
            // txt_fabricante
            // 
            this.txt_fabricante.Location = new System.Drawing.Point(208, 236);
            this.txt_fabricante.Name = "txt_fabricante";
            this.txt_fabricante.Size = new System.Drawing.Size(287, 26);
            this.txt_fabricante.TabIndex = 72;
            // 
            // Certificados_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 540);
            this.Controls.Add(this.txt_fabricante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tt_reg_nuevo);
            this.Controls.Add(this.cmb_idioma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.lbl_trad);
            this.Controls.Add(this.lbl_archivo);
            this.Controls.Add(this.btn_traduccion);
            this.Controls.Add(this.btn_archivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_vencimiento);
            this.Controls.Add(this.date_emision);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Certificados_Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificados_Editar";
            this.tt_reg_nuevo.ResumeLayout(false);
            this.tt_reg_nuevo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_idioma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label lbl_trad;
        private System.Windows.Forms.Label lbl_archivo;
        private System.Windows.Forms.Button btn_traduccion;
        private System.Windows.Forms.Button btn_archivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_vencimiento;
        private System.Windows.Forms.DateTimePicker date_emision;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip tt_reg_nuevo;
        private System.Windows.Forms.ToolStripButton btn_reg_descartar;
        private System.Windows.Forms.ToolStripButton btn_reg_guardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_fabricante;
    }
}