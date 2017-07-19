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
using System.IO;

namespace AppLicitaciones
{
    public partial class Catalogos_Traducciones : Form
    {
        MainConfig mc = new MainConfig();
        string fileName, archivo, camino;
        int id_catalogo = 0,id_traduccion = 0;
        public Catalogos_Traducciones()
        {
            InitializeComponent();
            this.DGV_Traducciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Traducciones.MultiSelect = false;
            lbl_archivo.Text = "(Vacio)";
        }
        public void mostrartraduccionescatalogo(int id_catalogo)
        {
            try {
                DGV_Traducciones.Rows.Clear();
                this.id_catalogo = id_catalogo;
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("SELECT id_traduccion_cat,descripcion_corta,dir_archivo FROM catalogos_traducciones "+
                    "WHERE id_catalogo_productos = @id",con);
                cmd.Parameters.AddWithValue("@id",id_catalogo);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_Traducciones.Rows.Add(dr.ItemArray);
                    
                }
                con.Close();
                
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


    }

        private void btn_traduccion_referencias_Click(object sender, EventArgs e)
        {
            if (id_traduccion != 0)
            {
                Catalogos_traduccion_referencias ctr = new Catalogos_traduccion_referencias();
                ctr.mostrarreferenciascatalogo(id_catalogo,id_traduccion);
                DialogResult result = ctr.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Guardado");
                }
                else
                {
                    MessageBox.Show("No se hizo cambio alguno");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una traducción");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO catalogos_traducciones (id_catalogo_productos,descripcion_corta,dir_archivo,actualizado_en)"+
                    "  OUTPUT INSERTED.id_traduccion_cat values(@idcatalogo,@descripcion,@archivo,@update)", con);
                cmd.Parameters.AddWithValue("@idcatalogo",id_catalogo);
                cmd.Parameters.AddWithValue("@descripcion",txt_desc.Text);
                cmd.Parameters.AddWithValue("@archivo",lbl_archivo.Text);
                cmd.Parameters.AddWithValue("@update", DateTime.Now);
                Int32 newId = (Int32)cmd.ExecuteScalar();
                crearDirectorios(newId);
                con.Close();
                mostrartraduccionescatalogo(id_catalogo);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
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
                    SqlCommand cmd = new SqlCommand("Select * from registros_tramites_prorroga where id_tramite_prorroga=@id", con);
                    cmd.Parameters.AddWithValue("@id", id_catalogo);
                    cmd.ExecuteScalar();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    adapt.Fill(dt);
                    try
                    {
                        File.Delete(Path.GetDirectoryName(Application.ExecutablePath) +
                            @"\DocumentosNT\Registros-Sanitarios\" + id_catalogo + @"\traducciones\" + id_traduccion +
                            @"\" + dt.Rows[0]["dir_archivo"].ToString());
                        cmd = new SqlCommand("UPDATE catalogos_traducciones set dir_archivo=@archivo where id_traduccion_cat=" + id_traduccion + "", con);
                        cmd.Parameters.AddWithValue("@archivo", "(Vacio)");
                        lbl_archivo.Text = "(Vacio)";
                        cmd.ExecuteScalar();
                        con.Close();
                        MessageBox.Show("Archivo Borrado");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El archivo no existe, se procede a limpar la base de datos");
                        cmd = new SqlCommand("UPDATE catalogos_traducciones set dir_archivo=@archivo where id_traduccion_cat=" + id_traduccion + "", con);
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

        private void btn_ver_Click(object sender, EventArgs e)
        {
            string newpath = Path.GetDirectoryName(Application.ExecutablePath) + @"\DocumentosNT\Catalogos-Productos\" + id_catalogo + "\\traducciones";
            string pathanexos = newpath + "\\" + id_traduccion + "\\" + lbl_archivo.Text;

            if (lbl_archivo.Text != "(Vacio)")
            {

                System.Diagnostics.Process.Start(pathanexos);
            }
            else
            {
                MessageBox.Show("No hay archivo");
            }
        }

        private void crearDirectorios(int id)
        {
            string newpath = Path.GetDirectoryName(Application.ExecutablePath) + @"\DocumentosNT\Catalogos-Productos\" + id_catalogo + "\\traducciones";
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

        private void DGV_Traducciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                btn_guardar.Enabled = false;
                id_traduccion = Convert.ToInt32(DGV_Traducciones.Rows[e.RowIndex].Cells["idColumn"].Value);
                txt_desc.Text = DGV_Traducciones.Rows[e.RowIndex].Cells["descColumn"].Value.ToString();
                lbl_archivo.Text = DGV_Traducciones.Rows[e.RowIndex].Cells["archivoColumn"].Value.ToString();
                if (lbl_archivo.Text != "(Vacio)")
                {
                    btn_archivo.Text = "Cambiar";
                }
            }
        }

        private void DGV_Traducciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (id_traduccion != 0 && e.RowIndex != -1)
            {
                id_traduccion = 0;
                btn_guardar.Enabled = true;
                txt_desc.Text = "";
                lbl_archivo.Text = "(Vacio)";
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE catalogos_traducciones  set descripcion_corta=@descripcion,dir_archivo=@archivo,actualizado_en = @update "+
                    "  OUTPUT INSERTED.id_traduccion_cat WHERE id_traduccion_cat = @id", con);
                cmd.Parameters.AddWithValue("@id", id_traduccion);
                cmd.Parameters.AddWithValue("@descripcion", txt_desc.Text);
                cmd.Parameters.AddWithValue("@archivo", lbl_archivo.Text);
                cmd.Parameters.AddWithValue("@update", DateTime.Now);
                cmd.ExecuteNonQuery();
                crearDirectorios(id_traduccion);
                mostrartraduccionescatalogo(id_catalogo);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("DELETE FROM catalogos_traducciones where id_traduccion_cat = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id_traduccion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Borrado");
                borrararchivotraduccion(id_traduccion);
                mostrartraduccionescatalogo(id_catalogo);
                con.Close();
                btn_guardar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void borrararchivotraduccion(int id_traduccion)
        {
            string newpath = Path.GetDirectoryName(Application.ExecutablePath) + @"\DocumentosNT\Catalogos-Productos\" + id_traduccion + "\\traducciones";
            string pathanexos = newpath + "\\" + id_traduccion + "\\" + lbl_archivo.Text;

            if (lbl_archivo.Text != "(Vacio)")
            {

                File.Delete(pathanexos);
            }
            else
            {
                MessageBox.Show("No hay archivo");
            }
        }
    }
}
