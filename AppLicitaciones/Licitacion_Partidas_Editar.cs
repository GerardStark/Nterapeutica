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
    public partial class Licitacion_Partidas_Editar : Form
    {
        MainConfig mc = new MainConfig();
        int idPartida;
        public Licitacion_Partidas_Editar()
        {
            InitializeComponent();
            string[] array_specs = {
                "Cirugia Cardiovascular",
                "Hemodinamia",
                "Urología",
                "Minima Invasion",
                "Endoscopia",
                "Terapia Endovascular Neurologica",
                "Marcapasos",
                "Material de Curacion",
                "Subrogados" };
            mc.llenarcombobox(array_specs, cmb_especialidad);
        }

        public void pasarInfoPartidas(int idPartida)
        {
            this.idPartida = idPartida;
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT id,numero_partida,nombre_partida,especialidad,id_bases FROM licitacion_partidas WHERE id = @idPartida", con))
                {
                    cmd.Parameters.AddWithValue("@idPartida", idPartida);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count != 0)
                    {
                        txt_numero.Text = dt.Rows[0]["numero_partida"].ToString();
                        txt_nombre.Text = dt.Rows[0]["nombre_partida"].ToString();
                        cmb_especialidad.SelectedIndex = mc.obtenervaluecomboitem(dt.Rows[0]["especialidad"].ToString(), cmb_especialidad);
                        txt_min.Text = dt.Rows[0]["minimo"].ToString();
                        txt_max.Text = dt.Rows[0]["maximo"].ToString();
                    }
                }
            }
        }

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("update_licitacion_partida", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPartida", idPartida);
                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@espec", (cmb_especialidad.SelectedItem as ComboboxItem).Text);
                    cmd.Parameters.AddWithValue("@max", txt_max.Text);
                    cmd.Parameters.AddWithValue("@min", txt_min.Text);
                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                    Int32 newId = cmd.ExecuteNonQuery();
                    if (newId != 0)
                    {
                        MessageBox.Show("Actualizado");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }
    }
}
