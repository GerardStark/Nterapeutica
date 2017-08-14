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
    public partial class Licitaciones_Princpial : Form
    {
        public Licitaciones_Princpial()
        {
            InitializeComponent();
        }

        private void btn_nuevas_Click(object sender, EventArgs e)
        {
            Licitacion_Nueva form = new Licitacion_Nueva();            
            form.ShowDialog();
        }

        private void btn_activas_Click(object sender, EventArgs e)
        {
            Licitacion_Actuales form = new Licitacion_Actuales();
            form.mostrarLicitacionesActivas(1);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                //something
            }
        }

        private void btn_historico_Click(object sender, EventArgs e)
        {
            Licitacion_Actuales form = new Licitacion_Actuales();
            form.mostrarLicitacionesActivas(0);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                //something
            }
        }

        private void btn_todas_Click(object sender, EventArgs e)
        {
            Licitacion_Actuales form = new Licitacion_Actuales();
            form.mostrarLicitacionesActivas(2);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                //something
            }
        }
    }
}
