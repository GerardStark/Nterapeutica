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
using LibLicitacion;
using System.IO;

namespace AppLicitaciones
{
    public partial class Registros_Visualizar : Form
    {
        MainConfig mc = new MainConfig();
        int id_registro;
        public Registros_Visualizar()
        {
            InitializeComponent();
        }
        public void mostrarinforegistro(int id_registro)
        {
            this.id_registro = id_registro;
            SqlConnection con = new SqlConnection(mc.con);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Registros_Sanitarios Where id_registro = @id",con);
            cmd.Parameters.AddWithValue("@id", id_registro);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                lbl_reg_numero.Text = dt.Rows[0]["numero_registro"].ToString();
                lbl_reg_solicitud.Text = dt.Rows[0]["numero_solicitud"].ToString();
                lbl_reg_titular.Text = dt.Rows[0]["titular"].ToString();
                lbl_reg_fabricante.Text = dt.Rows[0]["fabricante"].ToString();
                lbl_reg_marca.Text = dt.Rows[0]["marca"].ToString();
                lbl_rfc.Text = dt.Rows[0]["rfc"].ToString();
                //encontrar pais
                lbl_reg_pais.Text = mc.obtenernombrepais(Convert.ToInt32(dt.Rows[0]["pais_origen"]));
                
                lbl_reg_emision.Text = dt.Rows[0]["fecha_emision"].ToString();
                lbl_reg_vencimiento.Text = dt.Rows[0]["fecha_vencimiento"].ToString();
                lbl_reg_archivo.Text = dt.Rows[0]["dir_archivo"].ToString();
                lbl_distintiva.Text = dt.Rows[0]["denom_distintiva"].ToString();
                lbl_generica.Text = dt.Rows[0]["denom_generica"].ToString();
                lbl_reg_tipo.Text = dt.Rows[0]["tipo"].ToString();
            }
        }        

        private void btn_reg_borrar_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(id_registro.ToString());
            DialogResult dialogResult = MessageBox.Show("Seguro que desea borrar el registro sanitario? Esta acción no se puede deshacer", "Borrar Registro Sanitario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd_referencias = new SqlCommand("Select id_clave_registro from registros_claves_referencias where id_registro_sanitario = @idref",con);
                cmd_referencias.Parameters.AddWithValue("@idref", id_registro);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd_referencias);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DialogResult resultclaves = MessageBox.Show("El Registro Sanitario tiene referencias que dependen de el y tiene que ser borrados primero, ¿Desea seguir?", "Borrar Referencias del Registro Sanitario", MessageBoxButtons.YesNo);
                    if (resultclaves == DialogResult.Yes)
                    {
                        try
                        {
                            SqlCommand cmd_claves = new SqlCommand("Delete from registros_claves_referencias where id_registro_sanitario = @id_ref", con);
                            cmd_claves.Parameters.AddWithValue("@id_ref", id_registro);
                            cmd_claves.ExecuteNonQuery();
                            MessageBox.Show("Referencias Borradas");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                SqlCommand cmd_prorrogas = new SqlCommand("Select id_tramite_prorroga from registros_tramites_prorroga where id_registro_sanitario = @idpro", con);
                cmd_prorrogas.Parameters.AddWithValue("@idpro", id_registro);
                SqlDataAdapter adaptd = new SqlDataAdapter(cmd_prorrogas);
                DataTable dts = new DataTable();
                adaptd.Fill(dts);
                if (dts.Rows.Count > 0)
                {
                    DialogResult resultclaves = MessageBox.Show("El Registro Sanitario tiene prorrogas que dependen de el y tiene que ser borrados primero, ¿Desea seguir?", "Borrar Prorrogas del Registro Sanitario", MessageBoxButtons.YesNo);
                    if (resultclaves == DialogResult.Yes)
                    {
                        try
                        {
                            SqlCommand cmd_tramites = new SqlCommand("Delete from registros_tramites_prorroga where id_registro_sanitario = @id_pro", con);
                            cmd_tramites.Parameters.AddWithValue("@id_pro", id_registro);
                            cmd_tramites.ExecuteNonQuery();
                            MessageBox.Show("Prorrogas Borradas");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
                SqlCommand cmd_registro = new SqlCommand("Delete From registros_sanitarios where id_registro = @id_reg", con);
                cmd_registro.Parameters.AddWithValue("@id_reg", id_registro);
                cmd_registro.ExecuteNonQuery();
                MessageBox.Show("Registro Borrado");
                con.Close();
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
            else
            {
                MessageBox.Show("Acción Cancelada");
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void btn_reg_editar_Click(object sender, EventArgs e)
        {
            Registros_Editar re = new Registros_Editar();
            re.llenarcamposregistro(id_registro);
            DialogResult result2 = re.ShowDialog();
            this.Hide();
            if (result2 == DialogResult.OK)
            {
                MessageBox.Show("Registro Actualizado.");
                mostrarinforegistro(id_registro);
                this.Show();
            }
            else
            {
                MessageBox.Show("No se modifico el registro.");
                this.Show();
                
            }
        }

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btn_archivo_abrir_Click(object sender, EventArgs e)
        {
            string newpath = Path.GetDirectoryName(Application.ExecutablePath) + @"\DocumentosNT\Registros-Sanitarios\";
            string pathanexos = newpath + "\\" + id_registro + "\\"+lbl_reg_archivo.Text;

            if (lbl_reg_archivo.Text != "(Vacio)")
            {
                try
                {
                    System.Diagnostics.Process.Start(pathanexos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
