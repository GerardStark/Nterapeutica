namespace AppLicitaciones
{
    partial class Form_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.licitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosSanitariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificadosDeCalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadroBasicoDelIMSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricantesTitularesDistribuidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noSeQueEstoyHaciendoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licitacionesToolStripMenuItem,
            this.bancoDeDatosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1328, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // licitacionesToolStripMenuItem
            // 
            this.licitacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("licitacionesToolStripMenuItem.Image")));
            this.licitacionesToolStripMenuItem.Name = "licitacionesToolStripMenuItem";
            this.licitacionesToolStripMenuItem.Size = new System.Drawing.Size(118, 25);
            this.licitacionesToolStripMenuItem.Text = "Licitaciones";
            this.licitacionesToolStripMenuItem.Click += new System.EventHandler(this.licitacionesToolStripMenuItem_Click);
            // 
            // bancoDeDatosToolStripMenuItem
            // 
            this.bancoDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosSanitariosToolStripMenuItem,
            this.certificadosDeCalidadToolStripMenuItem,
            this.catálogosDeProductosToolStripMenuItem,
            this.cuadroBasicoDelIMSSToolStripMenuItem,
            this.fabricantesTitularesDistribuidoresToolStripMenuItem});
            this.bancoDeDatosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bancoDeDatosToolStripMenuItem.Image")));
            this.bancoDeDatosToolStripMenuItem.Name = "bancoDeDatosToolStripMenuItem";
            this.bancoDeDatosToolStripMenuItem.Size = new System.Drawing.Size(145, 25);
            this.bancoDeDatosToolStripMenuItem.Text = "Banco de Datos";
            // 
            // registrosSanitariosToolStripMenuItem
            // 
            this.registrosSanitariosToolStripMenuItem.Name = "registrosSanitariosToolStripMenuItem";
            this.registrosSanitariosToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.registrosSanitariosToolStripMenuItem.Text = "Registros Sanitarios";
            this.registrosSanitariosToolStripMenuItem.Click += new System.EventHandler(this.registrosSanitariosToolStripMenuItem_Click);
            // 
            // certificadosDeCalidadToolStripMenuItem
            // 
            this.certificadosDeCalidadToolStripMenuItem.Name = "certificadosDeCalidadToolStripMenuItem";
            this.certificadosDeCalidadToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.certificadosDeCalidadToolStripMenuItem.Text = "Certificados de Calidad";
            this.certificadosDeCalidadToolStripMenuItem.Click += new System.EventHandler(this.certificadosDeCalidadToolStripMenuItem_Click);
            // 
            // catálogosDeProductosToolStripMenuItem
            // 
            this.catálogosDeProductosToolStripMenuItem.Name = "catálogosDeProductosToolStripMenuItem";
            this.catálogosDeProductosToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.catálogosDeProductosToolStripMenuItem.Text = "Catálogos de Productos";
            this.catálogosDeProductosToolStripMenuItem.Click += new System.EventHandler(this.catálogosDeProductosToolStripMenuItem_Click);
            // 
            // cuadroBasicoDelIMSSToolStripMenuItem
            // 
            this.cuadroBasicoDelIMSSToolStripMenuItem.Name = "cuadroBasicoDelIMSSToolStripMenuItem";
            this.cuadroBasicoDelIMSSToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.cuadroBasicoDelIMSSToolStripMenuItem.Text = "Cuadro Basico del IMSS";
            this.cuadroBasicoDelIMSSToolStripMenuItem.Click += new System.EventHandler(this.cuadroBasicoDelIMSSToolStripMenuItem_Click);
            // 
            // fabricantesTitularesDistribuidoresToolStripMenuItem
            // 
            this.fabricantesTitularesDistribuidoresToolStripMenuItem.Name = "fabricantesTitularesDistribuidoresToolStripMenuItem";
            this.fabricantesTitularesDistribuidoresToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.fabricantesTitularesDistribuidoresToolStripMenuItem.Text = "Cartas de Apoyo/Marcas";
            this.fabricantesTitularesDistribuidoresToolStripMenuItem.Click += new System.EventHandler(this.fabricantesTitularesDistribuidoresToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualesToolStripMenuItem,
            this.informacionToolStripMenuItem,
            this.noSeQueEstoyHaciendoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem.Image")));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualesToolStripMenuItem
            // 
            this.manualesToolStripMenuItem.Name = "manualesToolStripMenuItem";
            this.manualesToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.manualesToolStripMenuItem.Text = "Manuales";
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.informacionToolStripMenuItem.Text = "Informacion";
            // 
            // noSeQueEstoyHaciendoToolStripMenuItem
            // 
            this.noSeQueEstoyHaciendoToolStripMenuItem.Name = "noSeQueEstoyHaciendoToolStripMenuItem";
            this.noSeQueEstoyHaciendoToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.noSeQueEstoyHaciendoToolStripMenuItem.Text = "No se que estoy haciendo";
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 691);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Pantalla Principal de Licitaciones.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem licitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosSanitariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificadosDeCalidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadroBasicoDelIMSSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noSeQueEstoyHaciendoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricantesTitularesDistribuidoresToolStripMenuItem;
    }
}