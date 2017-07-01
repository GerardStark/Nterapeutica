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
        int id_catalogo = 0;
        MainConfig mc = new MainConfig();
        int filtro_flag = 0;
        string ctrl, valor;
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
            try
            {
                valor = txt_terminos.Text;
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //if (Convert.ToBoolean(row.Cells["checkColumn"].Value) == true)
            //{
            //    MessageBox.Show(row.Index.ToString());
            //}
            //List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
            //foreach (DataGridViewRow row in DGV_Referencias.Rows)
            //{
            //    if (Convert.ToBoolean(row.Cells["checkColumn"].Value) == true)
            //    {
            //        rows_with_checked_column.Add(row);
            //    }
            //}
            //MessageBox.Show(rows_with_checked_column.Count().ToString());
        }

        private void DGV_Referencias_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Referencias.Rows.Count > 0)
            {
                if (Convert.ToBoolean(DGV_Referencias.Rows[e.RowIndex].Cells["checkColumn"].Value) == true)
                {
                    //List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
                    ////agrega las filas checadas a una lista
                    //foreach (DataGridViewRow row in DGV_Referencias.Rows)
                    //{
                    //    if (Convert.ToBoolean(row.Cells["checkColumn"].Value) == true)
                    //    {
                    //        rows_with_checked_column.Add(row);
                    //    }
                    //}
                    MessageBox.Show(e.RowIndex.ToString());
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
