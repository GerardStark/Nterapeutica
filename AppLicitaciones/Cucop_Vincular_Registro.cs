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
        int id_vinculo = 0;
        int id_registro = 0;
        int regrowindex = 0, numeroregistro = 0;
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

        public void mostrarVinculosRegistros(int idVinc)
        {
            this.id_vinculo = idVinc;
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                SqlCommand cmdvinc = new SqlCommand(@"select id, id_registro from cucop_vinculos_registros 
                WHERE id_cucop_vinculo = @vinc", con);
                cmdvinc.Parameters.AddWithValue("@vinc", idVinc);
                SqlDataAdapter adaptvinc = new SqlDataAdapter(cmdvinc);
                DataTable dtvinc = new DataTable();
                adaptvinc.Fill(dtvinc);
                foreach (DataRow drt in dtvinc.Rows)
                {
                    dgv_vinculados.Rows.Add(drt.ItemArray);
                }
                SqlCommand cmdreg = new SqlCommand(@"SELECT a.id_registro, a.numero_registro, a.titular, a.denom_distintiva, a.denom_generica, a.fabricante, a.pais_origen 
                FROM registros_sanitarios as a LEFT OUTER JOIN cucop_vinculos_registros as b ON a.id_registro = b.id_registro
                WHERE b.id IS NULL", con);                
                SqlDataAdapter adapt = new SqlDataAdapter(cmdreg);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    dgv_registros.Rows.Add(dr.ItemArray);
                }                
            }
            lbl_cucop.Text = id_vinculo.ToString();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //agregar registros a la lista de registros vinculados a la descripcion
            if (id_registro != 0 && numeroregistro != 0)
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
                numeroregistro = (Int32)dgv_registros.Rows[e.RowIndex].Cells["numeroColumn"].Value;
            }
        }

        private void dgv_registros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_registros.Columns[e.ColumnIndex].Name == "paisColumn")
            {
                if (e.Value != null)
                {

                    e.Value = mc.obtenernombrepais((Int32)e.Value);

                }
            }
        }

        private void dgv_vinculados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id_vinculo = (Int32)dgv_vinculados.Rows[e.RowIndex].Cells["idvincregColumn"].Value;
                regrowindex = e.RowIndex;
                numeroregistro = (Int32)dgv_vinculados.Rows[e.RowIndex].Cells["numvincregColumn"].Value;
            }
        }

        private void dgv_vinculados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_vinculados.Columns[e.ColumnIndex].Name == "numvincregColumn")
            {
                if (e.Value != null)
                {
                    
                    e.Value = mc.obtenernumeroregistro((Int32)e.Value);

                }
            }
        }
    }
}
