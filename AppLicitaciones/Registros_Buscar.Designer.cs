namespace AppLicitaciones
{
    partial class Registros_Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros_Buscar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_reg_buscar = new System.Windows.Forms.ToolStripButton();
            this.btn_buscar_cancelar = new System.Windows.Forms.ToolStripButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_opciones_buscqueda = new System.Windows.Forms.ComboBox();
            this.lbl_parametro = new System.Windows.Forms.Label();
            this.txt_parametros = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_reg_buscar,
            this.btn_buscar_cancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 176);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(550, 57);
            this.toolStrip1.TabIndex = 98;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_reg_buscar
            // 
            this.btn_reg_buscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_reg_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_reg_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_reg_buscar.Image")));
            this.btn_reg_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reg_buscar.Name = "btn_reg_buscar";
            this.btn_reg_buscar.Size = new System.Drawing.Size(54, 54);
            this.btn_reg_buscar.Text = "toolStripButton1";
            this.btn_reg_buscar.Click += new System.EventHandler(this.btn_reg_buscar_Click);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 20);
            this.label10.TabIndex = 100;
            this.label10.Text = "Selecciona un filtro:";
            // 
            // cmb_opciones_buscqueda
            // 
            this.cmb_opciones_buscqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_opciones_buscqueda.FormattingEnabled = true;
            this.cmb_opciones_buscqueda.Location = new System.Drawing.Point(179, 29);
            this.cmb_opciones_buscqueda.Name = "cmb_opciones_buscqueda";
            this.cmb_opciones_buscqueda.Size = new System.Drawing.Size(325, 28);
            this.cmb_opciones_buscqueda.TabIndex = 102;
            this.cmb_opciones_buscqueda.SelectedIndexChanged += new System.EventHandler(this.cmb_opciones_buscqueda_SelectedIndexChanged);
            // 
            // lbl_parametro
            // 
            this.lbl_parametro.AutoSize = true;
            this.lbl_parametro.Location = new System.Drawing.Point(145, 92);
            this.lbl_parametro.Name = "lbl_parametro";
            this.lbl_parametro.Size = new System.Drawing.Size(0, 20);
            this.lbl_parametro.TabIndex = 104;
            // 
            // txt_parametros
            // 
            this.txt_parametros.Location = new System.Drawing.Point(149, 115);
            this.txt_parametros.Name = "txt_parametros";
            this.txt_parametros.Size = new System.Drawing.Size(325, 26);
            this.txt_parametros.TabIndex = 105;
            this.txt_parametros.Visible = false;
            // 
            // Registros_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 233);
            this.Controls.Add(this.txt_parametros);
            this.Controls.Add(this.lbl_parametro);
            this.Controls.Add(this.cmb_opciones_buscqueda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Registros_Buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Registros Sanitarios";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_reg_buscar;
        private System.Windows.Forms.ToolStripButton btn_buscar_cancelar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_opciones_buscqueda;
        private System.Windows.Forms.Label lbl_parametro;
        private System.Windows.Forms.TextBox txt_parametros;
    }
}