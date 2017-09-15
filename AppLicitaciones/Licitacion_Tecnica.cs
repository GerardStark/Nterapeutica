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
                
                dgvItems.Rows.Add(i.Id, i.Procedimiento, i.Unidad, i.Nombre, getVinculaciones(i.Id), getUltimoModificado(i.Id));
                mc.buscarultimafilaeditada("licitacion_vinculacion", dgvItems);

            }
        }

        private int getVinculaciones(int idItem)
        {
            try
            {
                int v = Vinculacion.GetVinculacionesPorItem(idItem).Single(x => x.Item == idItem).Cucop;
                return v;
            }
            catch (Exception)
            {
                return 0;
            }    
        }

        private DateTime getUltimoModificado(int idItem)
        {
            try
            {
                DateTime date = Vinculacion.GetVinculacionesPorItem(idItem).Single(x => x.Item == idItem).Updated;
                return date;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return DateTime.MinValue;
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

        private void dgvItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.dgvItems.Columns[e.ColumnIndex].Name)
            {
                case "ofertaColumn":
                    if (e.Value != null && e.Value != DBNull.Value && Convert.ToInt32(e.Value) > 0)
                    {
                        e.Value = mc.obtenerDescripcionCucop(Convert.ToInt32(dgvItems.Rows[e.RowIndex].Cells["ofertaColumn"].Value));
                    }
                    else
                    {
                        e.Value = "Sin oferta";
                    }
                    break;
                case "idColumn":
                    e.Value = e.RowIndex + 1;
                    break;
            }
        }

        private void btn_oferta_Click(object sender, EventArgs e)
        {
            if (idItem != 0)
            {
                Licitacion_Item_Oferta form = new Licitacion_Item_Oferta();
                form.mostrarInfoItemCucops(idItem);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    mostrarItemsPorProcedimiento(idSub);
                }
            }
        }

        private void dgvProcedimientos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.dgvProcedimientos.Columns[e.ColumnIndex].Name)
            {
                case "idColumn":
                    e.Value = e.RowIndex + 1;
                    break;
            }
        }

        private void btn_proc_borrar_Click(object sender, EventArgs e)
        {

        }

        private void btn_item_borrar_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_preguntas_ja_Click(object sender, EventArgs e)
        {

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
 