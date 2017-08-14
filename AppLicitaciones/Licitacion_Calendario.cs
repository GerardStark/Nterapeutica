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
    public partial class Licitacion_Calendario : Form
    {
        MainConfig mc = new MainConfig();
        int idBases, idCalendario = -1;
        public Licitacion_Calendario()
        {
            InitializeComponent();
        }

        public void pasarIdLicitaciones(int idBases)
        {
            this.idBases = idBases;
        }

        public void mostrarFechasCalendario(int idBases)
        {
            this.idBases = idBases;
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * From licitacion_calendario WHERE id_bases = @idBases",con))
                {                    
                    cmd.Parameters.AddWithValue("@idBases",idBases);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        this.idCalendario = Convert.ToInt32(dt.Rows[0]["id_calendario"]);
                        dtp_publicacion.Value = Convert.ToDateTime(dt.Rows[0]["fecha_publicacion"]);
                        dtp_junta.Value = Convert.ToDateTime(dt.Rows[0]["fecha_junta_aclaraciones"]);
                        dtp_propuestas.Value = Convert.ToDateTime(dt.Rows[0]["fecha_apertura"]);
                        dtp_fallo.Value = Convert.ToDateTime(dt.Rows[0]["fecha_fallo"]);
                        dtp_firma.Value = Convert.ToDateTime(dt.Rows[0]["fecha_firma"]);
                        dtp_visita.Value = Convert.ToDateTime(dt.Rows[0]["fecha_visita"]);
                    }
                }
            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    if (idCalendario != -1)
                    {
                        using (SqlCommand cmd = new SqlCommand("licitaciones_calendario_update", con))
                        {
                            con.Open();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idCalendario", idCalendario);
                            cmd.Parameters.AddWithValue("@junta", dtp_junta.Value.Date);
                            cmd.Parameters.AddWithValue("@apertura", dtp_propuestas.Value.Date);
                            cmd.Parameters.AddWithValue("@fallo", dtp_fallo.Value.Date);
                            cmd.Parameters.AddWithValue("@firma", dtp_firma.Value.Date);
                            cmd.Parameters.AddWithValue("@visita", dtp_visita.Value.Date);
                            cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                            cmd.Parameters.AddWithValue("@publicacion", dtp_publicacion.Value.Date);
                            Int32 newId = cmd.ExecuteNonQuery();
                            if (newId > 0)
                            {
                                
                            }
                        }
                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand("licitaciones_calendario_insert", con))
                        {
                            con.Open();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idbases", idBases);
                            cmd.Parameters.AddWithValue("@junta", dtp_junta.Value.Date);
                            cmd.Parameters.AddWithValue("@apertura", dtp_propuestas.Value.Date);
                            cmd.Parameters.AddWithValue("@fallo", dtp_fallo.Value.Date);
                            cmd.Parameters.AddWithValue("@firma", dtp_firma.Value.Date);
                            cmd.Parameters.AddWithValue("@visita", dtp_visita.Value.Date);
                            cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                            cmd.Parameters.AddWithValue("@publicacion", dtp_publicacion.Value.Date);
                            Int32 newId = cmd.ExecuteNonQuery();
                        }
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
