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
    public partial class FTD_Principal : Form
    {
        public FTD_Principal()
        {
            InitializeComponent();
        }

        private void FTD_Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.fabricantes_titulares_distribuidores' Puede moverla o quitarla según sea necesario.
            this.fabricantes_titulares_distribuidoresTableAdapter.Fill(this.licitacionesDataSet.fabricantes_titulares_distribuidores);

        }
    }
}
