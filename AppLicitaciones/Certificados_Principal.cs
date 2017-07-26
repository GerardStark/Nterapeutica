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
    public partial class Certificados_Principal : Form
    {
        int id_certificado = 0;
        int filtro_flag = 0;
        MainConfig mc = new MainConfig();
        public Certificados_Principal()
        {
            InitializeComponent();
            llenartablacertificados();
            this.DGV_certificados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DGV_certificados.MultiSelect = false;
        }
        public void llenartablacertificados()
        {
            try
            {
                DGV_certificados.Rows.Clear();
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("Select id_certificado,numero_identificador,tipo,descripcion_detallada,fabricante,idioma,fecha_vencimiento,dir_archivo,dir_archivo_traduccion " +
                    "From certificados_calidad", con);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_certificados.Rows.Add(dr.ItemArray);
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
            Certificados_Nuevo cn = new Certificados_Nuevo();
            DialogResult result = cn.ShowDialog();
            if (result == DialogResult.OK)
            {
                llenartablacertificados();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            id_certificado = 0;
            Certificados_Buscar rn = new Certificados_Buscar();
            DialogResult result = rn.ShowDialog();
            if (result == DialogResult.OK)
            {
                string ctrl = rn.ctrl;
                string valor = rn.valor;
                filtrartablacertificados(ctrl, valor);
            }
            else
            {
                llenartablacertificados();
            }
        }

        public void filtrartablacertificados(string ctrl, string valor)
        {
            try
            {
                DGV_certificados.Rows.Clear();
                SqlConnection con = new SqlConnection(mc.con);
                con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select id_certificado,numero_identificador,tipo,descripcion_detallada,fabricante,idioma,fecha_vencimiento,dir_archivo,dir_archivo_traduccion " +
                   "From certificados_calidad Where " + ctrl + " Like '%" + valor + "%'", con);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                if (dt.Rows.Count >0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        DGV_certificados.Rows.Add(dr.ItemArray);
                    }
                }
                else
                {
                    MessageBox.Show("No hay coincidencias");
                    llenartablacertificados();
                }
                con.Close();
                filtro_flag = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void DGV_certificados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.DGV_certificados.Columns[e.ColumnIndex].Name)
            {
                
            }
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            if (id_certificado != 0)
            {
                Certificados_Visualizar cv = new Certificados_Visualizar();
                cv.mostrarinfocertificado(id_certificado);
                DialogResult result = cv.ShowDialog();
                if (filtro_flag == 0)
                {
                    llenartablacertificados();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un certificado");
            }
        }

        private void DGV_certificados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id_certificado = Convert.ToInt32(DGV_certificados.Rows[e.RowIndex].Cells["idColumn"].Value);
            }            
        }
    }
    
}
