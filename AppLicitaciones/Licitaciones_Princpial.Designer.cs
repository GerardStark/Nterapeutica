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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licitaciones_Princpial));
            this.btn_nueva = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_activas = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btn_historico = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.eventos = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_nueva
            // 
            this.btn_nueva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_nueva.Image = ((System.Drawing.Image)(resources.GetObject("btn_nueva.Image")));
            this.btn_nueva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nueva.Name = "btn_nueva";
            this.btn_nueva.Size = new System.Drawing.Size(66, 54);
            this.btn_nueva.Text = "toolStripButton1";
            this.btn_nueva.Click += new System.EventHandler(this.btn_nuevas_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(66, 15);
            this.toolStripLabel1.Text = "Nueva";
            // 
            // btn_activas
            // 
            this.btn_activas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_activas.Image = ((System.Drawing.Image)(resources.GetObject("btn_activas.Image")));
            this.btn_activas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_activas.Name = "btn_activas";
            this.btn_activas.Size = new System.Drawing.Size(66, 54);
            this.btn_activas.Text = "toolStripButton2";
            this.btn_activas.Click += new System.EventHandler(this.btn_activas_Click);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(66, 15);
            this.toolStripLabel6.Text = "Activas";
            // 
            // btn_historico
            // 
            this.btn_historico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_historico.Image = ((System.Drawing.Image)(resources.GetObject("btn_historico.Image")));
            this.btn_historico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_historico.Name = "btn_historico";
            this.btn_historico.Size = new System.Drawing.Size(66, 54);
            this.btn_historico.Text = "toolStripButton3";
            this.btn_historico.Click += new System.EventHandler(this.btn_historico_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(66, 15);
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
            this.toolStripLabel5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(69, 666);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // eventos
            // 
            this.eventos.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.eventos.Location = new System.Drawing.Point(78, 18);
            this.eventos.Name = "eventos";
            this.eventos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proximos Eventos:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(82, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 437);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(592, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 608);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Progreso de Licitaciones Activas";
            // 
            // Licitaciones_Princpial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 666);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventos);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Licitaciones_Princpial";
            this.Text = "Licitaciones_Princpial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.MonthCalendar eventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}