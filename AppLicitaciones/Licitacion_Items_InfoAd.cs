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
using System.Data.SqlClient;

namespace AppLicitaciones
{
    public partial class Licitacion_Items_InfoAd : Form
    {
        int idSub = 0, idInfo = 0;
        MainConfig mc = new MainConfig();
        public Licitacion_Items_InfoAd()
        {
            InitializeComponent();
        }

        public void mostrarInfosProce(int idSub)
        {
            dgvInfos.Rows.Clear();
            this.idSub = idSub;
            var infos = Procedimiento.GetProcedimientos().Where(x => x.Id == idSub).Single().Infos.ToList();
            foreach (ProceInfoAd info in infos)
            {
                dgvInfos.Rows.Add(info.Id, info.Nombre, info.Valor);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "licitacion_proce_infoad_insert";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idSub", idSub);
                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@valor",txt_valor.Text);
                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                    int result = cmd.ExecuteNonQuery();
                    if (result != 0)
                    {
                        mostrarInfosProce(idSub);
                    }
                }
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (idInfo != 0)
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM licitacion_items_info_Ad WHERE id = @id", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", idInfo);
                        int result = cmd.ExecuteNonQuery();
                        if (result != 0)
                        {
                            mostrarInfosProce(idSub);
                        }
                    }
                }
            }
        }

        private void dgvInfos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                idInfo = (Int32)dgvInfos.Rows[e.RowIndex].Cells["idColumn"].Value;
                txt_nombre.Text = dgvInfos.Rows[e.RowIndex].Cells["nombreColumn"].Value.ToString();
                txt_valor.Text = dgvInfos.Rows[e.RowIndex].Cells["valorColumn"].Value.ToString();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (idInfo != 0)
            {
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = "licitacion_proce_infoad_update";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idinfo", idInfo);
                        cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                        cmd.Parameters.AddWithValue("@valor", txt_valor.Text);
                        cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                        int result = cmd.ExecuteNonQuery();
                        if (result != 0)
                        {
                            mostrarInfosProce(idSub);
                        }
                    }
                }
            }
        }
    }
}
