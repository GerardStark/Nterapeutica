﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLicitacion;

namespace AppLicitaciones
{
    public partial class Catalogos_Visualizar : Form
    {
        MainConfig mc = new MainConfig();
        int id_catalogo = 0;
        public Catalogos_Visualizar()
        {
            InitializeComponent();
        }
        public void mostrarinfocatalogo(int id_catalogo)
        {
            this.id_catalogo = id_catalogo;
            SqlConnection con = new SqlConnection(mc.con);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from catalogos_productos Where id_catalogo = @id", con);
            cmd.Parameters.AddWithValue("@id", id_catalogo);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                //dt.Rows[0][""].ToString();
                lbl_nombre.Text = dt.Rows[0]["nombre_catalogo"].ToString();
                lbl_year.Text = dt.Rows[0]["año_plublicacion"].ToString();
                lbl_tipo.Text = dt.Rows[0]["tipo"].ToString();
                lbl_idioma.Text = dt.Rows[0]["idioma"].ToString();
                lbl_fabricante.Text = dt.Rows[0]["fabricante"].ToString();
                lbl_especialidad.Text = dt.Rows[0]["especialidad"].ToString();
                lbl_archivo.Text = dt.Rows[0]["dir_archivo"].ToString();
            }
        }

        private void btn_ver_archivo_Click(object sender, EventArgs e)
        {
            string newpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DocumentosNT\Catálogos-Productos\";
            string pathanexos = newpath + "\\" + id_catalogo + "\\" + lbl_archivo.Text;

            if (lbl_archivo.Text != "(Vacio)")
            {
                try
                {
                    System.Diagnostics.Process.Start(pathanexos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
    
}
