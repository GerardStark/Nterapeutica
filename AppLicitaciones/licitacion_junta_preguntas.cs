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
        int idItem = 0;
        public licitacion_junta_preguntas()
        {
            InitializeComponent();
        }

        public void mostrarInfoPregunta(int idItem)
        {
            //anterior es la pregunta deseada :/
            this.idItem = idItem;
            txt_anterior.Text = Item.GetItems().Where(x => x.Id == idItem).Single().Nombre;
            if (Item.GetItems().Where(x => x.Id == idItem).Single().Preguntas.Any())
            {

                var pregunta = Item.GetItems().Where(x => x.Id == idItem).Single().Preguntas.Single();
                txt_deseada.Text = pregunta.Anterior;
                txt_pregunta.Text = pregunta.Enunciado;
            }
            else
            {
                txt_anterior.Text = Item.GetItems().Where(x => x.Id == idItem).Single().Nombre;
                txt_pregunta.Text = "No tiene enunciado";
                txt_deseada.Text = "No tiene descripcion";
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
                        cmd.Parameters.AddWithValue("@anterior",txt_deseada.Text);
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
                    using (SqlCommand cmdp = new SqlCommand("licitacion_pregunta_insert", con))
                    {
                        cmdp.CommandType = CommandType.StoredProcedure;
                        cmdp.Parameters.AddWithValue("@item", idItem);
                        cmdp.Parameters.AddWithValue("@enunciado", txt_pregunta.Text);
                        cmdp.Parameters.AddWithValue("@anterior", txt_deseada.Text);
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
