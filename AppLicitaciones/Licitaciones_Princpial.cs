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
using System.Reflection;

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

        private void Licitaciones_Princpial_Load(object sender, EventArgs e)
        {
          
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.licitacion_bases' Puede moverla o quitarla según sea necesario.
            this.licitacion_basesTableAdapter.Fill(this.licitacionesDataSet.licitacion_bases);
            mostrarEventosProximos();
        }

        private void mostrarEventosProximos()
        {
            DateTime min = DateTime.Today;
            DateTime max = DateTime.Today.AddDays(7);            
            foreach (Calendario c in Calendario.GetCalendarios())
            {
 
                PropertyInfo[] p = c.GetType().GetProperties();
                for (int i = 2; i < p.Length - 2; i++)
                {
                    if ((DateTime)p[i].GetValue(c) > min && (DateTime)p[i].GetValue(c) < max)
                    {
                        Licitacion_Calendario_Principal l = new Licitacion_Calendario_Principal();
                        l.mostrarInfoEvento(c, p[i].Name, p[i].GetValue(c));
                        panelEventos.Controls.Add(l);
                    }                   
                }
            }
        }

        private void cmb_licitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mostrar informacion util para los licitantes:
            //numero total de items, registros, certificados y catalogos, asi como si son vigentes, fueron tramitados a tiempo o
                               
        }
    }
}
