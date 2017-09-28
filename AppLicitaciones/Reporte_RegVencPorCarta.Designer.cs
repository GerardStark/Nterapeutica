namespace AppLicitaciones
{
    partial class Reporte_RegVencPorCarta
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
            this.treeListView1 = new BrightIdeasSoftware.TreeListView();
            this.reqColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
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
            this.pnlDatos.TabIndex = 2;
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
            this.radConc.Size = new System.Drawing.Size(77, 17);
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
            this.radAct.Size = new System.Drawing.Size(80, 17);
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
            this.cmbNumLicit.Size = new System.Drawing.Size(237, 21);
            this.cmbNumLicit.TabIndex = 3;
            this.cmbNumLicit.SelectedIndexChanged += new System.EventHandler(this.cmbNumLicit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Licitacion";
            // 
            // treeListView1
            // 
            this.treeListView1.AllColumns.Add(this.reqColumn);
            this.treeListView1.CellEditUseWholeCell = false;
            this.treeListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reqColumn});
            this.treeListView1.Location = new System.Drawing.Point(260, 4);
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.ShowGroups = false;
            this.treeListView1.Size = new System.Drawing.Size(947, 614);
            this.treeListView1.TabIndex = 3;
            this.treeListView1.UseCompatibleStateImageBehavior = false;
            this.treeListView1.View = System.Windows.Forms.View.Details;
            this.treeListView1.VirtualMode = true;
            // 
            // reqColumn
            // 
            this.reqColumn.AspectName = "Nombre";
            this.reqColumn.Text = "Descripcion";
            // 
            // Reporte_RegVencPorCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeListView1);
            this.Controls.Add(this.pnlDatos);
            this.Name = "Reporte_RegVencPorCarta";
            this.Size = new System.Drawing.Size(1210, 618);
            this.Load += new System.EventHandler(this.Reporte_RegVencPorCarta_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.RadioButton radConc;
        private System.Windows.Forms.RadioButton radAct;
        private System.Windows.Forms.ComboBox cmbNumLicit;
        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.TreeListView treeListView1;
        private BrightIdeasSoftware.OLVColumn reqColumn;
    }
}
