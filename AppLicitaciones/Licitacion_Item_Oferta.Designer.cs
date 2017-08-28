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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_preguntas = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btn_buscar_items = new System.Windows.Forms.Button();
            this.btn_limpiar_resultados = new System.Windows.Forms.Button();
            this.btn_referencias = new System.Windows.Forms.Button();
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
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.BackgroundImage")));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(12, 432);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(50, 50);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_borrar.BackgroundImage")));
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar.Location = new System.Drawing.Point(68, 432);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(50, 50);
            this.btn_borrar.TabIndex = 9;
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // btn_preguntas
            // 
            this.btn_preguntas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_preguntas.BackgroundImage")));
            this.btn_preguntas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_preguntas.Location = new System.Drawing.Point(124, 432);
            this.btn_preguntas.Name = "btn_preguntas";
            this.btn_preguntas.Size = new System.Drawing.Size(50, 50);
            this.btn_preguntas.TabIndex = 10;
            this.btn_preguntas.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(236, 432);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(50, 50);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btn_buscar_items
            // 
            this.btn_buscar_items.Location = new System.Drawing.Point(518, 28);
            this.btn_buscar_items.Name = "btn_buscar_items";
            this.btn_buscar_items.Size = new System.Drawing.Size(157, 30);
            this.btn_buscar_items.TabIndex = 17;
            this.btn_buscar_items.Text = "Buscar Items Similares";
            this.btn_buscar_items.UseVisualStyleBackColor = true;
            this.btn_buscar_items.Click += new System.EventHandler(this.btn_buscar_items_Click);
            // 
            // btn_limpiar_resultados
            // 
            this.btn_limpiar_resultados.Location = new System.Drawing.Point(518, 64);
            this.btn_limpiar_resultados.Name = "btn_limpiar_resultados";
            this.btn_limpiar_resultados.Size = new System.Drawing.Size(157, 30);
            this.btn_limpiar_resultados.TabIndex = 18;
            this.btn_limpiar_resultados.Text = "Limpiar Resultados";
            this.btn_limpiar_resultados.UseVisualStyleBackColor = true;
            this.btn_limpiar_resultados.Click += new System.EventHandler(this.btn_limpiar_resultados_Click);
            // 
            // btn_referencias
            // 
            this.btn_referencias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_referencias.BackgroundImage")));
            this.btn_referencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_referencias.Location = new System.Drawing.Point(180, 432);
            this.btn_referencias.Name = "btn_referencias";
            this.btn_referencias.Size = new System.Drawing.Size(50, 50);
            this.btn_referencias.TabIndex = 19;
            this.btn_referencias.UseVisualStyleBackColor = true;
            // 
            // Licitacion_Item_Oferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 523);
            this.Controls.Add(this.btn_referencias);
            this.Controls.Add(this.btn_limpiar_resultados);
            this.Controls.Add(this.btn_buscar_items);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_preguntas);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_guardar);
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
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_preguntas;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btn_buscar_items;
        private System.Windows.Forms.Button btn_limpiar_resultados;
        private System.Windows.Forms.Button btn_referencias;
    }
}