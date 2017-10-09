namespace AppLicitaciones
{
    partial class Registros_Prorrogas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros_Prorrogas));
            this.DGV_Referencias = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archivoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btn_editar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btn_eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.date_tramite = new System.Windows.Forms.DateTimePicker();
            this.btn_archivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_archivo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Referencias)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Referencias
            // 
            this.DGV_Referencias.AllowUserToAddRows = false;
            this.DGV_Referencias.AllowUserToDeleteRows = false;
            this.DGV_Referencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Referencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Referencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.numeroColumn,
            this.fechaColumn,
            this.archivoColumn});
            this.DGV_Referencias.Location = new System.Drawing.Point(58, 154);
            this.DGV_Referencias.Name = "DGV_Referencias";
            this.DGV_Referencias.ReadOnly = true;
            this.DGV_Referencias.Size = new System.Drawing.Size(546, 510);
            this.DGV_Referencias.TabIndex = 3;
            this.DGV_Referencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Referencias_CellClick);
            this.DGV_Referencias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Referencias_CellDoubleClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "#";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // numeroColumn
            // 
            this.numeroColumn.HeaderText = "Numero";
            this.numeroColumn.Name = "numeroColumn";
            this.numeroColumn.ReadOnly = true;
            this.numeroColumn.Width = 200;
            // 
            // fechaColumn
            // 
            this.fechaColumn.HeaderText = "Fecha Emision";
            this.fechaColumn.Name = "fechaColumn";
            this.fechaColumn.ReadOnly = true;
            this.fechaColumn.Width = 200;
            // 
            // archivoColumn
            // 
            this.archivoColumn.HeaderText = "Archivo";
            this.archivoColumn.Name = "archivoColumn";
            this.archivoColumn.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.toolStripLabel2,
            this.btn_editar,
            this.toolStripLabel4,
            this.btn_eliminar,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(55, 676);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_guardar
            // 
            this.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(52, 54);
            this.btn_guardar.Text = "toolStripButton2";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(52, 15);
            this.toolStripLabel2.Text = "Nuevo";
            // 
            // btn_editar
            // 
            this.btn_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(52, 54);
            this.btn_editar.Text = "toolStripButton5";
            this.btn_editar.ToolTipText = "Editar";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(52, 15);
            this.toolStripLabel4.Text = "Editar";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(52, 54);
            this.btn_eliminar.Text = "toolStripButton3";
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(52, 15);
            this.toolStripLabel3.Text = "Eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero de Tramite:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(58, 38);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(254, 26);
            this.txt_numero.TabIndex = 5;
            // 
            // date_tramite
            // 
            this.date_tramite.Location = new System.Drawing.Point(337, 38);
            this.date_tramite.Name = "date_tramite";
            this.date_tramite.Size = new System.Drawing.Size(267, 26);
            this.date_tramite.TabIndex = 6;
            // 
            // btn_archivo
            // 
            this.btn_archivo.Location = new System.Drawing.Point(58, 97);
            this.btn_archivo.Name = "btn_archivo";
            this.btn_archivo.Size = new System.Drawing.Size(122, 31);
            this.btn_archivo.TabIndex = 7;
            this.btn_archivo.Text = "Cambiar";
            this.btn_archivo.UseVisualStyleBackColor = true;
            this.btn_archivo.Click += new System.EventHandler(this.btn_archivo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha del tramite:";
            // 
            // lbl_archivo
            // 
            this.lbl_archivo.AutoSize = true;
            this.lbl_archivo.Location = new System.Drawing.Point(58, 131);
            this.lbl_archivo.Name = "lbl_archivo";
            this.lbl_archivo.Size = new System.Drawing.Size(48, 20);
            this.lbl_archivo.TabIndex = 9;
            this.lbl_archivo.Text = "Label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Archivo";
            // 
            // btn_ver
            // 
            this.btn_ver.Location = new System.Drawing.Point(187, 97);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(114, 31);
            this.btn_ver.TabIndex = 11;
            this.btn_ver.Text = "Ver";
            this.btn_ver.UseVisualStyleBackColor = true;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // Registros_Prorrogas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 676);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_archivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_archivo);
            this.Controls.Add(this.date_tramite);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Referencias);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Registros_Prorrogas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros_Prorrogas";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Referencias)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Referencias;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btn_editar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btn_eliminar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.DateTimePicker date_tramite;
        private System.Windows.Forms.Button btn_archivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_archivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ver;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn archivoColumn;
    }
}