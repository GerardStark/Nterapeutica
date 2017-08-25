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
            Procedimiento.GetProcedimientos();
            foreach(Procedimiento p in Procedimiento.GetProcedimientosPorPartidas(idPartida))
            {
                dgvProcedimientos.Rows.Add(p.Id,p.Partida,p.Numero,p.Nombre);
            }
        }

        private void mostrarItemsPorProcedimiento(int idSub)
        {
            dgvItems.Rows.Clear();
            foreach (Item i in Item.GetItemsPorProcedimiento(idSub))
            {
                dgvItems.Rows.Add(i.Id, i.Procedimiento, i.Unidad, i.Nombre);

            }
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                idItem = Convert.ToInt32(dgvItems.Rows[e.RowIndex].Cells["idItemColumn"].Value);
            }
        }

        private void btn_proc_editar_Click(object sender, EventArgs e)
        {
            if (idSub != 0)
            {
                Licitacion_Procedimientos_Editar form = new Licitacion_Procedimientos_Editar();
                form.pasarInfoProcedimiento(idSub);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MostrarProcedimientosPorPartida(idPartida);
                }
            }
        }

        private void btn_item_nuevo_Click(object sender, EventArgs e)
        {
            Licitacion_Items_Nuevo form = new Licitacion_Items_Nuevo();
            form.pasarIdPartida(idSub);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                mostrarItemsPorProcedimiento(idSub);
            }
        }

        private void btn_item_editar_Click(object sender, EventArgs e)
        {
            if (idItem != 0)
            {
                Licitacion_Items_Editar form = new Licitacion_Items_Editar();
                form.mostrarInfoItem(idItem);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    mostrarItemsPorProcedimiento(idSub);
                }
            }
        }

        private void btn_proc_nuevo_Click(object sender, EventArgs e)
        {
            Licitacion_Procedimientos_Nuevo form = new Licitacion_Procedimientos_Nuevo();
            form.pasarIdPartida(idPartida);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                MostrarProcedimientosPorPartida(idPartida);
            }
        }

        private void dgvProcedimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dgvItems.Rows.Clear();
                idSub = Convert.ToInt32(dgvProcedimientos.Rows[e.RowIndex].Cells["idSubColumn"].Value);
                mostrarItemsPorProcedimiento(idSub);
            }
        }




        //obtener el id del procedimiento y mostrar los items en la OLV
    }

}
 