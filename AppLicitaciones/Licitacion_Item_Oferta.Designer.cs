namespace AppLicitaciones
{
    partial class Licitacion_Item_Oferta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licitacion_Item_Oferta));
            this.txt_item = new System.Windows.Forms.TextBox();
            this.txt_cucop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btn_buscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btn_junta = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btn_descartar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btn_info = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(12, 28);
            this.txt_item.Multiline = true;
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(500, 182);
            this.txt_item.TabIndex = 0;
            // 
            // txt_cucop
            // 
            this.txt_cucop.Location = new System.Drawing.Point(12, 244);
            this.txt_cucop.Multiline = true;
            this.txt_cucop.Name = "txt_cucop";
            this.txt_cucop.Size = new System.Drawing.Size(500, 182);
            this.txt_cucop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descripcion del Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item ofertado seleccionado:";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btn_buscar
            // 
            this.btn_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(73, 44);
            this.btn_buscar.Text = "toolStripButton1";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(73, 15);
            this.toolStripLabel1.Text = "Cambiar";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(73, 15);
            this.toolStripLabel2.Text = "Informacion";
            // 
            // btn_junta
            // 
            this.btn_junta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_junta.Image = ((System.Drawing.Image)(resources.GetObject("btn_junta.Image")));
            this.btn_junta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_junta.Name = "btn_junta";
            this.btn_junta.Size = new System.Drawing.Size(73, 44);
            this.btn_junta.Text = "toolStripButton4";
            this.btn_junta.Click += new System.EventHandler(this.btn_junta_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(73, 15);
            this.toolStripLabel4.Text = "Preguntas JA";
            // 
            // btn_descartar
            // 
            this.btn_descartar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_descartar.Image = ((System.Drawing.Image)(resources.GetObject("btn_descartar.Image")));
            this.btn_descartar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_descartar.Name = "btn_descartar";
            this.btn_descartar.Size = new System.Drawing.Size(73, 44);
            this.btn_descartar.Text = "toolStripButton6";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(73, 15);
            this.toolStripLabel6.Text = "Descartar";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_buscar,
            this.toolStripLabel1,
            this.btn_info,
            this.toolStripLabel2,
            this.btn_junta,
            this.toolStripLabel4,
            this.btn_descartar,
            this.toolStripLabel6,
            this.btn_guardar,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(533, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(76, 442);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_guardar
            // 
            this.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(73, 44);
            this.btn_guardar.Text = "toolStripButton1";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(73, 15);
            this.toolStripLabel3.Text = "Guardar";
            // 
            // btn_info
            // 
            this.btn_info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_info.Image = ((System.Drawing.Image)(resources.GetObject("btn_info.Image")));
            this.btn_info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(73, 44);
            this.btn_info.Text = "toolStripButton2";
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // Licitacion_Item_Oferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 442);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cucop);
            this.Controls.Add(this.txt_item);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Licitacion_Item_Oferta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licitacion_Item_Oferta";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.TextBox txt_cucop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_buscar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btn_junta;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btn_descartar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btn_info;
    }
}