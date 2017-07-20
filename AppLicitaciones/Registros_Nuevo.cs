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
using System.Diagnostics;

namespace AppLicitaciones
{
    public partial class Registros_Nuevo : Form
    {
        MainConfig mc = new MainConfig();
        string fileName, archivo, camino;
        int id_fabricante;
        public Registros_Nuevo()
        {
            InitializeComponent();
            lbl_reg_archivo.Text = "";
            rad_registro.Checked = true;
            
        }
        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            var checkedButton = Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("insert into registros_sanitarios (numero_registro,numero_solicitud,titular,rfc,denom_distintiva,denom_generica,fabricante,"+
                "marca,pais_origen,fecha_emision,fecha_vencimiento,dir_archivo,actualizado_en,tipo) OUTPUT INSERTED.Id_registro "+
                "values(@numero,@solicitud,@titular,@rfc,@distintiva,@generica,@fabricante,@marca,@pais,@emision,@vencimiento,@archivo,@actualizado,@tipo)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@numero",txt_numero.Text);
                cmd.Parameters.AddWithValue("@solicitud", txt_solicitud.Text);
                cmd.Parameters.AddWithValue("@titular",txt_titular.Text);
                cmd.Parameters.AddWithValue("@rfc", txt_rfc.Text);
                cmd.Parameters.AddWithValue("@distintiva", txt_distintiva.Text);
                cmd.Parameters.AddWithValue("@generica", txt_generica.Text);
                cmd.Parameters.AddWithValue("@fabricante", txt_fabricante.Text);
                cmd.Parameters.AddWithValue("@marca", txt_marca.Text);
                cmd.Parameters.AddWithValue("@pais", cmb_pais.SelectedValue);
                cmd.Parameters.AddWithValue("@emision", date_emision.Value.Date);
                cmd.Parameters.AddWithValue("@vencimiento",date_vencimiento.Value.Date);
                cmd.Parameters.AddWithValue("@tipo", checkedButton.Text);
                cmd.Parameters.AddWithValue("@archivo", lbl_reg_archivo.Text);
                cmd.Parameters.AddWithValue("@actualizado", DateTime.Now);
                Int32 newId = (Int32)cmd.ExecuteScalar();
                mc.crearDirectorios(archivo, fileName, newId,"Registros-Sanitarios");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_archivo_Click(object sender, EventArgs e)
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

        private void date_emision_ValueChanged(object sender, EventArgs e)
        {
            DateTime vencimiento = date_emision.Value.Date;
            vencimiento = vencimiento.AddYears(5);
            date_vencimiento.Value = vencimiento;
        }

        private void Registros_Nuevo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.paises_origen' Puede moverla o quitarla según sea necesario.
            this.paises_origenTableAdapter.Fill(this.licitacionesDataSet.paises_origen);

        }

        private void btn_reg_descartar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txt_limpiar_campos_Click(object sender, EventArgs e)
        {
            txt_numero.Text = "";
            txt_solicitud.Text = "";
            txt_titular.Text = "";
            txt_rfc.Text = "";
            txt_distintiva.Text = "";
            txt_generica.Text = "";
            txt_fabricante.Text = "";
            txt_marca.Text = "";
            cmb_pais.SelectedIndex = 0;
            lbl_reg_archivo.Text = "";
            date_emision.ResetText();
            date_vencimiento.ResetText();
        }
    }
}
