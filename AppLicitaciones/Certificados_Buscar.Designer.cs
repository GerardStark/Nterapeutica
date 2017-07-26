namespace AppLicitaciones
{
    partial class Certificados_Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Certificados_Buscar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_cat_buscar = new System.Windows.Forms.ToolStripButton();
            this.btn_buscar_cancelar = new System.Windows.Forms.ToolStripButton();
            this.txt_parametros = new System.Windows.Forms.TextBox();
            this.lbl_tipo_filtro = new System.Windows.Forms.Label();
            this.cmb_filtros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cat_buscar,
            this.btn_buscar_cancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 176);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(526, 57);
            this.toolStrip1.TabIndex = 105;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_cat_buscar
            // 
            this.btn_cat_buscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_cat_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_cat_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cat_buscar.Image")));
            this.btn_cat_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cat_buscar.Name = "btn_cat_buscar";
            this.btn_cat_buscar.Size = new System.Drawing.Size(54, 54);
            this.btn_cat_buscar.Text = "toolStripButton1";
            this.btn_cat_buscar.Click += new System.EventHandler(this.btn_cat_buscar_Click);
            // 
            // btn_buscar_cancelar
            // 
            this.btn_buscar_cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_buscar_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_cancelar.Image")));
            this.btn_buscar_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscar_cancelar.Name = "btn_buscar_cancelar";
            this.btn_buscar_cancelar.Size = new System.Drawing.Size(54, 54);
            this.btn_buscar_cancelar.Text = "Opciones";
            this.btn_buscar_cancelar.Click += new System.EventHandler(this.btn_buscar_cancelar_Click);
            // 
            // txt_parametros
            // 
            this.txt_parametros.Location = new System.Drawing.Point(139, 117);
            this.txt_parametros.Name = "txt_parametros";
            this.txt_parametros.Size = new System.Drawing.Size(272, 26);
            this.txt_parametros.TabIndex = 104;
            this.txt_parametros.Visible = false;
            // 
            // lbl_tipo_filtro
            // 
            this.lbl_tipo_filtro.AutoSize = true;
            this.lbl_tipo_filtro.Location = new System.Drawing.Point(135, 94);
            this.lbl_tipo_filtro.Name = "lbl_tipo_filtro";
            this.lbl_tipo_filtro.Size = new System.Drawing.Size(0, 20);
            this.lbl_tipo_filtro.TabIndex = 103;
            // 
            // cmb_filtros
            // 
            this.cmb_filtros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filtros.FormattingEnabled = true;
            this.cmb_filtros.Location = new System.Drawing.Point(150, 42);
            this.cmb_filtros.Name = "cmb_filtros";
            this.cmb_filtros.Size = new System.Drawing.Size(272, 28);
            this.cmb_filtros.TabIndex = 102;
            this.cmb_filtros.SelectedIndexChanged += new System.EventHandler(this.cmb_filtros_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "Filtros:";
            // 
            // Certificados_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 233);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txt_parametros);
            this.Controls.Add(this.lbl_tipo_filtro);
            this.Controls.Add(this.cmb_filtros);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Certificados_Buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificados_Buscar";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_cat_buscar;
        private System.Windows.Forms.ToolStripButton btn_buscar_cancelar;
        private System.Windows.Forms.TextBox txt_parametros;
        private System.Windows.Forms.Label lbl_tipo_filtro;
        private System.Windows.Forms.ComboBox cmb_filtros;
        private System.Windows.Forms.Label label1;
    }
}