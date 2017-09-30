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
    public partial class VisualizarDocumentacionCucop : UserControl
    {
        public VisualizarDocumentacionCucop()
        {
            InitializeComponent();
        }

        //crear un evento que al dar clic al respectivo vinculo mande a los RECACE
        public void mostrarDocumentacionOpcion(int id)
        {
            var opcion = CucopVinculos.GetVinculaciones().Where(x => x.Id == id).Single();
            lbl_nombre.Text = opcion.Nombre;
            lbl_carta.Text = opcion.CartaApoyo.ToString();
            foreach (VinculoRegistros re in opcion.Registros)
            {
                LinkLabel l = new LinkLabel();
                l.Text = RegistroSanitario.GetRegistros().Where(x => x.Id == re.Nombre).Single().Nombre;
                l.Tag = re.Nombre;
                l.LinkClicked += verRegistro;
                pnl_reg.Controls.Add(l);
            }

            foreach (VinculoCatalogos ca in opcion.Catalogos)
            {
                LinkLabel l = new LinkLabel();
                l.Text = CatalogoProductos.getCatalogos().Where(x => x.Id == ca.Nombre).Single().Nombre;
                l.Tag = ca.Nombre;
                l.LinkClicked += verCatalogo;
                pnl_cat.Controls.Add(l);
            }

            foreach (VinculoCertificados ce in opcion.Certificados)
            {
                LinkLabel l = new LinkLabel();
                l.Text = CertificadoCalidad.GetCertificados().Where(x => x.Id == ce.Nombre).Single().Nombre;
                l.Tag = ce.Nombre;
                l.LinkClicked += verCertificado;
                pnl_cer.Controls.Add(l);
            }
        }

        private void verRegistro(object sender, EventArgs e)
        {
            LinkLabel l = sender as LinkLabel;
            int id = Convert.ToInt32(l.Tag);
            Registros_Visualizar form = new Registros_Visualizar();
            form.mostrarinforegistro(id);
            form.Show();
        }

        private void verCatalogo(object sender, EventArgs e)
        {
            LinkLabel l = sender as LinkLabel;
            int id = Convert.ToInt32(l.Tag);
            Catalogos_Visualizar form = new Catalogos_Visualizar();
            form.mostrarinfocatalogo(id);
            form.Show();
        }

        private void verCertificado(object sender, EventArgs e)
        {
            LinkLabel l = sender as LinkLabel;
            int id = Convert.ToInt32(l.Tag);
            Certificados_Visualizar form = new Certificados_Visualizar();
            form.mostrarinfocertificado(id);
            form.Show();
        }
    }
}
