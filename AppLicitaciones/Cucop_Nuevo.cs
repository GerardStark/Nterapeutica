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
    public partial class Cucop_Nuevo : Form
    {
        MainConfig mc = new MainConfig();
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
        public Cucop_Nuevo()
        {
            InitializeComponent();
            mc.llenarcombobox(array_specs, cmb_spec);
            mc.llenarcombobox(array_tipos,cmb_tipo);
            mc.llenarcombobox(array_tipos, cmb_cont);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (chk_sccb.Checked == true)
            {
                try
                {
                    SqlConnection con = new SqlConnection(mc.con);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO cucop (clave,descripcion,especialidad,presentacion_tipo,presentacion_cant,presentacion_cont,actualizado_en)" +
                        " OUTPUT INSERTED.id_cucop values(@clave,@desc,@spec,@tipo,@cant,@cont,@updated)", con);
                    cmd.Parameters.AddWithValue("@clave", "S.C.C/B");
                    cmd.Parameters.AddWithValue("@desc", mc.convertirasentencia(txt_desc.Text));
                    cmd.Parameters.AddWithValue("@spec", (cmb_spec.SelectedItem as ComboboxItem).Text);
                    cmd.Parameters.AddWithValue("@tipo", (cmb_tipo.SelectedItem as ComboboxItem).Text);
                    cmd.Parameters.AddWithValue("@cant", txt_cantidad.Text);
                    cmd.Parameters.AddWithValue("@cont", (cmb_cont.SelectedItem as ComboboxItem).Text);
                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                    Int32 newId = (Int32)cmd.ExecuteScalar();
                    //crearvinculodb(newId);
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
                        SqlCommand cmd = new SqlCommand("INSERT INTO cucop (clave,descripcion,especialidad,presentacion_tipo,presentacion_cant,presentacion_cont,actualizado_en)" +
                            " OUTPUT INSERTED.id_cucop values(@clave,@desc,@spec,@tipo,@cant,@cont,@updated)", con);
                        cmd.Parameters.AddWithValue("@clave", txt_clave_gpo.Text + "." + txt_clave_gen.Text + "." + txt_clave_esp.Text);
                        cmd.Parameters.AddWithValue("@desc", mc.convertirasentencia(txt_desc.Text));
                        cmd.Parameters.AddWithValue("@spec", (cmb_spec.SelectedItem as ComboboxItem).Text);
                        cmd.Parameters.AddWithValue("@tipo", (cmb_tipo.SelectedItem as ComboboxItem).Text);
                        cmd.Parameters.AddWithValue("@cant", txt_cantidad.Text);
                        cmd.Parameters.AddWithValue("@cont", (cmb_cont.SelectedItem as ComboboxItem).Text);
                        cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                        Int32 newId = (Int32)cmd.ExecuteScalar();
                        //crearvinculodb(newId);
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
        private void crearvinculodb(int id_cucop)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO aux_vinculos (id_cucop_item) VALUES (@idcucop) ", con);
                    cmd.Parameters.AddWithValue("@idcucop", id_cucop);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Exito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_descartar_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        private void limpiarcampos()
        {
            txt_clave_esp.Text = "";
            txt_clave_gen.Text = "";
            txt_clave_gpo.Text = "";
            txt_desc.Text = "";
            txt_cantidad.Text = "";
            cmb_cont.SelectedIndex = 0;
            cmb_spec.SelectedIndex = 0;
            cmb_tipo.SelectedIndex = 0;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void txt_clave_gpo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_clave_gen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_clave_esp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
