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
        public int id_cucop = 0;
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
                var cucop = Cucop.GetCucops().Where(x => x.Id == id_cucop).Single();
                lbl_clave.Text = cucop.Clave;
                txt_descripcion.Text = cucop.Descripcion;
                lbl_spec.Text = cucop.Especialidad;
                lbl_tipo.Text = cucop.Presentacion;
                lbl_cant.Text = cucop.Cantidad.ToString(); ;
                lbl_cont.Text = cucop.Contenedor;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

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

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
