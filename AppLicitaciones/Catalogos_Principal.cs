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
    public partial class Catalogos_Principal : Form
    {
        public Catalogos_Principal()
        {
            InitializeComponent();
        }

        private void Catalogos_Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.catalogos_productos' Puede moverla o quitarla según sea necesario.
            this.catalogos_productosTableAdapter.Fill(this.licitacionesDataSet.catalogos_productos);

        }
    }
}
