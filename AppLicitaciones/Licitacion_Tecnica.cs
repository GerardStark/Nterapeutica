using LibLicitacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLicitaciones
{
    public partial class Licitacion_Tecnica : Form
    {
        int idPartida, idSub, idItem;
        MainConfig mc = new MainConfig();
        public Licitacion_Tecnica()
        {
            InitializeComponent();            
        }
        public void MostrarProcedimientosPorPartida(int idPartida)
        {
            this.idPartida = idPartida;
            dgvProcedimientos.Rows.Clear();
            foreach(Procedimiento p in Procedimiento.GetProcedimientosPorPartidas(idPartida))
            {
                dgvProcedimientos.Rows.Add(p.Id,p.Partida,p.Numero,p.Nombre);
            }
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                idItem = Convert.ToInt32(dgvItems.Rows[e.RowIndex].Cells["idItemColumn"].Value);
            }
        }

        private void btn_proc_nuevo_Click(object sender, EventArgs e)
        {

        }

        private void dgvProcedimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dgvItems.Rows.Clear();
                idSub = Convert.ToInt32(dgvProcedimientos.Rows[e.RowIndex].Cells["idSubColumn"].Value);
                foreach (Item i in Item.GetItemsPorProcedimiento(idSub))
                {
                    dgvItems.Rows.Add(i.Id, i.Procedimiento, i.Unidad, i.Nombre);
                }
            }
        }




        //obtener el id del procedimiento y mostrar los items en la OLV
    }

}
