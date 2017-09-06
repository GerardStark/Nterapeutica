using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLicitacion;
using System.Data.SqlClient;

namespace AppLicitaciones
{
    public partial class licitacion_junta_preguntas : Form
    {
        MainConfig mc = new MainConfig();
        int idPregunta = 0;
        int idVinc;
        public licitacion_junta_preguntas()
        {
            InitializeComponent();
        }

        public void mostrarInfoPregunta(int idVinculo)
        {

            this.idVinc = idVinculo;
            Vinculacion vinc = Vinculacion.GetVinculaciones().Where(x => x.Id == idVinculo).Single();
            txt_item.Text = Item.GetItems().Where(x => x.Id == vinc.Item).Single().Nombre;
            txt_oferta.Text = Cucop.GetCucops().Where(x => x.Id == vinc.Cucop).Single().Descripcion;
            if (vinc.Preguntas.Count > 0)
            {
                txt_pregunta.Text = vinc.Preguntas.Single().Enunciado; 
                this.idPregunta = vinc.Preguntas.Single().Id;
            }
            else
            {
                txt_pregunta.Text = "Sin Pregunta";
                this.idPregunta = 0;
            }
           
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                if (idPregunta != 0)
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = "licitacion_pregunta_update";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idPregunta", idPregunta);
                        cmd.Parameters.AddWithValue("@enunciado", txt_pregunta.Text);
                        cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                        int confirm = cmd.ExecuteNonQuery();
                        if (confirm != 0)
                        {
                            MessageBox.Show("Guardado");
                        }

                    }
                }
                else
                {
                    using (SqlCommand cmdp = new SqlCommand("licitacion_pregunta_create", con))
                    {
                        cmdp.CommandType = CommandType.StoredProcedure;
                        cmdp.Parameters.AddWithValue("@idVinc", idVinc);
                        cmdp.Parameters.AddWithValue("@enunciado", txt_pregunta.Text);
                        cmdp.Parameters.AddWithValue("@updated", DateTime.Now);
                        int result = cmdp.ExecuteNonQuery();
                        if (result != 0)
                        {
                            MessageBox.Show("Guardado");
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
            }
        }
    }
}
