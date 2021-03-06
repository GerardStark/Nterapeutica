﻿using LibLicitacion;
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
    public partial class Cucop_Editar : Form
    {
        MainConfig mc = new MainConfig();
        int id_cucop = 0;
        string contenedor, tipo;
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
        string[] array_tipos = {
            "Pieza",
            "Paquete",
            "Kit",
            "Caja"
        };
        public Cucop_Editar()
        {
            InitializeComponent();
            mc.llenarcombobox(array_specs, cmb_spec);
            //mc.llenarcombobox(array_tipos, cmb_tipo);
            //mc.llenarcombobox(array_tipos, cmb_cont);
        }

        public void llenarinfocucop(int id_cucop)
        {
            this.id_cucop = id_cucop;
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select clave,descripcion,especialidad,presentacion_tipo,presentacion_cant,presentacion_cont,actualizado_en"+
                    " from cucop where id_cucop = @id", con);
                cmd.Parameters.AddWithValue("@id",id_cucop);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    txt_desc.Text = dt.Rows[0]["descripcion"].ToString();
                    txt_cantidad.Text = dt.Rows[0]["presentacion_cant"].ToString();
                    cmb_spec.SelectedIndex = mc.obtenervaluecomboitem(dt.Rows[0]["especialidad"].ToString(), cmb_spec);
                    contenedor = dt.Rows[0]["presentacion_cont"].ToString();
                    tipo = dt.Rows[0]["presentacion_tipo"].ToString();
                    string cucop = dt.Rows[0]["clave"].ToString();
                    if (cucop == "S.C.C/B")
                    {
                        chk_sccb.Checked = true;
                    }
                    else
                    {
                        string[] substrings = cucop.Split('.');
                        chk_sccb.Checked = false;
                        txt_clave_gpo.Text = substrings[0];
                        txt_clave_gen.Text = substrings[1];
                        txt_clave_esp.Text = substrings[2];
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (chk_sccb.Checked == true)
            {
                try
                {
                    SqlConnection con = new SqlConnection(mc.con);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE cucop SET clave = @clave,descripcion = @desc,especialidad = @spec,presentacion_tipo = @tipo,"
                        + "presentacion_cant = @cant,presentacion_cont = @cont,actualizado_en = @updated " +
                        "WHERE id_cucop = @id", con);
                    cmd.Parameters.AddWithValue("@id", id_cucop);
                    cmd.Parameters.AddWithValue("@clave", "S.C.C/B");
                    cmd.Parameters.AddWithValue("@desc", mc.convertirasentencia(txt_desc.Text));
                    cmd.Parameters.AddWithValue("@spec", (cmb_spec.SelectedItem as ComboboxItem).Text);
                    cmd.Parameters.AddWithValue("@tipo", cmb_tipo.Text);
                    cmd.Parameters.AddWithValue("@cant", txt_cantidad.Text);
                    cmd.Parameters.AddWithValue("@cont", cmb_cont.Text);
                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (txt_clave_gpo.Text.Length == 3 || txt_clave_gen.Text.Length == 3 || txt_clave_esp.Text.Length == 4)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(mc.con);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE cucop SET clave = @clave,descripcion = @desc,especialidad = @spec,presentacion_tipo = @tipo,"
                        + "presentacion_cant = @cant,presentacion_cont = @cont,actualizado_en = @updated " +
                        "WHERE id_cucop = @id", con);
                        cmd.Parameters.AddWithValue("@id", id_cucop);
                        cmd.Parameters.AddWithValue("@clave", txt_clave_gpo.Text + "." + txt_clave_gen.Text + "." + txt_clave_esp.Text);
                        cmd.Parameters.AddWithValue("@desc", mc.convertirasentencia(txt_desc.Text));
                        cmd.Parameters.AddWithValue("@spec", (cmb_spec.SelectedItem as ComboboxItem).Text);
                        cmd.Parameters.AddWithValue("@tipo", cmb_tipo);
                        cmd.Parameters.AddWithValue("@cant", txt_cantidad.Text);
                        cmd.Parameters.AddWithValue("@cont", cmb_cont.Text);
                        cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("El cucop debe consistir en 12 digitos como se muestra acontinuacion: xxx.xxx.xxxx");
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chk_sccb_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_sccb.Checked == true)
            {
                txt_clave_esp.ReadOnly = true;
                txt_clave_gen.ReadOnly = true;
                txt_clave_gpo.ReadOnly = true;
            }
            else
            {
                txt_clave_esp.ReadOnly = false;
                txt_clave_gen.ReadOnly = false;
                txt_clave_gpo.ReadOnly = false;
            }
        }

        private void Cucop_Editar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.data_unidades' Puede moverla o quitarla según sea necesario.
            this.data_unidadesTableAdapter.Fill(this.licitacionesDataSet.data_unidades);
            cmb_cont.Text = contenedor;
            cmb_tipo.Text = tipo;

        }
    }
}
