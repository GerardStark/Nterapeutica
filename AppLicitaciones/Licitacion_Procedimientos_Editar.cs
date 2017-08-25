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
    public partial class Licitacion_Procedimientos_Editar : Form
    {
        MainConfig mc = new MainConfig();
        int idSub;
        public Licitacion_Procedimientos_Editar()
        {
            InitializeComponent();
        }

        public void pasarInfoProcedimiento(int idSub)
        {
            this.idSub = idSub;
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = @"SELECT * FROM licitacion_subpar_proce WHERE id = @idSub";
                    cmd.Parameters.AddWithValue("@idSub",idSub);
                    using (SqlDataAdapter adapt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapt.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            txt_numero.Text = dt.Rows[0]["numero_subpartida"].ToString();
                            txt_nombre.Text = dt.Rows[0]["nombre_subpartida"].ToString();
                        }
                    }
                }
            }
        }

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = @"update_licitacion_procedimiento";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idSub", idSub);
                    cmd.Parameters.AddWithValue("@numero", txt_numero.Text);
                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                    Int32 newId = cmd.ExecuteNonQuery();
                    if (newId != 0)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }
    }
}
