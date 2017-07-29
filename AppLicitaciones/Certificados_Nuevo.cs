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
    public partial class Certificados_Nuevo : Form
    {
        MainConfig mc = new MainConfig();
        string fileName, archivo, camino;
        string fileNametrad, archivotrad, caminotrad;
        int id_fabricante = 0;
        public Certificados_Nuevo()
        {
            InitializeComponent();
            string[] array_tipos_certificado = { "ISO","FDA","CLV" };
            string[] array_idiomas = { "Español", "Inglés", "Francés", "Alemán", "Japonés", "Portugués", "Chino", "Koreano", "Irlandés" };
            mc.llenarcombobox(array_tipos_certificado, cmb_tipo);
            mc.llenarcombobox(array_idiomas, cmb_idioma);
        }

        private void txt_limpiar_campos_Click(object sender, EventArgs e)
        {
            txt_clave.Text = "";
            cmb_tipo.SelectedIndex = 0;
            cmb_idioma.SelectedIndex = 0;
            lbl_archivo.Text = "Archivo";
            lbl_trad.Text = "Traduccion";
            txt_fabricante.Text = "";
            id_fabricante = 0;
            date_emision.ResetText();
            date_vencimiento.ResetText();
        }

        private void btn_selec_fabricante_Click(object sender, EventArgs e)
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

        private void btn_traduccion_Click(object sender, EventArgs e)
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

        private void btn_reg_descartar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand(@"IF NOT EXISTS (SELECT numero_identificador,tipo,fabricante FROM certificados_calidad WHERE numero_identificador = @clave,tipo = @tipo,fabricante =@fabr)
                BEGIN
                    INSERT INTO certificados_calidad (numero_identificador,tipo,descripcion_detallada,fabricante,fecha_emision,fecha_vencimiento,idioma,dir_archivo,dir_archivo_traduccion,actualizado_en)
                    OUTPUT INSERTED.id_certificado
                    VALUES(@clave,@tipo,@desc,@fabr,@emision,@vencimento,@idioma,@archivo,@trad,@updated) 
                END", con);
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
                Int32 newid = (Int32)cmd.ExecuteScalar();
                mc.crearDirectorios(archivo, fileName, newid, "Certificados-Calidad");
                mc.crearDirectorios(archivotrad, fileNametrad, newid, "Certificados-Calidad");
                this.DialogResult = DialogResult.OK;
                con.Close();
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException)
                {
                    MessageBox.Show("Ya existe el Certificado");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
