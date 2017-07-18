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
    public partial class Certificados_Visualizar : Form
    {
        MainConfig mc = new MainConfig();
        int id_certificado = 0;
        public Certificados_Visualizar()
        {
            InitializeComponent();
           
        }
        public void mostrarinfocertificado(int id_certificado)
        {
            this.id_certificado = id_certificado;
            SqlConnection con = new SqlConnection(mc.con);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from certificados_calidad Where id_certificado = @id", con);
            cmd.Parameters.AddWithValue("@id", id_certificado);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                //dt.Rows[0][""].ToString();
                lbl_clave.Text = dt.Rows[0]["numero_identificador"].ToString();
                lbl_tipo.Text = dt.Rows[0]["tipo"].ToString();
                lbl_descripcion.Text = dt.Rows[0]["descripcion_detallada"].ToString();
                lbl_idioma.Text = dt.Rows[0]["idioma"].ToString();
                lbl_fabr.Text = dt.Rows[0]["fabricante"].ToString();
                lbl_emision.Text = dt.Rows[0]["fecha_emision"].ToString();
                lbl_vencimiento.Text = dt.Rows[0]["fecha_vencimiento"].ToString();
                lbl_archivo.Text = dt.Rows[0]["dir_archivo"].ToString();
                lbl_traduccion.Text = dt.Rows[0]["dir_archivo_traduccion"].ToString();
            }
        }

        private void btn_archivo_Click(object sender, EventArgs e)
        {
            string newpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DocumentosNT\Certificados-Calidad\";
            string pathanexos = newpath + "\\" + id_certificado + "\\" + lbl_archivo.Text;

            if (lbl_archivo.Text != "(Vacio)")
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

        private void btn_traduccion_Click(object sender, EventArgs e)
        {
            string newpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DocumentosNT\Certificados-Calidad\";
            string pathanexos = newpath + "\\" + id_certificado + "\\" + lbl_traduccion.Text;

            if (lbl_archivo.Text != "(Vacio)")
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

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btn_reg_editar_Click(object sender, EventArgs e)
        {
            Certificados_Editar re = new Certificados_Editar();
            re.llenarinfocertificado(id_certificado);
            DialogResult result2 = re.ShowDialog();
            this.Hide();
            if (result2 == DialogResult.OK)
            {
                MessageBox.Show("Certificado Actualizado.");
                mostrarinfocertificado(id_certificado);
                this.Show();
            }
            else
            {
                MessageBox.Show("No se modifico el Certificado.");
                this.Show();
            }
        }

        private void btn_reg_borrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea borrar el certificado? Esta accion no se puede deshacer","Borrar Catalogo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("Delete from certificados_calidad where id_certificado = @id",con);
                con.Open();
                cmd.Parameters.AddWithValue("id",id_certificado);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Borrado");
            }
            else
            {
                MessageBox.Show("Cancelado" );
            }
        }
    }
}
