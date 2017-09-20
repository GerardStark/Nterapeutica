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
        int idItem, idSub;
        string contenedor, tipo, ccb;
        public Licitacion_Items_Editar()
        {
            InitializeComponent();
           
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
                        txt_numero.Text = dt.Rows[0]["numero"].ToString();
                        txt_descripcion.Text = dt.Rows[0]["descripcion"].ToString();
                        tipo = dt.Rows[0]["unidad_venta"].ToString();
                        txt_cantidad.Text = dt.Rows[0]["cantidad"].ToString();
                        contenedor = dt.Rows[0]["contenedor"].ToString();
                        ccb = dt.Rows[0]["codigo_cuadro_basico"].ToString();
                        txt_min.Text = dt.Rows[0]["minimo"].ToString();
                        txt_max.Text = dt.Rows[0]["maximo"].ToString();
                        idSub = (Int32)dt.Rows[0]["id_paquete"];
                        if (ccb == "S.C.C/B")
                        {
                            chk_sccb.Checked = true;
                        }
                        else
                        {
                            string[] substrings = ccb.Split('.');
                            chk_sccb.Checked = false;
                            txt_clave_gpo.Text = substrings[0];
                            txt_clave_gen.Text = substrings[1];
                            txt_clave_esp.Text = substrings[2];
                            txt_clave_dif.Text = substrings[3];
                            txt_clave_var.Text = substrings[4];
                        }
                        var infos = Procedimiento.GetProcedimientos().Where(x => x.Id == (Int32)dt.Rows[0]["id_paquete"]).Single().Infos.ToList();
                        if (infos.Count > 0)
                        {
                            infoAd.Visible = true;
                            foreach (ProceInfoAd i in infos)
                            {
                                //var valor = Item.GetItems().Where(x => x.Id == (Int32)dt.Rows[0]["id_item"]).FirstOrDefault().Infos.Where(y => y.Info == i.Id).FirstOrDefault().Valor;
                                Label l = new Label();
                                l.Text = i.Nombre + ": ";
                                TextBox t = new TextBox();
                                t.Name = "txt_" + i.Nombre;
                                if (Item.GetItems().Where(x => x.Id == (Int32)dt.Rows[0]["id_item"]).FirstOrDefault().Infos.Any())
                                {
                                    t.Text = Item.GetItems().Where(x => x.Id == (Int32)dt.Rows[0]["id_item"]).FirstOrDefault().Infos.Where(y => y.Info == i.Id).FirstOrDefault().Valor;
                                }
                                else
                                {
                                    t.Text = "";
                                }
                                infoAd.Controls.Add(l);
                                infoAd.Controls.Add(t);
                            }
                        }
                    }
                }
            }
        }
        private void btn_reg_descartar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void chk_sccb_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_sccb.Checked == true)
            {
                txt_clave_dif.Enabled = false;
                txt_clave_esp.Enabled = false;
                txt_clave_gen.Enabled = false;
                txt_clave_gpo.Enabled = false;
                txt_clave_var.Enabled = false;
            }
            else
            {
                txt_clave_dif.Enabled = true;
                txt_clave_esp.Enabled = true;
                txt_clave_gen.Enabled = true;
                txt_clave_gpo.Enabled = true;
                txt_clave_var.Enabled = true;
            }
        }

        private void onlynumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            if (chk_sccb.Checked == true)
            {
                ccb = "S.C.C/B";
            }
            else
            {
                ccb = txt_clave_gpo.Text + "." + txt_clave_gen.Text + "." + txt_clave_esp.Text + "." + txt_clave_dif.Text + "." + txt_clave_var.Text;
            }
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("licitacion_item_update", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idItem", idItem);
                    cmd.Parameters.AddWithValue("@numero", txt_numero.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txt_descripcion.Text);
                    cmd.Parameters.AddWithValue("@unidad",cmb_tipo.Text);
                    cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txt_cantidad.Text));
                    cmd.Parameters.AddWithValue("@contenedor", cmb_cont.Text);
                    cmd.Parameters.AddWithValue("@max", txt_max.Text);
                    cmd.Parameters.AddWithValue("@min", txt_min.Text);
                    cmd.Parameters.AddWithValue("@ccb", ccb);
                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                    Int32 newId = cmd.ExecuteNonQuery();
                    if (newId != 0)
                    {
                        var infosi = Item.GetItems().Where(x => x.Id == idItem).FirstOrDefault().Infos;
                        if (infosi.Count > 0)
                        {
                            foreach (ItemInfoAd item in infosi)
                            {
                                using (SqlCommand cmi = new SqlCommand("licitacion_info_vinc_update",con))
                                {
                                    
                                    string nombre = ProceInfoAd.GetInfosPorProcedimiento(idSub).Where(x => x.Id == item.Info).FirstOrDefault().Nombre;
                                    cmi.CommandType = CommandType.StoredProcedure;
                                    cmi.Parameters.AddWithValue("@idInfo", item.Id);
                                    cmi.Parameters.AddWithValue("@valor", ((TextBox)infoAd.Controls["txt_" + nombre]).Text);
                                    cmi.Parameters.AddWithValue("@updated", DateTime.Now);
                                    int result = cmi.ExecuteNonQuery();
                                    if (result != 0)
                                    {
                                        
                                    }
                                }
                            }
                        }
                        else
                        {
                            var infosp = Procedimiento.GetProcedimientos().Where(x => x.Id == idSub).Single().Infos.ToList();
                            foreach (ProceInfoAd item in infosp)
                            {

                                using (SqlCommand cmi = new SqlCommand("licitacion_info_vinc_create",con))
                                {
                                    
                                    cmi.CommandType = CommandType.StoredProcedure;
                                    cmi.Parameters.AddWithValue("@idInfo", item.Id);
                                    cmi.Parameters.AddWithValue("@idItem", idItem);
                                    cmi.Parameters.AddWithValue("@valor", ((TextBox)infoAd.Controls["txt_" + item.Nombre]).Text);
                                    cmi.Parameters.AddWithValue("@updated", DateTime.Now);
                                    int result = cmi.ExecuteNonQuery();
                                    if (result != 0)
                                    {
                                       
                                    }
                                }
                            }
                        }
                        MessageBox.Show("Guardado");
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void Licitacion_Items_Editar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.data_unidades' Puede moverla o quitarla según sea necesario.
            this.data_unidadesTableAdapter.Fill(this.licitacionesDataSet.data_unidades);
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.data_unidades' Puede moverla o quitarla según sea necesario.
            this.data_unidadesTableAdapter.Fill(this.licitacionesDataSet.data_unidades);
            cmb_cont.Text = contenedor;
            cmb_tipo.Text = tipo;

        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
