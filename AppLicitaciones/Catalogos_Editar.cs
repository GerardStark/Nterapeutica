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
    public partial class Catalogos_Editar : Form
    {
        MainConfig mc = new MainConfig();
        string fileName, archivo, camino;
        int id_fabricante=0;
        int id_catalogo = 0;
        public Catalogos_Editar()
        {
            InitializeComponent();
            string[] array_tipos_catalogo = { "Catálogo", "Brochure", "Manual", "Ficha Técnica", };
            string[] array_idiomas = { "Español", "Inglés", "Francés", "Alemán", "Japonés", "Portugués", "Chino", "Koreano", "Irlandés" };
            string[] array_specs = {
                "Cirugia Cardiovascular",
                "Hemodinamia",
                "Urología",
                "Minima Invasion",
                "Endoscopia",
                "Terapia Endovascular Neurologica",
                "Marcapasos",
                "Material de Curacion",
                "Subrogados" };
            mc.llenarcombobox(array_tipos_catalogo, cmb_tipo);
            mc.llenarcombobox(array_idiomas, cmb_idioma);
            mc.llenarcombobox(array_specs, cmb_spec);
        }
        public void llenarinfocatalogos(int id_catalogo)
        {
            this.id_catalogo = id_catalogo;
            SqlConnection con = new SqlConnection(mc.con);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from catalogos_info_general Where id_catalogo = @id", con);
            cmd.Parameters.AddWithValue("@id", id_catalogo);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                //dt.Rows[0][""].ToString();
                txt_nombre.Text = dt.Rows[0]["nombre_catalogo"].ToString();
                txt_year.Text = dt.Rows[0]["publicacion"].ToString();
                cmb_tipo.SelectedIndex = mc.obtenervaluecomboitem(dt.Rows[0]["tipo_catalogo"].ToString(), cmb_tipo);
                cmb_idioma.SelectedIndex = mc.obtenervaluecomboitem(dt.Rows[0]["idioma"].ToString(),cmb_idioma);
                txt_fabricante.Text = dt.Rows[0]["fabricante"].ToString();
                txt_marca.Text = dt.Rows[0]["marca"].ToString();
                cmb_spec.SelectedIndex = mc.obtenervaluecomboitem(dt.Rows[0]["spec_catalogo"].ToString(), cmb_spec);
                lbl_archivo.Text = dt.Rows[0]["dir_archivo"].ToString();
                if (lbl_archivo.Text != "(Vacio)")
                {
                    btn_archivo.Text = "Cambiar";
                }
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
                    SqlCommand cmd = new SqlCommand("Select * from catalogos_info_general where id_catalogo=@id", con);
                    cmd.Parameters.AddWithValue("@id", id_catalogo);
                    cmd.ExecuteScalar();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    adapt.Fill(dt);
                    try
                    {
                        File.Delete(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DocumentosNT\Catalogos-Productos\" + id_catalogo + @"\" + dt.Rows[0]["dir_archivo"].ToString());
                        cmd = new SqlCommand("UPDATE catalogos_info_general set dir_archivo=@archivo where id_catalogo=" + id_catalogo + "", con);
                        cmd.Parameters.AddWithValue("@archivo", "(Vacio)");
                        lbl_archivo.Text = "(Vacio)";
                        cmd.ExecuteScalar();
                        con.Close();
                        MessageBox.Show("Archivo Borrado");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El archivo no existe, se procede a limpar la base de datos");
                        cmd = new SqlCommand("UPDATE catalogos_info_general set dir_archivo=@archivo where id_catalogo=" + id_catalogo + "", con);
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

        private void txt_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_reg_descartar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand(@"IF NOT EXISTS (SELECT nombre_catalogo,tipo_catalogo,spec_catalogo FROM catalogos_info_general WHERE nombre_catalogo = @nombre,tipo_catalogo = @tipo,spec_catalogo =@espec)
                    BEGIN
                        UPDATE catalogos_info_general SET nombre_catalogo = @nombre,publicacion = @año,tipo_catalogo = @tipo,spec_catalogo=@espec,
                        fabricante=@fabricante,marca = @marca, idioma=@idioma,dir_archivo=@archivo,actualizado_en=@actualizado WHERE id_catalogo = @id
                    END", con);
                cmd.Parameters.AddWithValue("@id",id_catalogo);
                cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text.ToUpper());
                cmd.Parameters.AddWithValue("@año", txt_year.Text);
                cmd.Parameters.AddWithValue("@espec", (cmb_spec.SelectedItem as ComboboxItem).Text);
                cmd.Parameters.AddWithValue("@tipo", (cmb_tipo.SelectedItem as ComboboxItem).Text);
                cmd.Parameters.AddWithValue("@fabricante", txt_fabricante.Text);
                cmd.Parameters.AddWithValue("@marca", txt_marca.Text);
                cmd.Parameters.AddWithValue("@idioma", (cmb_idioma.SelectedItem as ComboboxItem).Text);
                cmd.Parameters.AddWithValue("@archivo", lbl_archivo.Text);
                cmd.Parameters.AddWithValue("@actualizado", DateTime.Now);
                cmd.ExecuteNonQuery();
                mc.crearDirectorios(archivo, fileName, id_catalogo, "Catalogos-Productos");
                this.DialogResult = DialogResult.OK;
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
