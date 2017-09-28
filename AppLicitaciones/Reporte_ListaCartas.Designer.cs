namespace AppLicitaciones
{
    partial class Reporte_ListaCartas
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
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.radConc = new System.Windows.Forms.RadioButton();
            this.radAct = new System.Windows.Forms.RadioButton();
            this.cmbNumLicit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tlvCartas = new BrightIdeasSoftware.TreeListView();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlvCartas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.Controls.Add(this.button1);
            this.pnlDatos.Controls.Add(this.btnImprimir);
            this.pnlDatos.Controls.Add(this.radConc);
            this.pnlDatos.Controls.Add(this.radAct);
            this.pnlDatos.Controls.Add(this.cmbNumLicit);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Location = new System.Drawing.Point(4, 4);
            this.pnlDatos.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(254, 611);
            this.pnlDatos.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AppLicitaciones.Iconos.printer;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(198, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.imprimir);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::AppLicitaciones.Iconos.printer;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Location = new System.Drawing.Point(265, 679);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(67, 62);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // radConc
            // 
            this.radConc.AutoSize = true;
            this.radConc.Location = new System.Drawing.Point(113, 11);
            this.radConc.Margin = new System.Windows.Forms.Padding(4);
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
            this.radAct.Location = new System.Drawing.Point(9, 11);
            this.radAct.Margin = new System.Windows.Forms.Padding(4);
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
            this.cmbNumLicit.Location = new System.Drawing.Point(11, 70);
            this.cmbNumLicit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNumLicit.Name = "cmbNumLicit";
            this.cmbNumLicit.Size = new System.Drawing.Size(237, 24);
            this.cmbNumLicit.TabIndex = 3;
            this.cmbNumLicit.SelectedIndexChanged += new System.EventHandler(this.cmbNumLicit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Licitacion";
            // 
            // nombreColumn
            // 
            this.nombreColumn.AspectName = "Nombre";
            this.nombreColumn.Text = "Nombre de la Carta/Item";
            this.nombreColumn.Width = 855;
            // 
            // tlvCartas
            // 
            this.tlvCartas.AllColumns.Add(this.nombreColumn);
            this.tlvCartas.CellEditUseWholeCell = false;
            this.tlvCartas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombreColumn});
            this.tlvCartas.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlvCartas.Location = new System.Drawing.Point(266, 4);
            this.tlvCartas.Margin = new System.Windows.Forms.Padding(4);
            this.tlvCartas.Name = "tlvCartas";
            this.tlvCartas.ShowGroups = false;
            this.tlvCartas.Size = new System.Drawing.Size(940, 613);
            this.tlvCartas.TabIndex = 2;
            this.tlvCartas.UseCompatibleStateImageBehavior = false;
            this.tlvCartas.View = System.Windows.Forms.View.Details;
            this.tlvCartas.VirtualMode = true;
            // 
            // Reporte_ListaCartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlvCartas);
            this.Controls.Add(this.pnlDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reporte_ListaCartas";
            this.Size = new System.Drawing.Size(1210, 621);
            this.Load += new System.EventHandler(this.Reporte_ListaCartas_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlvCartas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.RadioButton radConc;
        private System.Windows.Forms.RadioButton radAct;
        private System.Windows.Forms.ComboBox cmbNumLicit;
        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.OLVColumn nombreColumn;
        private BrightIdeasSoftware.TreeListView tlvCartas;
        private System.Windows.Forms.Button button1;
    }
}
