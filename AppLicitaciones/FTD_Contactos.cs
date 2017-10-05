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
    public partial class FTD_Contactos : Form
    {
        MainConfig mc = new MainConfig();
        int id_fabricante, id_contacto =0;
        public FTD_Contactos()
        {
            InitializeComponent();
        }
        public void llenarcontactosfabricante(int id_fabricante)
        {
            this.id_fabricante = id_fabricante;
            try
            {
                DGV_contactos.Rows.Clear();
                SqlConnection con = new SqlConnection(mc.con);
                SqlCommand cmd = new SqlCommand("Select id_contacto, nombre,correo_electronico,correo_electronico_dos,telefono,telefono_dos,comentarios"+
                    " from fabricantes_contactos where id_ftd = @id ", con);
                cmd.Parameters.AddWithValue("@id", id_fabricante);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DGV_contactos.Rows.Add(dr.ItemArray);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DGV_contactos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_guardar.Enabled = false;
            id_contacto = Convert.ToInt32(DGV_contactos.Rows[e.RowIndex].Cells["idColumn"].Value);
            txt_nombre.Text = DGV_contactos.Rows[e.RowIndex].Cells["nombreColumn"].Value.ToString();
            txt_email.Text = DGV_contactos.Rows[e.RowIndex].Cells["emailColumn"].Value.ToString();
            txt_email_dos.Text = DGV_contactos.Rows[e.RowIndex].Cells["emaildosColumn"].Value.ToString();
            txt_telefono.Text = DGV_contactos.Rows[e.RowIndex].Cells["telefonoColumn"].Value.ToString();
            txt_telefono_dos.Text = DGV_contactos.Rows[e.RowIndex].Cells["telefonodosColumn"].Value.ToString();
            txt_comentarios.Text = DGV_contactos.Rows[e.RowIndex].Cells["ComentariosColumn"].Value.ToString();
        }

        private void DGV_contactos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_guardar.Enabled = true;
            id_contacto = 0;
            txt_nombre.Text = "";
            txt_email.Text = "";
            txt_email_dos.Text = "";
            txt_telefono.Text = "";
            txt_telefono_dos.Text = "";
            txt_comentarios.Text = "";
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (id_contacto != 0)
            {
                try
                {
                    SqlConnection con = new SqlConnection(mc.con);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update fabricantes_contactos set id_ftd = @idftd,nombre = @nombre,correo_electronico = @correo,correo_electronico_dos = @correodos," +
                        "telefono = @tel,telefono_dos = @teldos,comentarios = @coment,actualizado_en = @actualizado where id_contacto = @idcontacto", con);
                    cmd.Parameters.AddWithValue("@idcontacto", id_contacto);
                    cmd.Parameters.AddWithValue("@idftd", id_fabricante);
                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@correo", txt_email.Text);
                    cmd.Parameters.AddWithValue("@correodos", txt_email_dos.Text);
                    cmd.Parameters.AddWithValue("@tel", txt_telefono.Text);
                    cmd.Parameters.AddWithValue("@teldos", txt_telefono_dos.Text);
                    cmd.Parameters.AddWithValue("@coment", txt_comentarios.Text);
                    cmd.Parameters.AddWithValue("@actualizado", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    llenarcontactosfabricante(id_fabricante);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un contacto para editar");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (id_contacto != 0)
            {
                DialogResult result = MessageBox.Show("Se que quiere eliminar el contacto?", "Eliminar Contacto", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(mc.con);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE from fabricantes_contactos WHERE id_contacto = @id",con);
                    cmd.Parameters.AddWithValue("@id",id_contacto);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    llenarcontactosfabricante(id_fabricante);
                }
                else
                {
                    MessageBox.Show("Accion Cancelada");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un contacto para eliminar");
            }
        }

        private void DGV_contactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id_contacto = (Int32)DGV_contactos.Rows[e.RowIndex].Cells["idColumn"].Value;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(mc.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into fabricantes_contactos (id_ftd,nombre,correo_electronico,correo_electronico_dos," +
                    "telefono,telefono_dos,comentarios,actualizado_en) values (@idftd,@nombre,@correo,@correodos,@tel,@teldos,@coment,@actualizado)",con);
                cmd.Parameters.AddWithValue("@idftd",id_fabricante);
                cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                cmd.Parameters.AddWithValue("@correo",txt_email.Text);
                cmd.Parameters.AddWithValue("@correodos", txt_email_dos.Text);
                cmd.Parameters.AddWithValue("@tel",txt_telefono.Text);
                cmd.Parameters.AddWithValue("@teldos",txt_telefono_dos.Text);
                cmd.Parameters.AddWithValue("@coment",txt_comentarios.Text);
                cmd.Parameters.AddWithValue("@actualizado",DateTime.Now);
                cmd.ExecuteNonQuery();
                con.Close();
                llenarcontactosfabricante(id_fabricante);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    

