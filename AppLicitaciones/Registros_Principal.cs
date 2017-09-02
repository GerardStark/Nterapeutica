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
    public partial class Registros_Principal : Form
    {
        MainConfig mc = new MainConfig();
        int id_registro = 0, filtro_flag = 0;
        public Registros_Principal()
        {
            InitializeComponent();
            llenartablaregistros();
            this.DGVRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DGVRegistros.MultiSelect = false;
            //DGVRegistros.DefaultCellStyle.SelectionBackColor = DGVRegistros.DefaultCellStyle.BackColor;
            //DGVRegistros.DefaultCellStyle.SelectionForeColor = DGVRegistros.DefaultCellStyle.ForeColor;
        }
        public void llenartablaregistros()
        {
            try
            {
                DGVRegistros.Rows.Clear();
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("Select id_registro,numero_registro,numero_solicitud,rfc,tipo,titular,fabricante,marca,pais_origen," +
                    "fecha_emision,fecha_vencimiento,actualizado_en from registros_sanitarios", con);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                lbl_conteo.Text = dt.Rows.Count.ToString();
                foreach (DataRow dr in dt.Rows)
                {
                    DGVRegistros.Rows.Add(dr.ItemArray);
                }
                mc.buscarultimafilaeditada("registros_sanitarios", DGVRegistros);
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void btn_reg_nuevo_Click(object sender, EventArgs e)
        {
            Registros_Nuevo rn = new Registros_Nuevo();
            DialogResult result = rn.ShowDialog();
            if (result == DialogResult.OK)
            {
                llenartablaregistros();
            }
        }       
        private void btn_reg_buscar_Click(object sender, EventArgs e)
        {
            id_registro = 0;
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
                llenartablaregistros();
            }
        }
        
        public void filtrartablaregistros(string ctrl, string valor)
        {
            try
            {
                if (ctrl == "referencia")
                {
                    DGVRegistros.Rows.Clear();
                    SqlConnection con = new SqlConnection(mc.con);
                    con = new SqlConnection(mc.con);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select id_registro,numero_registro,numero_solicitud,rfc,tipo,titular,fabricante,marca,pais_origen," +
                    "fecha_emision,fecha_vencimiento,actualizado_en from registros_sanitarios where id_registro in " +
                        "(SELECT Id_registro_sanitario FROM registros_claves_referencias WHERE clave_ref_cod Like '%" + valor + "%')", con);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count >0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            DGVRegistros.Rows.Add(dr.ItemArray);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay coincidencias");
                        llenartablaregistros();
                    }
                    con.Close();
                }
                else
                {
                    DGVRegistros.Rows.Clear();
                    SqlConnection con = new SqlConnection(mc.con);
                    con = new SqlConnection(mc.con);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select id_registro, numero_registro, numero_solicitud, rfc, tipo, titular, fabricante, marca, pais_origen, " +
                    "fecha_emision,fecha_vencimiento,actualizado_en from registros_sanitarios where " + ctrl + " Like '%" + valor + "%'", con);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            DGVRegistros.Rows.Add(dr.ItemArray);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay coincidencias");
                        llenartablaregistros();
                    }   
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
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

        private void btn_reg_prorrogas_Click(object sender, EventArgs e)
        {
            if (id_registro > 0)
            {
                Registros_Prorrogas rp = new Registros_Prorrogas();
                rp.mostrarprorrogasregistro(id_registro);
                DialogResult result = rp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona un Registro Sanitario");
            }
        }

        private void btn_reg_claves_Click(object sender, EventArgs e)
        {
            if (id_registro != 0)
            {
                Registros_ClavesReferencias rc = new Registros_ClavesReferencias();
                rc.mostrarclavesregistro(id_registro);
                DialogResult result = rc.ShowDialog();

            }
            else
            {
                MessageBox.Show("Selecciona un Registro Sanitario");
            }
        }

        private void DGVRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id_registro = Convert.ToInt32(DGVRegistros.Rows[e.RowIndex].Cells["idColumn"].Value);
                //DGVRegistros.DefaultCellStyle.SelectionBackColor = DGVRegistros.DefaultCellStyle.ForeColor;
                //DGVRegistros.DefaultCellStyle.SelectionForeColor = DGVRegistros.DefaultCellStyle.BackColor;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aun eres muy joven para usar esta técnica");
        }

        private void DGVRegistros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.DGVRegistros.Columns[e.ColumnIndex].Name)
            {
                case "paisColumn":
                    if (e.Value != null && e.Value != DBNull.Value && Convert.ToInt32(e.Value) > 0)
                    {
                        if (Convert.ToInt32(e.Value) > 0)
                        {
                            int idpais = Convert.ToInt32(DGVRegistros.Rows[e.RowIndex].Cells["paisColumn"].Value);
                            e.Value = mc.obtenernombrepais(idpais);
                        }
                    }
                    else
                    {
                        e.Value = "(Vacio)";
                    }
                    break;
                case "idColumn":
                    e.Value = e.RowIndex + 1;
                    break;
            }
        }
    }
    
    
}
