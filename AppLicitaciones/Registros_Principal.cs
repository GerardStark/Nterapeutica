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
        }
        public void llenartablaregistros()
        {
            try
            {
                DGVRegistros.Rows.Clear();
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("Select id_registro,numero_registro,numero_solicitud,tipo,titular,fabricante,marca,nacionalidad,tratado_comercio," +
                    "fecha_emision,fecha_vencimiento from registros_sanitarios", con);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DGVRegistros.Rows.Add(dr.ItemArray);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                DGVRegistros.Rows.Clear();
                SqlConnection con = new SqlConnection(mc.con);
                con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select id_registro,numero_registro,numero_solicitud,tipo,titular,fabricante,marca,nacionalidad,tratado_comercio," +
                    "fecha_emision,fecha_vencimiento from registros_sanitarios where "+ ctrl + " Like '%"+valor+"%'", con);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DGVRegistros.Rows.Add(dr.ItemArray);
                }
                con.Close();
                filtro_flag = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                if (filtro_flag == 0)
                {
                    llenartablaregistros();
                }
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
            }
        }

        private void DGVRegistros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.DGVRegistros.Columns[e.ColumnIndex].Name)
            {
                case "fabrColumn":
                    if (e.Value != null && e.Value != DBNull.Value && Convert.ToInt32(e.Value) > 0)
                    {
                        if (Convert.ToInt32(e.Value) > 0)
                        {
                            int idfab = Convert.ToInt32(DGVRegistros.Rows[e.RowIndex].Cells["fabrColumn"].Value);
                            e.Value = mc.obtenernombrefabricante(idfab);
                        }
                    }
                    else
                    {
                        e.Value = "(Vacio)";
                    }
                    break;
            }
        }
    }
    
    
}
