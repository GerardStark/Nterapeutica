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

namespace AppLicitaciones
{
    public partial class Buscar_Cucops_Vinculacion : Form
    {
        public int idCucop = 0;
       
        MainConfig mc = new MainConfig();
        public Buscar_Cucops_Vinculacion()
        {
            InitializeComponent();
           
            mc.DoubleBuffered(dgvCucops, true);
        }

        private void llenarListaCucops()
        {
            List<Item> items = Item.GetItems();
            dgvCucops.Rows.Clear();
            foreach (Item i in items)
            {
                
                if (i.Vinculos.Any())
                {
                    
                    dgvCucops.Rows.Add(i.Id, i.Ccb, i.Nombre, i.Updated);
                }
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            List<Item> items = Item.GetItems();
            string texto = txt_filtrar.Text;
            dgvCucops.Rows.Clear();
            var results = items.Where(x => x.Nombre.IndexOf(texto, StringComparison.OrdinalIgnoreCase) > -1 && x.Vinculos.Any()).ToList();
            foreach (Item i in results)
            {
                dgvCucops.Rows.Add(i.Id, i.Ccb, i.Nombre, i.Updated);
            }
        }

        private void dgvCucops_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Int32 idCucop = (Int32)dgvCucops.Rows[e.RowIndex].Cells["idColumn"].Value;
                Licitacion_Item_Visualizar form = new Licitacion_Item_Visualizar();
                form.mostrarinfoItem(idCucop);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.idCucop = form.idItem;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void dgvCucops_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.dgvCucops.Columns[e.ColumnIndex].Name)
            {

                case "idColumn":
                    e.Value = e.RowIndex + 1;
                    break;
            }
        }
    }
}
