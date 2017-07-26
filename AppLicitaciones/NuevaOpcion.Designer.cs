namespace AppLicitaciones
{
    partial class NuevaOpcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaOpcion));
            this.txt_nombre_prod = new System.Windows.Forms.TextBox();
            this.btn_cert_vincular = new System.Windows.Forms.Button();
            this.btm_cat_vincular = new System.Windows.Forms.Button();
            this.btn_reg_vincular = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_id_vinculo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_borrar = new System.Windows.Forms.ToolStripButton();
            this.btn_cambiar_nombre = new System.Windows.Forms.Button();
            this.list_vinc_reg = new System.Windows.Forms.DataGridView();
            this.list_vinc_cat = new System.Windows.Forms.DataGridView();
            this.list_vinc_cert = new System.Windows.Forms.DataGridView();
            this.datColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_vinc_reg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_vinc_cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_vinc_cert)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre_prod
            // 
            this.txt_nombre_prod.Location = new System.Drawing.Point(247, 26);
            this.txt_nombre_prod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nombre_prod.Name = "txt_nombre_prod";
            this.txt_nombre_prod.Size = new System.Drawing.Size(480, 26);
            this.txt_nombre_prod.TabIndex = 179;
            this.txt_nombre_prod.TextChanged += new System.EventHandler(this.txt_nombre_prod_TextChanged);
            // 
            // btn_cert_vincular
            // 
            this.btn_cert_vincular.Location = new System.Drawing.Point(895, 409);
            this.btn_cert_vincular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cert_vincular.Name = "btn_cert_vincular";
            this.btn_cert_vincular.Size = new System.Drawing.Size(184, 49);
            this.btn_cert_vincular.TabIndex = 178;
            this.btn_cert_vincular.Text = "Cambiar";
            this.btn_cert_vincular.UseVisualStyleBackColor = true;
            this.btn_cert_vincular.Click += new System.EventHandler(this.btn_cert_vincular_Click);
            // 
            // btm_cat_vincular
            // 
            this.btm_cat_vincular.Location = new System.Drawing.Point(500, 409);
            this.btm_cat_vincular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btm_cat_vincular.Name = "btm_cat_vincular";
            this.btm_cat_vincular.Size = new System.Drawing.Size(184, 49);
            this.btm_cat_vincular.TabIndex = 177;
            this.btm_cat_vincular.Text = "Cambiar";
            this.btm_cat_vincular.UseVisualStyleBackColor = true;
            this.btm_cat_vincular.Click += new System.EventHandler(this.btm_cat_vincular_Click);
            // 
            // btn_reg_vincular
            // 
            this.btn_reg_vincular.Location = new System.Drawing.Point(100, 409);
            this.btn_reg_vincular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_reg_vincular.Name = "btn_reg_vincular";
            this.btn_reg_vincular.Size = new System.Drawing.Size(184, 49);
            this.btn_reg_vincular.TabIndex = 176;
            this.btn_reg_vincular.Text = "Cambiar";
            this.btn_reg_vincular.UseVisualStyleBackColor = true;
            this.btn_reg_vincular.Click += new System.EventHandler(this.btn_reg_vincular_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 20);
            this.label7.TabIndex = 175;
            this.label7.Text = "Catálogos de Productos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(903, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 174;
            this.label6.Text = "Certificados de Calidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 173;
            this.label5.Text = "Registros Sanitario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 172;
            this.label2.Text = "Nombre Producto:";
            // 
            // lbl_id_vinculo
            // 
            this.lbl_id_vinculo.AutoSize = true;
            this.lbl_id_vinculo.Location = new System.Drawing.Point(21, 31);
            this.lbl_id_vinculo.Name = "lbl_id_vinculo";
            this.lbl_id_vinculo.Size = new System.Drawing.Size(51, 20);
            this.lbl_id_vinculo.TabIndex = 183;
            this.lbl_id_vinculo.Text = "label1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_borrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 512);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1222, 57);
            this.toolStrip1.TabIndex = 184;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_borrar
            // 
            this.btn_borrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_borrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_borrar.Image")));
            this.btn_borrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(54, 54);
            this.btn_borrar.Text = "toolStripButton1";
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_cambiar_nombre
            // 
            this.btn_cambiar_nombre.Enabled = false;
            this.btn_cambiar_nombre.Location = new System.Drawing.Point(735, 26);
            this.btn_cambiar_nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cambiar_nombre.Name = "btn_cambiar_nombre";
            this.btn_cambiar_nombre.Size = new System.Drawing.Size(97, 26);
            this.btn_cambiar_nombre.TabIndex = 185;
            this.btn_cambiar_nombre.Text = "Guardar";
            this.btn_cambiar_nombre.UseVisualStyleBackColor = true;
            this.btn_cambiar_nombre.Click += new System.EventHandler(this.btn_cambiar_nombre_Click);
            // 
            // list_vinc_reg
            // 
            this.list_vinc_reg.AllowUserToAddRows = false;
            this.list_vinc_reg.AllowUserToDeleteRows = false;
            this.list_vinc_reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_vinc_reg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datColumn});
            this.list_vinc_reg.Location = new System.Drawing.Point(25, 95);
            this.list_vinc_reg.Name = "list_vinc_reg";
            this.list_vinc_reg.ReadOnly = true;
            this.list_vinc_reg.RowHeadersVisible = false;
            this.list_vinc_reg.Size = new System.Drawing.Size(335, 306);
            this.list_vinc_reg.TabIndex = 186;
            // 
            // list_vinc_cat
            // 
            this.list_vinc_cat.AllowUserToAddRows = false;
            this.list_vinc_cat.AllowUserToDeleteRows = false;
            this.list_vinc_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_vinc_cat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreColumn});
            this.list_vinc_cat.Location = new System.Drawing.Point(425, 95);
            this.list_vinc_cat.Name = "list_vinc_cat";
            this.list_vinc_cat.ReadOnly = true;
            this.list_vinc_cat.RowHeadersVisible = false;
            this.list_vinc_cat.Size = new System.Drawing.Size(334, 306);
            this.list_vinc_cat.TabIndex = 187;
            // 
            // list_vinc_cert
            // 
            this.list_vinc_cert.AllowUserToAddRows = false;
            this.list_vinc_cert.AllowUserToDeleteRows = false;
            this.list_vinc_cert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_vinc_cert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroColumn});
            this.list_vinc_cert.Location = new System.Drawing.Point(820, 95);
            this.list_vinc_cert.Name = "list_vinc_cert";
            this.list_vinc_cert.ReadOnly = true;
            this.list_vinc_cert.RowHeadersVisible = false;
            this.list_vinc_cert.Size = new System.Drawing.Size(334, 306);
            this.list_vinc_cert.TabIndex = 188;
            // 
            // datColumn
            // 
            this.datColumn.HeaderText = "Numero de Registro:";
            this.datColumn.Name = "datColumn";
            this.datColumn.ReadOnly = true;
            this.datColumn.Width = 330;
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre del Catalogo";
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.ReadOnly = true;
            this.nombreColumn.Width = 330;
            // 
            // numeroColumn
            // 
            this.numeroColumn.HeaderText = "Numero/Id del Certificado:";
            this.numeroColumn.Name = "numeroColumn";
            this.numeroColumn.ReadOnly = true;
            this.numeroColumn.Width = 330;
            // 
            // NuevaOpcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.list_vinc_cert);
            this.Controls.Add(this.list_vinc_cat);
            this.Controls.Add(this.list_vinc_reg);
            this.Controls.Add(this.btn_cambiar_nombre);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbl_id_vinculo);
            this.Controls.Add(this.txt_nombre_prod);
            this.Controls.Add(this.btn_cert_vincular);
            this.Controls.Add(this.btm_cat_vincular);
            this.Controls.Add(this.btn_reg_vincular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NuevaOpcion";
            this.Size = new System.Drawing.Size(1222, 569);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_vinc_reg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_vinc_cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_vinc_cert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_nombre_prod;
        private System.Windows.Forms.Button btn_cert_vincular;
        private System.Windows.Forms.Button btm_cat_vincular;
        private System.Windows.Forms.Button btn_reg_vincular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_id_vinculo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_borrar;
        private System.Windows.Forms.Button btn_cambiar_nombre;
        private System.Windows.Forms.DataGridView list_vinc_reg;
        private System.Windows.Forms.DataGridView list_vinc_cat;
        private System.Windows.Forms.DataGridView list_vinc_cert;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroColumn;
    }
}
