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
    public partial class Cucop_Principal : Form
    {
        MainConfig mc = new MainConfig();
        int id_cucop = 0, filtro_flag = 0;
        public Cucop_Principal()
        {
            InitializeComponent();
            llenartablacucops();
            this.DGV_cucop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DGV_cucop.MultiSelect = false;

        }
        public void llenartablacucops()
        {
            try
            {
                DGV_cucop.Rows.Clear();
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_cucop,clave,descripcion,especialidad,presentacion_tipo,presentacion_cant,presentacion_cont,actualizado_en from cucop", con);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_cucop.Rows.Add(dr.ItemArray);
                }
                con.Close();
                mc.buscarultimafilaeditada("cucop",DGV_cucop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Cucop_Nuevo rn = new Cucop_Nuevo();
            DialogResult result = rn.ShowDialog();
            if (result == DialogResult.OK)
            {
                llenartablacucops();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Cucop_Buscar cb = new Cucop_Buscar();
            DialogResult result = cb.ShowDialog();
            if (result == DialogResult.OK)
            {
                string ctrl = cb.ctrl;
                string valor = cb.valor;
                filtrarcucops(ctrl, valor);
            }
        }
        private void filtrarcucops(string ctrl, string valor)
        {
            try
            {
                DGV_cucop.Rows.Clear();
                SqlConnection con = new SqlConnection(mc.con);
                con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_cucop,clave,descripcion,especialidad,presentacion_tipo,presentacion_cant,presentacion_cont from cucop "+
                    "Where " + ctrl + " Like '%" + valor + "%'", con);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        DGV_cucop.Rows.Add(dr.ItemArray);
                    }
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
            if (id_cucop != 0)
            {
                //abre el panel de visualizacion del cucop
                Cucop_Visualizar rn = new Cucop_Visualizar();
                rn.mostrarinfocucop(id_cucop);
                DialogResult result = rn.ShowDialog();                
            }
            else
            {
                MessageBox.Show("Seleccione un Codigo de Cuadro Basico para visualizar");
            }
        }

        private void DGV_cucop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id_cucop = Convert.ToInt32(DGV_cucop.Rows[e.RowIndex].Cells["idColumn"].Value);
            }
        }
    }
}
