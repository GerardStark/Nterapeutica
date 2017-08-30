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
        public Buscar_Cucops_Vinculacion()
        {
            InitializeComponent();
            llenarListaCucops();
        }

        private void llenarListaCucops()
        {
            dgvCucops.Rows.Clear();
            foreach (Cucop c in Cucop.GetCucops())
            {

                dgvCucops.Rows.Add(c.Id, c.Clave, c.Descripcion);
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            dgvCucops.Rows.Clear();
            List<Cucop> cucops = Cucop.GetCucops();
            var terminos = txt_filtrar.Text.ToLower().Split(null);
            var termino = terminos[0];
            var result = from x in cucops where (x.Descripcion.Contains(termino)) select x;
            if (terminos.Length > 1)
            {
                for (int i = 1; i < terminos.Length; i++)
                {
                    var temptermino = terminos[i];
                    result = from x in cucops where (x.Descripcion.Contains(temptermino) || 
                             x.Descripcion.Contains(temptermino))
                             select x;
                }
            }
            foreach (Cucop c in result)
            {
                dgvCucops.Rows.Add(c.Id, c.Clave, c.Descripcion);
            }
        }
    }
}
