namespace AppLicitaciones
{
    partial class FTD_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTD_Principal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btn_contactos = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btn_cancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btn_seleccionar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mayorista = new System.Windows.Forms.TextBox();
            this.txt_apoyo = new System.Windows.Forms.TextBox();
            this.DGV_FTD = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apoyoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mayoristaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_FTD)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.toolStripLabel2,
            this.btn_contactos,
            this.toolStripLabel5,
            this.toolStripLabel6,
            this.btn_cancelar,
            this.toolStripLabel4,
            this.btn_seleccionar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(68, 639);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_guardar
            // 
            this.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 54);
            this.btn_guardar.Text = "toolStripButton2";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(65, 15);
            this.toolStripLabel2.Text = "Guardar";
            // 
            // btn_contactos
            // 
            this.btn_contactos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_contactos.Image = ((System.Drawing.Image)(resources.GetObject("btn_contactos.Image")));
            this.btn_contactos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_contactos.Name = "btn_contactos";
            this.btn_contactos.Size = new System.Drawing.Size(65, 54);
            this.btn_contactos.Text = "toolStripButton5";
            this.btn_contactos.Click += new System.EventHandler(this.btn_contactos_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(65, 15);
            this.toolStripLabel5.Text = "Contactos";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(65, 15);
            this.toolStripLabel6.Text = "Cancelar";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 54);
            this.btn_cancelar.Text = "toolStripButton1";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(65, 15);
            this.toolStripLabel4.Text = "Seleccionar";
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_seleccionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_seleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btn_seleccionar.Image")));
            this.btn_seleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(65, 54);
            this.btn_seleccionar.Text = "toolStripButton4";
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(263, 12);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(226, 26);
            this.txt_nombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Apoyo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distribuidor Mayorista";
            // 
            // txt_mayorista
            // 
            this.txt_mayorista.Location = new System.Drawing.Point(263, 85);
            this.txt_mayorista.Name = "txt_mayorista";
            this.txt_mayorista.Size = new System.Drawing.Size(226, 26);
            this.txt_mayorista.TabIndex = 5;
            // 
            // txt_apoyo
            // 
            this.txt_apoyo.Location = new System.Drawing.Point(263, 48);
            this.txt_apoyo.Name = "txt_apoyo";
            this.txt_apoyo.Size = new System.Drawing.Size(226, 26);
            this.txt_apoyo.TabIndex = 6;
            // 
            // DGV_FTD
            // 
            this.DGV_FTD.AllowUserToAddRows = false;
            this.DGV_FTD.AllowUserToDeleteRows = false;
            this.DGV_FTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_FTD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nombreColumn,
            this.apoyoColumn,
            this.mayoristaColumn});
            this.DGV_FTD.Location = new System.Drawing.Point(71, 117);
            this.DGV_FTD.Name = "DGV_FTD";
            this.DGV_FTD.ReadOnly = true;
            this.DGV_FTD.Size = new System.Drawing.Size(544, 510);
            this.DGV_FTD.TabIndex = 7;
            this.DGV_FTD.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_FTD_RowHeaderMouseClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "#";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre";
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.ReadOnly = true;
            this.nombreColumn.Width = 130;
            // 
            // apoyoColumn
            // 
            this.apoyoColumn.HeaderText = "Tipo de Apoyo";
            this.apoyoColumn.Name = "apoyoColumn";
            this.apoyoColumn.ReadOnly = true;
            this.apoyoColumn.Width = 120;
            // 
            // mayoristaColumn
            // 
            this.mayoristaColumn.HeaderText = "Distribuidor Mayorista";
            this.mayoristaColumn.Name = "mayoristaColumn";
            this.mayoristaColumn.ReadOnly = true;
            this.mayoristaColumn.Width = 150;
            // 
            // FTD_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 639);
            this.Controls.Add(this.DGV_FTD);
            this.Controls.Add(this.txt_apoyo);
            this.Controls.Add(this.txt_mayorista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FTD_Principal";
            this.Text = "Panel Principal de Fabricantes, Titulares y Distribuidores Mayoristas";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_FTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mayorista;
        private System.Windows.Forms.TextBox txt_apoyo;
        private System.Windows.Forms.DataGridView DGV_FTD;
        private System.Windows.Forms.ToolStripButton btn_seleccionar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btn_contactos;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apoyoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mayoristaColumn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton btn_cancelar;
    }
}