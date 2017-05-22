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
        }
        public void llenartablaftd()
        {
            try
            {
                DGV_FTD.Rows.Clear();
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("Select id_ftd,nombre,tipo_apoyo,distribuidor_mayorista from fabricantes_titulares_distribuidores", con);
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
            id_fabricante = Convert.ToInt32(DGV_FTD.Rows[e.RowIndex].Cells["idColumn"].Value);
            nombre_fabricante = DGV_FTD.Rows[e.RowIndex].Cells["nombreColumn"].Value.ToString();

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
                SqlCommand cmd = new SqlCommand("insert into fabricantes_titulares_distribuidores (nombre,tipo_apoyo,distribuidor_mayorista) values(@nombre,@apoyo,@mayorista)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@numero", txt_nombre.Text);
                cmd.Parameters.AddWithValue("@apoyo", txt_apoyo.Text);
                cmd.Parameters.AddWithValue("@mayorista", txt_mayorista.Text);
                cmd.Parameters.AddWithValue("@actualizado", DateTime.Now);
                Int32 newId = (Int32)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_contactos_Click(object sender, EventArgs e)
        {
            FTD_Contactos fc = new FTD_Contactos();
            //fc.llenarcontactosfabricante(id_fabricante);
            DialogResult result = fc.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }
    }
}
