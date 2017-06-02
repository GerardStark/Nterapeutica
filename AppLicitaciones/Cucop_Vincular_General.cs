using LibLicitacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLicitaciones
{
    public partial class Cucop_Vincular_General : Form
    {
        MainConfig mc = new MainConfig();
        int id_cucop = 0;
        public Cucop_Vincular_General()
        {
            InitializeComponent();
            lbl_nombre_prod.Text = "";
            //registros
            lbl_reg_numero.Text = "";
            lbl_reg_fabricante.Text = "";
            lbl_reg_denom_gen.Text = "";
            lbl_reg_denom_dist.Text = "";
            lbl_reg_vencimiento.Text = "";
            //catalogos
            lbl_cat_nombre.Text = "";
            lbl_cat_fabricante.Text = "";
            lbl_cat_idioma.Text = "";
            lbl_cat_especialidad.Text = "";
            lbl_cat_pagina.Text = "";
            //certificados
            lbl_cert_numero.Text = "";
            lbl_cert_fabricante.Text = "";
            lbl_cert_tipo.Text = "";
            lbl_cert_vencimiento.Text = "";
        }
        public void mostrarvinculoscucop(int id_cucop)
        {
            this.id_cucop = id_cucop;
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select nombre_generico_espeficico,grupo,codigo from cucop where id_cucop = @id", con);
                cmd.Parameters.AddWithValue("@id", id_cucop);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    lbl_ccb.Text = dt.Rows[0]["codigo"].ToString();
                    lbl_grupo.Text = dt.Rows[0]["grupo"].ToString();
                    lbl_nombre_gen.Text = dt.Rows[0]["nombre_generico_espeficico"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
