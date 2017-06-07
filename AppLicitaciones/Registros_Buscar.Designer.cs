namespace AppLicitaciones
{
    partial class Registros_Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros_Buscar));
            this.lbl_tlc = new System.Windows.Forms.Label();
            this.lbl_nacionalidad = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_fabricante = new System.Windows.Forms.Label();
            this.lbl_generica = new System.Windows.Forms.Label();
            this.lbl_distintiva = new System.Windows.Forms.Label();
            this.lbl_titular = new System.Windows.Forms.Label();
            this.lbl_solicitud = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_buscar_numero = new System.Windows.Forms.TextBox();
            this.txt_buscar_solicitud = new System.Windows.Forms.TextBox();
            this.txt_buscar_titular = new System.Windows.Forms.TextBox();
            this.txt_buscar_marca = new System.Windows.Forms.TextBox();
            this.txt_buscar_nacionalidad = new System.Windows.Forms.TextBox();
            this.txt_buscar_tlc = new System.Windows.Forms.TextBox();
            this.txt_buscar_distintiva = new System.Windows.Forms.TextBox();
            this.txt_buscar_generica = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_reg_buscar = new System.Windows.Forms.ToolStripButton();
            this.btn_buscar_cancelar = new System.Windows.Forms.ToolStripButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_buscar_fabricante = new System.Windows.Forms.ComboBox();
            this.cmb_opciones_buscqueda = new System.Windows.Forms.ComboBox();
            this.licitacionesDataSet = new AppLicitaciones.LicitacionesDataSet();
            this.fabricantestitularesdistribuidoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fabricantes_titulares_distribuidoresTableAdapter = new AppLicitaciones.LicitacionesDataSetTableAdapters.fabricantes_titulares_distribuidoresTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricantestitularesdistribuidoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tlc
            // 
            this.lbl_tlc.AutoSize = true;
            this.lbl_tlc.Location = new System.Drawing.Point(146, 106);
            this.lbl_tlc.Name = "lbl_tlc";
            this.lbl_tlc.Size = new System.Drawing.Size(42, 20);
            this.lbl_tlc.TabIndex = 82;
            this.lbl_tlc.Text = "TLC:";
            this.lbl_tlc.Visible = false;
            // 
            // lbl_nacionalidad
            // 
            this.lbl_nacionalidad.AutoSize = true;
            this.lbl_nacionalidad.Location = new System.Drawing.Point(83, 106);
            this.lbl_nacionalidad.Name = "lbl_nacionalidad";
            this.lbl_nacionalidad.Size = new System.Drawing.Size(104, 20);
            this.lbl_nacionalidad.TabIndex = 81;
            this.lbl_nacionalidad.Text = "Nacionalidad:";
            this.lbl_nacionalidad.Visible = false;
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(131, 106);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(57, 20);
            this.lbl_marca.TabIndex = 80;
            this.lbl_marca.Text = "Marca:";
            this.lbl_marca.Visible = false;
            // 
            // lbl_fabricante
            // 
            this.lbl_fabricante.AutoSize = true;
            this.lbl_fabricante.Location = new System.Drawing.Point(98, 106);
            this.lbl_fabricante.Name = "lbl_fabricante";
            this.lbl_fabricante.Size = new System.Drawing.Size(89, 20);
            this.lbl_fabricante.TabIndex = 79;
            this.lbl_fabricante.Text = "Fabricante:";
            this.lbl_fabricante.Visible = false;
            // 
            // lbl_generica
            // 
            this.lbl_generica.AutoSize = true;
            this.lbl_generica.Location = new System.Drawing.Point(6, 106);
            this.lbl_generica.Name = "lbl_generica";
            this.lbl_generica.Size = new System.Drawing.Size(184, 20);
            this.lbl_generica.TabIndex = 78;
            this.lbl_generica.Text = "Denominacion Generica:";
            this.lbl_generica.Visible = false;
            // 
            // lbl_distintiva
            // 
            this.lbl_distintiva.AutoSize = true;
            this.lbl_distintiva.Location = new System.Drawing.Point(6, 107);
            this.lbl_distintiva.Name = "lbl_distintiva";
            this.lbl_distintiva.Size = new System.Drawing.Size(183, 20);
            this.lbl_distintiva.TabIndex = 77;
            this.lbl_distintiva.Text = "Denominacion Distintiva:";
            this.lbl_distintiva.Visible = false;
            // 
            // lbl_titular
            // 
            this.lbl_titular.AutoSize = true;
            this.lbl_titular.Location = new System.Drawing.Point(131, 107);
            this.lbl_titular.Name = "lbl_titular";
            this.lbl_titular.Size = new System.Drawing.Size(56, 20);
            this.lbl_titular.TabIndex = 76;
            this.lbl_titular.Text = "Titular:";
            this.lbl_titular.Visible = false;
            // 
            // lbl_solicitud
            // 
            this.lbl_solicitud.AutoSize = true;
            this.lbl_solicitud.Location = new System.Drawing.Point(114, 107);
            this.lbl_solicitud.Name = "lbl_solicitud";
            this.lbl_solicitud.Size = new System.Drawing.Size(73, 20);
            this.lbl_solicitud.TabIndex = 75;
            this.lbl_solicitud.Text = "Solicitud:";
            this.lbl_solicitud.Visible = false;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(119, 108);
            this.lbl_numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(69, 20);
            this.lbl_numero.TabIndex = 74;
            this.lbl_numero.Text = "Numero:";
            this.lbl_numero.Visible = false;
            // 
            // txt_buscar_numero
            // 
            this.txt_buscar_numero.Location = new System.Drawing.Point(195, 102);
            this.txt_buscar_numero.Name = "txt_buscar_numero";
            this.txt_buscar_numero.Size = new System.Drawing.Size(309, 26);
            this.txt_buscar_numero.TabIndex = 86;
            this.txt_buscar_numero.Visible = false;
            this.txt_buscar_numero.WordWrap = false;
            // 
            // txt_buscar_solicitud
            // 
            this.txt_buscar_solicitud.Location = new System.Drawing.Point(195, 102);
            this.txt_buscar_solicitud.Name = "txt_buscar_solicitud";
            this.txt_buscar_solicitud.Size = new System.Drawing.Size(309, 26);
            this.txt_buscar_solicitud.TabIndex = 87;
            this.txt_buscar_solicitud.Visible = false;
            // 
            // txt_buscar_titular
            // 
            this.txt_buscar_titular.Location = new System.Drawing.Point(193, 102);
            this.txt_buscar_titular.Name = "txt_buscar_titular";
            this.txt_buscar_titular.Size = new System.Drawing.Size(309, 26);
            this.txt_buscar_titular.TabIndex = 88;
            this.txt_buscar_titular.Visible = false;
            // 
            // txt_buscar_marca
            // 
            this.txt_buscar_marca.Location = new System.Drawing.Point(193, 102);
            this.txt_buscar_marca.Name = "txt_buscar_marca";
            this.txt_buscar_marca.Size = new System.Drawing.Size(309, 26);
            this.txt_buscar_marca.TabIndex = 90;
            this.txt_buscar_marca.Visible = false;
            // 
            // txt_buscar_nacionalidad
            // 
            this.txt_buscar_nacionalidad.Location = new System.Drawing.Point(193, 102);
            this.txt_buscar_nacionalidad.Name = "txt_buscar_nacionalidad";
            this.txt_buscar_nacionalidad.Size = new System.Drawing.Size(309, 26);
            this.txt_buscar_nacionalidad.TabIndex = 91;
            this.txt_buscar_nacionalidad.Visible = false;
            // 
            // txt_buscar_tlc
            // 
            this.txt_buscar_tlc.Location = new System.Drawing.Point(195, 103);
            this.txt_buscar_tlc.Name = "txt_buscar_tlc";
            this.txt_buscar_tlc.Size = new System.Drawing.Size(309, 26);
            this.txt_buscar_tlc.TabIndex = 92;
            this.txt_buscar_tlc.Visible = false;
            // 
            // txt_buscar_distintiva
            // 
            this.txt_buscar_distintiva.Location = new System.Drawing.Point(195, 104);
            this.txt_buscar_distintiva.Name = "txt_buscar_distintiva";
            this.txt_buscar_distintiva.Size = new System.Drawing.Size(309, 26);
            this.txt_buscar_distintiva.TabIndex = 96;
            this.txt_buscar_distintiva.Visible = false;
            // 
            // txt_buscar_generica
            // 
            this.txt_buscar_generica.Location = new System.Drawing.Point(194, 103);
            this.txt_buscar_generica.Name = "txt_buscar_generica";
            this.txt_buscar_generica.Size = new System.Drawing.Size(309, 26);
            this.txt_buscar_generica.TabIndex = 97;
            this.txt_buscar_generica.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_reg_buscar,
            this.btn_buscar_cancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 176);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(526, 57);
            this.toolStrip1.TabIndex = 98;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_reg_buscar
            // 
            this.btn_reg_buscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_reg_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_reg_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_reg_buscar.Image")));
            this.btn_reg_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reg_buscar.Name = "btn_reg_buscar";
            this.btn_reg_buscar.Size = new System.Drawing.Size(54, 54);
            this.btn_reg_buscar.Text = "toolStripButton1";
            this.btn_reg_buscar.Click += new System.EventHandler(this.btn_reg_buscar_Click);
            // 
            // btn_buscar_cancelar
            // 
            this.btn_buscar_cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_buscar_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_cancelar.Image")));
            this.btn_buscar_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscar_cancelar.Name = "btn_buscar_cancelar";
            this.btn_buscar_cancelar.Size = new System.Drawing.Size(54, 54);
            this.btn_buscar_cancelar.Text = "Opciones";
            this.btn_buscar_cancelar.Click += new System.EventHandler(this.btn_buscar_cancelar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 20);
            this.label10.TabIndex = 100;
            this.label10.Text = "Selecciona un filtro:";
            // 
            // cmb_buscar_fabricante
            // 
            this.cmb_buscar_fabricante.DataSource = this.fabricantestitularesdistribuidoresBindingSource;
            this.cmb_buscar_fabricante.DisplayMember = "nombre";
            this.cmb_buscar_fabricante.FormattingEnabled = true;
            this.cmb_buscar_fabricante.Location = new System.Drawing.Point(193, 102);
            this.cmb_buscar_fabricante.Name = "cmb_buscar_fabricante";
            this.cmb_buscar_fabricante.Size = new System.Drawing.Size(311, 28);
            this.cmb_buscar_fabricante.TabIndex = 101;
            this.cmb_buscar_fabricante.ValueMember = "id_ftd";
            this.cmb_buscar_fabricante.Visible = false;
            // 
            // cmb_opciones_buscqueda
            // 
            this.cmb_opciones_buscqueda.FormattingEnabled = true;
            this.cmb_opciones_buscqueda.Location = new System.Drawing.Point(179, 29);
            this.cmb_opciones_buscqueda.Name = "cmb_opciones_buscqueda";
            this.cmb_opciones_buscqueda.Size = new System.Drawing.Size(325, 28);
            this.cmb_opciones_buscqueda.TabIndex = 102;
            this.cmb_opciones_buscqueda.SelectedIndexChanged += new System.EventHandler(this.cmb_opciones_buscqueda_SelectedIndexChanged);
            // 
            // licitacionesDataSet
            // 
            this.licitacionesDataSet.DataSetName = "LicitacionesDataSet";
            this.licitacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fabricantestitularesdistribuidoresBindingSource
            // 
            this.fabricantestitularesdistribuidoresBindingSource.DataMember = "fabricantes_titulares_distribuidores";
            this.fabricantestitularesdistribuidoresBindingSource.DataSource = this.licitacionesDataSet;
            // 
            // fabricantes_titulares_distribuidoresTableAdapter
            // 
            this.fabricantes_titulares_distribuidoresTableAdapter.ClearBeforeFill = true;
            // 
            // Registros_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 233);
            this.Controls.Add(this.cmb_opciones_buscqueda);
            this.Controls.Add(this.cmb_buscar_fabricante);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txt_buscar_generica);
            this.Controls.Add(this.txt_buscar_distintiva);
            this.Controls.Add(this.txt_buscar_tlc);
            this.Controls.Add(this.txt_buscar_nacionalidad);
            this.Controls.Add(this.txt_buscar_marca);
            this.Controls.Add(this.txt_buscar_titular);
            this.Controls.Add(this.txt_buscar_solicitud);
            this.Controls.Add(this.txt_buscar_numero);
            this.Controls.Add(this.lbl_tlc);
            this.Controls.Add(this.lbl_nacionalidad);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.lbl_fabricante);
            this.Controls.Add(this.lbl_generica);
            this.Controls.Add(this.lbl_distintiva);
            this.Controls.Add(this.lbl_titular);
            this.Controls.Add(this.lbl_solicitud);
            this.Controls.Add(this.lbl_numero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Registros_Buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Registros Sanitarios";
            this.Load += new System.EventHandler(this.Registros_Buscar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licitacionesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricantestitularesdistribuidoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_tlc;
        private System.Windows.Forms.Label lbl_nacionalidad;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_fabricante;
        private System.Windows.Forms.Label lbl_generica;
        private System.Windows.Forms.Label lbl_distintiva;
        private System.Windows.Forms.Label lbl_titular;
        private System.Windows.Forms.Label lbl_solicitud;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txt_buscar_numero;
        private System.Windows.Forms.TextBox txt_buscar_solicitud;
        private System.Windows.Forms.TextBox txt_buscar_titular;
        private System.Windows.Forms.TextBox txt_buscar_marca;
        private System.Windows.Forms.TextBox txt_buscar_nacionalidad;
        private System.Windows.Forms.TextBox txt_buscar_tlc;
        private System.Windows.Forms.TextBox txt_buscar_distintiva;
        private System.Windows.Forms.TextBox txt_buscar_generica;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_reg_buscar;
        private System.Windows.Forms.ToolStripButton btn_buscar_cancelar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_buscar_fabricante;
        private System.Windows.Forms.ComboBox cmb_opciones_buscqueda;
        private LicitacionesDataSet licitacionesDataSet;
        private System.Windows.Forms.BindingSource fabricantestitularesdistribuidoresBindingSource;
        private LicitacionesDataSetTableAdapters.fabricantes_titulares_distribuidoresTableAdapter fabricantes_titulares_distribuidoresTableAdapter;
    }
}