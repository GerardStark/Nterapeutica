using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLicitacion;

namespace AppLicitaciones
{
    public partial class Licitacion_Calendario_Principal : UserControl
    {
        int idBases;
        public Licitacion_Calendario_Principal()
        {
            InitializeComponent();
        }

        public void mostrarInfoEvento(Calendario c, string evento, object obj)
        {
            if (evento != "Id" || evento != "Bases")
            {
                lbl_evento.Text = evento;
                lbl_licit.Text = Licitacion.GetBases().Where(x => x.Id == c.Bases).Single().NumeroLicitacion;
                lbl_fecha.Text = obj.ToString();
                idBases = c.Bases;
            }
        }

        private void Licitacion_Calendario_Principal_Click(object sender, EventArgs e)
        {
            Licitacion_Calendario form = new Licitacion_Calendario();
            form.mostrarFechasCalendario(idBases);
            form.ShowDialog();
        }
    }
}
