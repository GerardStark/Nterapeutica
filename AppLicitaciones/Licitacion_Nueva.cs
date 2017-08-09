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

        public void nuevaLicitacion(string tipo)
        {
            Licitacion_Nueva_Abierta form = new Licitacion_Nueva_Abierta();
            form.pasarTipoLicitacion(tipo);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_nueva_la_Click(object sender, EventArgs e)
        {
            nuevaLicitacion("LA");
        }

        private void btn_nueva_it_Click(object sender, EventArgs e)
        {
            nuevaLicitacion("I3");
        }

        private void btn_nueva_ad_Click(object sender, EventArgs e)
        {
            nuevaLicitacion("AA");
        }
        
        private void btn_nueva_im_Click(object sender, EventArgs e)
        {
            nuevaLicitacion("IM");
        }
    }
}
