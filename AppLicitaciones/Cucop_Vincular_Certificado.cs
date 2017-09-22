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
    public partial class Cucop_Vincular_Certificado : Form
    {
        int id_vinculo = 0;
        int id_certificado = 0;
        int id_vinculo_cert = 0;
        MainConfig mc = new MainConfig();
        public Cucop_Vincular_Certificado()
        {
            InitializeComponent();
            this.dgv_certificados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv_certificados.MultiSelect = false;
            this.dgv_vinculados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vinculados.MultiSelect = false;
        }

        public void mostrarVinculosCertificados(int idVinc)
        {
            this.id_vinculo = idVinc;
            dgv_certificados.Rows.Clear();
            dgv_vinculados.Rows.Clear();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                SqlCommand cmdvinc = new SqlCommand(@"select id, id_certificados from cucop_vinculos_certificados 
                WHERE id_cucop_vinculo = @vinc", con);
                cmdvinc.Parameters.AddWithValue("@vinc", idVinc);
                SqlDataAdapter adaptvinc = new SqlDataAdapter(cmdvinc);
                DataTable dtvinc = new DataTable();
                adaptvinc.Fill(dtvinc);
                foreach (DataRow drt in dtvinc.Rows)
                {
                    dgv_vinculados.Rows.Add(drt.ItemArray);
                }
                SqlCommand cmdreg = new SqlCommand(@"SELECT a.id_certificado, a.numero_identificador, a.tipo, a.fabricante, a.idioma 
                FROM certificados_calidad as a LEFT OUTER JOIN cucop_vinculos_certificados as b ON a.id_certificado = b.id_certificados AND b.id_cucop_vinculo = @vinc
                WHERE b.id IS NULL", con);
                cmdreg.Parameters.AddWithValue("@vinc", idVinc);
                SqlDataAdapter adapt = new SqlDataAdapter(cmdreg);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    dgv_certificados.Rows.Add(dr.ItemArray);
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (id_certificado != 0)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(mc.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO cucop_vinculos_certificados (id_cucop_vinculo,id_certificados,actualizado_en) 
                        VALUES(@idVinculo,@idCertificado,@updated)", con);
                        cmd.Parameters.AddWithValue("@idVinculo", id_vinculo);
                        cmd.Parameters.AddWithValue("@idCertificado", id_certificado);
                        cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Agregado");
                        mostrarVinculosCertificados(id_vinculo);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }

            }
            else
            {
                MessageBox.Show("Selecciona un Certificado");
            }
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (id_vinculo_cert != 0)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(mc.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"DELETE FROM cucop_vinculos_certificados WHERE id = @idVinculoCert", con);
                        cmd.Parameters.AddWithValue("@idVinculoCert", id_vinculo_cert);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Removido");
                        mostrarVinculosCertificados(id_vinculo);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Selecciona un Vinculo");
            }
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            if (id_certificado != 0)
            {
                Certificados_Visualizar cv = new Certificados_Visualizar();
                cv.mostrarinfocertificado(id_certificado);
                DialogResult result = cv.ShowDialog();                
            }
            else
            {
                MessageBox.Show("Selecciona un certificado");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dgv_certificados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id_certificado = Convert.ToInt32(dgv_certificados.Rows[e.RowIndex].Cells["idColumn"].Value);
            }
        }

        private void dgv_vinculados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id_vinculo_cert = (Int32)dgv_vinculados.Rows[e.RowIndex].Cells["idvinccertColumn"].Value;
                id_certificado = (Int32)dgv_vinculados.Rows[e.RowIndex].Cells["numvinccertColumn"].Value;
            }
        }

        private void dgv_vinculados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_vinculados.Columns[e.ColumnIndex].Name == "numvinccertColumn")
            {
                if (e.Value != null)
                {

                    e.Value = mc.obtenernumerocertificado((Int32)e.Value);

                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Certificados_Buscar rn = new Certificados_Buscar();
            DialogResult result = rn.ShowDialog();
            if (result == DialogResult.OK)
            {
                string ctrl = rn.ctrl;
                string valor = rn.valor;
                filtrartablacertificados(ctrl, valor);
            }            
        }

        public void filtrartablacertificados(string ctrl, string valor)
        {
            try
            {
                dgv_certificados.Rows.Clear();
                SqlConnection con = new SqlConnection(mc.con);
                con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select id_certificado, numero_identificador, tipo, fabricante, idioma " +
                   "From certificados_calidad Where " + ctrl + " Like '%" + valor + "%'", con);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgv_certificados.Rows.Add(dr.ItemArray);
                    }
                }
                else
                {
                    MessageBox.Show("No hay concidiencias");
                    mostrarVinculosCertificados(id_vinculo);
                }
                con.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_certificados_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Certificados_Principal))
                {
                    form.Activate();
                    return;
                }
            }

            Certificados_Principal newForm = new Certificados_Principal();
            
            newForm.Show();
        }

        private void Cucop_Vincular_Certificado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
