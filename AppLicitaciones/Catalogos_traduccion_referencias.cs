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
using LibLicitacion;

namespace AppLicitaciones
{
    public partial class Catalogos_traduccion_referencias : Form
    {
        //INCOMPLETO
        int id_catalogo = 0;
        int id_traduccion = 0;
        MainConfig mc = new MainConfig();
        int filtro_flag = 0;
        string ctrl = "", valor = "";
        List<Int32> claves = new List<int>();
        public Catalogos_traduccion_referencias()
        {
            InitializeComponent();
            string[] array_filtros_referencias = { "Seleccionar","Clave", "Descripcion", "Unidad" };
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
        public void mostrarreferenciascatalogo(int id_catalogo,int id_traduccion)
        {
            this.id_catalogo = id_catalogo;
            this.id_traduccion = id_traduccion;
            try
            {
                DGV_Referencias.Rows.Clear();
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("Select id_clave_catalogo, clave_ref_cod, descripcion, unidad_venta " +
                    "from catalogos_claves_referencias where id_catalogo_productos = @id", con);
                cmd.Parameters.AddWithValue("@id", id_catalogo);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_Referencias.Rows.Add(dr.ItemArray);
                    marcarclaves(Convert.ToInt32(dr["id_clave_catalogo"]));                
                }
                con.Close();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                    SqlCommand cmd = new SqlCommand("Select id_clave_catalogo,clave_ref_cod,descripcion,unidad_venta " +
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

        private void marcarclaves(int id_clave)
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("Select id_referencia from aux_cat_trad_ref where id_traduccion = @idtrad and id_referencia = @idref", con);
                cmd.Parameters.AddWithValue("@idtrad", id_traduccion);
                cmd.Parameters.AddWithValue("@idref", id_clave);
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Guardar Cambios y Cerrar?", "Guardar Referencias en Traducción", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DGV_Referencias.EndEdit();
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmdelete = new SqlCommand("DELETE FROM aux_cat_trad_ref Where id_traduccion = " + id_traduccion + "", con);
                cmdelete.ExecuteNonQuery();
                claves.ForEach(delegate (int id)
                {
                    //insertar marcados, checar si no existen, eliminar los desmarcados

                    try
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO aux_cat_trad_ref (id_traduccion,id_referencia,actualizado_en)" +
                            "Values (@idtrad,@idref,@updated)", con);
                        cmd.Parameters.AddWithValue("@idtrad", id_traduccion);
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

        private void DGV_Referencias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //checar si existe en la db
           // marcarclaves(Convert.ToInt32(dr["id_clave_catalogo"]));
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
    }
}
