namespace AppLicitaciones
{
    partial class Visualizar_Opciones
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
            this.pnl_reg = new System.Windows.Forms.Panel();
            this.pnl_cert = new System.Windows.Forms.Panel();
            this.pnl_cat = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nombre_prod = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl_reg
            // 
            this.pnl_reg.Location = new System.Drawing.Point(3, 59);
            this.pnl_reg.Name = "pnl_reg";
            this.pnl_reg.Size = new System.Drawing.Size(297, 298);
            this.pnl_reg.TabIndex = 0;
            // 
            // pnl_cert
            // 
            this.pnl_cert.Location = new System.Drawing.Point(693, 59);
            this.pnl_cert.Name = "pnl_cert";
            this.pnl_cert.Size = new System.Drawing.Size(297, 298);
            this.pnl_cert.TabIndex = 1;
            // 
            // pnl_cat
            // 
            this.pnl_cat.Location = new System.Drawing.Point(357, 59);
            this.pnl_cat.Name = "pnl_cat";
            this.pnl_cat.Size = new System.Drawing.Size(297, 298);
            this.pnl_cat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registros Sanitarios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Catálogos de Productos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(689, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Certificados de Calidad:";
            // 
            // lbl_nombre_prod
            // 
            this.lbl_nombre_prod.AutoSize = true;
            this.lbl_nombre_prod.Location = new System.Drawing.Point(171, 0);
            this.lbl_nombre_prod.Name = "lbl_nombre_prod";
            this.lbl_nombre_prod.Size = new System.Drawing.Size(51, 20);
            this.lbl_nombre_prod.TabIndex = 3;
            this.lbl_nombre_prod.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre del Producto:";
            // 
            // Visualizar_Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_nombre_prod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_cat);
            this.Controls.Add(this.pnl_cert);
            this.Controls.Add(this.pnl_reg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Visualizar_Opciones";
            this.Size = new System.Drawing.Size(993, 361);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_reg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_cert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_cat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nombre_prod;
        private System.Windows.Forms.Label label4;
    }
}
