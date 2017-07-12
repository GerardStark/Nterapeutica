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
                SqlCommand cmd = new SqlCommand("Select * from cucop where id_cucop = @id", con);
                cmd.Parameters.AddWithValue("@id", id_cucop);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    lbl_clave.Text = dt.Rows[0]["clave"].ToString();
                    lbl_desc.Text = dt.Rows[0]["descripcion"].ToString();
                    lbl_spec.Text = dt.Rows[0]["especialidad"].ToString();
                    lbl_tipo.Text = dt.Rows[0]["presentacion_tipo"].ToString();
                    lbl_cant.Text = dt.Rows[0]["presentacion_cant"].ToString();
                    lbl_cont.Text = dt.Rows[0]["presentacion_cont"].ToString();
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
                MessageBox.Show("CUCOP Actualizado.");
                mostrarinfocucop(id_cucop);
                this.Show();
            }
            else
            {
                MessageBox.Show("No se modifico el CUCOP.");
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
