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
    public partial class Registros_ClavesReferencias : Form
    {
        MainConfig mc = new MainConfig();
        int id_registro, id_referencia = 0;
        public Registros_ClavesReferencias()
        {
            InitializeComponent();
        }
        //TODO llenar dgv con las clavevs asigandas al registro sanitario
        public void mostrarclavesregistro(int id_registro)
        {
            this.id_registro = id_registro;
            try
            {
                DGV_Referencias.Rows.Clear();
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("Select id_clave_registro, clave_ref_cod, descripcion, unidad_venta "+
                    "from registros_claves_referencias where id_registro_sanitario = @id", con);
                cmd.Parameters.AddWithValue("@id", id_registro);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_Referencias.Rows.Add(dr.ItemArray);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("INSERT into registros_claves_referencias (id_registro_sanitario,clave_ref_cod, descripcion, unidad_venta,actualizado_en)" +
                    "values (@idregistro,@clave,@descripcion,@unidad,@actualizado)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@idregistro", id_registro);
                cmd.Parameters.AddWithValue("@clave", txt_clave.Text);
                cmd.Parameters.AddWithValue("@descripcion", txt_descripcion.Text);
                cmd.Parameters.AddWithValue("@unidad", txt_unidad.Text);
                cmd.Parameters.AddWithValue("@actualizado", DateTime.Now);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Guardado");
                mostrarclavesregistro(id_registro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (id_referencia != 0)
            {
                try
                {
                    SqlConnection con = new SqlConnection(mc.con);
                    SqlCommand cmd = new SqlCommand("UPDATE registros_claves_referencias set clave_ref_cod = @clave , descripcion = @descripcion, unidad_venta = @unidad" +
                        ",actualizado_en = @actualizado where id_clave_registro = @id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id_referencia);
                    cmd.Parameters.AddWithValue("@idregistro", id_registro);
                    cmd.Parameters.AddWithValue("@clave", txt_clave.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txt_descripcion.Text);
                    cmd.Parameters.AddWithValue("@unidad", txt_unidad.Text);
                    cmd.Parameters.AddWithValue("@actualizado", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Actualizado");
                    mostrarclavesregistro(id_registro);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void DGV_Referencias_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (id_referencia != 0)
            {
                id_referencia = 0;
                btn_guardar.Enabled = true;
                txt_clave.Text = "";
                txt_descripcion.Text = "";
                txt_unidad.Text = "";
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //Eliminar uno por uno las clavess

        }

        private void DGV_Referencias_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_referencia = Convert.ToInt32(DGV_Referencias.Rows[e.RowIndex].Cells["idColumn"].Value);
            txt_clave.Text = DGV_Referencias.Rows[e.RowIndex].Cells["claveColumn"].Value.ToString();
            txt_descripcion.Text = DGV_Referencias.Rows[e.RowIndex].Cells["descripcionColumn"].Value.ToString();
            txt_unidad.Text = DGV_Referencias.Rows[e.RowIndex].Cells["unidadColumn"].Value.ToString();
            btn_guardar.Enabled = false;
        }
    }
}
