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
        public Cucop_Editar()
        {
            InitializeComponent();
        }

        public void llenarinfocucop(int id_cucop)
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select nombre_generico_espeficico,grupo,codigo from cucop where id_cucop = @id",con);
                cmd.Parameters.AddWithValue("@id",id_cucop);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    txt_codigo.Text = dt.Rows[0]["codigo"].ToString();
                    txt_grupo.Text = dt.Rows[0]["grupo"].ToString();
                    txt_nombre_gen.Text = dt.Rows[0]["nombre_generico_espeficico"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
