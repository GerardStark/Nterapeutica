namespace AppLicitaciones
{
    partial class Cucop_Visualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cucop_Visualizar));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tt_reg_editar = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_editar = new System.Windows.Forms.ToolStripButton();
            this.btn_borrar = new System.Windows.Forms.ToolStripButton();
            this.lbl_nombre_gen = new System.Windows.Forms.Label();
            this.lbl_grupo = new System.Windows.Forms.Label();
            this.lbl_ccb = new System.Windows.Forms.Label();
            this.tt_reg_editar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Codigo CCB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Grupo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre Generico:";
            // 
            // tt_reg_editar
            // 
            this.tt_reg_editar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tt_reg_editar.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tt_reg_editar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.btn_editar,
            this.btn_borrar});
            this.tt_reg_editar.Location = new System.Drawing.Point(0, 150);
            this.tt_reg_editar.Name = "tt_reg_editar";
            this.tt_reg_editar.Size = new System.Drawing.Size(531, 57);
            this.tt_reg_editar.TabIndex = 87;
            this.tt_reg_editar.Text = "Menú";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(54, 54);
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.ToolTipText = "OK";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(54, 54);
            this.btn_editar.Text = "toolStripButton5";
            this.btn_editar.ToolTipText = "Editar";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_borrar.Image")));
            this.btn_borrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(54, 54);
            this.btn_borrar.Text = "toolStripButton3";
            this.btn_borrar.ToolTipText = "Borrar";
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // lbl_nombre_gen
            // 
            this.lbl_nombre_gen.AutoSize = true;
            this.lbl_nombre_gen.Location = new System.Drawing.Point(175, 39);
            this.lbl_nombre_gen.Name = "lbl_nombre_gen";
            this.lbl_nombre_gen.Size = new System.Drawing.Size(60, 20);
            this.lbl_nombre_gen.TabIndex = 88;
            this.lbl_nombre_gen.Text = "label21";
            // 
            // lbl_grupo
            // 
            this.lbl_grupo.AutoSize = true;
            this.lbl_grupo.Location = new System.Drawing.Point(175, 68);
            this.lbl_grupo.Name = "lbl_grupo";
            this.lbl_grupo.Size = new System.Drawing.Size(60, 20);
            this.lbl_grupo.TabIndex = 89;
            this.lbl_grupo.Text = "label22";
            // 
            // lbl_ccb
            // 
            this.lbl_ccb.AutoSize = true;
            this.lbl_ccb.Location = new System.Drawing.Point(175, 100);
            this.lbl_ccb.Name = "lbl_ccb";
            this.lbl_ccb.Size = new System.Drawing.Size(60, 20);
            this.lbl_ccb.TabIndex = 90;
            this.lbl_ccb.Text = "label23";
            // 
            // Cucop_Visualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 207);
            this.Controls.Add(this.lbl_ccb);
            this.Controls.Add(this.lbl_grupo);
            this.Controls.Add(this.lbl_nombre_gen);
            this.Controls.Add(this.tt_reg_editar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cucop_Visualizar";
            this.Text = "Cucop_Visualizar";
            this.tt_reg_editar.ResumeLayout(false);
            this.tt_reg_editar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tt_reg_editar;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripButton btn_editar;
        private System.Windows.Forms.ToolStripButton btn_borrar;
        private System.Windows.Forms.Label lbl_nombre_gen;
        private System.Windows.Forms.Label lbl_grupo;
        private System.Windows.Forms.Label lbl_ccb;
    }
}