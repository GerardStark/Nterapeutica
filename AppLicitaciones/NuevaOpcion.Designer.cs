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
            this.txt_nombre_prod = new System.Windows.Forms.TextBox();
            this.btn_cert_vincular = new System.Windows.Forms.Button();
            this.btm_cat_vincular = new System.Windows.Forms.Button();
            this.btn_reg_vincular = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cambiar_nombre = new System.Windows.Forms.Button();
            this.list_vinc_reg = new System.Windows.Forms.DataGridView();
            this.datColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_vinc_cat = new System.Windows.Forms.DataGridView();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_vinc_cert = new System.Windows.Forms.DataGridView();
            this.numeroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_selectCarta = new System.Windows.Forms.Button();
            this.txt_carta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.list_vinc_reg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_vinc_cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_vinc_cert)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre_prod
            // 
            this.txt_nombre_prod.Location = new System.Drawing.Point(263, 42);
            this.txt_nombre_prod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nombre_prod.Name = "txt_nombre_prod";
            this.txt_nombre_prod.Size = new System.Drawing.Size(480, 26);
            this.txt_nombre_prod.TabIndex = 179;
            this.txt_nombre_prod.TextChanged += new System.EventHandler(this.txt_nombre_prod_TextChanged);
            // 
            // btn_cert_vincular
            // 
            this.btn_cert_vincular.Location = new System.Drawing.Point(911, 469);
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
            this.btm_cat_vincular.Location = new System.Drawing.Point(516, 469);
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
            this.btn_reg_vincular.Location = new System.Drawing.Point(116, 469);
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
            this.label7.Location = new System.Drawing.Point(518, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 20);
            this.label7.TabIndex = 175;
            this.label7.Text = "Catálogos de Productos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(919, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 174;
            this.label6.Text = "Certificados de Calidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 173;
            this.label5.Text = "Registros Sanitario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 172;
            this.label2.Text = "Nombre Producto:";
            // 
            // btn_cambiar_nombre
            // 
            this.btn_cambiar_nombre.Enabled = false;
            this.btn_cambiar_nombre.Location = new System.Drawing.Point(752, 42);
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
            this.list_vinc_reg.Location = new System.Drawing.Point(40, 155);
            this.list_vinc_reg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_vinc_reg.Name = "list_vinc_reg";
            this.list_vinc_reg.ReadOnly = true;
            this.list_vinc_reg.RowHeadersVisible = false;
            this.list_vinc_reg.Size = new System.Drawing.Size(335, 306);
            this.list_vinc_reg.TabIndex = 186;
            // 
            // datColumn
            // 
            this.datColumn.HeaderText = "Numero de Registro:";
            this.datColumn.Name = "datColumn";
            this.datColumn.ReadOnly = true;
            this.datColumn.Width = 330;
            // 
            // list_vinc_cat
            // 
            this.list_vinc_cat.AllowUserToAddRows = false;
            this.list_vinc_cat.AllowUserToDeleteRows = false;
            this.list_vinc_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_vinc_cat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreColumn});
            this.list_vinc_cat.Location = new System.Drawing.Point(441, 155);
            this.list_vinc_cat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_vinc_cat.Name = "list_vinc_cat";
            this.list_vinc_cat.ReadOnly = true;
            this.list_vinc_cat.RowHeadersVisible = false;
            this.list_vinc_cat.Size = new System.Drawing.Size(334, 306);
            this.list_vinc_cat.TabIndex = 187;
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre del Catalogo";
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.ReadOnly = true;
            this.nombreColumn.Width = 330;
            // 
            // list_vinc_cert
            // 
            this.list_vinc_cert.AllowUserToAddRows = false;
            this.list_vinc_cert.AllowUserToDeleteRows = false;
            this.list_vinc_cert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_vinc_cert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroColumn});
            this.list_vinc_cert.Location = new System.Drawing.Point(836, 155);
            this.list_vinc_cert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_vinc_cert.Name = "list_vinc_cert";
            this.list_vinc_cert.ReadOnly = true;
            this.list_vinc_cert.RowHeadersVisible = false;
            this.list_vinc_cert.Size = new System.Drawing.Size(334, 306);
            this.list_vinc_cert.TabIndex = 188;
            // 
            // numeroColumn
            // 
            this.numeroColumn.HeaderText = "Numero/Id del Certificado:";
            this.numeroColumn.Name = "numeroColumn";
            this.numeroColumn.ReadOnly = true;
            this.numeroColumn.Width = 330;
            // 
            // btn_selectCarta
            // 
            this.btn_selectCarta.Location = new System.Drawing.Point(548, 78);
            this.btn_selectCarta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_selectCarta.Name = "btn_selectCarta";
            this.btn_selectCarta.Size = new System.Drawing.Size(112, 26);
            this.btn_selectCarta.TabIndex = 191;
            this.btn_selectCarta.Text = "Seleccionar";
            this.btn_selectCarta.UseVisualStyleBackColor = true;
            this.btn_selectCarta.Click += new System.EventHandler(this.btn_selectCarta_Click);
            // 
            // txt_carta
            // 
            this.txt_carta.Location = new System.Drawing.Point(263, 78);
            this.txt_carta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_carta.Name = "txt_carta";
            this.txt_carta.ReadOnly = true;
            this.txt_carta.Size = new System.Drawing.Size(277, 26);
            this.txt_carta.TabIndex = 190;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 189;
            this.label1.Text = "Carta de Apoyo:";
            // 
            // NuevaOpcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_selectCarta);
            this.Controls.Add(this.txt_carta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_vinc_cert);
            this.Controls.Add(this.list_vinc_cat);
            this.Controls.Add(this.list_vinc_reg);
            this.Controls.Add(this.btn_cambiar_nombre);
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
        private System.Windows.Forms.Button btn_cambiar_nombre;
        private System.Windows.Forms.DataGridView list_vinc_reg;
        private System.Windows.Forms.DataGridView list_vinc_cat;
        private System.Windows.Forms.DataGridView list_vinc_cert;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroColumn;
        private System.Windows.Forms.Button btn_selectCarta;
        private System.Windows.Forms.TextBox txt_carta;
        private System.Windows.Forms.Label label1;
    }
}
