namespace AppLicitaciones
{
    partial class Reporte_Principal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.flpDatos = new System.Windows.Forms.FlowLayoutPanel();
            this.radConc = new System.Windows.Forms.RadioButton();
            this.radAct = new System.Windows.Forms.RadioButton();
            this.cmbNumLicit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.flpDatos);
            this.pnlDatos.Controls.Add(this.radConc);
            this.pnlDatos.Controls.Add(this.radAct);
            this.pnlDatos.Controls.Add(this.cmbNumLicit);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Location = new System.Drawing.Point(3, 4);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(254, 550);
            this.pnlDatos.TabIndex = 1;
            // 
            // flpDatos
            // 
            this.flpDatos.Location = new System.Drawing.Point(6, 112);
            this.flpDatos.Name = "flpDatos";
            this.flpDatos.Size = new System.Drawing.Size(241, 435);
            this.flpDatos.TabIndex = 4;
            // 
            // radConc
            // 
            this.radConc.AutoSize = true;
            this.radConc.Location = new System.Drawing.Point(113, 19);
            this.radConc.Name = "radConc";
            this.radConc.Size = new System.Drawing.Size(93, 20);
            this.radConc.TabIndex = 3;
            this.radConc.TabStop = true;
            this.radConc.Text = "Concluidas";
            this.radConc.UseVisualStyleBackColor = true;
            // 
            // radAct
            // 
            this.radAct.AutoSize = true;
            this.radAct.Location = new System.Drawing.Point(6, 19);
            this.radAct.Name = "radAct";
            this.radAct.Size = new System.Drawing.Size(96, 20);
            this.radAct.TabIndex = 2;
            this.radAct.TabStop = true;
            this.radAct.Text = "En Proceso";
            this.radAct.UseVisualStyleBackColor = true;
            // 
            // cmbNumLicit
            // 
            this.cmbNumLicit.FormattingEnabled = true;
            this.cmbNumLicit.Location = new System.Drawing.Point(6, 82);
            this.cmbNumLicit.Name = "cmbNumLicit";
            this.cmbNumLicit.Size = new System.Drawing.Size(241, 24);
            this.cmbNumLicit.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Licitacion";
            // 
            // pnlReportes
            // 
            this.pnlReportes.Location = new System.Drawing.Point(263, 4);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(944, 550);
            this.pnlReportes.TabIndex = 2;
            // 
            // Reporte_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlReportes);
            this.Controls.Add(this.pnlDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reporte_Principal";
            this.Size = new System.Drawing.Size(1210, 618);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.RadioButton radConc;
        private System.Windows.Forms.RadioButton radAct;
        private System.Windows.Forms.ComboBox cmbNumLicit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlReportes;
        private System.Windows.Forms.FlowLayoutPanel flpDatos;
    }
}
