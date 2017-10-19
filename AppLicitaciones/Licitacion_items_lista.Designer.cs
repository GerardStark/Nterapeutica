namespace AppLicitaciones
{
    partial class Licitacion_items_lista
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.txtCcb = new System.Windows.Forms.TextBox();
            this.chkccb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::AppLicitaciones.Iconos.android_checkmark;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(13, 13);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 0;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtList
            // 
            this.txtList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtList.Location = new System.Drawing.Point(212, 35);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(979, 459);
            this.txtList.TabIndex = 1;
            // 
            // txtCcb
            // 
            this.txtCcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCcb.Location = new System.Drawing.Point(70, 35);
            this.txtCcb.Multiline = true;
            this.txtCcb.Name = "txtCcb";
            this.txtCcb.Size = new System.Drawing.Size(136, 459);
            this.txtCcb.TabIndex = 2;
            // 
            // chkccb
            // 
            this.chkccb.AutoSize = true;
            this.chkccb.Location = new System.Drawing.Point(70, 13);
            this.chkccb.Name = "chkccb";
            this.chkccb.Size = new System.Drawing.Size(73, 20);
            this.chkccb.TabIndex = 3;
            this.chkccb.Text = "S.C/C.B";
            this.chkccb.UseVisualStyleBackColor = true;
            // 
            // Licitacion_items_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 506);
            this.Controls.Add(this.chkccb);
            this.Controls.Add(this.txtCcb);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Licitacion_items_lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licitacion_items_lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.TextBox txtCcb;
        private System.Windows.Forms.CheckBox chkccb;
    }
}