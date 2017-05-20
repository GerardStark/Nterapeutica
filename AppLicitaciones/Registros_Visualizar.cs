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
        public static int id_registro;
        public int pasaridregistro(int id_registro)
        {
            return id_registro;
        }
        public Registros_Visualizar()
        {
            InitializeComponent();
            MessageBox.Show(id_registro.ToString());
            mostrarinforegistro(id_registro);
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
                lbl_reg_numero.Text = dt.Rows[0]["id_registro"].ToString();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }


        }

        private void btn_reg_borrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
