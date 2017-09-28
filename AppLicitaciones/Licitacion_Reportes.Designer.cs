namespace AppLicitaciones
{
    partial class Licitacion_Reportes
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRep = new System.Windows.Forms.ComboBox();
            this.pnlFormatReport = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reporte:";
            // 
            // cmbRep
            // 
            this.cmbRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRep.FormattingEnabled = true;
            this.cmbRep.Location = new System.Drawing.Point(75, 12);
            this.cmbRep.Name = "cmbRep";
            this.cmbRep.Size = new System.Drawing.Size(402, 24);
            this.cmbRep.TabIndex = 4;
            this.cmbRep.SelectedIndexChanged += new System.EventHandler(this.cmbRep_SelectedIndexChanged);
            // 
            // pnlFormatReport
            // 
            this.pnlFormatReport.Location = new System.Drawing.Point(12, 42);
            this.pnlFormatReport.Name = "pnlFormatReport";
            this.pnlFormatReport.Size = new System.Drawing.Size(1210, 618);
            this.pnlFormatReport.TabIndex = 1;
            // 
            // Licitacion_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 672);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlFormatReport);
            this.Controls.Add(this.cmbRep);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Licitacion_Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licitacion_Reportes";
            this.Load += new System.EventHandler(this.Licitacion_Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRep;
        public System.Windows.Forms.Panel pnlFormatReport;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}