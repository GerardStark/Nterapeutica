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
            this.txt_item = new System.Windows.Forms.TextBox();
            this.txt_cucop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.txt_opcion_uno = new System.Windows.Forms.TextBox();
            this.txt_opcion_dos = new System.Windows.Forms.TextBox();
            this.txt_opcion_tres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(180, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 11;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(236, 432);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 12;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // txt_opcion_uno
            // 
            this.txt_opcion_uno.Location = new System.Drawing.Point(558, 100);
            this.txt_opcion_uno.Multiline = true;
            this.txt_opcion_uno.Name = "txt_opcion_uno";
            this.txt_opcion_uno.Size = new System.Drawing.Size(587, 133);
            this.txt_opcion_uno.TabIndex = 13;
            // 
            // txt_opcion_dos
            // 
            this.txt_opcion_dos.Location = new System.Drawing.Point(558, 239);
            this.txt_opcion_dos.Multiline = true;
            this.txt_opcion_dos.Name = "txt_opcion_dos";
            this.txt_opcion_dos.Size = new System.Drawing.Size(587, 133);
            this.txt_opcion_dos.TabIndex = 14;
            // 
            // txt_opcion_tres
            // 
            this.txt_opcion_tres.Location = new System.Drawing.Point(558, 378);
            this.txt_opcion_tres.Multiline = true;
            this.txt_opcion_tres.Name = "txt_opcion_tres";
            this.txt_opcion_tres.Size = new System.Drawing.Size(587, 133);
            this.txt_opcion_tres.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cucops o Items que mas se asemejan a la descripción:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(558, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 30);
            this.button6.TabIndex = 17;
            this.button6.Text = "Buscar Items Similares";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Licitacion_Item_Oferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 523);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_opcion_tres);
            this.Controls.Add(this.txt_opcion_dos);
            this.Controls.Add(this.txt_opcion_uno);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cucop);
            this.Controls.Add(this.txt_item);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Licitacion_Item_Oferta";
            this.Text = "Licitacion_Item_Oferta";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.TextBox txt_cucop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TextBox txt_opcion_tres;
        private System.Windows.Forms.TextBox txt_opcion_dos;
        private System.Windows.Forms.TextBox txt_opcion_uno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
    }
}