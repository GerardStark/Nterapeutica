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
            DialogResult result = MessageBox.Show("Se va a borrar el Cucop/item y todos sus vinculos de Registros, Certificados y Catálogos, Continuar?", "Borrar Cucop",MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(mc.con))
                    {
                        con.Open();
                        //Busca los Vinculos (CHILD) del CUCOP/ITEM (parent)
                        using (SqlCommand cmdvinculos = new SqlCommand(@"SELECT * FROM cucop_vinculos WHERE id_cucop_item = @idcucop", con))
                        {
                            cmdvinculos.Parameters.AddWithValue("@idCucop", id_cucop);
                            SqlDataAdapter adapt = new SqlDataAdapter(cmdvinculos);
                            DataTable dt = new DataTable();
                            adapt.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                //Busca los Registros Vinculados (GRANDCHILD) de los vinculos (CHILD)
                                using (SqlCommand cmdRegVinc = new SqlCommand(@"SELECT * FROM cucop_vinculos_registros WHERE id_cucop_vinculo = @idVinc", con))
                                {
                                    cmdRegVinc.Parameters.AddWithValue("@idVinc", Convert.ToInt32(dt.Rows[0]["id_vinculacion"]));
                                    SqlDataAdapter adaptRegVinc = new SqlDataAdapter(cmdRegVinc);
                                    DataTable dtRegVinc = new DataTable();
                                    adaptRegVinc.Fill(dtRegVinc);
                                    if (dtRegVinc.Rows.Count > 0)
                                    {
                                        foreach (DataRow row in dtRegVinc.Rows)
                                        {
                                            //Busca y borra las referencias (GRANGRANCHILD) de los registros Vinculados y luego los borra (GRANDCHILD) 
                                            using (SqlCommand cmdRegRef = new SqlCommand(@"DELETE FROM cucop_vinculos_registros_referencias Where id_vinculo_registro =  @idVinculoReg;
                                                                                   DELETE FROM cucop_vinculos_registros WHERE id = @idVinculoReg", con))
                                            {
                                                cmdRegRef.Parameters.AddWithValue("@idVinculoReg", Convert.ToInt32(row["id"]));
                                                cmdRegRef.ExecuteNonQuery();
                                            }
                                        }
                                    }

                                }

                                //Busca los Certificados Vinculados (GRANDCHILD) de los vinculos (CHILD)
                                using (SqlCommand cmdCertVinc = new SqlCommand(@"DELETE FROM cucop_vinculos_certificados WHERE id_cucop_vinculo = @idVinc", con))
                                {
                                    cmdCertVinc.Parameters.AddWithValue("@idVinc", Convert.ToInt32(dt.Rows[0]["id_vinculacion"]));
                                    cmdCertVinc.ExecuteNonQuery();
                                }

                                //Busca los Catalogos Vinculados (GRANDCHILD) de los vinculos (CHILD)
                                using (SqlCommand cmdCatVinc = new SqlCommand(@"SELECT * FROM cucop_vinculos_catalogos WHERE id_cucop_vinculo = @idVinc", con))
                                {
                                    cmdCatVinc.Parameters.AddWithValue("@idVinc", Convert.ToInt32(dt.Rows[0]["id_vinculacion"]));
                                    SqlDataAdapter adaptCatVinc = new SqlDataAdapter(cmdCatVinc);
                                    DataTable dtCatVinc = new DataTable();
                                    adaptCatVinc.Fill(dtCatVinc);
                                    if (dtCatVinc.Rows.Count > 0)
                                    {
                                        foreach (DataRow row in dtCatVinc.Rows)
                                        {
                                            //Busca y borra las referencias (GRANGRANCHILD) de los catalogos Vinculados y luego los borra (GRANDCHILD) 
                                            using (SqlCommand cmdCatRef = new SqlCommand(@"DELETE FROM cucop_vinculos_catalogos_referencias Where id_vinculo_catalogo = @idVinculoCat
                                                                                       DELETE FROM cucop_vinculos_catalogos WHERE id = @idVinculoCat", con))
                                            {
                                                cmdCatRef.Parameters.AddWithValue("@idVinculoCat", Convert.ToInt32(row["id"]));
                                                cmdCatRef.ExecuteNonQuery();
                                            }
                                        }
                                    }

                                }
                            }
                        }


                        //BORRA los Vinculos del Cucop/Item (CHILD) y luego borra el CUCOP (PARENT)
                        using (SqlCommand cmd = new SqlCommand(@"DELETE FROM cucop_vinculos WHERE id_cucop_item = @idCucop;
                                                             DELETE FROM cucop WHERE id_cucop = @idCucop",con))
                        {
                            
                            cmd.Parameters.AddWithValue("@idCucop", id_cucop);
                            int state = cmd.ExecuteNonQuery();
                            if (state != 0)
                            {
                                MessageBox.Show("Borrado");
                                this.DialogResult = DialogResult.OK;
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
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
