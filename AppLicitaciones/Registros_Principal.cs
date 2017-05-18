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

namespace AppLicitaciones
{
    public partial class Registros_Principal : Form
    {
        MainConfig mc = new MainConfig();
        public Registros_Principal()
        {
            InitializeComponent();
            llenartablaregistros();
        }
        private void btn_reg_nuevo_Click(object sender, EventArgs e)
        {
            Registros_Nuevo rn = new Registros_Nuevo();
            DialogResult result = rn.ShowDialog();
            if (result == DialogResult.OK)
            {
                llenartablaregistros();
            }
        }       
        private void btn_reg_buscar_Click(object sender, EventArgs e)
        {
            Registros_Nuevo rn = new Registros_Nuevo();
            DialogResult result = rn.ShowDialog();
            if (result == DialogResult.OK)
            {
                filtrartablaregistros();
            }
        }
        public void llenartablaregistros()
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("Select id_registro,numero_registro,numero_solicitud,tipo,titular,fabricante,marca,nacionalidad,tratado_comercio," +
                    "fecha_emision,fecha_vencimiento from registros_sanitarios", con);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DGVRegistros.Rows.Add(dr.ItemArray);

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void filtrartablaregistros()
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from registros_sanitarios", con);
                SqlDataAdapter adapt = new SqlDataAdapter();
                adapt.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                con.Close();
                DataView dv = new DataView(dt);
                //TODO
                //StringBuilder sb = new StringBuilder();
                //dv.RowFilter = string.Format("titular = '{2}' OR numero Like '%{0}%'" +
                //    "OR tipo_producto = '{1}' OR solicitud_tramite Like '%{0}%' OR denominacion_distintiva Like '%{0}%' OR denominacion_generica Like '%{0}%'"
                //    , txt_buscar.Text, buscartipoprod(txt_buscar.Text), getidproveedor(txt_buscar.Text));
                //dataGridView1.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
    
    
}
