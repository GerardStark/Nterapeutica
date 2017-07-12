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
        public string con = @"Data Source=192.168.1.101\SQLEXPRESS;Initial Catalog=Licitaciones;Integrated Security=False;User Id=user; Password=gerardo123;";  
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
        public void llenarcombobox(string[] items, ComboBox cmb)
        {
            for (int i = 0; i < items.Length; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = items[i];
                item.Value = i + 1;
                cmb.Items.Add(item);
            }
        }
        public int obtenervaluecomboitem(string text, ComboBox cmbox)
        {
            int value = 0;
            foreach (ComboboxItem item in cmbox.Items)
            {
                if (item.Text == text)
                {
                    value = Convert.ToInt32(item.Value);
                }
            }

            return value - 1;
        }
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
