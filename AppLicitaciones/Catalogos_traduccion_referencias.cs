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
        public Catalogos_traduccion_referencias()
        {
            InitializeComponent();
            string[] array_filtros_referencias = { "Clave", "Descripcion", "Unidad" };
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

        }
    }
}
