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
    public partial class Licitacion_Procedimientos_Nuevo : Form
    {
        MainConfig mc = new MainConfig();
        int idPartida, numProcedimiento;
        public Licitacion_Procedimientos_Nuevo()
        {
            InitializeComponent();
        }
        public void pasarIdPartida(int idPartida)
        {
            this.idPartida = idPartida;
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT id,numero_subpartida,nombre_subpartida,id_partida FROM licitacion_subpar_proce" +
                    " WHERE id_partida = @idPartida", con))
                {
                    cmd.Parameters.AddWithValue("@idPartida", idPartida);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    this.numProcedimiento = dt.Rows.Count + 1;
                    txt_numero.Text = numProcedimiento.ToString();
                }
            }

        }

        private void btn_reg_descartar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Licitacion_Procedimientos_Nuevo_Load(object sender, EventArgs e)
        {

        }

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = @"insert_licitacion_procedimiento";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPartida",idPartida);
                    cmd.Parameters.AddWithValue("@numero",txt_numero.Text);
                    cmd.Parameters.AddWithValue("@nombre",txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                    Int32 newId = cmd.ExecuteNonQuery();
                    if (newId != 0)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }
    }
}
