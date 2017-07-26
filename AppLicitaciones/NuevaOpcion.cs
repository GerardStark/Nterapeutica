using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLicitacion;
using System.Data.SqlClient;

namespace AppLicitaciones
{
    public partial class NuevaOpcion : UserControl
    {
        MainConfig mc = new MainConfig();
        int idCucop = 0;
        int optCucop = 0;
        int idVinculo = 0;
        public NuevaOpcion()
        {
            InitializeComponent();
        }

        public void mostrarNombreProducto(string nombre)
        {
            txt_nombre_prod.Text = nombre;
            btn_cambiar_nombre.Enabled = false;
        }
        public void buscarRegistros(int idVinculo)
        {
            //Llena la lista de registros de la opcion existente
            list_vinc_reg.Rows.Clear();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"select a.id_registro from registros_sanitarios as a LEFT OUTER JOIN cucop_vinculos_registros as b ON a.id_registro = b.id_registro 
                WHERE b.id_cucop_vinculo = @idVinculo", con);
                cmd.Parameters.AddWithValue("@idVinculo",idVinculo);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    list_vinc_reg.Rows.Add(mc.obtenernumeroregistro((Int32)dr["id_registro"]));
                }
            }
        }

        public void buscarCatalogos(int idVinculo)
        {
            //Llena la lista de catalogos de la opcion existente
            list_vinc_cat.Rows.Clear();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"select a.id_catalogo from catalogos_info_general as a LEFT OUTER JOIN cucop_vinculos_catalogos as b ON a.id_catalogo = b.id_catalogo 
                WHERE b.id_cucop_vinculo = @idVinculo", con);
                cmd.Parameters.AddWithValue("@idVinculo", idVinculo);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    list_vinc_cat.Rows.Add(mc.obtenernombrecatalogo((Int32)dr["id_catalogo"]));
                }
            }
        }

        public void buscarCertificados(int idVinculo)
        {
            //Llena la lista de certificados de la opcion existente
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                list_vinc_cert.Rows.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand(@"select a.id_certificado from certificados_calidad as a LEFT OUTER JOIN cucop_vinculos_certificados as b ON a.id_certificado = b.id_certificados 
                WHERE b.id_cucop_vinculo = @idVinculo", con);
                cmd.Parameters.AddWithValue("@idVinculo", idVinculo);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    list_vinc_cert.Rows.Add(mc.obtenernumerocertificado((Int32)dr["id_certificado"]));
                }
            }
        }

        public void pasardatosvinculo(int idCucop, int opt, int vinc)
        {
            this.idCucop = idCucop;
            this.optCucop = opt;
            this.idVinculo = vinc;
            lbl_id_vinculo.Text = idVinculo.ToString();
        }

        private void btn_reg_vincular_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(""+idCucop+" "+optCucop+" "+idVinculo);
            Cucop_Vincular_Registro newForm = new Cucop_Vincular_Registro();
            newForm.mostrarVinculosRegistros(idVinculo);
            DialogResult result = newForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                buscarRegistros(idVinculo);
            }
        }

        private void btm_cat_vincular_Click(object sender, EventArgs e)
        {
            Cucop_Vincular_Catalogo newForm = new Cucop_Vincular_Catalogo();
            newForm.mostrarVinculosCatalogos(idVinculo);
            DialogResult result = newForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                buscarCatalogos(idVinculo);
            }
        }

        private void btn_cert_vincular_Click(object sender, EventArgs e)
        {
            Cucop_Vincular_Certificado newForm = new Cucop_Vincular_Certificado();
            newForm.mostrarVinculosCertificados(idVinculo);
            DialogResult result = newForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                buscarCertificados(idVinculo);
            }
        }

        private void txt_nombre_prod_TextChanged(object sender, EventArgs e)
        {
            btn_cambiar_nombre.Enabled = true;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Seguro que desea eliminar la opcion " + optCucop + "? Esto eliminara todos los vinculos de RECACE", "Borrar Opcion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(mc.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@" DELETE FROM cucop_vinculos_registros WHERE id_cucop_vinculo = @vinc;
                        DELETE FROM cucop_vinculos_catalogos WHERE id_cucop_vinculo = @vinc; 
                        DELETE FROM cucop_vinculos_certificados WHERE id_cucop_vinculo = @vinc;
                        DELETE FROM cucop_vinculos WHERE id_vinculacion = @vinc;
                        ", con);
                        cmd.Parameters.AddWithValue("@vinc", idVinculo);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }               
            }
        }

        private void btn_cambiar_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE cucop_vinculos SET nombre = @nombre WHERE id_vinculacion = @idVinc",con);
                    cmd.Parameters.AddWithValue("@idVinc",idVinculo);
                    cmd.Parameters.AddWithValue("@nombre",txt_nombre_prod.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cambiado");
                    btn_cambiar_nombre.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
