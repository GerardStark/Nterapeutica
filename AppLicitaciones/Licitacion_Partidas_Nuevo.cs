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
    public partial class Licitacion_Partidas_Nuevo : Form
    {
        MainConfig mc = new MainConfig();
        int idBases = 0, numPartida = 0;
        public Licitacion_Partidas_Nuevo()
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

        public void pasarIdBases(int idBases)
        {
            this.idBases = idBases;
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT id,numero_partida,nombre_partida,especialidad,id_bases FROM licitacion_partidas WHERE id_bases = @idBases", con))
                {
                    cmd.Parameters.AddWithValue("@idBases", idBases);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    this.numPartida = dt.Rows.Count + 1;
                    txt_numero.Text = numPartida.ToString();
                }
            }
           
        }
        private void txt_limpiar_campos_Click(object sender, EventArgs e)
        {
            txt_numero.Text = "";
            txt_nombre.Text = "";
            cmb_especialidad.SelectedIndex = 0;
        }

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("insert_licitacion_partida",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idBases",idBases);
                    cmd.Parameters.AddWithValue("@numero", numPartida);
                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@espec", (cmb_especialidad.SelectedItem as ComboboxItem).Text);
                    cmd.Parameters.AddWithValue("@max",txt_max.Text);
                    cmd.Parameters.AddWithValue("@min", txt_min.Text);
                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                    Int32 newId = cmd.ExecuteNonQuery();
                    if (newId != 0)
                    {
                        MessageBox.Show("Guardado");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }
    }
}
