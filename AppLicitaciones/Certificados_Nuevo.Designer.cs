namespace AppLicitaciones
{
    partial class Certificados_Nuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Certificados_Nuevo));
            this.tt_reg_nuevo = new System.Windows.Forms.ToolStrip();
            this.btn_reg_descartar = new System.Windows.Forms.ToolStripButton();
            this.btn_reg_guardar = new System.Windows.Forms.ToolStripButton();
            this.txt_limpiar_campos = new System.Windows.Forms.ToolStripButton();
            this.date_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.date_emision = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_archivo = new System.Windows.Forms.Button();
            this.btn_traduccion = new System.Windows.Forms.Button();
            this.lbl_archivo = new System.Windows.Forms.Label();
            this.lbl_trad = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.cmb_idioma = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fabricante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tt_reg_nuevo.SuspendLayout();
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
            this.tt_reg_nuevo.Location = new System.Drawing.Point(0, 420);
            this.tt_reg_nuevo.Name = "tt_reg_nuevo";
            this.tt_reg_nuevo.Size = new System.Drawing.Size(563, 57);
            this.tt_reg_nuevo.TabIndex = 28;
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
            this.txt_limpiar_campos.Click += new System.EventHandler(this.txt_limpiar_campos_Click);
            // 
            // date_vencimiento
            // 
            this.date_vencimiento.Location = new System.Drawing.Point(200, 310);
            this.date_vencimiento.Name = "date_vencimiento";
            this.date_vencimiento.Size = new System.Drawing.Size(288, 26);
            this.date_vencimiento.TabIndex = 36;
            // 
            // date_emision
            // 
            this.date_emision.Location = new System.Drawing.Point(201, 278);
            this.date_emision.Name = "date_emision";
            this.date_emision.Size = new System.Drawing.Size(288, 26);
            this.date_emision.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Fecha de Vencimiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Fecha de Emision:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Clave/Referencia:";
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(201, 37);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(287, 26);
            this.txt_clave.TabIndex = 38;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(201, 101);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(287, 105);
            this.txt_descripcion.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Descripcion:";
            // 
            // btn_archivo
            // 
            this.btn_archivo.Location = new System.Drawing.Point(86, 338);
            this.btn_archivo.Name = "btn_archivo";
            this.btn_archivo.Size = new System.Drawing.Size(105, 28);
            this.btn_archivo.TabIndex = 43;
            this.btn_archivo.Text = "Archivo";
            this.btn_archivo.UseVisualStyleBackColor = true;
            this.btn_archivo.Click += new System.EventHandler(this.btn_archivo_Click);
            // 
            // btn_traduccion
            // 
            this.btn_traduccion.Location = new System.Drawing.Point(69, 372);
            this.btn_traduccion.Name = "btn_traduccion";
            this.btn_traduccion.Size = new System.Drawing.Size(124, 28);
            this.btn_traduccion.TabIndex = 44;
            this.btn_traduccion.Text = "Traduccion";
            this.btn_traduccion.UseVisualStyleBackColor = true;
            this.btn_traduccion.Click += new System.EventHandler(this.btn_traduccion_Click);
            // 
            // lbl_archivo
            // 
            this.lbl_archivo.AutoSize = true;
            this.lbl_archivo.Location = new System.Drawing.Point(199, 346);
            this.lbl_archivo.Name = "lbl_archivo";
            this.lbl_archivo.Size = new System.Drawing.Size(59, 20);
            this.lbl_archivo.TabIndex = 45;
            this.lbl_archivo.Text = "(Vacio)";
            // 
            // lbl_trad
            // 
            this.lbl_trad.AutoSize = true;
            this.lbl_trad.Location = new System.Drawing.Point(199, 376);
            this.lbl_trad.Name = "lbl_trad";
            this.lbl_trad.Size = new System.Drawing.Size(59, 20);
            this.lbl_trad.TabIndex = 46;
            this.lbl_trad.Text = "(Vacio)";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(201, 67);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(287, 28);
            this.cmb_tipo.TabIndex = 47;
            // 
            // cmb_idioma
            // 
            this.cmb_idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_idioma.FormattingEnabled = true;
            this.cmb_idioma.Location = new System.Drawing.Point(202, 209);
            this.cmb_idioma.Name = "cmb_idioma";
            this.cmb_idioma.Size = new System.Drawing.Size(287, 28);
            this.cmb_idioma.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Idioma:";
            // 
            // txt_fabricante
            // 
            this.txt_fabricante.Location = new System.Drawing.Point(200, 245);
            this.txt_fabricante.Name = "txt_fabricante";
            this.txt_fabricante.Size = new System.Drawing.Size(288, 26);
            this.txt_fabricante.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Fabricante:";
            // 
            // Certificados_Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 477);
            this.Controls.Add(this.txt_fabricante);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.tt_reg_nuevo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Certificados_Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificados_Nuevo";
            this.tt_reg_nuevo.ResumeLayout(false);
            this.tt_reg_nuevo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tt_reg_nuevo;
        private System.Windows.Forms.ToolStripButton btn_reg_descartar;
        private System.Windows.Forms.ToolStripButton btn_reg_guardar;
        private System.Windows.Forms.ToolStripButton txt_limpiar_campos;
        private System.Windows.Forms.DateTimePicker date_vencimiento;
        private System.Windows.Forms.DateTimePicker date_emision;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_archivo;
        private System.Windows.Forms.Button btn_traduccion;
        private System.Windows.Forms.Label lbl_archivo;
        private System.Windows.Forms.Label lbl_trad;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.ComboBox cmb_idioma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_fabricante;
        private System.Windows.Forms.Label label6;
    }
}