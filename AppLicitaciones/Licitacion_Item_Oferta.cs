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
            var topResults = comparados.OrderBy(i => i.Resultado).Take(4).ToList();
            if (topResults[0].Resultado == 0)
            {
                txt_cucop.Text = topResults[0].Cucop.Descripcion;
            }
            txt_opcion_uno.Text = topResults[1].Cucop.Descripcion;
            txt_opcion_dos.Text = topResults[2].Cucop.Descripcion;
            txt_opcion_tres.Text = topResults[3].Cucop.Descripcion;

            //metodo que regrese los objetos "Item" que cumplan con ser los 3 mas cercanos a 0


        }
    }
}
