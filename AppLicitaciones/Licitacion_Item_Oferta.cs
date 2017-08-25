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
            int [] results = new int [99];
            this.idItem = idItem;
            string desc = Item.GetItems().Single(x => x.Id == idItem).Nombre;
            for (int i = 0; i < Cucop.GetCucops().Count; i++)
            {
                foreach (Cucop c in Cucop.GetCucops())
                {
                    results[i] = LevenshteinDistance.Compute(desc, c.Descripcion);
                }
                
            }
            

        }
    }
}
