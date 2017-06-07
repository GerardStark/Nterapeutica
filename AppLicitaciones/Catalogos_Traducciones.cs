using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLicitacion;
using System.Data.SqlClient;
using System.IO;

namespace AppLicitaciones
{
    public partial class Catalogos_Traducciones : Form
    {
        MainConfig mc = new MainConfig();
        int id_catalogo = 0;
        public Catalogos_Traducciones()
        {
            InitializeComponent();
        }
        public void mostrartraduccionescatalogo(int id_catalogo)
        {
            try { 
                this.id_catalogo = id_catalogo;
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("SELECT id_traduccion_cat,descripcion_corta FROM catalogos_traducciones "+
                    "WHERE id_catalogo_productos = @id",con);
                cmd.Parameters.AddWithValue("@id",id_catalogo); cmd.Parameters.AddWithValue("@id", id_catalogo);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_Traducciones.Rows.Add(dr.ItemArray);
                }
                con.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


}

        private void btn_traduccion_referencias_Click(object sender, EventArgs e)
        {
            Catalogos_traduccion_referencias ctr = new Catalogos_traduccion_referencias();
            ctr.mostrarreferenciascatalogo(id_catalogo);
            DialogResult result = ctr.ShowDialog();
            if (result == DialogResult.OK)
            {
                //TODO something
            }
            else
            {
                MessageBox.Show("No se hizo cambio alguno");
            }
        }
    }
}
