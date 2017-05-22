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
    public partial class Registros_Visualizar : Form
    {
        MainConfig mc = new MainConfig();
        public Registros_Visualizar()
        {
            InitializeComponent();
        }
        public void mostrarinforegistro(int id_registro)
        {
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
                lbl_reg_nacionalidad.Text = dt.Rows[0]["nacionalidad"].ToString();
                lbl_reg_tlc.Text = dt.Rows[0]["tratado_comercio"].ToString();
                lbl_reg_emision.Text = dt.Rows[0]["fecha_emision"].ToString();
                lbl_reg_vencimiento.Text = dt.Rows[0]["fecha_vencimiento"].ToString();
                lbl_reg_archivo.Text = dt.Rows[0]["dir_archivo"].ToString();
                lbl_reg_distintiva.Text = dt.Rows[0]["denom_distintiva"].ToString();
                lbl_reg_generica.Text = dt.Rows[0]["denom_generica"].ToString();
            }
        }

        private void btn_reg_borrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que desea borrar el registro sanitario? Esta acción no se puede deshacer", "Borrar Registro Sanitario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Registro Borrado");
                //TODO Borrar Registro
            }
            else
            {
                MessageBox.Show("Acción Cancelada");
            }
        }

        private void btn_reg_editar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
