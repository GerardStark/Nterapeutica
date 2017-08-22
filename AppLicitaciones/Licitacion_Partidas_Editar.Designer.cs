namespace AppLicitaciones
{
    partial class Licitacion_Partidas_Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licitacion_Partidas_Editar));
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tt_reg_nuevo = new System.Windows.Forms.ToolStrip();
            this.btn_reg_descartar = new System.Windows.Forms.ToolStripButton();
            this.btn_reg_guardar = new System.Windows.Forms.ToolStripButton();
            this.txt_limpiar_campos = new System.Windows.Forms.ToolStripButton();
            this.cmb_especialidad = new System.Windows.Forms.ComboBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tt_reg_nuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(168, 12);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.ReadOnly = true;
            this.txt_numero.Size = new System.Drawing.Size(72, 22);
            this.txt_numero.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Especialidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre de la Partida:";
            // 
            // tt_reg_nuevo
            // 
            this.tt_reg_nuevo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tt_reg_nuevo.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tt_reg_nuevo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_reg_descartar,
            this.btn_reg_guardar,
            this.txt_limpiar_campos});
            this.tt_reg_nuevo.Location = new System.Drawing.Point(0, 156);
            this.tt_reg_nuevo.Name = "tt_reg_nuevo";
            this.tt_reg_nuevo.Size = new System.Drawing.Size(542, 57);
            this.tt_reg_nuevo.TabIndex = 36;
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
            // 
            // cmb_especialidad
            // 
            this.cmb_especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_especialidad.FormattingEnabled = true;
            this.cmb_especialidad.Location = new System.Drawing.Point(168, 109);
            this.cmb_especialidad.Name = "cmb_especialidad";
            this.cmb_especialidad.Size = new System.Drawing.Size(357, 24);
            this.cmb_especialidad.TabIndex = 35;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(168, 40);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(357, 63);
            this.txt_nombre.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Numero de Partida:";
            // 
            // Licitacion_Partidas_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 213);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tt_reg_nuevo);
            this.Controls.Add(this.cmb_especialidad);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Licitacion_Partidas_Editar";
            this.Text = "Licitacion_Partidas_Editar";
            this.tt_reg_nuevo.ResumeLayout(false);
            this.tt_reg_nuevo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip tt_reg_nuevo;
        private System.Windows.Forms.ToolStripButton btn_reg_descartar;
        private System.Windows.Forms.ToolStripButton btn_reg_guardar;
        private System.Windows.Forms.ToolStripButton txt_limpiar_campos;
        private System.Windows.Forms.ComboBox cmb_especialidad;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
    }
}