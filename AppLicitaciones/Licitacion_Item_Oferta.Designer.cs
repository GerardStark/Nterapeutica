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
            this.btn_item_nuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(12, 12);
            this.txt_item.Multiline = true;
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(500, 300);
            this.txt_item.TabIndex = 0;
            // 
            // txt_cucop
            // 
            this.txt_cucop.Location = new System.Drawing.Point(603, 12);
            this.txt_cucop.Multiline = true;
            this.txt_cucop.Name = "txt_cucop";
            this.txt_cucop.Size = new System.Drawing.Size(500, 300);
            this.txt_cucop.TabIndex = 4;
            // 
            // btn_item_nuevo
            // 
            this.btn_item_nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_item_nuevo.BackgroundImage")));
            this.btn_item_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_item_nuevo.Location = new System.Drawing.Point(533, 41);
            this.btn_item_nuevo.Name = "btn_item_nuevo";
            this.btn_item_nuevo.Size = new System.Drawing.Size(50, 50);
            this.btn_item_nuevo.TabIndex = 11;
            this.btn_item_nuevo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(533, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(533, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Agregar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Quitar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cucop/items";
            // 
            // Licitacion_Item_Oferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 324);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_item_nuevo);
            this.Controls.Add(this.txt_cucop);
            this.Controls.Add(this.txt_item);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Licitacion_Item_Oferta";
            this.Text = "Licitacion_Item_Oferta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.TextBox txt_cucop;
        private System.Windows.Forms.Button btn_item_nuevo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}