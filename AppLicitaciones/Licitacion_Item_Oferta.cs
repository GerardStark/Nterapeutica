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
    public partial class Licitacion_Item_Oferta : Form
    {
        MainConfig mc = new MainConfig();
        int idItem;
        int idCucop;
        int idVinc;
        public Licitacion_Item_Oferta()
        {
            InitializeComponent();
        }

        public void mostrarInfoItemCucops(int idItem)
        {
            this.idItem = idItem;
            List<ResultadoLev> comparados = new List<ResultadoLev>();
            Item item = Item.GetItems().Single(x => x.Id == idItem);
            txt_item.Text = item.Nombre;
            //try
            //{
            Vinculacion vinculo = item.Vinculos.Single();
            idVinc = vinculo.Id;
            if (vinculo.Cucop != 0)
            {
                txt_cucop.Text = Cucop.GetCucops().Where(x => x.Id == vinculo.Cucop).Single().Descripcion;
                idCucop = item.Vinculos.Single().Cucop;
            }
            else
            {
                txt_cucop.Text = "Sin Oferta";
                idCucop = 0;
            }         
            //foreach (Cucop c in Cucop.GetCucops())
            //{
            //    int result = LevenshteinDistance.Compute(item.Nombre, c.Descripcion);
            //    ResultadoLev r = new ResultadoLev();
            //    r.Cucop = c;
            //    r.Resultado = result;
            //    comparados.Add(r);

            //    Console.WriteLine(result);
            //    if (result == 0)
            //    {
            //        txt_cucop.Text = c.Descripcion;
            //    }

            //}
            //var topResults = comparados.OrderBy(i => i.Resultado).Take(4).ToList();
            //var diffBuilder = new InlineDiffBuilder(new Differ());
            //var diff = diffBuilder.BuildDiffModel(item.Nombre, topResults[0].Cucop.Descripcion);

            //foreach (var line in diff.Lines)
            //{
            //    switch (line.Type)
            //    {
            //        case ChangeType.Inserted:
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.Write("+ ");
            //            break;
            //        case ChangeType.Deleted:
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.Write("- ");
            //            break;
            //        default:
            //            Console.ForegroundColor = ConsoleColor.White;
            //            Console.Write("  ");
            //            break;
            //    }

            //    Console.WriteLine(line.Text);
            //metodo que regrese los objetos "Item" que cumplan con ser los 3 mas cercanos a 0
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Buscar_Cucops_Vinculacion form = new Buscar_Cucops_Vinculacion();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.idCucop = form.idCucop;
                txt_cucop.Text = Cucop.GetCucops().Where(x => x.Id == this.idCucop).Single().Descripcion;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                if (idCucop != 0)
                {
                    using (SqlCommand cmd = new SqlCommand("licitacion_vinculacion_update", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idVinc", idVinc);
                        cmd.Parameters.AddWithValue("@idItem", idItem);
                        cmd.Parameters.AddWithValue("@idCucop", idCucop);
                        cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                        int confirm = cmd.ExecuteNonQuery();
                        if (confirm != 0)
                        {
                            MessageBox.Show("Guardado");
                        }
                    }
                }
                else
                {
                    using (SqlCommand cmdd = new SqlCommand("licitacion_vinculacion_create", con))
                    {
                        cmdd.CommandType = CommandType.StoredProcedure;
                        cmdd.Parameters.AddWithValue("@idItem", idItem);
                        cmdd.Parameters.AddWithValue("@idCucop", idCucop);
                        cmdd.Parameters.AddWithValue("@updated", DateTime.Now);
                        int confirm = cmdd.ExecuteNonQuery();
                        if (confirm != 0)
                        {
                            using (SqlCommand cmdp = new SqlCommand("licitacion_pregunta_create",con))
                            {
                                cmdp.CommandType = CommandType.StoredProcedure;
                                cmdp.Parameters.AddWithValue("@idVinc",idVinc);
                                cmdp.Parameters.AddWithValue("@enunciado","");
                                cmdp.Parameters.AddWithValue("@updated",DateTime.Now);
                                int result = cmdp.ExecuteNonQuery();
                                if (result != 0)
                                {
                                    MessageBox.Show("Guardado");
                                    this.DialogResult = DialogResult.OK;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Cucop_Visualizar form = new Cucop_Visualizar();
            form.mostrarinfocucop(idCucop);
        }

        private void btn_junta_Click(object sender, EventArgs e)
        {
            licitacion_junta_preguntas form = new licitacion_junta_preguntas();
            form.mostrarInfoPregunta(idVinc);
            form.Show();
        }

        private void Licitacion_Item_Oferta_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_descartar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Borrar Vinculo?","Desvincular",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("licitacion_vinculacion_update", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idVinc", idVinc);
                        cmd.Parameters.AddWithValue("@idItem", idItem);
                        cmd.Parameters.AddWithValue("@idCucop", DBNull.Value);
                        cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                        int confirm = cmd.ExecuteNonQuery();
                        if (confirm != 0)
                        {
                            MessageBox.Show("Borrado");
                            mostrarInfoItemCucops(idItem);
                        }
                    }
                }
            }
        }
    }
}
