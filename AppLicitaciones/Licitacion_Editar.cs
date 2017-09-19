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
    public partial class Licitacion_Editar : Form
    {
        int idlicit, entidad,tipoexp;
        MainConfig mc = new MainConfig();
        string archivo, fileName, tipoLic, camino;

        private void Licitacion_Editar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.aux_tipos_expediente' Puede moverla o quitarla según sea necesario.
            this.aux_tipos_expedienteTableAdapter.Fill(this.licitacionesDataSet.aux_tipos_expediente);
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.aux_entidades_federativas' Puede moverla o quitarla según sea necesario.
            this.aux_entidades_federativasTableAdapter.Fill(this.licitacionesDataSet.aux_entidades_federativas);
            cmb_entidad.SelectedValue = entidad;
            cmb_tipo_exp.SelectedValue = tipoexp;
        }

        public Licitacion_Editar()
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
           // mc.llenarcombobox(array_specs, cmb_especialidad);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("licitaciones_bases_update ", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idBases",idlicit);
                        cmd.Parameters.AddWithValue("@numero", txt_numero.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@unidadComp", txt_unidad_compradora.Text);
                        cmd.Parameters.AddWithValue("@entidadFed", cmb_entidad.SelectedValue);
                        cmd.Parameters.AddWithValue("@espec","");
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
                        int newId = cmd.ExecuteNonQuery();
                        mc.crearDirectorios(archivo, fileName, idlicit, "Licitaciones");
                        if (newId != 0)
                        {
                            MessageBox.Show("Actualizado");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
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

        public void pasarTipoLicitacion(string tipoLic)
        {
            this.tipoLic = tipoLic;
        }

        public void llenarFormularioEdicionLicitacion(int idlicit)
        {
            this.idlicit = idlicit;
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM licitacion_bases WHERE id_bases = @idBases ", con))
                {
                    cmd.Parameters.AddWithValue("@idBases", idlicit);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                       
                        txt_numero.Text = dt.Rows[0]["numero_licitacion"].ToString();
                        txt_unidad_compradora.Text = dt.Rows[0]["unidad_compradora"].ToString();
                        entidad = (Int32)dt.Rows[0]["entidad_federativa"];//obtener texto
                        //cmb_especialidad.SelectedIndex = mc.obtenervaluecomboitem(dt.Rows[0]["especialidad"].ToString(),cmb_especialidad);
                        txt_tipo_contrato.Text = dt.Rows[0]["tipo_contratacion"].ToString();
                        txt_duracion_contrato.Text = dt.Rows[0]["duracion_contrato"].ToString();
                        txt_num_expediente.Text = dt.Rows[0]["expediente"].ToString();
                        tipoexp = (Int32)dt.Rows[0]["tipo_expediente"];
                        //tipoexp = (Int32)dt.Rows[0]["tipo_expediente"];//obtener texto
                        txt_nombre_operador.Text = dt.Rows[0]["operador_nombre"].ToString();
                        txt_correo_operador.Text = dt.Rows[0]["operador_correo"].ToString();
                        txt_desc.Text = dt.Rows[0]["descripcion"].ToString();
                        lbl_archivo.Text = dt.Rows[0]["dir_archivo"].ToString();
                    }
                }
            }
            
        }
    }
}
