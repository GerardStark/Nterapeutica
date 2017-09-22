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
    public partial class Cucop_Vincular_Catalogo : Form
    {
        int id_vinculo = 0;
        int id_catalogo = 0;
        int id_vinculo_cat = 0;
        MainConfig mc = new MainConfig();
        public Cucop_Vincular_Catalogo()
        {
            InitializeComponent();
            this.dgv_catalogos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv_catalogos.MultiSelect = false;
            this.dgv_vinculados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vinculados.MultiSelect = false;
        }

        public void mostrarVinculosCatalogos(int idVinc)
        {
            this.id_vinculo = idVinc;
            dgv_catalogos.Rows.Clear();
            dgv_vinculados.Rows.Clear();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                SqlCommand cmdvinc = new SqlCommand(@"select id, id_catalogo from cucop_vinculos_catalogos
                WHERE id_cucop_vinculo = @vinc", con);
                cmdvinc.Parameters.AddWithValue("@vinc", idVinc);
                SqlDataAdapter adaptvinc = new SqlDataAdapter(cmdvinc);
                DataTable dtvinc = new DataTable();
                adaptvinc.Fill(dtvinc);
                foreach (DataRow drt in dtvinc.Rows)
                {
                    dgv_vinculados.Rows.Add(drt.ItemArray);
                }
                SqlCommand cmdcat = new SqlCommand(@"SELECT a.id_catalogo, a.nombre_catalogo, a.tipo_catalogo, a.spec_catalogo, a.fabricante, a.marca, a.idioma 
                FROM catalogos_info_general as a LEFT OUTER JOIN cucop_vinculos_catalogos as b ON a.id_catalogo = b.id_catalogo AND b.id_cucop_vinculo = @vinc
                WHERE b.id IS NULL", con);
                cmdcat.Parameters.AddWithValue("@vinc", idVinc);
                SqlDataAdapter adapt = new SqlDataAdapter(cmdcat);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    dgv_catalogos.Rows.Add(dr.ItemArray);
                }
            }
           
        }       

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (id_catalogo != 0)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(mc.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO cucop_vinculos_catalogos (id_cucop_vinculo,id_catalogo,actualizado_en) OUTPUT INSERTED.id
                        VALUES(@idVinculo,@idCatalogo,@updated)", con);
                        cmd.Parameters.AddWithValue("@idVinculo", id_vinculo);
                        cmd.Parameters.AddWithValue("@idCatalogo", id_catalogo);
                        cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                        Int32 newId = (Int32)cmd.ExecuteScalar();
                        Cucop_Vincular_Catalogos_Referencias cvrc = new Cucop_Vincular_Catalogos_Referencias();
                        cvrc.mostrarReferenciasCatalogos(id_catalogo, newId);
                        DialogResult result = cvrc.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            MessageBox.Show("Agregado");
                            mostrarVinculosCatalogos(id_vinculo);
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
                MessageBox.Show("Selecciona un Catalogo");
            }
        }


        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (id_vinculo_cat != 0)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(mc.con))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"DELETE FROM cucop_vinculos_catalogos_referencias Where id_vinculo_catalogo = @idVinculoCat
                        DELETE FROM cucop_vinculos_catalogos WHERE id = @idVinculoCat", con);
                        cmd.Parameters.AddWithValue("@idVinculoCat", id_vinculo_cat);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Removido");
                        mostrarVinculosCatalogos(id_vinculo);
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
            if (id_catalogo != 0)
            {
                //abre el panel de visualizacion del registro
                Catalogos_Visualizar rn = new Catalogos_Visualizar();
                rn.mostrarinfocatalogo(id_catalogo);
                DialogResult result = rn.ShowDialog();                
            }
            else
            {
                MessageBox.Show("Seleccione un Catálogo de la lista para poder visualizarlo.");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dgv_catalogos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id_catalogo = Convert.ToInt32(dgv_catalogos.Rows[e.RowIndex].Cells["idColumn"].Value);
            }
        }

        private void dgv_vinculados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id_vinculo_cat = (Int32)dgv_vinculados.Rows[e.RowIndex].Cells["idvinccatColumn"].Value;
                id_catalogo = (Int32)dgv_vinculados.Rows[e.RowIndex].Cells["numvinccatColumn"].Value;
            }
        }

        private void dgv_vinculados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_vinculados.Columns[e.ColumnIndex].Name == "numvinccatColumn")
            {
                if (e.Value != null)
                {

                    e.Value = mc.obtenernombrecatalogo((Int32)e.Value);

                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
            Catalogos_Buscar rn = new Catalogos_Buscar();
            DialogResult result = rn.ShowDialog();
            if (result == DialogResult.OK)
            {
                string ctrl = rn.ctrl;
                string valor = rn.valor;
                filtrartablacatalogos(ctrl, valor);
            }            
        }

        private void filtrartablacatalogos(string ctrl, string valor)
        {
            try
            {
                if (ctrl == "referencia")
                {
                    dgv_catalogos.Rows.Clear();
                    SqlConnection con = new SqlConnection(mc.con);
                    con = new SqlConnection(mc.con);
                    con.Open();
                    //cambiar por tabla catalogos
                    SqlCommand cmd = new SqlCommand("Select  id_catalogo, nombre_catalogo, tipo_catalogo, spec_catalogo, fabricante, marca, idioma  " +
                        "from catalogos_info_general where id_catalogo in" +
                        "(SELECT Id_catalogo_productos FROM catalogos_claves_referencias WHERE clave_ref_cod Like '%" + valor + "%')", con);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            dgv_catalogos.Rows.Add(dr.ItemArray);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay concidiencias");
                        mostrarVinculosCatalogos(id_vinculo);
                    }
                    con.Close();
                    
                }
                else
                {
                    dgv_catalogos.Rows.Clear();
                    SqlConnection con = new SqlConnection(mc.con);
                    con = new SqlConnection(mc.con);
                    con.Open();
                    //cambiar por tabla catalogos
                    SqlCommand cmd = new SqlCommand("Select  id_catalogo, nombre_catalogo, tipo_catalogo, spec_catalogo, fabricante, marca, idioma " +
                        "from catalogos_info_general where " + ctrl + " Like '%" + valor + "%'", con);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            dgv_catalogos.Rows.Add(dr.ItemArray);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay concidiencias");
                        mostrarVinculosCatalogos(id_vinculo);
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
            Cucop_Vincular_Catalogos_Referencias cvcr = new Cucop_Vincular_Catalogos_Referencias();
            cvcr.mostrarReferenciasCatalogos(id_catalogo, id_vinculo_cat);
            DialogResult result = cvcr.ShowDialog();
            if (result == DialogResult.OK)
            {
                //something
            }
        }

        private void btn_catalogos_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Catalogos_Principal))
                {
                    form.Activate();
                    return;
                }
            }

            Catalogos_Principal newForm = new Catalogos_Principal();           
            newForm.Show();
        }

        private void Cucop_Vincular_Catalogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
