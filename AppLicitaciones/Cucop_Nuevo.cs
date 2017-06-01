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
    public partial class Cucop_Nuevo : Form
    {
        MainConfig mc = new MainConfig();
        public Cucop_Nuevo()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //todo insertar en la tabla cucop
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO cucop (nombre_generico_espeficico,grupo,codigo) values(@nombre,@grupo,@ccb)",con);
                cmd.Parameters.AddWithValue("@nombre",txt_nombre_gen.Text);
                cmd.Parameters.AddWithValue("@grupo", txt_grupo.Text);
                cmd.Parameters.AddWithValue("@ccb", txt_codigo.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btn_descartar_Click(object sender, EventArgs e)
        {
            txt_nombre_gen.Text = "";
            txt_grupo.Text = "";
            txt_codigo.Text = "";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
