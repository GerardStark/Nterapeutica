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
    public partial class Licitacion_Nueva_Abierta : Form
    {
        MainConfig mc = new MainConfig();
        string fileName, archivo, camino, tipoLic;
        public Licitacion_Nueva_Abierta()
        {
            InitializeComponent();
            lbl_archivo.Text = "(Vacio)";
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
            mc.llenarcombobox(array_specs, cmb_especialidad);
        }

        public void pasarTipoLicitacion(string tipoLic)
        {
            this.tipoLic = tipoLic;
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

        private void txt_num_expediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Licitacion_Nueva_Abierta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.aux_tipos_expediente' Puede moverla o quitarla según sea necesario.
            this.aux_tipos_expedienteTableAdapter.Fill(this.licitacionesDataSet.aux_tipos_expediente);
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.aux_entidades_federativas' Puede moverla o quitarla según sea necesario.
            this.aux_entidades_federativasTableAdapter.Fill(this.licitacionesDataSet.aux_entidades_federativas);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    //procedimiento en SQL para insertar bases
                    using (SqlCommand cmd = new SqlCommand("licitaciones_bases_insert", con))
                    {
                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@numero", txt_numero.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@unidadComp", txt_unidad_compradora.Text);
                        cmd.Parameters.AddWithValue("@entidadFed", cmb_entidad.SelectedValue);
                        cmd.Parameters.AddWithValue("@espec", (cmb_especialidad.SelectedItem as ComboboxItem).Text);
                        cmd.Parameters.AddWithValue("@duracion", txt_duracion_contrato.Text);
                        cmd.Parameters.AddWithValue("@tipoContrat", txt_tipo_contrato.Text);
                        cmd.Parameters.AddWithValue("@estado", 0);
                        cmd.Parameters.AddWithValue("@expediente", txt_num_expediente.Text);
                        cmd.Parameters.AddWithValue("@tipoLic", tipoLic);
                        cmd.Parameters.AddWithValue("@tipoExp", cmb_tipo_exp.SelectedValue);
                        cmd.Parameters.AddWithValue("@nombre", txt_nombre_operador.Text);
                        cmd.Parameters.AddWithValue("@email", txt_correo_operador.Text);
                        cmd.Parameters.AddWithValue("@descripcion", txt_desc.Text);
                        cmd.Parameters.AddWithValue("@archivo", lbl_archivo.Text);
                        cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                        Int32 newId = (Int32)cmd.ExecuteScalar();
                        mc.crearDirectorios(archivo, fileName, newId, "Licitaciones");
                        if (newId != 0)
                        {
                            Licitacion_Calendario form = new Licitacion_Calendario();
                            form.pasarIdLicitaciones(newId);
                            form.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
