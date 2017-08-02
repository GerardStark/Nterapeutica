using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibLicitacion;

namespace AppLicitaciones
{
    public partial class Visualizar_Opciones : UserControl
    {
        MainConfig mc = new MainConfig();
        public Visualizar_Opciones()
        {
            InitializeComponent();
        }

        public void mostrarNombreProducto(string nombre)
        {
            lbl_nombre_prod.Text = nombre;            
        }

        public void buscarRegistros(int idVinculo)
        {
            //Llena la lista de registros de la opcion existente
            
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"select a.id_registro from registros_sanitarios as a LEFT OUTER JOIN cucop_vinculos_registros as b ON a.id_registro = b.id_registro 
                WHERE b.id_cucop_vinculo = @idVinculo", con);
                cmd.Parameters.AddWithValue("@idVinculo", idVinculo);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Label lbl = new Label();
                    lbl.Text = mc.obtenernumeroregistro((Int32)dr["id_registro"]);
                    pnl_reg.Controls.Add(lbl);

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
                    Label lbl = new Label();
                    lbl.Text = mc.obtenernombrecatalogo((Int32)dr["id_catalogo"]);
                    pnl_cat.Controls.Add(lbl);

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
                    Label lbl = new Label();
                    lbl.Text = mc.obtenernumerocertificado((Int32)dr["id_certificado"]);
                    pnl_cert.Controls.Add(lbl);
                }
            }
        }
    }
}
