using LibLicitacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiffPlex;
using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;

namespace AppLicitaciones
{
    public partial class Licitacion_Item_Oferta : Form
    {
        MainConfig mc = new MainConfig();
        int idItem;
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
            foreach (Cucop c in Cucop.GetCucops())
            {
                int result = LevenshteinDistance.Compute(item.Nombre, c.Descripcion);
                ResultadoLev r = new ResultadoLev();
                r.Cucop = c;
                r.Resultado = result;
                comparados.Add(r);

                //Console.WriteLine(result);
                //if (result == 0)
                //{
                //    txt_cucop.Text = c.Descripcion;
                //}

            }
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

        private void btn_limpiar_resultados_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_buscar_items_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Buscar_Cucops_Vinculacion form = new Buscar_Cucops_Vinculacion();
            form.ShowDialog();
        }
    }
}
