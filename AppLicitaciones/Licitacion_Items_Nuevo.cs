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
    public partial class Licitacion_Items_Nuevo : Form
    {
        MainConfig mc = new MainConfig();
        int idSub;
        string ccb;
        public Licitacion_Items_Nuevo()
        {
            InitializeComponent();
            
        }

        public void pasarIdPartida(int idSub)
        {
            this.idSub = idSub;
            var infos = Procedimiento.GetProcedimientos().Where(x => x.Id == idSub).Single().Infos.ToList();
            if (infos.Count > 0)
            {
                infoAd.Visible = true;
                foreach (ProceInfoAd item in infos)
                {
                    Label l = new Label();
                    l.Text = item.Nombre + ": ";
                    TextBox t = new TextBox();
                    t.Name = "txt_" + item.Nombre;
                    infoAd.Controls.Add(l);
                    infoAd.Controls.Add(t);
                }
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
                using (SqlCommand cmd = new SqlCommand("licitacion_item_insert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idSub",idSub);
                    cmd.Parameters.AddWithValue("@numero", txt_numero.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txt_descripcion.Text);
                    cmd.Parameters.AddWithValue("@unidad", cmb_tipo.Text);
                    cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txt_cantidad.Text));
                    cmd.Parameters.AddWithValue("@contenedor", cmb_cont.Text);
                    cmd.Parameters.AddWithValue("@max", txt_max.Text);
                    cmd.Parameters.AddWithValue("@min", txt_min.Text);
                    cmd.Parameters.AddWithValue("@ccb", ccb);
                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                    Int32 newId = (Int32)cmd.ExecuteScalar();
                    if (newId != 0)
                    {
                        var infos = Procedimiento.GetProcedimientos().Where(x => x.Id == idSub).Single().Infos.ToList();
                        foreach (ProceInfoAd item in infos)
                        {
                            
                            using (SqlCommand cmi = new SqlCommand("licitacion_info_vinc_create",con))
                            {
                                cmi.CommandType = CommandType.StoredProcedure;
                                cmi.Parameters.AddWithValue("@idInfo", item.Id);
                                cmi.Parameters.AddWithValue("@idItem", newId);
                                cmi.Parameters.AddWithValue("@valor", ((TextBox)infoAd.Controls["txt_"+item.Nombre]).Text);
                                cmi.Parameters.AddWithValue("@updated", DateTime.Now);
                                int confirm = cmi.ExecuteNonQuery();
                                if (confirm != 0)
                                {
                                    MessageBox.Show("guardado");
                                    this.DialogResult = DialogResult.OK;
                                }
                            }
                        }
                        //using (SqlCommand cmdd = new SqlCommand("licitacion_vinculacion_create", con))
                        //{
                        //    cmdd.CommandType = CommandType.StoredProcedure;
                        //    cmdd.Parameters.AddWithValue("@idItem", newId);
                        //    cmdd.Parameters.AddWithValue("@idCucop", DBNull.Value);
                        //    cmdd.Parameters.AddWithValue("@updated", DateTime.Now);
                        //    int confirm = cmdd.ExecuteNonQuery();
                        //    if (confirm != 0)
                        //    {
                        //        MessageBox.Show("Guardado");
                        //        this.DialogResult = DialogResult.OK;
                        //    }
                        //}
                    }
                }
            }
        }

        private void btn_reg_descartar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Licitacion_Items_Nuevo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.data_unidades' Puede moverla o quitarla según sea necesario.
            this.data_unidadesTableAdapter.Fill(this.licitacionesDataSet.data_unidades);
            long numero = 0;
            if (Item.GetItemsPorProcedimiento(idSub).Any())
            {
                numero = Item.GetItemsPorProcedimiento(idSub).Last().Numero + 1;
                txt_numero.Text = numero.ToString();
            }
            else
            {
                numero = numero + 1;
                txt_numero.Text = numero.ToString();
            }
        }

        private void onlynumbers(object sender, KeyPressEventArgs e)
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
    }
}
