namespace AppLicitaciones
{
    partial class Licitacion_Items_Buscar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar:";
            // 
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(63, 46);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(449, 22);
            this.txt_filtro.TabIndex = 1;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.BackgroundImage = global::AppLicitaciones.Iconos.search;
            this.btn_filtrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_filtrar.Location = new System.Drawing.Point(477, 75);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(35, 35);
            this.btn_filtrar.TabIndex = 3;
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::AppLicitaciones.Iconos.close_round;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(12, 75);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(35, 35);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.AutoSize = true;
            this.btnTodos.Location = new System.Drawing.Point(15, 13);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(247, 20);
            this.btnTodos.TabIndex = 4;
            this.btnTodos.Text = "Buscar en Todos los procedimientos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.CheckedChanged += new System.EventHandler(this.btnTodos_CheckedChanged);
            // 
            // Licitacion_Items_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 123);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Licitacion_Items_Buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licitacion_Items_Buscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.CheckBox btnTodos;
    }
}