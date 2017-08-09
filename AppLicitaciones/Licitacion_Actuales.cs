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
    public partial class Licitacion_Actuales : Form
    {
        MainConfig mc = new MainConfig();
        int idLicitacion = 0;
        public Licitacion_Actuales()
        {
            InitializeComponent();
        }

        public void mostrarLicitacionesActivas(int estado)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    if (estado == 1)
                    {
                        using (SqlCommand cmd = new SqlCommand(@"SELECT id_bases,numero_licitacion,unidad_compradora,entidad_federativa,especialidad,expediente,tipo_expediente,descripcion,actualizado_en 
                                                         FROM licitacion_bases WHERE id_bases IN (SELECT id_bases FROM licitacion_calendario WHERE @hoy <= fecha_firma)", con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@hoy", DateTime.Now);
                            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapt.Fill(dt);
                            foreach (DataRow dr in dt.Rows)
                            {
                                dgv_licitaciones.Rows.Add(dr.ItemArray);
                            }
                            mc.buscarultimafilaeditada("licitacion_bases", dgv_licitaciones);
                        }
                    }
                    else if (estado == 0)
                    {
                        using (SqlCommand cmd = new SqlCommand(@"SELECT id_bases,numero_licitacion,unidad_compradora,entidad_federativa,especialidad,expediente,tipo_expediente,descripcion,actualizado_en 
                                                         FROM licitacion_bases WHERE id_bases IN (SELECT id_bases FROM licitacion_calendario WHERE @hoy >= fecha_firma)", con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@hoy", DateTime.Now);
                            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapt.Fill(dt);
                            foreach (DataRow dr in dt.Rows)
                            {
                                dgv_licitaciones.Rows.Add(dr.ItemArray);
                            }
                            mc.buscarultimafilaeditada("licitacion_bases", dgv_licitaciones);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void dgv_licitaciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.dgv_licitaciones.Columns[e.ColumnIndex].Name)
            {
                case "tipoExpColumn":
                    if (e.Value != null && e.Value != DBNull.Value && Convert.ToInt32(e.Value) > 0)
                    {
                        if (Convert.ToInt32(e.Value) > 0)
                        {
                            int idpais = Convert.ToInt32(dgv_licitaciones.Rows[e.RowIndex].Cells["tipoExpColumn"].Value);
                            e.Value = mc.obtenertipoexpediente(idpais);
                        }
                    }
                    else
                    {
                        e.Value = "(Vacio)";
                    }
                    break;
            }
        }

        private void btn_tecnica_Click(object sender, EventArgs e)
        {
            Licitacion_Tecnica form = new Licitacion_Tecnica();
            DialogResult result =  form.ShowDialog();
            if (result == DialogResult.OK)
            {
                //something
            }
        }

        private void btn_columnas_Click(object sender, EventArgs e)
        {
            if (idLicitacion !=0)
            {
                Licitacion_Columnas form = new Licitacion_Columnas();
                form.mostrarColumnasBases(idLicitacion);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //something
                }
            }
        }

        private void dgv_licitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                idLicitacion = Convert.ToInt32(dgv_licitaciones.Rows[e.RowIndex].Cells["idColumn"].Value);
                
            }
        }
    }
}
