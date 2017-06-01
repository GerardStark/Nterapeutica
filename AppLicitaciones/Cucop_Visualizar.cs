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
    public partial class Cucop_Visualizar : Form
    {
        int id_cucop = 0;
        MainConfig mc = new MainConfig();
        public Cucop_Visualizar()
        {
            InitializeComponent();
        }
        public void mostrarinfocucop(int id_cucop)
        {
            this.id_cucop = id_cucop;
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select nombre_generico_espeficico,grupo,codigo from cucop where id_cucop = @id", con);
                cmd.Parameters.AddWithValue("@id", id_cucop);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    lbl_ccb.Text = dt.Rows[0]["codigo"].ToString();
                    lbl_grupo.Text = dt.Rows[0]["grupo"].ToString();
                    lbl_nombre_gen.Text = dt.Rows[0]["nombre_generico_espeficico"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Cucop_Editar re = new Cucop_Editar();
            re.llenarinfocucop(id_cucop);
            DialogResult result2 = re.ShowDialog();
            this.Hide();
            if (result2 == DialogResult.OK)
            {
                MessageBox.Show("Registro Actualizado.");
                mostrarinfocucop(id_cucop);
                this.Show();
            }
            else
            {
                MessageBox.Show("No se modifico el registro.");
                this.Show();

            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            //TODO borrar cucop
        }
    }
}
