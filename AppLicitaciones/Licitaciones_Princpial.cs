using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLicitacion;

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
            Licitacion_Nueva_Abierta form = new Licitacion_Nueva_Abierta();            
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

        private void panelEventos_Paint(object sender, PaintEventArgs e)
        {
            foreach (Calendario item in Calendario.GetCalendarios())
            {
                Label lb = new Label();
                lb.Text = item.Id.ToString();
                panelEventos.Controls.Add(lb);
            }
        }

        private void Licitaciones_Princpial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.licitacion_bases' Puede moverla o quitarla según sea necesario.
            this.licitacion_basesTableAdapter.Fill(this.licitacionesDataSet.licitacion_bases);

        }
    }
}
