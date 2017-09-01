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
        private List<string> terminos = new List<string>();
        private List<Cucop> cucops = Cucop.GetCucops();
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

                dgvCucops.Rows.Add(c.Id, c.Clave, c.Descripcion);
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            dgvCucops.Rows.Clear();
            
            var terminos = txt_filtrar.Text.ToLower().Split(null);
            var termino = terminos[0];
            var result = from x in cucops where (x.Descripcion.Contains(termino)) select x;
            cucops.Clear();
            foreach (Cucop c in result)
            {
                dgvCucops.Rows.Add(c.Id, c.Clave, c.Descripcion);
                cucops.Add(c);
            }
        }

        private void dgvCucops_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Int32 idCucop = (Int32)dgvCucops.Rows[e.RowIndex].Cells["idColumn"].Value;
                Cucop_Visualizar form = new Cucop_Visualizar();
                form.mostrarinfocucop(idCucop);
                form.ShowDialog();
            }
        }
    }
}
