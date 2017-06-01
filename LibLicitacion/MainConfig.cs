using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace LibLicitacion
{
    public class MainConfig
    {
        public String con = @"Data Source=APOYO3-LAP\SQLEXPRESS;Initial Catalog=Licitaciones;Integrated Security=True";
        public bool ChecarTipoUsuario(int tipo_usuario)
        {
            if (tipo_usuario != 1)
            {
                return false; 
            }
            else
            {
                return true;
            }
        }
        public string obtenernombrefabricante(int id_fabricante)
        {
            string nombre = "";
            if (id_fabricante != 0)
            {
                SqlConnection conec = new SqlConnection(con);
                conec.Open();
                SqlCommand cmd = new SqlCommand("Select * from fabricantes_titulares_distribuidores where id_ftd=@id", conec);
                cmd.Parameters.AddWithValue("@id", id_fabricante);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds, "fabricantes");
                conec.Close();
                if (ds.Tables["fabricantes"].Rows.Count > 0)
                {
                    nombre = ds.Tables["fabricantes"].Rows[0]["nombre"].ToString();
                }
                else
                {
                    nombre = "(Vacio)";
                }                
            }
            else
            {
                nombre = "(Vacio)";
            }
            return nombre;
        }
        public void crearDirectorios(string nombre_archivo, string archivo_origen, int id, string tipo_archivo)
        {
            //obtener la direccion donde se van a guardar los archivos
            string directorio = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DocumentosNT\"+tipo_archivo+@"\"+id+"";
            if (Directory.Exists(directorio))
            {
                if (archivo_origen != null)
                {
                    File.Copy(archivo_origen, Path.Combine(directorio, nombre_archivo));
                }
            }
            else
            {
                Directory.CreateDirectory(directorio);
                if (archivo_origen != null)
                {
                    File.Copy(archivo_origen, Path.Combine(directorio, nombre_archivo));
                }
            }
        }
       /* public void mostrarDialogoArchivo()
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
                        cmd = new SqlCommand("UPDATE registros_sanitarios set dir_archivo=@archivo where id_registro=" + id_registro + "", con);
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
        }*/
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
