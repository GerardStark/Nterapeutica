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
            foreach (ProceInfoAd i in Procedimiento.GetProcedimientos().Where(x => x.Id == idSub).Single().Infos)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = i.Nombre + "Column";
                col.HeaderText = i.Valor;
                if (!dgvItems.Columns.Contains(i.Nombre + "Column"))
                {
                    dgvItems.Columns.Add(col);
                }
            }

            foreach (Item i in Item.GetItemsPorProcedimiento(idSub))
            {
                var infoproce = Procedimiento.GetProcedimientos().Where(x => x.Id == i.Procedimiento).Single().Infos.ToList();
                dgvItems.Rows.Add(i.Id,i.Procedimiento, i.Unidad, i.Nombre, getVinculaciones(i.Id), i.Updated);                                             
            }
        }        

        private string getVinculaciones(int idItem)
        {
            string nombres = "";
            if (Item.GetItems().Where(x => x.Id == idItem).Single().Vinculos.Any())
            {
                foreach (CucopVinculos item in Item.GetItems().Where(x => x.Id == idItem).Single().Vinculos)
                {
                    nombres = nombres +", "+ item.Nombre;
                }
                return nombres;
            }
            return "Sin Documentación";
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
                //case "ofertaColumn":
                //    if (e.Value != null && e.Value != DBNull.Value && Convert.ToInt32(e.Value) > 0)
                //    {
                //        e.Value = mc.obtenerDescripcionCucop(Convert.ToInt32(dgvItems.Rows[e.RowIndex].Cells["ofertaColumn"].Value));
                //    }
                //    else
                //    {
                //        e.Value = "Sin oferta";
                //    }
                //    break;
                case "idColumn":
                    e.Value = e.RowIndex + 1;
                    break;
            }
        }

        private void btn_oferta_Click(object sender, EventArgs e)
        {
            if (idItem != 0)
            {
                Cucop_Vincular_General cvg = new Cucop_Vincular_General();
                cvg.mostrarvinculoscucop(idItem);
                DialogResult result = cvg.ShowDialog();
                mostrarItemsPorProcedimiento(idSub);
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
            if (idSub != 0)
            {
                DialogResult result = MessageBox.Show("Borrar Procedimiento? Esto borrata toda la informacion relacionada al procedimiento/subpartida", "Borrar Procedimiento/Subpartida", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var proce = Procedimiento.GetProcedimientos().Where(x => x.Id == idSub).Single();
                    using (SqlConnection con = new SqlConnection(mc.con))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = con;
                            foreach (Item i in proce.Items)
                            {
                                foreach (CucopVinculos v in i.Vinculos)
                                {
                                   
                                    cmd.CommandText = "DELETE FROM cucup_vinculos WHERE id_vinculacion=" + v.Id;
                                    cmd.ExecuteNonQuery();
                                }

                                foreach (Pregunta p in i.Preguntas)
                                {
                                    cmd.CommandText = "DELETE FROM licitacion_preguntas WHERE id=" + p.Id;
                                    cmd.ExecuteNonQuery();
                                }

                                foreach (ItemInfoAd f in i.Infos)
                                {
                                    cmd.CommandText = "DELETE FROM licitacion_itenms_info_ad_vinc WHERE id=" + f.Id;
                                    cmd.ExecuteNonQuery();
                                }
                                cmd.CommandText = "DELETE FROM licitacion_items WHERE id_item=" + i.Id;
                                cmd.ExecuteNonQuery();
                            }
                            cmd.CommandText = "DELETE FROM licitacion_subpar_proce WHERE id=" + proce.Id;
                            cmd.ExecuteNonQuery();
                        }                        
                    }
                    idSub = 0;
                    MessageBox.Show("Procedimiento/Subpartida Eliminado");
                    MostrarProcedimientosPorPartida(idPartida);

                }
                else
                {
                    MessageBox.Show("Cancelado");
                }
            }
            
        }

        private void btn_item_borrar_Click(object sender, EventArgs e)
        {
            if (idItem != 0)
            {
                DialogResult result = MessageBox.Show("Borrar item? esto borrara toda la informacion relacionada al item", "Borrar Item", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var item = Item.GetItems().Where(x => x.Id == idItem).Single();
                    using (SqlConnection con = new SqlConnection(mc.con))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = con;
                            foreach (CucopVinculos v in item.Vinculos)
                            {
                                
                                cmd.CommandText = "DELETE FROM cucup_vinculos WHERE id_vinculacion=" + v.Id;
                                cmd.ExecuteNonQuery();
                            }

                            foreach (Pregunta p in item.Preguntas)
                            {
                                cmd.CommandText = "DELETE FROM licitacion_preguntas WHERE id=" + p.Id;
                                cmd.ExecuteNonQuery();
                            }

                            foreach (ItemInfoAd f in item.Infos)
                            {
                                cmd.CommandText = "DELETE FROM licitacion_info_ad_vinc WHERE id=" + f.Id;
                                cmd.ExecuteNonQuery();
                            }
                            cmd.CommandText = "DELETE FROM licitacion_items WHERE id_item=" + item.Id;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    idItem = 0;
                    MessageBox.Show("Item Eliminado");
                    mostrarItemsPorProcedimiento(idSub);

                }
                else
                {
                    MessageBox.Show("Cancelado");
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_preguntas_ja_Click(object sender, EventArgs e)
        {
            Licitacion_Items_InfoAd form = new Licitacion_Items_InfoAd();
            form.mostrarInfosProce(idSub);
            form.Show();
        }

        private void Licitacion_Tecnica_Load(object sender, EventArgs e)
        {
            int proces = Procedimiento.GetProcedimientosPorPartidas(idPartida).Count;
            lbl_proces.Text = proces.ToString();
            int items = 0;
            foreach (Procedimiento p in Procedimiento.GetProcedimientosPorPartidas(idPartida))
            {
                items = items +p.Items.Count;
            }
            lbl_items.Text = items.ToString();
            int nodocs = 0;
            foreach (Procedimiento p in Procedimiento.GetProcedimientosPorPartidas(idPartida))
            {
                foreach (Item i in p.Items)
                {
                    if (!i.Vinculos.Any())
                    {
                        nodocs++;
                    }
                }
            }
            lbl_itemssr.Text = nodocs.ToString();



        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            Licitacion_Items_Buscar form = new Licitacion_Items_Buscar();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                dgvItems.Rows.Clear();
                string filtro = form.filtro;               
                foreach (Item i in Item.GetItemsPorProcedimiento(idSub))
                {
                    if (i.Nombre.Contains(filtro))
                    {
                        dgvItems.Rows.Add(i.Id, i.Procedimiento, i.Unidad, i.Nombre, "", i.Updated);
                    }                  
                }               
            }
        }

        private void btn_preguntas_Click(object sender, EventArgs e)
        {
            if (idItem != 0)
            {
                licitacion_junta_preguntas form = new licitacion_junta_preguntas();
                form.mostrarInfoPregunta(idItem);
                form.Show();
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
 