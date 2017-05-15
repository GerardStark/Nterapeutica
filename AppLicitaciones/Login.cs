using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLicitacion;
using System.Data.SqlClient;

namespace AppLicitaciones
{
    public partial class Login : Form
    {
        MainConfig mc = new MainConfig();
        public Login()
        {
            InitializeComponent();
        }
        //Se mantiene el tipo de usuario para brindar privilegios en los formularios posteriores
        public static int usertipo { get; set; }
        private void btn_login_Click(object sender, EventArgs e)
        {
            string cs = mc.con;
            if (txt_user.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Por favor introduce un Usuario y Contraseña Correctos.");
                return;
            }
            try
            {
                //Conexion de SQL
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from aux_users where nombre_usuario=@username and contraseña_hash=@password", con);
                cmd.Parameters.AddWithValue("@username", txt_user.Text);
                cmd.Parameters.AddWithValue("@password", txt_password.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //Si el conteo es = 1, existe un usuario con esas credenciales y se muestra el formulario
                if (count == 1)
                {
                    //se obtiene el tipo de usuario
                    usertipo = Convert.ToInt32(ds.Tables[0].Rows[0]["tipo"]);
                    MessageBox.Show("Bienvenido! " + ds.Tables[0].Rows[0]["nombre"].ToString());
                    this.Hide();
                    Form_Principal mpg = new Form_Principal();
                    mpg.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //termina la aplicacion cuando se da clic en cerrar
        private void FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
