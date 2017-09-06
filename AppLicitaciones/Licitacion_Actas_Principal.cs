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
    public partial class Licitacion_Actas_Principal : Form
    {
        MainConfig mc = new MainConfig();
        Int32 idActa;
        int idLicit;
        string fileName, archivo, camino;
        public Licitacion_Actas_Principal()
        {
            InitializeComponent();
            lbl_archivo.Text = "(Vacio)";
            btn_archivo.BackgroundImage = Iconos.search;
            date_emision.Format = DateTimePickerFormat.Custom;
            date_emision.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        public void mostrarActasLicitacion(int idLicit)
        {
            this.idLicit = idLicit;
            try
            {
                foreach (Acta a in Acta.GetActasPorLicitacion(idLicit))
                {
                    dgvActas.Rows.Add(a.Id, a.Tipo, a.Descripcion, a.Emision, a.Archivo);                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Licitacion_Actas_Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.data_tipos_acta' Puede moverla o quitarla según sea necesario.
            this.data_tipos_actaTableAdapter.Fill(this.licitacionesDataSet.data_tipos_acta);

        }

        private void dgvActas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                btn_nuevo.Enabled = false;
                idActa = (Int32)dgvActas.Rows[e.RowIndex].Cells["idColumn"].Value;
                cmb_tipo.SelectedValue = (Int32)dgvActas.Rows[e.RowIndex].Cells["tipoColumn"].Value;
                txt_desc.Text = dgvActas.Rows[e.RowIndex].Cells["descColumn"].Value.ToString();
                date_emision.Value = Convert.ToDateTime(dgvActas.Rows[e.RowIndex].Cells["emisionColumn"].Value);
                lbl_archivo.Text = dgvActas.Rows[e.RowIndex].Cells["archivoColumn"].Value.ToString();
                if (lbl_archivo.Text != "(Vacio)")
                {
                    btn_archivo.BackgroundImage = Iconos.android_close;
                }
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "licitacion_actas_insert";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idLicit", idLicit);
                    cmd.Parameters.AddWithValue("@tipo", cmb_tipo.SelectedValue);
                    cmd.Parameters.AddWithValue("@descripcion", txt_desc.Text);
                    cmd.Parameters.AddWithValue("@emision", date_emision.Value.Date);
                    cmd.Parameters.AddWithValue("@archivo", lbl_archivo.Text);
                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                    Int32 newId = (Int32)cmd.ExecuteScalar();
                    if (newId != 0)
                    {
                        crearDirectorios(newId);
                        mostrarActasLicitacion(idLicit);
                        MessageBox.Show("Guardado");
                    }
                }
            }
        }

        private void lbl_archivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (idActa != 0)
            {
                string newpath = Path.GetDirectoryName(Application.ExecutablePath) + @"\DocumentosNT\Licitacion\" + idLicit + "\\Actas";
                string pathanexos = newpath + "\\" + idActa + "\\" + lbl_archivo.Text;

                if (lbl_archivo.Text != "(Vacio)")
                {

                    System.Diagnostics.Process.Start(pathanexos);
                }
                else
                {
                    MessageBox.Show("No hay archivo");
                }
            }
        }

        private void dgvActas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                idActa = 0;
                cmb_tipo.SelectedIndex = 0;
                txt_desc.Text = "";
                date_emision.Value = DateTime.Today;
                lbl_archivo.Text = "(Vacio)";
                btn_nuevo.Enabled = true;
            }
        }

        private void crearDirectorios(int id)
        {
            string newpath = Path.GetDirectoryName(Application.ExecutablePath) + @"\DocumentosNT\Licitacion\" + idLicit + "\\Actas";
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
                openFileDialog1.Filter = "PDF Files|*.pdf|Word Files|*.*";
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
                    SqlCommand cmd = new SqlCommand("Select * from licitacion_actas where id=@id", con);
                    cmd.Parameters.AddWithValue("@id", idActa);
                    cmd.ExecuteScalar();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    adapt.Fill(dt);
                    try
                    {
                        File.Delete(Path.GetDirectoryName(Application.ExecutablePath) +
                            @"\DocumentosNT\Licitacion\" + idLicit + @"\Actas\" + idActa +
                            @"\" + dt.Rows[0]["dir_archivo"].ToString());
                        cmd = new SqlCommand("UPDATE licitacion_actas set dir_archivo=@archivo where id=" + idActa + "", con);
                        cmd.Parameters.AddWithValue("@archivo", "(Vacio)");
                        lbl_archivo.Text = "(Vacio)";
                        cmd.ExecuteScalar();
                        con.Close();
                        MessageBox.Show("Archivo Borrado");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El archivo no existe, se procede a limpar la base de datos");
                        cmd = new SqlCommand("UPDATE licitacion_actas set dir_archivo=@archivo where id=" + idActa + "", con);
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
    }
}
