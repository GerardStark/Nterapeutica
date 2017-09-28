namespace AppLicitaciones
{
    partial class Reporte_InfoLicitacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNumLicit = new System.Windows.Forms.ComboBox();
            this.radAct = new System.Windows.Forms.RadioButton();
            this.radConc = new System.Windows.Forms.RadioButton();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.chkTec = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.lblVisita = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblJA = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblDof = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblCnet = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblFirma = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblFallo = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_operador = new System.Windows.Forms.Label();
            this.lbl_tipoexp = new System.Windows.Forms.Label();
            this.lbl_numexped = new System.Windows.Forms.Label();
            this.lbl_durcontrato = new System.Windows.Forms.Label();
            this.lbl_tipocontrato = new System.Windows.Forms.Label();
            this.lbl_entidad = new System.Windows.Forms.Label();
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMuestras = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Licitacion";
            // 
            // cmbNumLicit
            // 
            this.cmbNumLicit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumLicit.FormattingEnabled = true;
            this.cmbNumLicit.Location = new System.Drawing.Point(8, 57);
            this.cmbNumLicit.Name = "cmbNumLicit";
            this.cmbNumLicit.Size = new System.Drawing.Size(241, 24);
            this.cmbNumLicit.TabIndex = 3;
            this.cmbNumLicit.SelectedIndexChanged += new System.EventHandler(this.cmbNumLicit_SelectedIndexChanged);
            // 
            // radAct
            // 
            this.radAct.AutoSize = true;
            this.radAct.Location = new System.Drawing.Point(7, 9);
            this.radAct.Name = "radAct";
            this.radAct.Size = new System.Drawing.Size(96, 20);
            this.radAct.TabIndex = 1;
            this.radAct.TabStop = true;
            this.radAct.Text = "En Proceso";
            this.radAct.UseVisualStyleBackColor = true;
            // 
            // radConc
            // 
            this.radConc.AutoSize = true;
            this.radConc.Location = new System.Drawing.Point(114, 9);
            this.radConc.Name = "radConc";
            this.radConc.Size = new System.Drawing.Size(93, 20);
            this.radConc.TabIndex = 2;
            this.radConc.TabStop = true;
            this.radConc.Text = "Concluidas";
            this.radConc.UseVisualStyleBackColor = true;
            // 
            // pnlDatos
            // 
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.Controls.Add(this.btnImprimir);
            this.pnlDatos.Controls.Add(this.chkTec);
            this.pnlDatos.Controls.Add(this.radConc);
            this.pnlDatos.Controls.Add(this.radAct);
            this.pnlDatos.Controls.Add(this.cmbNumLicit);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Location = new System.Drawing.Point(4, 4);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(254, 611);
            this.pnlDatos.TabIndex = 0;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::AppLicitaciones.Iconos.printer;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Location = new System.Drawing.Point(199, 552);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(50, 50);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.imprimir);
            // 
            // chkTec
            // 
            this.chkTec.AutoSize = true;
            this.chkTec.Location = new System.Drawing.Point(8, 119);
            this.chkTec.Name = "chkTec";
            this.chkTec.Size = new System.Drawing.Size(177, 20);
            this.chkTec.TabIndex = 4;
            this.chkTec.Text = "Adjuntar Avance Tecnico";
            this.chkTec.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(340, 352);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(148, 16);
            this.label28.TabIndex = 142;
            this.label28.Text = "Calendario de Eventos:";
            // 
            // lblVisita
            // 
            this.lblVisita.AutoSize = true;
            this.lblVisita.Location = new System.Drawing.Point(531, 532);
            this.lblVisita.Name = "lblVisita";
            this.lblVisita.Size = new System.Drawing.Size(52, 16);
            this.lblVisita.TabIndex = 141;
            this.lblVisita.Text = "label13";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(281, 532);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(134, 16);
            this.label27.TabIndex = 140;
            this.label27.Text = "Visita a Instalaciones";
            // 
            // lblJA
            // 
            this.lblJA.AutoSize = true;
            this.lblJA.Location = new System.Drawing.Point(531, 429);
            this.lblJA.Name = "lblJA";
            this.lblJA.Size = new System.Drawing.Size(52, 16);
            this.lblJA.TabIndex = 139;
            this.lblJA.Text = "label13";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(281, 429);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(191, 16);
            this.label25.TabIndex = 138;
            this.label25.Text = "Primera Junta de Aclaraciones";
            // 
            // lblDof
            // 
            this.lblDof.AutoSize = true;
            this.lblDof.Location = new System.Drawing.Point(531, 402);
            this.lblDof.Name = "lblDof";
            this.lblDof.Size = new System.Drawing.Size(52, 16);
            this.lblDof.TabIndex = 137;
            this.lblDof.Text = "label13";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(281, 402);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 16);
            this.label23.TabIndex = 136;
            this.label23.Text = "Publicación en el Dof";
            // 
            // lblCnet
            // 
            this.lblCnet.AutoSize = true;
            this.lblCnet.Location = new System.Drawing.Point(531, 375);
            this.lblCnet.Name = "lblCnet";
            this.lblCnet.Size = new System.Drawing.Size(52, 16);
            this.lblCnet.TabIndex = 135;
            this.lblCnet.Text = "label13";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(281, 375);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(165, 16);
            this.label21.TabIndex = 134;
            this.label21.Text = "Publicación en Compranet";
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(531, 506);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(52, 16);
            this.lblFirma.TabIndex = 133;
            this.lblFirma.Text = "label13";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(281, 506);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 16);
            this.label19.TabIndex = 132;
            this.label19.Text = "Firma del Contrato";
            // 
            // lblFallo
            // 
            this.lblFallo.AutoSize = true;
            this.lblFallo.Location = new System.Drawing.Point(531, 481);
            this.lblFallo.Name = "lblFallo";
            this.lblFallo.Size = new System.Drawing.Size(52, 16);
            this.lblFallo.TabIndex = 131;
            this.lblFallo.Text = "label13";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(281, 481);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 16);
            this.label17.TabIndex = 130;
            this.label17.Text = "Emisión del fallo";
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.Location = new System.Drawing.Point(531, 455);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(52, 16);
            this.lblApertura.TabIndex = 129;
            this.lblApertura.Text = "label13";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(281, 455);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 16);
            this.label15.TabIndex = 128;
            this.label15.Text = "Apertura de propuestas";
            // 
            // lbl_desc
            // 
            this.lbl_desc.Location = new System.Drawing.Point(424, 278);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(651, 63);
            this.lbl_desc.TabIndex = 125;
            this.lbl_desc.Text = "label23";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(424, 252);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(52, 16);
            this.lbl_correo.TabIndex = 124;
            this.lbl_correo.Text = "label22";
            // 
            // lbl_operador
            // 
            this.lbl_operador.AutoSize = true;
            this.lbl_operador.Location = new System.Drawing.Point(427, 227);
            this.lbl_operador.Name = "lbl_operador";
            this.lbl_operador.Size = new System.Drawing.Size(52, 16);
            this.lbl_operador.TabIndex = 123;
            this.lbl_operador.Text = "label21";
            // 
            // lbl_tipoexp
            // 
            this.lbl_tipoexp.AutoSize = true;
            this.lbl_tipoexp.Location = new System.Drawing.Point(428, 201);
            this.lbl_tipoexp.Name = "lbl_tipoexp";
            this.lbl_tipoexp.Size = new System.Drawing.Size(52, 16);
            this.lbl_tipoexp.TabIndex = 122;
            this.lbl_tipoexp.Text = "label20";
            // 
            // lbl_numexped
            // 
            this.lbl_numexped.AutoSize = true;
            this.lbl_numexped.Location = new System.Drawing.Point(427, 176);
            this.lbl_numexped.Name = "lbl_numexped";
            this.lbl_numexped.Size = new System.Drawing.Size(52, 16);
            this.lbl_numexped.TabIndex = 121;
            this.lbl_numexped.Text = "label19";
            // 
            // lbl_durcontrato
            // 
            this.lbl_durcontrato.AutoSize = true;
            this.lbl_durcontrato.Location = new System.Drawing.Point(427, 150);
            this.lbl_durcontrato.Name = "lbl_durcontrato";
            this.lbl_durcontrato.Size = new System.Drawing.Size(52, 16);
            this.lbl_durcontrato.TabIndex = 120;
            this.lbl_durcontrato.Text = "label18";
            // 
            // lbl_tipocontrato
            // 
            this.lbl_tipocontrato.AutoSize = true;
            this.lbl_tipocontrato.Location = new System.Drawing.Point(427, 124);
            this.lbl_tipocontrato.Name = "lbl_tipocontrato";
            this.lbl_tipocontrato.Size = new System.Drawing.Size(52, 16);
            this.lbl_tipocontrato.TabIndex = 119;
            this.lbl_tipocontrato.Text = "label17";
            // 
            // lbl_entidad
            // 
            this.lbl_entidad.AutoSize = true;
            this.lbl_entidad.Location = new System.Drawing.Point(427, 98);
            this.lbl_entidad.Name = "lbl_entidad";
            this.lbl_entidad.Size = new System.Drawing.Size(52, 16);
            this.lbl_entidad.TabIndex = 118;
            this.lbl_entidad.Text = "label15";
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.Location = new System.Drawing.Point(427, 53);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(648, 33);
            this.lbl_unidad.TabIndex = 117;
            this.lbl_unidad.Text = "label14";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(427, 27);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(52, 16);
            this.lbl_numero.TabIndex = 116;
            this.lbl_numero.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(340, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 115;
            this.label12.Text = "Descripcion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 114;
            this.label5.Text = "Tipo de Contrato:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 16);
            this.label11.TabIndex = 113;
            this.label11.Text = "Correo del Operador:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 16);
            this.label10.TabIndex = 112;
            this.label10.Text = "Nombre del Operador:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 16);
            this.label9.TabIndex = 111;
            this.label9.Text = "Tipo de Expediente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 110;
            this.label8.Text = "# de Expediente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 109;
            this.label7.Text = "Duracion del Contrato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 106;
            this.label3.Text = "Entidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 105;
            this.label2.Text = "Unidad Compradora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 104;
            this.label4.Text = "Numero:";
            // 
            // lblMuestras
            // 
            this.lblMuestras.AutoSize = true;
            this.lblMuestras.Location = new System.Drawing.Point(531, 558);
            this.lblMuestras.Name = "lblMuestras";
            this.lblMuestras.Size = new System.Drawing.Size(52, 16);
            this.lblMuestras.TabIndex = 144;
            this.lblMuestras.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(281, 557);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 16);
            this.label14.TabIndex = 143;
            this.label14.Text = "Entrega de Muestras";
            // 
            // Reporte_InfoLicitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblMuestras);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.lblVisita);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.lblJA);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.lblDof);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lblCnet);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblFallo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblApertura);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.lbl_operador);
            this.Controls.Add(this.lbl_tipoexp);
            this.Controls.Add(this.lbl_numexped);
            this.Controls.Add(this.lbl_durcontrato);
            this.Controls.Add(this.lbl_tipocontrato);
            this.Controls.Add(this.lbl_entidad);
            this.Controls.Add(this.lbl_unidad);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reporte_InfoLicitacion";
            this.Size = new System.Drawing.Size(1210, 621);
            this.Load += new System.EventHandler(this.Reporte_InfoLicitacion_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNumLicit;
        private System.Windows.Forms.RadioButton radAct;
        private System.Windows.Forms.RadioButton radConc;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblVisita;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblJA;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblDof;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblCnet;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblFallo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_operador;
        private System.Windows.Forms.Label lbl_tipoexp;
        private System.Windows.Forms.Label lbl_numexped;
        private System.Windows.Forms.Label lbl_durcontrato;
        private System.Windows.Forms.Label lbl_tipocontrato;
        private System.Windows.Forms.Label lbl_entidad;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkTec;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblMuestras;
        private System.Windows.Forms.Label label14;
    }
}
