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
    public partial class Licitacion_items_lista : Form
    {
        int idSub = 0;
        MainConfig mc = new MainConfig();
        public Licitacion_items_lista()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var subpar = (from sp in Procedimiento.GetProcedimientos() where sp.Id == idSub select sp).First();
            List < string > items = txtList.Text.Split(new[] { "\r\n" }, StringSplitOptions.None)
                             .ToList();
            if (MessageBox.Show("Total de filas a insertar: "+ items.Count.ToString()+" ¿Insertar?","Insertar Lista de Items",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    using (SqlConnection con = new SqlConnection(mc.con))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = con;
                            cmd.CommandText = "licitacion_item_insert";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idSub", subpar.Id);
                            cmd.Parameters.AddWithValue("@numero", i+1);
                            cmd.Parameters.AddWithValue("@descripcion", items[i]);
                            cmd.Parameters.AddWithValue("@unidad", "Pieza");
                            cmd.Parameters.AddWithValue("@cantidad", 1);
                            cmd.Parameters.AddWithValue("@contenedor", "Pieza");
                            cmd.Parameters.AddWithValue("@max", subpar.Maximo);
                            cmd.Parameters.AddWithValue("@min", subpar.Minimo);
                            cmd.Parameters.AddWithValue("@ccb", "S.C.C/B");
                            cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Guardado");
                this.DialogResult = DialogResult.OK;
            
            }
        }

        internal void pasardatossubpar(int idSub)
        {
            this.idSub = idSub;

        }
    }
}
