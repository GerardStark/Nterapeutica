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
    public partial class Cucop_Editar : Form
    {
        MainConfig mc = new MainConfig();
        int id_cucop = 0;
        public Cucop_Editar()
        {
            InitializeComponent();
        }

        public void llenarinfocucop(int id_cucop)
        {
            this.id_cucop = id_cucop;
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select nombre_generico_especifico,grupo,codigo from cucop where id_cucop = @id", con);
                cmd.Parameters.AddWithValue("@id",id_cucop);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    txt_codigo.Text = dt.Rows[0]["codigo"].ToString();
                    txt_grupo.Text = dt.Rows[0]["grupo"].ToString();
                    txt_nombre_gen.Text = dt.Rows[0]["nombre_generico_especifico"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE cucop SET nombre_generico_espeficico = @nombre, grupo = @grupo, codigo = @codigo "+
                    "WHERE id_cucop = @id",con);
                cmd.Parameters.AddWithValue("@id",id_cucop);
                cmd.Parameters.AddWithValue("@nombre", txt_nombre_gen.Text);
                cmd.Parameters.AddWithValue("@grupo",txt_grupo.Text);
                cmd.Parameters.AddWithValue("@codigo", txt_codigo.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
