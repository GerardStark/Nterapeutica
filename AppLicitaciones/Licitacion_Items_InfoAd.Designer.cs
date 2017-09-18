namespace AppLicitaciones
{
    partial class Licitacion_Items_InfoAd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licitacion_Items_InfoAd));
            this.tt_reg_editar = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_borrar = new System.Windows.Forms.ToolStripButton();
            this.btn_editar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInfos = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt_reg_editar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfos)).BeginInit();
            this.SuspendLayout();
            // 
            // tt_reg_editar
            // 
            this.tt_reg_editar.Dock = System.Windows.Forms.DockStyle.Left;
            this.tt_reg_editar.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tt_reg_editar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.btn_borrar,
            this.btn_editar});
            this.tt_reg_editar.Location = new System.Drawing.Point(0, 0);
            this.tt_reg_editar.Name = "tt_reg_editar";
            this.tt_reg_editar.Size = new System.Drawing.Size(45, 536);
            this.tt_reg_editar.TabIndex = 88;
            this.tt_reg_editar.Text = "Menú";
            // 
            // btn_guardar
            // 
            this.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(42, 44);
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.ToolTipText = "OK";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_borrar.Image = global::AppLicitaciones.Iconos.close_round;
            this.btn_borrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(42, 44);
            this.btn_borrar.Text = "toolStripButton1";
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_editar.Image = global::AppLicitaciones.Iconos.edit;
            this.btn_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(42, 44);
            this.btn_editar.Text = "toolStripButton1";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "Nombre del Atributo:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(189, 12);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(220, 22);
            this.txt_nombre.TabIndex = 90;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(189, 40);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(220, 22);
            this.txt_valor.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 92;
            this.label2.Text = "Valor:";
            // 
            // dgvInfos
            // 
            this.dgvInfos.AllowUserToAddRows = false;
            this.dgvInfos.AllowUserToDeleteRows = false;
            this.dgvInfos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInfos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nombreColumn,
            this.valorColumn});
            this.dgvInfos.Location = new System.Drawing.Point(56, 77);
            this.dgvInfos.MultiSelect = false;
            this.dgvInfos.Name = "dgvInfos";
            this.dgvInfos.ReadOnly = true;
            this.dgvInfos.RowHeadersVisible = false;
            this.dgvInfos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfos.Size = new System.Drawing.Size(353, 447);
            this.dgvInfos.TabIndex = 93;
            this.dgvInfos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfos_CellClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "#";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 50;
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre";
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.ReadOnly = true;
            this.nombreColumn.Width = 175;
            // 
            // valorColumn
            // 
            this.valorColumn.HeaderText = "Valor";
            this.valorColumn.Name = "valorColumn";
            this.valorColumn.ReadOnly = true;
            this.valorColumn.Width = 125;
            // 
            // Licitacion_Items_InfoAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 536);
            this.Controls.Add(this.dgvInfos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tt_reg_editar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Licitacion_Items_InfoAd";
            this.Text = "Licitacion_Items_InfoAd";
            this.tt_reg_editar.ResumeLayout(false);
            this.tt_reg_editar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tt_reg_editar;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripButton btn_borrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInfos;
        private System.Windows.Forms.ToolStripButton btn_editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorColumn;
    }
}