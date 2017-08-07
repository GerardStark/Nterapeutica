namespace AppLicitaciones
{
    partial class Licitacion_Nueva
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
            this.btn_nueva_la = new System.Windows.Forms.Button();
            this.btn_nueva_it = new System.Windows.Forms.Button();
            this.btn_nueva_ad = new System.Windows.Forms.Button();
            this.btn_nueva_im = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nueva_la
            // 
            this.btn_nueva_la.Location = new System.Drawing.Point(12, 12);
            this.btn_nueva_la.Name = "btn_nueva_la";
            this.btn_nueva_la.Size = new System.Drawing.Size(157, 163);
            this.btn_nueva_la.TabIndex = 0;
            this.btn_nueva_la.Text = "Licitación Abierta";
            this.btn_nueva_la.UseVisualStyleBackColor = true;
            this.btn_nueva_la.Click += new System.EventHandler(this.btn_nueva_la_Click);
            // 
            // btn_nueva_it
            // 
            this.btn_nueva_it.Location = new System.Drawing.Point(175, 12);
            this.btn_nueva_it.Name = "btn_nueva_it";
            this.btn_nueva_it.Size = new System.Drawing.Size(157, 163);
            this.btn_nueva_it.TabIndex = 1;
            this.btn_nueva_it.Text = "Invitación a Tres";
            this.btn_nueva_it.UseVisualStyleBackColor = true;
            this.btn_nueva_it.Click += new System.EventHandler(this.btn_nueva_it_Click);
            // 
            // btn_nueva_ad
            // 
            this.btn_nueva_ad.Location = new System.Drawing.Point(338, 12);
            this.btn_nueva_ad.Name = "btn_nueva_ad";
            this.btn_nueva_ad.Size = new System.Drawing.Size(157, 163);
            this.btn_nueva_ad.TabIndex = 2;
            this.btn_nueva_ad.Text = "Adjudicación Directa";
            this.btn_nueva_ad.UseVisualStyleBackColor = true;
            this.btn_nueva_ad.Click += new System.EventHandler(this.btn_nueva_ad_Click);
            // 
            // btn_nueva_im
            // 
            this.btn_nueva_im.Location = new System.Drawing.Point(501, 12);
            this.btn_nueva_im.Name = "btn_nueva_im";
            this.btn_nueva_im.Size = new System.Drawing.Size(157, 163);
            this.btn_nueva_im.TabIndex = 3;
            this.btn_nueva_im.Text = "Investigacion de Mercado/Cotización";
            this.btn_nueva_im.UseVisualStyleBackColor = true;
            this.btn_nueva_im.Click += new System.EventHandler(this.btn_nueva_im_Click);
            // 
            // Licitacion_Nueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 192);
            this.Controls.Add(this.btn_nueva_im);
            this.Controls.Add(this.btn_nueva_ad);
            this.Controls.Add(this.btn_nueva_it);
            this.Controls.Add(this.btn_nueva_la);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Licitacion_Nueva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licitacion_Nueva";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nueva_la;
        private System.Windows.Forms.Button btn_nueva_it;
        private System.Windows.Forms.Button btn_nueva_ad;
        private System.Windows.Forms.Button btn_nueva_im;
    }
}