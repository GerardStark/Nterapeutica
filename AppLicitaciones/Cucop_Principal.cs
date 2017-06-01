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
        int id_cucop = 0;
        public Cucop_Principal()
        {
            InitializeComponent();
            llenartablacucops();
        }
        public void llenartablacucops()
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_cucop,nombre_generico_espeficico,nombre_producto,"+
                    "grupo,codigo,id_registro_sanitario,id_catalogo_productos,id_certificado_calidad from cucop",con);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_cucop.Rows.Add(dr.ItemArray);
                }
                con.Close();
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
                filtrarcucops();
            }
        }

        private void filtrarcucops()
        {
            //TODO filtrar cucops
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            Cucop_Visualizar cv = new Cucop_Visualizar();
            DialogResult result = cv.ShowDialog();
            if (result == DialogResult.OK)
            {
                Cucop_Editar ce = new Cucop_Editar();
                DialogResult result2 = ce.ShowDialog();
                if (result2 == DialogResult.OK)
                {
                    //TODO editar cucop seleccionado
                }
            }
        }

        private void DGV_cucop_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_cucop = Convert.ToInt32(DGV_cucop.Rows[e.RowIndex].Cells["idColumn"].Value);
        }

        private void btn_vincular_Click(object sender, EventArgs e)
        {
            Cucop_Vincular_General cvg = new Cucop_Vincular_General();
            cvg.mostrarvinculoscucop(id_cucop);
            DialogResult result = cvg.ShowDialog();
            if (result == DialogResult.OK)
            {
                //TODO something
            }
        }
    }
}
