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
    public partial class FTD_Principal : Form
    {
        MainConfig mc = new MainConfig();
        public int id_fabricante = 0;
        public string nombre_fabricante = "";
        public FTD_Principal()
        {
            InitializeComponent();
            this.DGV_FTD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DGV_FTD.MultiSelect = false;
        }
        public void llenartablaftd()
        {
            try
            {
                DGV_FTD.Rows.Clear();
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("Select id_ftd,nombre,tipo_apoyo,distribuidor_mayorista,rfc from fabricantes_titulares_distribuidores", con);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_FTD.Rows.Add(dr.ItemArray);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DGV_FTD_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (id_fabricante != 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona un Fabricante");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("insert into fabricantes_titulares_distribuidores (nombre,tipo_apoyo,distribuidor_mayorista,rfc,actualizado_en)"+
                    " values(@nombre,@apoyo,@mayorista,@rfc, @actualizado)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                cmd.Parameters.AddWithValue("@apoyo", txt_apoyo.Text);
                cmd.Parameters.AddWithValue("@mayorista", txt_mayorista.Text);
                cmd.Parameters.AddWithValue("@rfc",txt_rfc.Text);
                cmd.Parameters.AddWithValue("@actualizado", DateTime.Now);
                cmd.ExecuteNonQuery();
                con.Close();
                llenartablaftd();
                limpiarcampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (id_fabricante != 0)
            {
                try
                {
                    SqlConnection con = new SqlConnection(mc.con);
                    SqlCommand cmd = new SqlCommand("update fabricantes_titulares_distribuidores set nombre = @nombre,tipo_apoyo = @apoyo,distribuidor_mayorista= @mayorista," +
                        " rfc = @rfc, actualizado_en = @actualizado where id_ftd = @id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id_fabricante);
                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@apoyo", txt_apoyo.Text);
                    cmd.Parameters.AddWithValue("@mayorista", txt_mayorista.Text);
                    cmd.Parameters.AddWithValue("@rfc", txt_rfc.Text);
                    cmd.Parameters.AddWithValue("@actualizado", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    llenartablaftd();
                    limpiarcampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un fabricante a editar");
            }
        }

        private void btn_contactos_Click(object sender, EventArgs e)
        {
            FTD_Contactos fc = new FTD_Contactos();
            fc.llenarcontactosfabricante(id_fabricante);
            DialogResult result = fc.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }

        private void DGV_FTD_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
        private void limpiarcampos()
        {
            btn_guardar.Enabled = true;
            txt_nombre.Text = "";
            txt_apoyo.Text = "";
            txt_mayorista.Text = "";
            txt_rfc.Text = "";
            id_fabricante = 0;
            nombre_fabricante = "";
        }

        private void DGV_FTD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_fabricante = Convert.ToInt32(DGV_FTD.Rows[e.RowIndex].Cells["idColumn"].Value);
            nombre_fabricante = DGV_FTD.Rows[e.RowIndex].Cells["nombreColumn"].Value.ToString();
            txt_nombre.Text = DGV_FTD.Rows[e.RowIndex].Cells["nombreColumn"].Value.ToString();
            txt_apoyo.Text = DGV_FTD.Rows[e.RowIndex].Cells["apoyoColumn"].Value.ToString();
            txt_mayorista.Text = DGV_FTD.Rows[e.RowIndex].Cells["mayoristaColumn"].Value.ToString();
            txt_rfc.Text = DGV_FTD.Rows[e.RowIndex].Cells["rfcColumn"].Value.ToString();
            btn_guardar.Enabled = false;
        }

        private void DGV_FTD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiarcampos();
        }
    }
}
