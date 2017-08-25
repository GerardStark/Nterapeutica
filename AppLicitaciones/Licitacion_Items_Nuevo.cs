﻿using LibLicitacion;
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
                "Caja"
            };
            mc.llenarcombobox(array_tipos, cmb_tipo);
            mc.llenarcombobox(array_tipos, cmb_cont);

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
                    cmd.Parameters.AddWithValue("@unidad", (cmb_tipo.SelectedItem as ComboboxItem).Text);
                    cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txt_cantidad.Text));
                    cmd.Parameters.AddWithValue("@contenedor", (cmb_cont.SelectedItem as ComboboxItem).Text);
                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                    Int32 newId = cmd.ExecuteNonQuery();
                    if (newId != 0)
                    {
                        MessageBox.Show("Guardado");
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void btn_reg_descartar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
