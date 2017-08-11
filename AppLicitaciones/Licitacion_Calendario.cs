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

        public void mostrarFechasCalendario(int idBases)
        {

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
                        cmd.Parameters.AddWithValue("@junta", dtp_junta.Value.Date);
                        cmd.Parameters.AddWithValue("@apertura", dtp_propuestas.Value.Date);
                        cmd.Parameters.AddWithValue("@fallo", dtp_fallo.Value.Date);
                        cmd.Parameters.AddWithValue("@firma", dtp_firma.Value.Date);
                        cmd.Parameters.AddWithValue("@visita", dtp_visita.Value.Date);
                        cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                        cmd.Parameters.AddWithValue("@publicacion", dtp_publicacion.Value.Date);
                        Int32 newId = cmd.ExecuteNonQuery();
                        if (newId != 0)
                        {
                            //Licitacion_Columnas form = new Licitacion_Columnas();
                            //form.mostrarColumnasBases(idBases);
                            //DialogResult result = form.ShowDialog();
                            //if (result == DialogResult.OK)
                            //{
                            //    this.DialogResult = DialogResult.OK;
                            //    this.Close();
                            //}
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
