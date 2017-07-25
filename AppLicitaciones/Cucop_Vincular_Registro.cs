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
    public partial class Cucop_Vincular_Registro : Form
    {
        int id_cucop = 0;
        int id_vinculo = 0;
        int id_registro = 0;
        int regrowindex = 0;
        string numeroregistro = "";
        List<Int32> registrosID = new List<int>();
        MainConfig mc = new MainConfig();
        public Cucop_Vincular_Registro()
        {
            InitializeComponent();
            this.dgv_registros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv_registros.MultiSelect = false;
            this.dgv_vinculados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vinculados.MultiSelect = false;
        }

        public void mostrarVinculosRegistros(int id_cucop)
        {
            this.id_cucop = id_cucop;
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                SqlCommand cmdreg = new SqlCommand("SELECT id_registro,numero_registro,titular,denom_distintiva,denom_generica,fabricante,pais_origen FROM registros_sanitarios as a LEFT OUTER JOIN aux_vinculos as b"+
                    " ON a.id_registro = b.id_registro_sanitario AND b.id_cucop_item = @idcucop WHERE b.id_vinculacion IS null", con);
                cmdreg.Parameters.AddWithValue("@idcucop",id_cucop);
                SqlDataAdapter adapt = new SqlDataAdapter(cmdreg);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    dgv_registros.Rows.Add(dr.ItemArray);
                }
                SqlCommand cmdvinc = new SqlCommand("SELECT id_vinculacion,id_registro_sanitario FROM aux_vinculos WHERE id_cucop_item = @idcucop", con);
                cmdvinc.Parameters.AddWithValue("@idcucop",id_cucop);
                SqlDataAdapter adaptvinc = new SqlDataAdapter(cmdvinc);
                DataTable dtvinc = new DataTable();
                adaptvinc.Fill(dtvinc);
                foreach (DataRow drv in dtvinc.Rows)
                {
                    dgv_vinculados.Rows.Add(drv.ItemArray);
                }
            }
            lbl_cucop.Text = id_cucop.ToString();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //agregar registros a la lista de registros vinculados a la descripcion
            if (id_registro != 0 && numeroregistro != "")
            {
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    con.Open();
                    //SqlCommand cmd = new SqlCommand("INSERT into aux_vinculos value",con);
                }

            }
            else
            {
                MessageBox.Show("Selecciona un registro sanitario");
            }
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            //quitar registro de la lista de vinculados, regresarlo a la lista de registros
            if (id_vinculo != 0)
            {

            }
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            //informacion del registro sanitario y sus referencias
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //guarda todos los cambias
        }

        private void btn_descartar_Click(object sender, EventArgs e)
        {
            //cierra sin guardar los cambios
        }

        private void dgv_registros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id_registro = Convert.ToInt32(dgv_registros.Rows[e.RowIndex].Cells["idColumn"].Value);
                regrowindex = e.RowIndex;
                numeroregistro = dgv_registros.Rows[e.RowIndex].Cells["numeroColumn"].Value.ToString();
            }
        }

        private void dgv_registros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (dgv_vinculados.Rows[e.RowIndex].Cells["numvincregColumn"].Value != DBNull.Value)
            //{
            //    //formatear texto para que en lugar del id se vea el numero de registro sanitario.
            //}
        }

        private void dgv_vinculados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id_vinculo = Convert.ToInt32(dgv_registros.Rows[e.RowIndex].Cells["idColumn"].Value);
                regrowindex = e.RowIndex;
                numeroregistro = dgv_registros.Rows[e.RowIndex].Cells["numeroColumn"].Value.ToString();
            }
        }
    }
}
