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
    public partial class Cucop_Vincular_General : Form
    {
        MainConfig mc = new MainConfig();
        int id_cucop = 0, id_registro = 0;
        public Cucop_Vincular_General()
        {
            InitializeComponent();
            txt_nombre_prod.Text = "";
        }
        public void mostrarvinculoscucop(int id_cucop)
        {
            this.id_cucop = id_cucop;
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from cucop where id_cucop = @id", con);
                cmd.Parameters.AddWithValue("@id", id_cucop);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void vervinculosregistros(int id_cucop)
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select id_registro, numero_registro from registros_sanitarios", con);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = row["numero_registro"].ToString();
                    item.Tag = Convert.ToInt32(row["id_registro"]);
                    list_vinc_reg.Items.Add(item);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void list_vinc_reg_MouseClick(object sender, MouseEventArgs e)
        {
            var firstSelectedItem = list_vinc_reg.SelectedItems[0];
            id_registro = Convert.ToInt32(firstSelectedItem.Tag);
        }

        private void btn_reg_vincular_Click(object sender, EventArgs e)
        {
            Cucop_Vincular_Registro cvr = new Cucop_Vincular_Registro();
            DialogResult result = cvr.ShowDialog();
            if (result == DialogResult.OK)
            {
                vervinculosregistros(id_cucop);
            }
            else
            {
                MessageBox.Show("No se hizo cambio alguno");
            }
        }

        private void btn_ver_reg_Click(object sender, EventArgs e)
        {
            if (id_registro != 0)
            {
                //abre el panel de visualizacion del registro
                Registros_Visualizar rn = new Registros_Visualizar();
                rn.mostrarinforegistro(id_registro);
                DialogResult result = rn.ShowDialog();              
            }
            else
            {
                MessageBox.Show("Seleccione un Registro Sanitario de la lista para poder visualizarlo.");
            }
        }

    }
}
