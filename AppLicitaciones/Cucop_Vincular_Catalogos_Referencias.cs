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
    public partial class Cucop_Vincular_Catalogos_Referencias : Form
    {
        int id_registro = 0, id_vinculacion = 0, filtro_flag = 0;
        MainConfig mc = new MainConfig();
        string ctrl = "", valor = "";
        List<Int32> claves = new List<int>();
        public Cucop_Vincular_Catalogos_Referencias()
        {
            InitializeComponent();
            string[] array_filtros_referencias = { "Seleccionar", "Clave", "Descripcion", "Unidad" };
            mc.llenarcombobox(array_filtros_referencias, cmb_filtros);
            foreach (DataGridViewColumn col in DGV_Referencias.Columns)
            {
                if (col.Index == 4)
                {
                    col.ReadOnly = false;
                }
                else
                {
                    col.ReadOnly = true;
                }
            }
            cmb_filtros.SelectedIndex = 0;
        }

        private void DGV_Referencias_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Referencias.Rows.Count > 0)
            {
                if (Convert.ToBoolean(DGV_Referencias.Rows[e.RowIndex].Cells["checkColumn"].Value) == true)
                {
                    claves.Add(Convert.ToInt32(DGV_Referencias.Rows[e.RowIndex].Cells["idColumn"].Value));
                }
                else
                {
                    claves.Remove(Convert.ToInt32(DGV_Referencias.Rows[e.RowIndex].Cells["idColumn"].Value));
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chck_all_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_all.Checked == true)
            {
                foreach (DataGridViewRow row in DGV_Referencias.Rows)
                {
                    row.Cells["checkColumn"].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in DGV_Referencias.Rows)
                {
                    row.Cells["checkColumn"].Value = false;
                }
            }
        }

        private void cmb_filtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(((ComboboxItem)cmb_filtros.SelectedItem).Value);
            switch (value)
            {
                case 2:
                    ctrl = "clave_ref_cod";
                    break;
                case 3:
                    ctrl = "descripcion";
                    break;
                case 4:
                    ctrl = "unidad_venta";
                    break;
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            valor = txt_terminos.Text;
            if (ctrl != "" && valor != "")
            {
                try
                {
                    DGV_Referencias.Rows.Clear();
                    SqlConnection con = new SqlConnection(mc.con);
                    con = new SqlConnection(mc.con);
                    con.Open();
                    //cambiar por tabla catalogos
                    SqlCommand cmd = new SqlCommand("Select  id_clave_catalogo, clave_ref_cod, descripcion, unidad_venta " +
                    "from catalogos_claves_referencias where " + ctrl + " Like '%" + valor + "%'", con);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        DGV_Referencias.Rows.Add(dr.ItemArray);
                    }
                    con.Close();
                    filtro_flag = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Selecciona un filtro");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Guardar Cambios y Cerrar?", "Guardar Referencias en Vinculacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DGV_Referencias.EndEdit();
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmdelete = new SqlCommand("DELETE FROM cucop_vinculos_catalogos_referencias Where id_vinculo_catalogo = " + id_vinculacion + "", con);
                cmdelete.ExecuteNonQuery();
                claves.ForEach(delegate (int id)
                {
                    //insertar marcados, checar si no existen, eliminar los desmarcados

                    try
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO cucop_vinculos_catalogos_referencias (id_vinculo_catalogo,id_referencia,actualizado_en)" +
                            "Values (@idtrad,@idref,@updated)", con);
                        cmd.Parameters.AddWithValue("@idtrad", id_vinculacion);
                        cmd.Parameters.AddWithValue("@idref", id);
                        cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                });
                con.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se guardaron los Cambios");
            }
        }

        //cambiar
        public void mostrarReferenciasCatalogos(int id_registro, int id_vinculacion)
        {
            this.id_registro = id_registro;
            this.id_vinculacion = id_vinculacion;
            try
            {
                DGV_Referencias.Rows.Clear();
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("Select id_clave_catalogo, clave_ref_cod, descripcion, unidad_venta " +
                    "from catalogos_claves_referencias where id_catalogo_productos = @id", con);
                cmd.Parameters.AddWithValue("@id", id_registro);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_Referencias.Rows.Add(dr.ItemArray);
                    marcarclaves(Convert.ToInt32(dr["id_clave_catalogo"]), id_vinculacion);
                }
                con.Close();
                // mc.buscarultimafilaeditada("registros_claves_referencias", DGV_Referencias);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //cambiar
        private void marcarclaves(int id_clave, int id_vinculacion)
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("Select id_referencia from cucop_vinculos_catalogos_referencias where id_vinculo_catalogo = @idVinculo and id_referencia = @idref", con);
                cmd.Parameters.AddWithValue("@idref", id_clave);
                cmd.Parameters.AddWithValue("@idVinculo", id_vinculacion);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in DGV_Referencias.Rows)
                    {
                        if (row.Cells["idColumn"].Value.ToString().Equals(id_clave.ToString()))
                        {
                            row.Cells["checkColumn"].Value = true;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
