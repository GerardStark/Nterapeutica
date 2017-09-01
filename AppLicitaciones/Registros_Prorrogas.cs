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
    public partial class Registros_Prorrogas : Form
    {
        MainConfig mc = new MainConfig();
        string fileName, archivo, camino;
        int id_tramite, id_registro;

        public Registros_Prorrogas()
        {
            InitializeComponent();
            lbl_archivo.Text = "(Vacio)";
            this.DGV_Referencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Referencias.MultiSelect = false;
        }

        public void mostrarprorrogasregistro(int id_registro)
        {
            this.id_registro = id_registro;
            try
            {
                DGV_Referencias.Rows.Clear();
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("Select id_tramite_prorroga, numero_tramite, fecha_emision, dir_archivo " +
                    "from registros_tramites_prorroga where id_registro_sanitario = @id", con);
                cmd.Parameters.AddWithValue("@id", id_registro);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_Referencias.Rows.Add(dr.ItemArray);
                }
               // mc.buscarultimafilaeditada("registros_tramites_prorroga", DGV_Referencias);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            string newpath = Path.GetDirectoryName(Application.ExecutablePath) + @"\DocumentosNT\Registros-Sanitarios\"+id_registro+ "\\tramites";
            string pathanexos = newpath + "\\" + id_tramite + "\\" + lbl_archivo.Text;

            if (lbl_archivo.Text != "(Vacio)")
            {

                System.Diagnostics.Process.Start(pathanexos);
            }
            else
            {
                MessageBox.Show("No hay archivo");
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE registros_tramites_prorroga set id_registro_sanitario = @registro, numero_tramite = @numero, "+
                    "fecha_emision = @emision, dir_archivo = @archivo, actualizado_en = @actualizado where id_tramite_prorroga = @idtramite", con);
                cmd.Parameters.AddWithValue("@idtramite", id_tramite);
                cmd.Parameters.AddWithValue("@registro", id_registro);
                cmd.Parameters.AddWithValue("@numero",txt_numero.Text);
                cmd.Parameters.AddWithValue("@emision", date_tramite.Value.Date);
                cmd.Parameters.AddWithValue("@archivo", lbl_archivo.Text);
                cmd.Parameters.AddWithValue("actualizado", DateTime.Now);
                cmd.ExecuteNonQuery();
                if (lbl_archivo.Text == "(Vacio)")
                {
                    crearDirectorios(id_tramite);
                }
                con.Close();
                mostrarprorrogasregistro(id_registro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (id_tramite != 0)
            {
                try
                {
                    SqlConnection con = new SqlConnection(mc.con);
                    SqlCommand cmd = new SqlCommand("DELETE FROM registros_tramites_prorroga where id_tramite_prorroga = @id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id_tramite);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Borrado");
                    borrararchivoprorroga(id_tramite);
                    mostrarprorrogasregistro(id_registro);
                    con.Close();
                    btn_guardar.Enabled = true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una referencia");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mc.con);
            SqlCommand cmd = new SqlCommand("insert into registros_tramites_prorroga (id_registro_sanitario,numero_tramite,fecha_emision,dir_archivo,actualizado_en) "+
                "OUTPUT INSERTED.id_tramite_prorroga values(@idregistro,@numero,@emision,@archivo,@actualizado)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@idregistro", id_registro);
            cmd.Parameters.AddWithValue("@numero", txt_numero.Text);
            cmd.Parameters.AddWithValue("@emision", date_tramite.Value.Date);
            cmd.Parameters.AddWithValue("@archivo", lbl_archivo.Text);
            cmd.Parameters.AddWithValue("@actualizado", DateTime.Now);
            Int32 newId = (Int32)cmd.ExecuteScalar();
            crearDirectorios(newId);
            con.Close();
            mostrarprorrogasregistro(id_registro);
        }

        private void DGV_Referencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                btn_guardar.Enabled = false;
                id_tramite = Convert.ToInt32(DGV_Referencias.Rows[e.RowIndex].Cells["idColumn"].Value);
                txt_numero.Text = DGV_Referencias.Rows[e.RowIndex].Cells["numeroColumn"].Value.ToString();
                date_tramite.Value = DateTime.Parse(DGV_Referencias.Rows[e.RowIndex].Cells["fechaColumn"].Value.ToString());
                lbl_archivo.Text = DGV_Referencias.Rows[e.RowIndex].Cells["archivoColumn"].Value.ToString();
            }
        }

        private void DGV_Referencias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (id_tramite != 0 && e.RowIndex != -1)
            {
                id_tramite = 0;
                btn_guardar.Enabled = true;
                txt_numero.Text = "";
                date_tramite.Value = DateTime.Today;
                lbl_archivo.Text = "(Vacio)";
            }
        }

        private void crearDirectorios(int id)
        {
            string newpath = Path.GetDirectoryName(Application.ExecutablePath) + @"\DocumentosNT\Registros-Sanitarios\" + id_registro + "\\tramites";
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
                    cmd.Parameters.AddWithValue("@id", id_tramite);
                    cmd.ExecuteScalar();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    adapt.Fill(dt);
                    try
                    {
                        File.Delete(Path.GetDirectoryName(Application.ExecutablePath) + 
                            @"\DocumentosNT\Registros-Sanitarios\" + id_registro + @"\tramites\" + id_tramite +
                            @"\" + dt.Rows[0]["dir_archivo"].ToString());
                        cmd = new SqlCommand("UPDATE registros_tramites_prorroga set dir_archivo=@archivo where id_tramite_prorroga=" + id_tramite + "", con);
                        cmd.Parameters.AddWithValue("@archivo", "(Vacio)");
                        lbl_archivo.Text = "(Vacio)";
                        cmd.ExecuteScalar();
                        con.Close();
                        MessageBox.Show("Archivo Borrado");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El archivo no existe, se procede a limpar la base de datos");
                        cmd = new SqlCommand("UPDATE registros_tramites_prorroga set dir_archivo=@archivo where id_tramite_prorroga=" + id_tramite + "", con);
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
        private void borrararchivoprorroga(int id_tramite)
        {
            string newpath = Path.GetDirectoryName(Application.ExecutablePath) + @"\DocumentosNT\Registros-Sanitarios\" + id_registro + "\\tramites";
            string pathanexos = newpath + "\\" + id_tramite + "\\" + lbl_archivo.Text;

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
