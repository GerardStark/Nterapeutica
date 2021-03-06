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
    public partial class Catalogos_ClavesReferencias : Form
    {
        MainConfig mc = new MainConfig();
        int id_catalogo, id_referencia = 0;
        public Catalogos_ClavesReferencias()
        {
            InitializeComponent();
            this.DGV_Referencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Referencias.MultiSelect = false;
        }
        //TODO llenar dgv con las clavevs asigandas al registro sanitario
        public void mostrarclavescatalogos(int id_catalogo)
        {
            this.id_catalogo = id_catalogo;
            try
            {
                DGV_Referencias.Rows.Clear();
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select id_clave_catalogo, clave_ref_cod, descripcion, unidad_venta, pagina_pdf,pagina_cat,actualizado_en " +
                        "from catalogos_claves_referencias where id_catalogo_productos = @id", con);
                    cmd.Parameters.AddWithValue("@id", id_catalogo);                    
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    lbl_conteo.Text = dt.Rows.Count.ToString();
                    foreach (DataRow dr in dt.Rows)
                    {
                        DGV_Referencias.Rows.Add(dr.ItemArray);
                    }
                    mc.buscarultimafilaeditada("catalogos_claves_referencias", DGV_Referencias);
                    
                }
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (id_referencia != 0)
            {
                DialogResult result = MessageBox.Show("Se va a duplicar la información capturada en una Referencia Nueva, ¿seguir?", "Aviso de duplicado", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(mc.con);
                        SqlCommand cmd = new SqlCommand("INSERT into catalogos_claves_referencias (id_catalogo_productos,clave_ref_cod,descripcion,unidad_venta,pagina_pdf,pagina_cat,actualizado_en)" +
                            "values (@idcatalogo,@clave,@descripcion,@unidad,@pagpdf,@pagcat,@actualizado)", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@idcatalogo", id_catalogo);
                        cmd.Parameters.AddWithValue("@clave", txt_clave.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@descripcion", mc.convertirasentencia(txt_descripcion.Text));
                        cmd.Parameters.AddWithValue("@unidad", cmb_unidad.Text);
                        cmd.Parameters.AddWithValue("@pagpdf", txt_pag_pdf.Text);
                        cmd.Parameters.AddWithValue("@pagcat", txt_pag_cat.Text);
                        cmd.Parameters.AddWithValue("@actualizado", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Guardado");
                        mostrarclavescatalogos(id_catalogo);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(mc.con);
                    SqlCommand cmd = new SqlCommand("INSERT into catalogos_claves_referencias (id_catalogo_productos,clave_ref_cod,descripcion,unidad_venta,pagina_pdf,pagina_cat,actualizado_en)" +
                        "values (@idcatalogo,@clave,@descripcion,@unidad,@pagpdf,@pagcat,@actualizado)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@idcatalogo", id_catalogo);
                    cmd.Parameters.AddWithValue("@clave", txt_clave.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@descripcion", mc.convertirasentencia(txt_descripcion.Text));
                    cmd.Parameters.AddWithValue("@unidad", cmb_unidad.Text);
                    cmd.Parameters.AddWithValue("@pagpdf", txt_pag_pdf.Text);
                    cmd.Parameters.AddWithValue("@pagcat", txt_pag_cat.Text);
                    cmd.Parameters.AddWithValue("@actualizado", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Guardado");
                    mostrarclavescatalogos(id_catalogo);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (id_referencia != 0)
            {
                try
                {
                    SqlConnection con = new SqlConnection(mc.con);
                    SqlCommand cmd = new SqlCommand("UPDATE catalogos_claves_referencias set clave_ref_cod = @clave , descripcion = @descripcion, unidad_venta = @unidad" +
                        ",pagina_pdf = @pagpdf,pagina_cat = @pagcat, actualizado_en = @actualizado where id_clave_catalogo = @id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id_referencia);
                    cmd.Parameters.AddWithValue("@idcatalogo", id_catalogo);
                    cmd.Parameters.AddWithValue("@clave", txt_clave.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@descripcion", mc.convertirasentencia(txt_descripcion.Text));
                    cmd.Parameters.AddWithValue("@unidad", cmb_unidad.Text);
                    cmd.Parameters.AddWithValue("@pagpdf", txt_pag_pdf.Text);
                    cmd.Parameters.AddWithValue("@pagcat", txt_pag_cat.Text);
                    cmd.Parameters.AddWithValue("@actualizado", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Actualizado");
                    mostrarclavescatalogos(id_catalogo);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Selecciona una referencia");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (id_referencia != 0)
            {
                try
                {
                    SqlConnection con = new SqlConnection(mc.con);
                    SqlCommand cmd = new SqlCommand("DELETE FROM catalogos_claves_referencias where id_clave_catalogo = @id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id_referencia);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Borrado");
                    mostrarclavescatalogos(id_catalogo);
                    con.Close();
                    btn_guardar.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una referencia");
            }

        }

        private void DGV_Referencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id_referencia = Convert.ToInt32(DGV_Referencias.Rows[e.RowIndex].Cells["idColumn"].Value);
                txt_clave.Text = DGV_Referencias.Rows[e.RowIndex].Cells["claveColumn"].Value.ToString();
                txt_descripcion.Text = DGV_Referencias.Rows[e.RowIndex].Cells["descripcionColumn"].Value.ToString();
                cmb_unidad.SelectedText = DGV_Referencias.Rows[e.RowIndex].Cells["unidadColumn"].Value.ToString();
                txt_pag_pdf.Text = DGV_Referencias.Rows[e.RowIndex].Cells["pagpdfColumn"].Value.ToString();
                txt_pag_cat.Text = DGV_Referencias.Rows[e.RowIndex].Cells["pagcatColumn"].Value.ToString();
               
            }
        }

        private void Catalogos_ClavesReferencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.data_unidades' Puede moverla o quitarla según sea necesario.
            this.data_unidadesTableAdapter.Fill(this.licitacionesDataSet.data_unidades);

        }

        private void DGV_Referencias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.DGV_Referencias.Columns[e.ColumnIndex].Name)
            {

                case "idColumn":
                    e.Value = e.RowIndex + 1;
                    break;
            }
        }

        private void DGV_Referencias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (id_referencia != 0 && e.RowIndex != -1)
            {
                id_referencia = 0;
                btn_guardar.Enabled = true;
                txt_clave.Text = "";
                txt_descripcion.Text = "";
                cmb_unidad.SelectedIndex = 0;
                txt_pag_cat.Text = "";
                txt_pag_pdf.Text = "";
            }
        }
    }
}
