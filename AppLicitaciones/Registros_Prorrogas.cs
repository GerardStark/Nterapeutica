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

namespace AppLicitaciones
{
    public partial class Registros_Prorrogas : Form
    {
        MainConfig mc = new MainConfig();
        int id_registro, id_prorroga;
        public Registros_Prorrogas()
        {
            InitializeComponent();
        }
        public void mostrarprorrogasregistro(int id_registro)
        {
            this.id_registro = id_registro;
            try
            {
                DGV_Referencias.Rows.Clear();
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("Select id_tramite_prorroga, numero_tramite, fecha_emision, dir_archivo " +
                    "from registros_tramites_prorroga where id_registro_sanitario = @id", con);
                cmd.Parameters.AddWithValue("@id", id_registro);
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
    }
}
