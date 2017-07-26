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
    public partial class Cucop_Vincular_General : Form
    {
        MainConfig mc = new MainConfig();
        public int idCucop = 0;
        public int cont = 0;
        public int idVinculo = 0;
        public Cucop_Vincular_General()
        {
            InitializeComponent();
        }
        public void mostrarvinculoscucop(int idCucop)
        {
            this.idCucop = idCucop;
            while (tabOpciones.TabPages.Count > 0)
            {
                tabOpciones.TabPages[0].Dispose();
            }
            try
            {
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT * From cucop_vinculos WHERE id_cucop_item = @item", con);
                    cmd.Parameters.AddWithValue("@item", idCucop);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //buscar opciones, y sus vinculaciones ya establecidas
                        int current = i + 1;
                        TabPage opcion = new TabPage();
                        opcion.Text = "Opcion " + current;
                        NuevaOpcion opt = new NuevaOpcion();
                        opcion.Controls.Add(opt);
                        tabOpciones.TabPages.Add(opcion);
                        opt.pasardatosvinculo(idCucop, current, Convert.ToInt32(dt.Rows[i]["id_vinculacion"]));
                        opt.mostrarNombreProducto(Text = dt.Rows[i]["nombre"].ToString());
                        opt.buscarRegistros(Convert.ToInt32(dt.Rows[i]["id_vinculacion"]));
                        opt.buscarCatalogos(Convert.ToInt32(dt.Rows[i]["id_vinculacion"]));
                        opt.buscarCertificados(Convert.ToInt32(dt.Rows[i]["id_vinculacion"]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO cucop_vinculos (opcion,id_cucop_item,actualizado_en) OUTPUT INSERTED.id_vinculacion
                    VALUES (@opt,@cucop,@update)", con);
                    cmd.Parameters.AddWithValue("@opt", cont);
                    cmd.Parameters.AddWithValue("@cucop", idCucop);
                    cmd.Parameters.AddWithValue("@update", DateTime.Now);
                    //cmd.Parameters.AddWithValue("@nombre");
                    Int32 newId = (Int32)cmd.ExecuteScalar();
                    mostrarvinculoscucop(idCucop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }       
    }  
}
