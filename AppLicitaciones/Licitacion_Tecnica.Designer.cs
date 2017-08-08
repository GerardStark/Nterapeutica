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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licitacion_Tecnica));
            this.tree_items = new BrightIdeasSoftware.TreeListView();
            this.descColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.tree_items)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tree_items
            // 
            this.tree_items.AllColumns.Add(this.descColumn);
            this.tree_items.CellEditUseWholeCell = false;
            this.tree_items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.descColumn});
            this.tree_items.Location = new System.Drawing.Point(12, 76);
            this.tree_items.Name = "tree_items";
            this.tree_items.ShowGroups = false;
            this.tree_items.Size = new System.Drawing.Size(1090, 541);
            this.tree_items.TabIndex = 0;
            this.tree_items.UseCompatibleStateImageBehavior = false;
            this.tree_items.View = System.Windows.Forms.View.Details;
            this.tree_items.VirtualMode = true;
            // 
            // descColumn
            // 
            this.descColumn.Text = "Descripción";
            this.descColumn.Width = 550;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1114, 57);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Licitacion_Tecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 629);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tree_items);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Licitacion_Tecnica";
            this.Text = "Licitacion_Tecnica";
            ((System.ComponentModel.ISupportInitialize)(this.tree_items)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.TreeListView tree_items;
        private BrightIdeasSoftware.OLVColumn descColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}