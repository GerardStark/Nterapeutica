namespace AppLicitaciones
{
    partial class Reporte_Referencias
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
            this.components = new System.ComponentModel.Container();
            this.tlvReg = new BrightIdeasSoftware.TreeListView();
            this.reqColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.radConc = new System.Windows.Forms.RadioButton();
            this.radAct = new System.Windows.Forms.RadioButton();
            this.cmbNumLicit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tlvReg)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlvReg
            // 
            this.tlvReg.AllColumns.Add(this.reqColumn);
            this.tlvReg.CellEditUseWholeCell = false;
            this.tlvReg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reqColumn});
            this.tlvReg.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlvReg.Location = new System.Drawing.Point(345, 4);
            this.tlvReg.Margin = new System.Windows.Forms.Padding(4);
            this.tlvReg.Name = "tlvReg";
            this.tlvReg.ShowGroups = false;
            this.tlvReg.Size = new System.Drawing.Size(861, 611);
            this.tlvReg.TabIndex = 11;
            this.tlvReg.UseCompatibleStateImageBehavior = false;
            this.tlvReg.View = System.Windows.Forms.View.Details;
            this.tlvReg.VirtualMode = true;
            // 
            // reqColumn
            // 
            this.reqColumn.AspectName = "Nombre";
            this.reqColumn.Text = "Descripcion";
            this.reqColumn.Width = 832;
            // 
            // pnlDatos
            // 
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.Controls.Add(this.checkBox2);
            this.pnlDatos.Controls.Add(this.checkBox1);
            this.pnlDatos.Controls.Add(this.txtFolio);
            this.pnlDatos.Controls.Add(this.label3);
            this.pnlDatos.Controls.Add(this.label2);
            this.pnlDatos.Controls.Add(this.txtHeader);
            this.pnlDatos.Controls.Add(this.btn_imprimir);
            this.pnlDatos.Controls.Add(this.btnImprimir);
            this.pnlDatos.Controls.Add(this.radConc);
            this.pnlDatos.Controls.Add(this.radAct);
            this.pnlDatos.Controls.Add(this.cmbNumLicit);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Location = new System.Drawing.Point(5, 4);
            this.pnlDatos.Margin = new System.Windows.Forms.Padding(5);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(338, 611);
            this.pnlDatos.TabIndex = 10;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackgroundImage = global::AppLicitaciones.Iconos.printer;
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir.Location = new System.Drawing.Point(263, 543);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(67, 62);
            this.btn_imprimir.TabIndex = 14;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::AppLicitaciones.Iconos.printer;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Location = new System.Drawing.Point(353, 836);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(89, 76);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // radConc
            // 
            this.radConc.AutoSize = true;
            this.radConc.Location = new System.Drawing.Point(151, 14);
            this.radConc.Margin = new System.Windows.Forms.Padding(5);
            this.radConc.Name = "radConc";
            this.radConc.Size = new System.Drawing.Size(93, 20);
            this.radConc.TabIndex = 2;
            this.radConc.TabStop = true;
            this.radConc.Text = "Concluidas";
            this.radConc.UseVisualStyleBackColor = true;
            // 
            // radAct
            // 
            this.radAct.AutoSize = true;
            this.radAct.Location = new System.Drawing.Point(12, 14);
            this.radAct.Margin = new System.Windows.Forms.Padding(5);
            this.radAct.Name = "radAct";
            this.radAct.Size = new System.Drawing.Size(96, 20);
            this.radAct.TabIndex = 1;
            this.radAct.TabStop = true;
            this.radAct.Text = "En Proceso";
            this.radAct.UseVisualStyleBackColor = true;
            // 
            // cmbNumLicit
            // 
            this.cmbNumLicit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumLicit.FormattingEnabled = true;
            this.cmbNumLicit.Location = new System.Drawing.Point(4, 86);
            this.cmbNumLicit.Margin = new System.Windows.Forms.Padding(5);
            this.cmbNumLicit.Name = "cmbNumLicit";
            this.cmbNumLicit.Size = new System.Drawing.Size(326, 24);
            this.cmbNumLicit.TabIndex = 3;
            this.cmbNumLicit.SelectedIndexChanged += new System.EventHandler(this.cmbNumLicit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Licitacion";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(4, 184);
            this.txtHeader.Multiline = true;
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(326, 130);
            this.txtHeader.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Encabezado de las Referencias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Folio de las Referencias:";
            this.label3.Visible = false;
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(4, 350);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(326, 22);
            this.txtFolio.TabIndex = 18;
            this.txtFolio.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(253, 329);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 20);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "No lleva";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(253, 164);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(77, 20);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "No lleva";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Reporte_Referencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlvReg);
            this.Controls.Add(this.pnlDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Reporte_Referencias";
            this.Size = new System.Drawing.Size(1210, 618);
            this.Load += new System.EventHandler(this.Reporte_Referencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlvReg)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.TreeListView tlvReg;
        private BrightIdeasSoftware.OLVColumn reqColumn;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.RadioButton radConc;
        private System.Windows.Forms.RadioButton radAct;
        private System.Windows.Forms.ComboBox cmbNumLicit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}
