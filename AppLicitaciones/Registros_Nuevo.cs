﻿using System;
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
        string columna, fileName, archivo, camino;
        public Registros_Nuevo()
        {
            InitializeComponent();
            lbl_reg_archivo.Text = "";
        }

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("insert into registros_sanitarios (numero_registro,numero_solicitud,titular,denom_distintiva,denom_generica,fabricante,"+
                "marca,nacionalidad,tratado_comercio,fecha_emision,fecha_vencimiento,dir_archivo,actualizado_en,tipo) OUTPUT INSERTED.Id "+
                "values(@numero,@solicitud,@titular,@distintiva,@generica,@fabricante,@marca,@nacionalidad,@tlc,@emision,@vencimiento,@archivo,@actualizado,@tipo)", con);
                cmd.Parameters.AddWithValue("@numero",txt_numero.Text);
                cmd.Parameters.AddWithValue("@solicitud", txt_solicitud.Text);
                cmd.Parameters.AddWithValue("@titular",txt_titular.Text);
                cmd.Parameters.AddWithValue("@distintiva", txt_distintiva.Text);
                cmd.Parameters.AddWithValue("@generica", txt_generica.Text);
                cmd.Parameters.AddWithValue("@fabricante",txt_fabricante.Text);
                cmd.Parameters.AddWithValue("@@marca", txt_marca.Text);
                cmd.Parameters.AddWithValue("@nacionalidad", txt_nacionalidad.Text);
                cmd.Parameters.AddWithValue("@tlc", txt_tlc.Text);
                cmd.Parameters.AddWithValue("@emision", date_emision.Value.Date);
                cmd.Parameters.AddWithValue("@vencimiento",date_vencimiento.Value.Date);
                cmd.Parameters.AddWithValue("@tipo",cmb_tipo.SelectedValue);
                cmd.Parameters.AddWithValue("@actualizado", DateTime.Now);
                Int32 newId = (Int32)cmd.ExecuteScalar();
                crearDirectorios(newId);
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void crearDirectorios(int id)
        {
            string newpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DocumentosNT\Registros-Sanitarios\";

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
            txt_distintiva.Text = "";
            txt_generica.Text = "";
            txt_fabricante.Text = "";
            txt_marca.Text = "";
            txt_nacionalidad.Text = "";
            txt_tlc.Text = "";
            lbl_reg_archivo.Text = "";
            date_emision.ResetText();
            date_vencimiento.ResetText();
        }

        private void btn_archivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "PDF Files|*.pdf|Word Files|*.docx";
            openFileDialog1.Title = "Select a PDF/Word File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lbl_reg_archivo.Text = openFileDialog1.SafeFileName;
                fileName = openFileDialog1.FileName;
                camino = Path.GetDirectoryName(fileName);
                archivo = Path.GetFileName(fileName);
            }
        }
    }
}
