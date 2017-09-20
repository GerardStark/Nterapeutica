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

        public void mostrarDocumentacionOpcion(int id)
        {
            var opcion = CucopVinculos.GetVinculaciones().Where(x => x.Id == id).Single();
            lbl_nombre.Text = opcion.Nombre;
            lbl_carta.Text = opcion.CartaApoyo.ToString();
            foreach (VinculoRegistros r in opcion.Registros)
            {
                LinkLabel l = new LinkLabel();
                l.Text = RegistroSanitario.GetRegistros().Where(x => x.Id == r.Registro).Single().Numero;
                pnl_reg.Controls.Add(l);
            }

            foreach (VinculoCatalogos c in opcion.Catalogos)
            {
                LinkLabel l = new LinkLabel();
                l.Text = CatalogoProductos.getCatalogos().Where(x => x.Id == c.Catalogo).Single().Nombre;
                pnl_cat.Controls.Add(l);
            }

            foreach (VinculoCertificados c in opcion.Certificados)
            {
                LinkLabel l = new LinkLabel();
                l.Text = CertificadoCalidad.GetCertificados().Where(x => x.Id == c.Certificado).Single().Numero;
                pnl_cer.Controls.Add(l);
            }
        }
    }
}
