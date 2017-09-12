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
    public partial class Licitacion_Items_Nuevo : Form
    {
        MainConfig mc = new MainConfig();
        int idSub;
        public Licitacion_Items_Nuevo()
        {
            InitializeComponent();
            string[] array_tipos = {
                "Pieza",
                "Paquete",
                "Kit",
                "Caja",
                "Equipo"
            };
            //mc.llenarcombobox(array_tipos, cmb_tipo);
            //mc.llenarcombobox(array_tipos, cmb_cont);

        }

        public void pasarIdPartida(int idSub)
        {
            this.idSub = idSub;
        }

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("licitacion_item_insert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idSub",idSub);
                    cmd.Parameters.AddWithValue("@descripcion", txt_descripcion.Text);
                    cmd.Parameters.AddWithValue("@unidad", cmb_tipo.Text);
                    cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txt_cantidad.Text));
                    cmd.Parameters.AddWithValue("@contenedor", cmb_cont.Text);
                    cmd.Parameters.AddWithValue("@max", txt_max.Text);
                    cmd.Parameters.AddWithValue("@min", txt_min.Text);
                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                    Int32 newId = (Int32)cmd.ExecuteScalar();
                    if (newId != 0)
                    {
                        using (SqlCommand cmdd = new SqlCommand("licitacion_vinculacion_create", con))
                        {
                            cmdd.CommandType = CommandType.StoredProcedure;
                            cmdd.Parameters.AddWithValue("@idItem", newId);
                            cmdd.Parameters.AddWithValue("@idCucop", DBNull.Value);
                            cmdd.Parameters.AddWithValue("@updated", DateTime.Now);
                            int confirm = cmdd.ExecuteNonQuery();
                            if (confirm != 0)
                            {
                                MessageBox.Show("Guardado");
                                this.DialogResult = DialogResult.OK;
                            }
                        }
                    }
                }
            }
        }

        private void btn_reg_descartar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Licitacion_Items_Nuevo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.data_unidades' Puede moverla o quitarla según sea necesario.
            this.data_unidadesTableAdapter.Fill(this.licitacionesDataSet.data_unidades);

        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
