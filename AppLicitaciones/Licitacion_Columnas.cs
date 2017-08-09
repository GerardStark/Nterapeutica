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
    public partial class Licitacion_Columnas : Form
    {
        int rowindex = 0, idBases = 0;
        string nombre = "";
        MainConfig mc = new MainConfig();
        List<LicitacionColumna> columnas = new List<LicitacionColumna>();
        public Licitacion_Columnas()
        {
            InitializeComponent();
        }

        public void mostrarColumnasBases(int idBases)
        {
            this.idBases = idBases;
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT id,nombre_columna,jerarquia FROM licitacion_columnas WHERE id_bases = @idBases ",con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@idBases",idBases);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            dgvColumnas.Rows.Add(dr.ItemArray);
                            LicitacionColumna col = new LicitacionColumna();
                            col.numero = dgvColumnas.Rows.Count + 1;
                            col.nombre = dr["nombre_columna"].ToString();
                            col.orden = (Int32)dr["jerarquia"];
                            columnas.Add(col);
                        }
                    }
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            LicitacionColumna col = new LicitacionColumna();
            col.numero = dgvColumnas.Rows.Count + 1; 
            col.nombre = txt_nombre.Text;
            col.orden = Convert.ToInt32(txt_orden.Text);
            columnas.Add(col);
            //MessageBox.Show(columnas.Count.ToString());
            dgvColumnas.Rows.Add(col.numero,col.nombre,col.orden);
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(columnas.Count.ToString());
            if (dgvColumnas.Rows.Count > 0)
            {
                columnas.RemoveAll(delegate (LicitacionColumna col) {
                    return col.nombre == dgvColumnas.Rows[rowindex].Cells["nombreColumn"].Value.ToString();
                });
                dgvColumnas.Rows.RemoveAt(rowindex);        
            }
            else
            {
                MessageBox.Show("No hay columnas que borrar");
            }
        }

        private void txt_orden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvColumnas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.dgvColumnas.Columns[e.ColumnIndex].Name)
            {
                case "idColumn":
                    if (e.Value != null && e.Value != DBNull.Value && Convert.ToInt32(e.Value) > 0)
                    {
                        if (Convert.ToInt32(e.Value) > 0)
                        {
                            e.Value = e.RowIndex + 1;
                        }
                    }
                    else
                    {
                        e.Value = "(Vacio)";
                    }
                    break;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    con.Open();
                    using (SqlCommand delete = new SqlCommand("DELETE FROM licitacion_columnas WHERE id_bases = @idbases", con))
                    {
                        delete.Parameters.AddWithValue("@idBases", idBases);
                        delete.ExecuteNonQuery();
                    }
                    foreach (LicitacionColumna col in columnas)
                    {
                        using (SqlCommand cmd = new SqlCommand(@"INSERT INTO licitacion_columnas (id_bases,nombre_columna,jerarquia) VALUES (@idBases,@nombre,@orden);", con))
                        {
                            cmd.Parameters.AddWithValue("@idBases", idBases);
                            cmd.Parameters.AddWithValue("@nombre", col.nombre);
                            cmd.Parameters.AddWithValue("@orden", col.orden);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void dgvColumnas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                rowindex = e.RowIndex;
                nombre = dgvColumnas.Rows[e.RowIndex].Cells["nombreColumn"].Value.ToString();
            }                
        }
    }
}
