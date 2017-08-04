namespace AppLicitaciones
{
    partial class Licitacion_Calendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licitacion_Calendario));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_cancelar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_publicacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_junta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_propuestas = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_fallo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_firma = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_visita = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.btn_cancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 348);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(424, 57);
            this.toolStrip1.TabIndex = 18;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha de Publicacion en Compranet";
            // 
            // dtp_publicacion
            // 
            this.dtp_publicacion.Location = new System.Drawing.Point(51, 45);
            this.dtp_publicacion.Name = "dtp_publicacion";
            this.dtp_publicacion.Size = new System.Drawing.Size(320, 26);
            this.dtp_publicacion.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fecha de la Junta de Aclaraciones:";
            // 
            // dtp_junta
            // 
            this.dtp_junta.Location = new System.Drawing.Point(51, 97);
            this.dtp_junta.Name = "dtp_junta";
            this.dtp_junta.Size = new System.Drawing.Size(320, 26);
            this.dtp_junta.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha de la Apertura de Propuestas:";
            // 
            // dtp_propuestas
            // 
            this.dtp_propuestas.Location = new System.Drawing.Point(51, 149);
            this.dtp_propuestas.Name = "dtp_propuestas";
            this.dtp_propuestas.Size = new System.Drawing.Size(320, 26);
            this.dtp_propuestas.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Fecha del Anuncio de Fallo:";
            // 
            // dtp_fallo
            // 
            this.dtp_fallo.Location = new System.Drawing.Point(51, 201);
            this.dtp_fallo.Name = "dtp_fallo";
            this.dtp_fallo.Size = new System.Drawing.Size(320, 26);
            this.dtp_fallo.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fecha de la Firma del Contrato";
            // 
            // dtp_firma
            // 
            this.dtp_firma.Location = new System.Drawing.Point(51, 253);
            this.dtp_firma.Name = "dtp_firma";
            this.dtp_firma.Size = new System.Drawing.Size(320, 26);
            this.dtp_firma.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Fecha de la Visita a Instalaciones:";
            // 
            // dtp_visita
            // 
            this.dtp_visita.Location = new System.Drawing.Point(51, 305);
            this.dtp_visita.Name = "dtp_visita";
            this.dtp_visita.Size = new System.Drawing.Size(320, 26);
            this.dtp_visita.TabIndex = 30;
            // 
            // Licitacion_Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 405);
            this.Controls.Add(this.dtp_visita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_firma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_fallo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_propuestas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_junta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_publicacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Licitacion_Calendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licitacion_Calendario";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripButton btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_publicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_junta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_propuestas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_fallo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_firma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_visita;
    }
}