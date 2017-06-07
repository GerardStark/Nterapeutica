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
           
            mc.llenarcombobox(mc.array_tipos_catalogo,cmb_tipo);
            mc.llenarcombobox(mc.array_idiomas,cmb_idioma);
        }        

        private void txt_limpiar_campos_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_year.Text = "";
            cmb_idioma.SelectedIndex = 0;
            cmb_tipo.SelectedIndex = 0;
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

        private void btn_reg_descartar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into catalogos_info_general (nombre_catalogo,publicacion,tipo_catalogo,spec_catalogo,fabricante, " +
                    "idioma,dir_archivo,actualizado_en) OUTPUT INSERTED.id_catalogo values (@nombre,@año,@tipo,@espec,@fabricante,@idioma,@archivo,@actualizado)", con);
                cmd.Parameters.AddWithValue("@nombre",txt_nombre.Text);
                cmd.Parameters.AddWithValue("@año",txt_year.Text);
                cmd.Parameters.AddWithValue("@espec",txt_especialidad.Text);
                cmd.Parameters.AddWithValue("@tipo", (cmb_tipo.SelectedItem as ComboboxItem).Text);
                cmd.Parameters.AddWithValue("@fabricante",id_fabricante);
                cmd.Parameters.AddWithValue("@idioma", (cmb_idioma.SelectedItem as ComboboxItem).Text);
                cmd.Parameters.AddWithValue("@archivo",lbl_archivo.Text);
                cmd.Parameters.AddWithValue("@actualizado", DateTime.Now);
                Int32 newId = (Int32)cmd.ExecuteScalar();
                mc.crearDirectorios(archivo, fileName, newId, "Catalogos-Productos");
                this.DialogResult = DialogResult.OK;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

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
