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
                dgvReg.Rows.Add(r.Registro);               
            }

            foreach (VinculoCatalogos c in opcion.Catalogos)
            {
                dgvCat.Rows.Add(c.Catalogo);
            }

            foreach (VinculoCertificados c in opcion.Certificados)
            {
                dgvCer.Rows.Add(c.Certificado);
            }
        }
    }
}
