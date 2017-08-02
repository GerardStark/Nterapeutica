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
                    txt_descripcion.Text = dt.Rows[0]["descripcion"].ToString();
                    lbl_spec.Text = dt.Rows[0]["especialidad"].ToString();
                    lbl_tipo.Text = dt.Rows[0]["presentacion_tipo"].ToString();
                    lbl_cant.Text = dt.Rows[0]["presentacion_cant"].ToString();
                    lbl_cont.Text = dt.Rows[0]["presentacion_cont"].ToString();
                   // mostrarVinculosCucop((Int32)dt.Rows[0]["id_cucop"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //private void mostrarVinculosCucop(int idCucop)
        //{
        //    tabOpciones.TabPages.Clear();
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(mc.con))
        //        {
        //            con.Open();
        //            SqlCommand cmd = new SqlCommand(@"SELECT * From cucop_vinculos WHERE id_cucop_item = @item", con);
        //            cmd.Parameters.AddWithValue("@item", idCucop);
        //            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
        //            DataTable dt = new DataTable();
        //            adapt.Fill(dt);
        //            for (int i = 0; i < dt.Rows.Count; i++)
        //            {
        //                //buscar opciones, y sus vinculaciones ya establecidas
        //                int current = i + 1;
        //                TabPage opcion = new TabPage();
        //                opcion.Text = "Opcion " + current;
        //                Visualizar_Opciones opt = new Visualizar_Opciones();
        //                opcion.Controls.Add(opt);
        //                tabOpciones.TabPages.Add(opcion);                        
        //                opt.mostrarNombreProducto(Text = dt.Rows[i]["nombre"].ToString());
        //                opt.buscarRegistros(Convert.ToInt32(dt.Rows[i]["id_vinculacion"]));
        //                opt.buscarCatalogos(Convert.ToInt32(dt.Rows[i]["id_vinculacion"]));
        //                opt.buscarCertificados(Convert.ToInt32(dt.Rows[i]["id_vinculacion"]));
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

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

        private void btn_vincular_Click(object sender, EventArgs e)
        {
            if (id_cucop != 0)
            {
                Cucop_Vincular_General cvg = new Cucop_Vincular_General();
                cvg.mostrarvinculoscucop(id_cucop);
                DialogResult result = cvg.ShowDialog();
                mostrarinfocucop(id_cucop);
                
            }
        }
    }
}
