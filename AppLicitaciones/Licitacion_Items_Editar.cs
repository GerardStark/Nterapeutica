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
    public partial class Licitacion_Items_Editar : Form
    {
        MainConfig mc = new MainConfig();
        int idItem;
        public Licitacion_Items_Editar()
        {
            InitializeComponent();
            string[] array_tipos = {
                "Pieza",
                "Paquete",
                "Kit",
                "Caja"
            };
            mc.llenarcombobox(array_tipos, cmb_tipo);
            mc.llenarcombobox(array_tipos, cmb_cont);
        }

        public void mostrarInfoItem(int idItem)
        {
            this.idItem = idItem;
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM licitacion_items WHERE id_item = @idItem",con))
                {
                    cmd.Parameters.AddWithValue("@idItem", idItem);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        txt_descripcion.Text = dt.Rows[0]["descripcion"].ToString();
                        cmb_tipo.SelectedIndex = mc.obtenervaluecomboitem(dt.Rows[0]["unidad_venta"].ToString(), cmb_tipo);
                        txt_cantidad.Text = dt.Rows[0]["cantidad"].ToString();
                        cmb_cont.SelectedIndex = mc.obtenervaluecomboitem(dt.Rows[0]["contenedor"].ToString(), cmb_cont);
                    }
                }
            }
        }
        private void btn_reg_descartar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        
        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("licitacion_item_update", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idItem", idItem);
                    cmd.Parameters.AddWithValue("@descripcion", txt_descripcion.Text);
                    cmd.Parameters.AddWithValue("@unidad", (cmb_tipo.SelectedItem as ComboboxItem).Text);
                    cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txt_cantidad.Text));
                    cmd.Parameters.AddWithValue("@contenedor", (cmb_cont.SelectedItem as ComboboxItem).Text);
                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                    Int32 newId = cmd.ExecuteNonQuery();
                    if (newId != 0)
                    {
                        MessageBox.Show("Guardado");
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }
    }
}
