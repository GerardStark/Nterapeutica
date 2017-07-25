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
        }
        public void buscarRegistros(int idVinculo)
        {
            //Llena la lista de registros de la opcion existente
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
                    list_vinc_reg.Items.Add(dr["id_registro"].ToString());
                }
            }
        }

        public void buscarCatalogos(int idVinculo)
        {
            //Llena la lista de catalogos de la opcion existente
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
                    list_vinc_cat.Items.Add(dr["id_catalogo"].ToString());
                }
            }
        }

        public void buscarCertificados(int idVinculo)
        {
            //Llena la lista de certificados de la opcion existente
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"select a.id_certificado from certificados_calidad as a LEFT OUTER JOIN cucop_vinculos_certificados as b ON a.id_certificado = b.id_certificados 
                WHERE b.id_cucop_vinculo = @idVinculo", con);
                cmd.Parameters.AddWithValue("@idVinculo", idVinculo);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    list_vinc_cert.Items.Add(dr["id_certificado"].ToString());
                }
            }
        }

        public void pasardatosvinculo(int idCucop, int opt, int vinc)
        {
            this.idCucop = idCucop;
            this.optCucop = opt;
            this.idVinculo = vinc;
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
            DialogResult result = newForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //something
            }
        }

        private void btn_cert_vincular_Click(object sender, EventArgs e)
        {
            Cucop_Vincular_Certificado newForm = new Cucop_Vincular_Certificado();
            DialogResult result = newForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //something
            }
        }
    }
}
