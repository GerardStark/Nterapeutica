namespace AppLicitaciones
{
    partial class Licitacion_Tecnica
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
            this.objlistview_listado = new BrightIdeasSoftware.ObjectListView();
            this.descColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.subColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.itemColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cartaColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cucopColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objlistview_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // objlistview_listado
            // 
            this.objlistview_listado.AllColumns.Add(this.descColumn);
            this.objlistview_listado.AllColumns.Add(this.subColumn);
            this.objlistview_listado.AllColumns.Add(this.itemColumn);
            this.objlistview_listado.AllColumns.Add(this.cartaColumn);
            this.objlistview_listado.AllColumns.Add(this.cucopColumn);
            this.objlistview_listado.CellEditUseWholeCell = false;
            this.objlistview_listado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.descColumn,
            this.subColumn,
            this.itemColumn,
            this.cartaColumn,
            this.cucopColumn});
            this.objlistview_listado.Cursor = System.Windows.Forms.Cursors.Default;
            this.objlistview_listado.Location = new System.Drawing.Point(12, 12);
            this.objlistview_listado.Name = "objlistview_listado";
            this.objlistview_listado.Size = new System.Drawing.Size(870, 579);
            this.objlistview_listado.TabIndex = 0;
            this.objlistview_listado.UseCompatibleStateImageBehavior = false;
            this.objlistview_listado.View = System.Windows.Forms.View.Details;
            // 
            // descColumn
            // 
            this.descColumn.Text = "Partida";
            this.descColumn.Width = 63;
            // 
            // subColumn
            // 
            this.subColumn.Text = "Subpartida/Procedimiento";
            this.subColumn.Width = 170;
            // 
            // itemColumn
            // 
            this.itemColumn.Text = "Items Requeridos";
            this.itemColumn.Width = 246;
            // 
            // cartaColumn
            // 
            this.cartaColumn.Text = "Carta de apoyo";
            this.cartaColumn.Width = 111;
            // 
            // cucopColumn
            // 
            this.cucopColumn.Text = "Item Ofertado";
            this.cucopColumn.Width = 272;
            // 
            // Licitacion_Tecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 603);
            this.Controls.Add(this.objlistview_listado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Licitacion_Tecnica";
            this.Text = "Licitacion_Tecnica";
            ((System.ComponentModel.ISupportInitialize)(this.objlistview_listado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objlistview_listado;
        private BrightIdeasSoftware.OLVColumn descColumn;
        private BrightIdeasSoftware.OLVColumn subColumn;
        private BrightIdeasSoftware.OLVColumn itemColumn;
        private BrightIdeasSoftware.OLVColumn cartaColumn;
        private BrightIdeasSoftware.OLVColumn cucopColumn;
    }
}