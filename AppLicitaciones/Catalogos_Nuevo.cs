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
    public partial class Catalogos_Nuevo : Form
    {
        MainConfig mc = new MainConfig();
        string fileName, archivo, camino;
        int id_fabricante;
        public Catalogos_Nuevo()
        {
            InitializeComponent();
        }

        private void txt_limpiar_campos_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_year.Text = "";
            txt_idioma.Text = "";
            txt_fabricante.Text = "";
            txt_especialidad.Text = "";
            lbl_archivo.Text = "";
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

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("Insert into catalogos_productos (nombre_catalogo, año_publicacion,especialidad,fabricante "+
                    "idioma,dir_archivo,actualizado_en) values (@nombre,@año,@espec,@fabricante,@idioma,@archivo,@actualizado)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@nombre",txt_nombre.Text);
                cmd.Parameters.AddWithValue("@año",txt_year.Text);
                cmd.Parameters.AddWithValue("@espec",txt_especialidad.Text);
                cmd.Parameters.AddWithValue("@fabricante",id_fabricante);
                cmd.Parameters.AddWithValue("@idioma",txt_idioma.Text);
                cmd.Parameters.AddWithValue("@archivo",lbl_archivo.Text);
                cmd.Parameters.AddWithValue("@actualizado", DateTime.Now);
                Int32 newId = (Int32)cmd.ExecuteScalar();
                mc.crearDirectorios(archivo, fileName, newId, "Catálogos-Productos");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_archivo_Click(object sender, EventArgs e)
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
    }
}
