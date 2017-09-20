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
    public partial class Cucop_Vinculos_Eliminar : Form
    {
        MainConfig mc = new MainConfig();
        int idCucop = 0;
        public Cucop_Vinculos_Eliminar()
        {
            InitializeComponent();
            this.dgv_vinculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vinculos.MultiSelect = false;
        }

        public void mostrarvinculoscucop(int idCucop)
        {
            this.idCucop = idCucop;
            dgv_vinculos.Rows.Clear();
            try
            {
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT id_vinculacion,opcion,nombre From cucop_vinculos WHERE id_item = @item", con);
                    cmd.Parameters.AddWithValue("@item", idCucop);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgv_vinculos.Rows.Add(dr.ItemArray);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_vinculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //MessageBox.Show(dgv_vinculos.Rows[e.RowIndex].Cells["idColumn"].Value.ToString());
                DialogResult result = MessageBox.Show("Seguro que desea borrar la opcion: " + dgv_vinculos.Rows[e.RowIndex].Cells["optColumn"].Value.ToString() + ". Esto Borrará todos los vinculos realizados","Borrar Opcion",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(mc.con))
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand(@"DELETE FROM cucop_vinculos_registros WHERE id_cucop_vinculo = @id;
                                                          DELETE FROM cucop_vinculos_catalogos WHERE id_cucop_vinculo = @id;
                                                          DELETE FROM cucop_vinculos_certificados WHERE id_cucop_vinculo = @id;
                                                          DELETE FROM cucop_vinculos WHERE id_vinculacion = @id;", con);
                            cmd.Parameters.AddWithValue("@id", (Int32)dgv_vinculos.Rows[e.RowIndex].Cells["idColumn"].Value);
                            cmd.ExecuteNonQuery();
                            mostrarvinculoscucop(idCucop);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                }
            }
        }

        private void Cucop_Vinculos_Eliminar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
