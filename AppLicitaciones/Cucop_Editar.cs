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
    public partial class Cucop_Editar : Form
    {
        MainConfig mc = new MainConfig();
        int id_cucop = 0;
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
            mc.llenarcombobox(array_tipos, cmb_tipo);
            mc.llenarcombobox(array_tipos, cmb_cont);
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
                    cmb_cont.SelectedIndex = mc.obtenervaluecomboitem(dt.Rows[0]["presentacion_cont"].ToString(),cmb_cont);
                    cmb_tipo.SelectedIndex = mc.obtenervaluecomboitem(dt.Rows[0]["presentacion_tipo"].ToString(), cmb_tipo);
                    string cucop = dt.Rows[0]["clave"].ToString();
                    if (cucop == "S.C.C/B")
                    {
                        chk_sccb.Checked = true;
                    }
                    else
                    {
                        chk_sccb.Checked = false;
                        txt_clave_gpo.Text = cucop.Substring(0,2);
                        txt_clave_gen.Text = cucop.Substring(1,3);
                        txt_clave_esp.Text = cucop.Substring(1,4);
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
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE cucop SET clave = @clave,descripcion = @desc,especialidad = @spec,presentacion_tipo = @tipo,"
                    +"presentacion_cant = @cant,presentacion_cont = @cont,actualizado_en = @updated " +
                    "WHERE id_cucop = @id",con);
                cmd.Parameters.AddWithValue("@clave", "S.C.C/B");
                cmd.Parameters.AddWithValue("@desc", txt_desc.Text);
                cmd.Parameters.AddWithValue("@spec", (cmb_spec.SelectedItem as ComboboxItem).Text);
                cmd.Parameters.AddWithValue("@tipo", (cmb_tipo.SelectedItem as ComboboxItem).Text);
                cmd.Parameters.AddWithValue("@cant", txt_cantidad.Text);
                cmd.Parameters.AddWithValue("@cont", (cmb_cont.SelectedItem as ComboboxItem).Text);
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
    }
}
