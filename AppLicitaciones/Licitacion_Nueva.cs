﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLicitaciones
{
    public partial class Licitacion_Nueva : Form
    {
        public Licitacion_Nueva()
        {
            InitializeComponent();
        }

        private void btn_nueva_la_Click(object sender, EventArgs e)
        {
            Licitacion_Nueva_Abierta form = new Licitacion_Nueva_Abierta();
            form.pasarTipoLicitacion("LA");
            DialogResult result = form.ShowDialog();
            
            if (result == DialogResult.Cancel)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_nueva_it_Click(object sender, EventArgs e)
        {
            Licitacion_Nueva_Abierta form = new Licitacion_Nueva_Abierta();
            form.pasarTipoLicitacion("I3");
            DialogResult result = form.ShowDialog();
            
            if (result == DialogResult.Cancel)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_nueva_ad_Click(object sender, EventArgs e)
        {
            Licitacion_Nueva_Abierta form = new Licitacion_Nueva_Abierta();
            form.pasarTipoLicitacion("AA");
            DialogResult result = form.ShowDialog();
            
            if (result == DialogResult.Cancel)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        
        private void btn_nueva_im_Click(object sender, EventArgs e)
        {
            Licitacion_Nueva_Abierta form = new Licitacion_Nueva_Abierta();
            form.pasarTipoLicitacion("EC");
            DialogResult result =  form.ShowDialog();
            
            if (result == DialogResult.Cancel)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
