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
        int id_vinculo_reg = 0;        
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
            dgv_registros.Rows.Clear();
            dgv_vinculados.Rows.Clear();
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
                FROM registros_sanitarios as a LEFT OUTER JOIN cucop_vinculos_registros as b ON a.id_registro = b.id_registro AND b.id_cucop_vinculo = @vinc
                WHERE b.id IS NULL", con);
                cmdreg.Parameters.AddWithValue("@vinc", idVinc);
                SqlDataAdapter adapt = new SqlDataAdapter(cmdreg);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    dgv_registros.Rows.Add(dr.ItemArray);
                }                
            }
            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //agregar registros a la lista de registros vinculados a la descripcion
            if (id_registro != 0)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(mc.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO cucop_vinculos_registros (id_cucop_vinculo,id_registro,actualizado_en) OUTPUT INSERTED.id
                        VALUES(@idVinculo,@idRegistro,@updated)", con);
                        cmd.Parameters.AddWithValue("@idVinculo", id_vinculo);
                        cmd.Parameters.AddWithValue("@idRegistro", id_registro);
                        cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                        Int32 newId = (Int32)cmd.ExecuteScalar();
                        Cucop_Vincular_Registros_Referencias cvrr = new Cucop_Vincular_Registros_Referencias();
                        cvrr.mostrarReferenciasRegistro(id_registro, newId);
                        DialogResult result = cvrr.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            MessageBox.Show("Agregado");
                            mostrarVinculosRegistros(id_vinculo);
                        }
                        else
                        {
                            MessageBox.Show("Es recomendado que se agreguen las referencias al asignar el registro, pueden asignarse luego.");
                        }
                        
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
                MessageBox.Show("Selecciona un registro sanitario");
            }
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            //quitar registro de la lista de vinculados, regresarlo a la lista de registros
            if (id_vinculo_reg != 0)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(mc.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"DELETE FROM cucop_vinculos_registros_referencias Where id_vinculo_registro =  @idVinculoReg;
                        DELETE FROM cucop_vinculos_registros WHERE id = @idVinculoReg", con);
                        cmd.Parameters.AddWithValue("@idVinculoReg", id_vinculo_reg);                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Removido");
                        mostrarVinculosRegistros(id_vinculo);
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
            //si hay registro seleccionado, procede a visualizar
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dgv_registros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id_registro = Convert.ToInt32(dgv_registros.Rows[e.RowIndex].Cells["idColumn"].Value);
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
                id_vinculo_reg = (Int32)dgv_vinculados.Rows[e.RowIndex].Cells["idvincregColumn"].Value;
                id_registro = (Int32)dgv_vinculados.Rows[e.RowIndex].Cells["numvincregColumn"].Value;
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Registros_Buscar rn = new Registros_Buscar();
            DialogResult result = rn.ShowDialog();
            if (result == DialogResult.OK)
            {
                string ctrl = rn.ctrl;
                string valor = rn.valor;
                filtrartablaregistros(ctrl, valor);
            }
            else
            {
                mostrarVinculosRegistros(id_vinculo);
            }
        }
        public void filtrartablaregistros(string ctrl, string valor)
        {
            try
            {
                if (ctrl == "referencia")
                {
                    dgv_registros.Rows.Clear();
                    SqlConnection con = new SqlConnection(mc.con);
                    con = new SqlConnection(mc.con);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select id_registro, numero_registro, titular, denom_distintiva, denom_generica, fabricante, pais_origen from registros_sanitarios where id_registro in " +
                        "(SELECT Id_registro_sanitario FROM registros_claves_referencias WHERE clave_ref_cod Like '%" + valor + "%')", con);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            dgv_registros.Rows.Add(dr.ItemArray);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay concidiencias");
                        mostrarVinculosRegistros(id_vinculo);
                    }
                    con.Close();
                }
                else
                {
                    dgv_registros.Rows.Clear();
                    SqlConnection con = new SqlConnection(mc.con);
                    con = new SqlConnection(mc.con);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select id_registro, numero_registro, titular, denom_distintiva, denom_generica, fabricante, pais_origen " +
                        "from registros_sanitarios where " + ctrl + " Like '%" + valor + "%'", con);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            dgv_registros.Rows.Add(dr.ItemArray);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay concidiencias");
                        mostrarVinculosRegistros(id_vinculo);
                    }
                    con.Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Cucop_Vincular_Registros_Referencias cvrr = new Cucop_Vincular_Registros_Referencias();
            cvrr.mostrarReferenciasRegistro(id_registro,id_vinculo_reg);
            DialogResult result = cvrr.ShowDialog();
            if (result == DialogResult.OK)
            {
                //something
            }

        }

        private void btn_registros_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Registros_Principal))
                {
                    form.Activate();
                    return;
                }
            }

            Registros_Principal newForm = new Registros_Principal();
            newForm.Show();
        }
    }
}
