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
        int idBases;
        public Licitacion_Calendario()
        {
            InitializeComponent();
        }

        public void pasarIdLicitaciones(int idBases)
        {
            this.idBases = idBases;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    using (SqlCommand cmd = new SqlCommand("licitaciones_calendario_insert", con))
                    {
                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idbases", idBases);
                        cmd.Parameters.AddWithValue("@junta", dtp_junta.Text);
                        cmd.Parameters.AddWithValue("@apertura", dtp_propuestas.Text);
                        cmd.Parameters.AddWithValue("@fallo", dtp_fallo.Text);
                        cmd.Parameters.AddWithValue("@firma", dtp_firma.Text);
                        cmd.Parameters.AddWithValue("@visita", dtp_visita.Text);
                        cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                        cmd.Parameters.AddWithValue("@publicacion", dtp_publicacion.Text);
                        Int32 newId = cmd.ExecuteNonQuery();
                        if (newId != 0)
                        {
                            MessageBox.Show("Success");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                }
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
