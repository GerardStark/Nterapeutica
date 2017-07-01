namespace AppLicitaciones
{
    partial class Catalogos_traduccion_referencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogos_traduccion_referencias));
            this.DGV_Referencias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_terminos = new System.Windows.Forms.TextBox();
            this.cmb_filtros = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_cancelar = new System.Windows.Forms.ToolStripButton();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.chck_all = new System.Windows.Forms.CheckBox();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Referencias)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Referencias
            // 
            this.DGV_Referencias.AllowUserToAddRows = false;
            this.DGV_Referencias.AllowUserToDeleteRows = false;
            this.DGV_Referencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Referencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.claveColumn,
            this.descripcionColumn,
            this.unidadColumn,
            this.checkColumn});
            this.DGV_Referencias.Location = new System.Drawing.Point(12, 46);
            this.DGV_Referencias.Name = "DGV_Referencias";
            this.DGV_Referencias.Size = new System.Drawing.Size(813, 423);
            this.DGV_Referencias.TabIndex = 16;
            this.DGV_Referencias.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Referencias_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Filtrar:";
            // 
            // txt_terminos
            // 
            this.txt_terminos.Location = new System.Drawing.Point(219, 17);
            this.txt_terminos.Name = "txt_terminos";
            this.txt_terminos.Size = new System.Drawing.Size(315, 26);
            this.txt_terminos.TabIndex = 19;
            // 
            // cmb_filtros
            // 
            this.cmb_filtros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filtros.FormattingEnabled = true;
            this.cmb_filtros.Location = new System.Drawing.Point(92, 15);
            this.cmb_filtros.Name = "cmb_filtros";
            this.cmb_filtros.Size = new System.Drawing.Size(121, 28);
            this.cmb_filtros.TabIndex = 20;
            this.cmb_filtros.SelectedIndexChanged += new System.EventHandler(this.cmb_filtros_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cancelar,
            this.btn_guardar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 478);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(831, 57);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(54, 54);
            this.btn_cancelar.Text = "toolStripButton1";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(54, 54);
            this.btn_guardar.Text = "toolStripButton2";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(541, 15);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 28);
            this.btn_filtrar.TabIndex = 22;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // chck_all
            // 
            this.chck_all.AutoSize = true;
            this.chck_all.Location = new System.Drawing.Point(747, 18);
            this.chck_all.Name = "chck_all";
            this.chck_all.Size = new System.Drawing.Size(72, 24);
            this.chck_all.TabIndex = 23;
            this.chck_all.Text = "Todas";
            this.chck_all.UseVisualStyleBackColor = true;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "#";
            this.idColumn.Name = "idColumn";
            // 
            // claveColumn
            // 
            this.claveColumn.HeaderText = "Clave";
            this.claveColumn.Name = "claveColumn";
            // 
            // descripcionColumn
            // 
            this.descripcionColumn.HeaderText = "Descripcion";
            this.descripcionColumn.Name = "descripcionColumn";
            this.descripcionColumn.Width = 320;
            // 
            // unidadColumn
            // 
            this.unidadColumn.HeaderText = "Unidad";
            this.unidadColumn.Name = "unidadColumn";
            this.unidadColumn.Width = 150;
            // 
            // checkColumn
            // 
            this.checkColumn.HeaderText = "Seleccionar";
            this.checkColumn.Name = "checkColumn";
            this.checkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.checkColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Catalogos_traduccion_referencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 535);
            this.Controls.Add(this.chck_all);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmb_filtros);
            this.Controls.Add(this.txt_terminos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Referencias);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Catalogos_traduccion_referencias";
            this.Text = "Catalogos_traduccion_referencias";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Referencias)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Referencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_terminos;
        private System.Windows.Forms.ComboBox cmb_filtros;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_cancelar;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.CheckBox chck_all;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkColumn;
    }
}