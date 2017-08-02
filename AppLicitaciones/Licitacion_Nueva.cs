using System;
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
            this.Hide();
            DialogResult result = form.ShowDialog();
            
            if (result == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btn_nueva_it_Click(object sender, EventArgs e)
        {
            Licitacion_Nueva_Invitacion form = new Licitacion_Nueva_Invitacion();
            this.Hide();
            DialogResult result = form.ShowDialog();
            
            if (result == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btn_nueva_ad_Click(object sender, EventArgs e)
        {
            Licitacion_Nueva_Adjudicacion form = new Licitacion_Nueva_Adjudicacion();
            this.Hide();
            DialogResult result = form.ShowDialog();
            
            if (result == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btn_nueva_im_Click(object sender, EventArgs e)
        {
            Licitacion_Nueva_Mercado form = new Licitacion_Nueva_Mercado();
            this.Hide();
            DialogResult result =  form.ShowDialog();
            
            if (result == DialogResult.Cancel)
            {
                this.Show();
            }
        }
    }
}
