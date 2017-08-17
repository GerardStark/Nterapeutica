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
    public partial class Licitacion_Visualizar : Form
    {
        int idLicit;
        MainConfig mc = new MainConfig();
        public Licitacion_Visualizar()
        {
            InitializeComponent();
        }

        public void mostrarInfoBases(int idLicitacion)
        {
            this.idLicit = idLicitacion;
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM licitacion_bases WHERE id_bases = @idBases",con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        lbl_numero.Text = dt.Rows[0][""].ToString();
                    }
                }
            }
        }
    }
}
