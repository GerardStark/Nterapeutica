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
                if (col.Index == 3)
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
            foreach (Cucop c in Cucop.GetCucops())
            {
                dgvCucops.Rows.Add(c.Id, c.Clave, c.Descripcion, c.Updated);
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            dgvCucops.Rows.Clear();
            foreach (Cucop c in Cucop.GetCucops().Where(x => x.Descripcion.Contains(txt_filtrar.Text)))
            {
                dgvCucops.Rows.Add(c.Id,c.Clave,c.Descripcion);
            }
        }

        private void dgvCucops_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Int32 idCucop = (Int32)dgvCucops.Rows[e.RowIndex].Cells["idColumn"].Value;
                Cucop_Visualizar form = new Cucop_Visualizar();
                form.mostrarinfocucop(idCucop);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.idCucop = form.id_cucop;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void bnt_cucosps_Click(object sender, EventArgs e)
        {
            Cucop_Principal form = new Cucop_Principal();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                llenarListaCucops();
                mc.buscarultimafilaeditada("cucop", dgvCucops);
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
