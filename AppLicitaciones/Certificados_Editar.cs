using LibLicitacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLicitaciones
{
    public partial class Certificados_Editar : Form
    {
        MainConfig mc = new MainConfig();
        int id_certificado = 0;
        
        string fileName, archivo, camino;
        string fileNametrad, archivotrad, caminotrad;

        public Certificados_Editar()
        {
            InitializeComponent();
            string[] array_tipos_certificado = { "ISO", "FDA", "CLV" };
            string[] array_idiomas = { "Español", "Inglés", "Francés", "Alemán", "Japonés", "Portugués", "Chino", "Koreano", "Irlandés" };
            mc.llenarcombobox(array_tipos_certificado, cmb_tipo);
            mc.llenarcombobox(array_idiomas, cmb_idioma);
        }

        private void btn_archivo_Click(object sender, EventArgs e)
        {
            if (lbl_archivo.Text == "(Vacio)")
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "PDF Files|*.pdf|Word Files|*.docx";
                openFileDialog1.Title = "Select a PDF/Word File";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    lbl_archivo.Text = openFileDialog1.SafeFileName;
                    fileName = openFileDialog1.FileName;
                    camino = Path.GetDirectoryName(fileName);
                    archivo = Path.GetFileName(fileName);
                }
                else if (result == DialogResult.Cancel)
                {
                    lbl_archivo.Text = "(Vacio)";
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Seguro que deseas borrar el archivo? Esto no se puede deshacer", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(mc.con);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from certificados_calidad where id_certificado=@id", con);
                    cmd.Parameters.AddWithValue("@id", id_certificado);
                    cmd.ExecuteScalar();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    adapt.Fill(dt);
                    try
                    {
                        File.Delete(Path.GetDirectoryName(Application.ExecutablePath) + @"\DocumentosNT\Certificados-Calidad\" + id_certificado + @"\" + dt.Rows[0]["dir_archivo"].ToString());
                        cmd = new SqlCommand("UPDATE certificados_calidad set dir_archivo=@archivo where id_certificado=" + id_certificado + "", con);
                        cmd.Parameters.AddWithValue("@archivo", "(Vacio)");
                        lbl_archivo.Text = "(Vacio)";
                        cmd.ExecuteScalar();
                        con.Close();
                        MessageBox.Show("Archivo Borrado");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El archivo no existe, se procede a limpar la base de datos");
                        cmd = new SqlCommand("UPDATE certificados_calidad set dir_archivo=@archivo where id_certificado=" + id_certificado + "", con);
                        cmd.Parameters.AddWithValue("@archivo", "(Vacio)");
                        lbl_archivo.Text = "(Vacio)";
                        cmd.ExecuteScalar();
                        con.Close();
                        MessageBox.Show("Se eliminó el archivo, ya puede capturar un archivo nuevo");
                    }
                }
                else
                {
                    MessageBox.Show("No se ha borrado el archivo");
                }
            }
        }

        private void btn_traduccion_Click(object sender, EventArgs e)
        {
            if (lbl_trad.Text == "(Vacio)")
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "PDF Files|*.pdf|Word Files|*.docx";
                openFileDialog1.Title = "Select a PDF/Word File";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    lbl_trad.Text = openFileDialog1.SafeFileName;
                    fileNametrad = openFileDialog1.FileName;
                    caminotrad = Path.GetDirectoryName(fileNametrad);
                    archivotrad = Path.GetFileName(fileNametrad);
                }
                else if (result == DialogResult.Cancel)
                {
                    lbl_trad.Text = "(Vacio)";
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Seguro que deseas borrar el archivo? Esto no se puede deshacer", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(mc.con);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from certificados_calidad where id_certificado=@id", con);
                    cmd.Parameters.AddWithValue("@id", id_certificado);
                    cmd.ExecuteScalar();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    adapt.Fill(dt);
                    try
                    {
                        File.Delete(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DocumentosNT\Certificados-Calidad\" + id_certificado + @"\" + dt.Rows[0]["dir_archivo_traduccion"].ToString());
                        cmd = new SqlCommand("UPDATE certificados_calidad set dir_archivo_traduccion=@archivo where id_certificado=" + id_certificado + "", con);
                        cmd.Parameters.AddWithValue("@archivo", "(Vacio)");
                        lbl_trad.Text = "(Vacio)";
                        cmd.ExecuteScalar();
                        con.Close();
                        MessageBox.Show("Archivo Borrado");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El archivo no existe, se procede a limpar la base de datos");
                        cmd = new SqlCommand("UPDATE certificados_calidad set dir_archivo_traduccion=@archivo where id_certificado=" + id_certificado + "", con);
                        cmd.Parameters.AddWithValue("@archivo", "(Vacio)");
                        lbl_trad.Text = "(Vacio)";
                        cmd.ExecuteScalar();
                        con.Close();
                        MessageBox.Show("Se eliminó el archivo, ya puede capturar un archivo nuevo");
                    }
                }
                else
                {
                    MessageBox.Show("No se ha borrado el archivo");
                }
            }
        }        

        public void llenarinfocertificado(int id_certificado)
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
                txt_clave.Text = dt.Rows[0]["numero_identificador"].ToString();               
                txt_descripcion.Text = dt.Rows[0]["descripcion_detallada"].ToString();
                cmb_tipo.SelectedIndex = mc.obtenervaluecomboitem(dt.Rows[0]["tipo"].ToString(), cmb_tipo);
                cmb_idioma.SelectedIndex = mc.obtenervaluecomboitem(dt.Rows[0]["idioma"].ToString(), cmb_idioma);
                txt_fabricante.Text = dt.Rows[0]["fabricante"].ToString();              
                date_emision.Text = dt.Rows[0]["fecha_emision"].ToString();
                date_vencimiento.Text = dt.Rows[0]["fecha_vencimiento"].ToString();
                lbl_archivo.Text = dt.Rows[0]["dir_archivo"].ToString();
                if (lbl_archivo.Text != "(Vacio)")
                {
                    btn_archivo.Text = "Cambiar";
                }
                lbl_trad.Text = dt.Rows[0]["dir_archivo_traduccion"].ToString();
                if (lbl_trad.Text != "(Vacio)")
                {
                    btn_archivo.Text = "Cambiar";
                }
            }
        }

        private void btn_reg_descartar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mc.con);
            SqlCommand cmd = new SqlCommand(@"IF NOT EXISTS (SELECT numero_identificador,tipo,fabricante FROM certificados_calidad WHERE numero_identificador = @clave AND tipo = @tipo AND fabricante =@fabr)
                BEGIN
                    UPDATE certificados_calidad SET numero_identificador = @clave, tipo = @tipo,descripcion_detallada = @desc,fabricante = @fabr,
                    fecha_emision = @emision,fecha_vencimiento = @vencimento,idioma = @idioma,dir_archivo = @archivo,dir_archivo_traduccion = @trad ,actualizado_en = @updated
                    WHERE id_certificado = @id 
                END", con);
            cmd.Parameters.AddWithValue("@id", id_certificado);
            cmd.Parameters.AddWithValue("@clave", txt_clave.Text.ToUpper());
            cmd.Parameters.AddWithValue("@tipo", (cmb_tipo.SelectedItem as ComboboxItem).Text);
            cmd.Parameters.AddWithValue("@desc", mc.convertirasentencia(txt_descripcion.Text));
            cmd.Parameters.AddWithValue("@fabr", txt_fabricante.Text);
            cmd.Parameters.AddWithValue("@emision", date_emision.Value.Date);
            cmd.Parameters.AddWithValue("@vencimento", date_vencimiento.Value.Date);
            cmd.Parameters.AddWithValue("@idioma", (cmb_idioma.SelectedItem as ComboboxItem).Text);
            cmd.Parameters.AddWithValue("@archivo", lbl_archivo.Text);
            cmd.Parameters.AddWithValue("@trad", lbl_trad.Text);
            cmd.Parameters.AddWithValue("@updated", DateTime.Now);
            con.Open();
            cmd.ExecuteNonQuery();
            mc.crearDirectorios(archivo, fileName, id_certificado, "Certificados-Calidad");
            mc.crearDirectorios(archivotrad, fileNametrad, id_certificado, "Certificados-Calidad");
            this.DialogResult = DialogResult.OK;
            con.Close();
        }
    }
}
