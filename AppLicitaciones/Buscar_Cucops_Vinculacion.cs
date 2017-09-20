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
    public partial class Buscar_Cucops_Vinculacion : Form
    {
        public int idCucop = 0;
        MainConfig mc = new MainConfig();
        public Buscar_Cucops_Vinculacion()
        {
            InitializeComponent();
            llenarListaCucops();
            foreach (DataGridViewColumn col in dgvCucops.Columns)
            {
                if (col.Index == 4)
                {
                    col.ReadOnly = false;
                }
                else
                {
                    col.ReadOnly = true;
                }
            }
        }

        private void llenarListaCucops()
        {
            dgvCucops.Rows.Clear();
            foreach (Item i in Item.GetItems())
            {
                var numlicit = Licitacion.GetBases()
                    .Where(x => x.Id == Partida.GetPartidas()
                    .Where(z => z.Id == Procedimiento.GetProcedimientos()
                    .Where(y => y.Id == i.Procedimiento).Single().Partida)
                    .Single().IdBases).Single().NumeroLicitacion;
                dgvCucops.Rows.Add(i.Id,numlicit, i.Ccb, i.Nombre, i.Updated);
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            dgvCucops.Rows.Clear();
            foreach (Item i in Item.GetItems().Where(x => x.Nombre.Contains(txt_filtrar.Text)))
            {
                dgvCucops.Rows.Add();
            }
        }

        private void dgvCucops_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Int32 idCucop = (Int32)dgvCucops.Rows[e.RowIndex].Cells["idColumn"].Value;
                Licitacion_Item_Visualizar form = new Licitacion_Item_Visualizar();
                form.mostrarinfoItem(idCucop);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.idCucop = form.idItem;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void dgvCucops_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.dgvCucops.Columns[e.ColumnIndex].Name)
            {

                case "idColumn":
                    e.Value = e.RowIndex + 1;
                    break;
            }
        }
    }
}
