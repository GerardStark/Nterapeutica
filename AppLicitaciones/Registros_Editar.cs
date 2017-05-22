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
    public partial class Registros_Editar : Form
    {
        MainConfig mc = new MainConfig();
        int id_fabricante;
        public Registros_Editar()
        {
            InitializeComponent();
        }
        public void llenarcamposregistro(int id_registro)
        {
            MessageBox.Show(id_registro.ToString());
            SqlConnection con = new SqlConnection(mc.con);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Registros_Sanitarios Where id_registro = @id", con);
            cmd.Parameters.AddWithValue("@id", id_registro);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                txt_numero.Text = dt.Rows[0]["numero_registro"].ToString();
                txt_solicitud.Text = dt.Rows[0]["numero_solicitud"].ToString();
                txt_titular.Text = dt.Rows[0]["titular"].ToString();
                txt_fabricante.Text = dt.Rows[0]["fabricante"].ToString();
                txt_marca.Text = dt.Rows[0]["marca"].ToString();
                txt_nacionalidad.Text = dt.Rows[0]["nacionalidad"].ToString();
                txt_tlc.Text = dt.Rows[0]["tratado_comercio"].ToString();
                date_emision.Value = Convert.ToDateTime(dt.Rows[0]["fecha_emision"]);
                date_vencimiento.Value = Convert.ToDateTime(dt.Rows[0]["fecha_vencimiento"]);
                lbl_archivo.Text = dt.Rows[0]["dir_archivo"].ToString();
                txt_distintiva.Text = dt.Rows[0]["denom_distintiva"].ToString();
                txt_generica.Text = dt.Rows[0]["denom_generica"].ToString();
            }
        }

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Se guardaran los cambios realizados, esta acción no se puede deshacer", "Actualizar Registro Sanitario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //TODO Actualizar Registro
                try
                {
                    MessageBox.Show("Registro Actualizado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Acción Cancelada");
            }
        }

        private void btn_select_fabricante_Click(object sender, EventArgs e)
        {
            FTD_Principal ftdp = new FTD_Principal();
            ftdp.llenartablaftd();
            DialogResult result = ftdp.ShowDialog();
            if (result == DialogResult.OK)
            {
                id_fabricante = ftdp.id_fabricante;
                txt_fabricante.Text = ftdp.nombre_fabricante;
            }
        }
    }
}
