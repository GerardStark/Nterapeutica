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
    public partial class Catalogos_Principal : Form
    {
        MainConfig mc = new MainConfig();
        int id_catalogo = 0, filtro_flag = 0;
        public Catalogos_Principal()
        {
            InitializeComponent();
            llenartablacatalogos();
        }

        public void llenartablacatalogos()
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select id_catalogo,nombre_catalogo,tipo,año_plublicacion,especialidad,fabricante,idioma from catalogos_productos", con);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_Catalogos.Rows.Add(dr.ItemArray);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Catalogos_Nuevo cn = new Catalogos_Nuevo();
            DialogResult result = cn.ShowDialog();
            if (result == DialogResult.OK)
            {
                llenartablacatalogos();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            id_catalogo = 0;
            Catalogos_Buscar rn = new Catalogos_Buscar();
            DialogResult result = rn.ShowDialog();
            if (result == DialogResult.OK)
            {
                //string ctrl = rn.ctrl;
                //string valor = rn.valor;
                filtrartablacatalogos("", "");
            }
            else
            {
                llenartablacatalogos();
            }
        }

        private void DGV_Catalogos_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            id_catalogo = Convert.ToInt32(DGV_Catalogos.Rows[e.RowIndex].Cells["idColumn"].Value);
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            //si hay registro seleccionado, procede a visualizar
            if (id_catalogo != 0)
            {
                //abre el panel de visualizacion del registro
                Catalogos_Visualizar rn = new Catalogos_Visualizar();
                rn.mostrarinfocatalogo(id_catalogo);
                DialogResult result = rn.ShowDialog();
                if (filtro_flag == 0)
                {
                    llenartablacatalogos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Catálogo de la lista para poder visualizarlo.");
            }
        }

        private void btn_traducciones_Click(object sender, EventArgs e)
        {
            if (id_catalogo != 0)
            {
                Catalogos_Traducciones ct = new Catalogos_Traducciones();
                DialogResult result = ct.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Something...
                }
            }
            else
            {
                MessageBox.Show("Selecciona un catalogo de la lista para poder ver sus traducciones");
            }
        }

        private void btn_claves_Click(object sender, EventArgs e)
        {
            if (id_catalogo != 0)
            {
                Catalogos_ClavesReferencias ct = new Catalogos_ClavesReferencias();
                DialogResult result = ct.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Something...
                }
            }
            else
            {
                MessageBox.Show("Selecciona un catalogo de la lista para poder ver sus claves/referencias");
            }
        }

        private void filtrartablacatalogos (string ctrl, string valor)
        {
            try
            {
                DGV_Catalogos.Rows.Clear();
                SqlConnection con = new SqlConnection(mc.con);
                con = new SqlConnection(mc.con);
                con.Open();
                //cambiar por tabla catalogos
                SqlCommand cmd = new SqlCommand("Select id_catalogo,nombre_catalogo,tipo,año_plublicacion,especialidad,fabricante,idioma " +
                    "from catalogos_productos where " + ctrl + " Like '%" + valor + "%'", con);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_Catalogos.Rows.Add(dr.ItemArray);
                }
                con.Close();
                filtro_flag = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
    

