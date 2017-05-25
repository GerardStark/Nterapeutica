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
using System.IO;

namespace AppLicitaciones
{
    public partial class Registros_Editar : Form
    {
        MainConfig mc = new MainConfig();
        string fileName, archivo, camino;
        int id_fabricante, id_registro;
        public Registros_Editar()
        {
            InitializeComponent();
            string[] textos = new string[] { "Registro", "Modificación", "Prórroga" };
            string[] values = new string[] { "Registro", "Modificación", "Prórroga" };
            llenarcombobox(textos, values);
        }
        private void llenarcombobox(string[] textos, string[] values)
        {
            for (int i = 0; i < textos.Length; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = textos[i].ToString();
                item.Value = values[i].ToString();
                cmb_tipo.Items.Add(item);
            }
            cmb_tipo.SelectedIndex = 0;
        }
        public void llenarcamposregistro(int id_registro)
        {
            this.id_registro = id_registro;
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
                //TODO buscar nombre con el id del fabricante
                id_fabricante = Convert.ToInt32(dt.Rows[0]["fabricante"]);
                txt_fabricante.Text = mc.obtenernombrefabricante(Convert.ToInt32(dt.Rows[0]["fabricante"]));
                txt_marca.Text = dt.Rows[0]["marca"].ToString();
                txt_nacionalidad.Text = dt.Rows[0]["nacionalidad"].ToString();
                txt_tlc.Text = dt.Rows[0]["tratado_comercio"].ToString();
                date_emision.Value = Convert.ToDateTime(dt.Rows[0]["fecha_emision"]);
                date_vencimiento.Value = Convert.ToDateTime(dt.Rows[0]["fecha_vencimiento"]);
                lbl_reg_archivo.Text = dt.Rows[0]["dir_archivo"].ToString();
                txt_distintiva.Text = dt.Rows[0]["denom_distintiva"].ToString();
                txt_generica.Text = dt.Rows[0]["denom_generica"].ToString();
                cmb_tipo.SelectedText = dt.Rows[0]["tipo"].ToString();
            }
        }

        private void btn_archivo_Click(object sender, EventArgs e)
        {
            if (lbl_reg_archivo.Text == "(Vacio)")
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "PDF Files|*.pdf|Word Files|*.docx";
                openFileDialog1.Title = "Select a PDF/Word File";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    lbl_reg_archivo.Text = openFileDialog1.SafeFileName;
                    fileName = openFileDialog1.FileName;
                    camino = Path.GetDirectoryName(fileName);
                    archivo = Path.GetFileName(fileName);
                }
                else if (result == DialogResult.Cancel)
                {
                    lbl_reg_archivo.Text = "(Vacio)";
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
                    SqlCommand cmd = new SqlCommand("Select * from registros_sanitarios where id_registro=@id", con);
                    cmd.Parameters.AddWithValue("@id", id_registro);
                    cmd.ExecuteScalar();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    adapt.Fill(dt);
                    try
                    {
                        File.Delete(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DocumentosNT\Registros-Sanitarios\" + id_registro + @"\" + dt.Rows[0]["dir_archivo"].ToString());
                        cmd = new SqlCommand("UPDATE registros_sanitarios set dir_archivo=@archivo where id=" + id_registro + "", con);
                        cmd.Parameters.AddWithValue("@archivo", "(Vacio)");
                        lbl_reg_archivo.Text = "(Vacio)";
                        cmd.ExecuteScalar();
                        con.Close();
                        MessageBox.Show("Archivo Borrado");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El archivo no existe, se procede a limpar la base de datos");
                        cmd = new SqlCommand("UPDATE registros_sanitarios set dir_archivo=@archivo where id_registro=" + id_registro + "", con);
                        cmd.Parameters.AddWithValue("@archivo", "(Vacio)");
                        lbl_reg_archivo.Text = "(Vacio)";
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

        private void btn_reg_descartar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Se guardaran los cambios realizados, esta acción no se puede deshacer", "Actualizar Registro Sanitario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //TODO Actualizar Registro
                try
                {
                    SqlConnection con = new SqlConnection(mc.con);
                    SqlCommand cmd = new SqlCommand("update registros_sanitarios set numero_registro = @numero, numero_solicitud = @solicitud, titular = @titular," +
                        "denom_distintiva = @distintiva, denom_generica = @generica, fabricante = @fabricante, marca = @marca, nacionalidad = @nacionalidad,"+
                        "tratado_comercio = @tlc, fecha_emision = @emision, fecha_vencimiento = @vencimiento, dir_archivo = @archivo, actualizado_en = @actualizado "+
                        "where id_registro = @id",con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id_registro);
                    cmd.Parameters.AddWithValue("@numero", txt_numero.Text);
                    cmd.Parameters.AddWithValue("@solicitud", txt_solicitud.Text);
                    cmd.Parameters.AddWithValue("@titular", txt_titular.Text);
                    cmd.Parameters.AddWithValue("@distintiva", txt_distintiva.Text);
                    cmd.Parameters.AddWithValue("@generica", txt_generica.Text);
                    cmd.Parameters.AddWithValue("@fabricante", id_fabricante);
                    cmd.Parameters.AddWithValue("@marca", txt_marca.Text);
                    cmd.Parameters.AddWithValue("@nacionalidad", txt_nacionalidad.Text);
                    cmd.Parameters.AddWithValue("@tlc", txt_tlc.Text);
                    cmd.Parameters.AddWithValue("@emision", date_emision.Value.Date);
                    cmd.Parameters.AddWithValue("@vencimiento", date_vencimiento.Value.Date);
                    cmd.Parameters.AddWithValue("@tipo", cmb_tipo.SelectedText);
                    cmd.Parameters.AddWithValue("@archivo", lbl_reg_archivo.Text);
                    cmd.Parameters.AddWithValue("@actualizado", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    crearDirectorios(id_registro);
                    con.Close();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
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
        private void crearDirectorios(int id)
        {
            string newpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DocumentosNT\Registros-Sanitarios\";
            string pathanexos = newpath + "\\" + id + "\\";
            if (Directory.Exists(newpath + "\\" + id + "\\"))
            {
                if (archivo != null)
                {
                    File.Copy(fileName, Path.Combine(pathanexos, archivo));
                }
            }
            else
            {
                Directory.CreateDirectory(newpath + "\\" + id + "\\");

                if (archivo != null)
                {
                    File.Copy(fileName, Path.Combine(pathanexos, archivo));
                }
            }
        }
    }
}
