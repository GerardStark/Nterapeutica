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
        int idItem = 0, idInfo = 0;
        MainConfig mc = new MainConfig();
        public Licitacion_Items_InfoAd()
        {
            InitializeComponent();
        }

        public void mostrarInfosItem(int idItem)
        {
            this.idItem = idItem;
            var infos = Item.GetItems().Where(x => x.Id == idItem).Single().Infos.ToList();
            foreach (ItemInfoAd item in infos)
            {
                dgvInfos.Rows.Add(item.Id, item.Nombre, item.Valor);
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
                    cmd.CommandText = "licitacion_item_infoad_insert";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idItem",idItem);
                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@valor",txt_valor.Text);
                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                    int result = cmd.ExecuteNonQuery();
                    if (result != 0)
                    {
                        mostrarInfosItem(idItem);
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
                            mostrarInfosItem(idItem);
                        }
                    }
                }
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
                        cmd.CommandText = "licitacion_item_infoad_update";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idinfo", idInfo);
                        cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                        cmd.Parameters.AddWithValue("@valor", txt_valor.Text);
                        cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                        int result = cmd.ExecuteNonQuery();
                        if (result != 0)
                        {
                            mostrarInfosItem(idItem);
                        }
                    }
                }
            }
        }
    }
}
