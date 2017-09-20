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
    public partial class Licitacion_Item_Visualizar : Form
    {
        public int idItem;
        public Licitacion_Item_Visualizar()
        {
            InitializeComponent();
        }

        public void mostrarinfoItem(int iditem)
        {
            this.idItem = iditem;
            var current = Item.GetItems().Where(x => x.Id == iditem).Single();
            lbl_licit.Text = Licitacion.GetBases()
                   .Where(x => x.Id == Partida.GetPartidas()
                   .Where(z => z.Id == Procedimiento.GetProcedimientos()
                   .Where(y => y.Id == current.Procedimiento).Single().Partida)
                   .Single().IdBases).Single().NumeroLicitacion;
            lbl_partida.Text = Partida.GetPartidas()
                   .Where(z => z.Id == Procedimiento.GetProcedimientos()
                   .Where(y => y.Id == current.Procedimiento).Single().Partida).Single().Nombre;
            lbl_sub.Text = Procedimiento.GetProcedimientos().Where(y => y.Id == current.Procedimiento).Single().Nombre;
            lbl_ccb.Text = current.Ccb;
            lbl_num.Text = current.Numero.ToString();
            lbl_desc.Text = current.Nombre;
            lbl_uni.Text = current.Unidad;
            lbl_cant.Text = current.Cantidad.ToString();
            lbl_cont.Text = current.Contenedor;
            lbl_min.Text = current.Minimo.ToString();
            lbl_max.Text = current.Maximo.ToString();
            foreach (CucopVinculos item in current.Vinculos)
            {
                int opctxt = item.Opcion;
                TabPage opcion = new TabPage();
                opcion.Text = "Opcion " + opctxt;
                VisualizarDocumentacionCucop opt = new VisualizarDocumentacionCucop();
                opcion.Controls.Add(opt);
                tabOpciones.TabPages.Add(opcion);
                opt.mostrarDocumentacionOpcion(item.Id);
            }

        }
    }
}
