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
    public partial class Form_Principal : Form
    {
        int idLicitacion = 0;
        public Form_Principal()
        {
            InitializeComponent();
            //Verifica que el usuario sea administrador para poder entrar al menu de Herramientas de Admins.
            //bool admin = mc.ChecarTipoUsuario(tipo_usuario);
            //if (admin == true)
            //{
            //    herramientasAdminToolStripMenuItem.Enabled = true;
            //}
            //else
            //{
            //    MessageBox.Show("Necesitas ser Administrador para acceder a este modulo.");
            //    herramientasAdminToolStripMenuItem.Enabled = false;
            //}
        }
        int tipo_usuario = Login.usertipo;
        MainConfig mc = new MainConfig();
        private void herramientasAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //estableque el padre MDI y que la ventana no se pueda abrir mas de una vez y esté maximizada.
        private void registrosSanitariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Registros_Principal))
                {
                    form.Activate();
                    return;
                }
            }

            Registros_Principal newForm = new Registros_Principal();
            //newForm.MdiParent = this;
            //newForm.WindowState = FormWindowState.Maximized;
            newForm.Show();
        }

        private void certificadosDeCalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Certificados_Principal))
                {
                    form.Activate();
                    return;
                }
            }

            Certificados_Principal newForm = new Certificados_Principal();
            //newForm.MdiParent = this;
            //newForm.WindowState = FormWindowState.Maximized;
            newForm.Show();
        }

        private void catálogosDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Catalogos_Principal))
                {
                    form.Activate();
                    return;
                }
            }

            Catalogos_Principal newForm = new Catalogos_Principal();
            //newForm.MdiParent = this;
            //newForm.WindowState = FormWindowState.Maximized;
            newForm.Show();
        }

        private void cuadroBasicoDelIMSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Cucop_Principal))
                {
                    form.Activate();
                    return;
                }
            }

            Cucop_Principal newForm = new Cucop_Principal();
            //newForm.MdiParent = this;
            //newForm.WindowState = FormWindowState.Maximized;
            newForm.Show();
        }
        //termina la aplicacion cuando se da clic en cerrar
        private new void FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void licitacionesEnCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Licitacion_Actuales))
                {
                    form.Activate();
                    return;
                }
            }

            Licitacion_Actuales newForm = new Licitacion_Actuales();
            //newForm.MdiParent = this;
            //newForm.WindowState = FormWindowState.Maximized;
            newForm.Show();
        }

        private void nuevaLicitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Licitacion_Nueva))
                {
                    form.Activate();
                    return;
                }
            }

            Licitacion_Nueva newForm = new Licitacion_Nueva();
            //newForm.MdiParent = this;
            //newForm.WindowState = FormWindowState.Maximized;
            newForm.Show();
        }

        private void fabricantesTitularesDistribuidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FTD_Principal))
                {
                    form.Activate();
                    return;
                }
            }

            FTD_Principal newForm = new FTD_Principal();
            //newForm.MdiParent = this;
            //newForm.llenartablaftd();
            newForm.Show();
        }

        private void especialistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Especialistas_Principal))
                {
                    form.Activate();
                    return;
                }
            }

            Especialistas_Principal newForm = new Especialistas_Principal();
            newForm.Show();
        }

        private void procesosDeLicitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Licitaciones_Princpial))
                {
                    form.Activate();
                    return;
                }
            }

            Licitaciones_Princpial newForm = new Licitaciones_Princpial();
            //newForm.MdiParent = this;            
            newForm.Show();
        }

        private void impresionDeReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Licitacion_Reportes))
                {
                    form.Activate();
                    return;
                }
            }

            Licitacion_Reportes newForm = new Licitacion_Reportes();
            //newForm.MdiParent = this;            
            newForm.Show();
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            var licitaciones = from lc in Licitacion.GetBases()
                               from cl in lc.Calendarios
                               where cl.Firma > DateTime.Today
                               select lc;
            foreach (Licitacion lc in licitaciones)
            {
                dgvCalendario.Rows.Add(
                    lc.Id,
                    lc.NumeroLicitacion,
                    lc.Calendarios.First().Junta,
                    lc.Calendarios.First().Apertura,
                    lc.Calendarios.First().Fallo,
                    lc.Calendarios.First().Muestras,
                    lc.Calendarios.First().Firma
                    );
            }
        }

        private void dgvCalendario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Convert.ToInt32(dgvCalendario.Rows[e.RowIndex].Cells["idColumn"].Value) != 0)
            {
                Licitacion_Partidas_Principal form = new Licitacion_Partidas_Principal();
                form.mostrarPartidasLicitacion(Convert.ToInt32(dgvCalendario.Rows[e.RowIndex].Cells["idColumn"].Value));
                form.Show();

            }
        }
    }
}
