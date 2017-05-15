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
    public partial class Registros_ClavesReferencias : Form
    {
        public Registros_ClavesReferencias()
        {
            InitializeComponent();
        }

        private void Registros_ClavesReferencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.registros_claves_referencias' Puede moverla o quitarla según sea necesario.
            this.registros_claves_referenciasTableAdapter.Fill(this.licitacionesDataSet.registros_claves_referencias);

        }
    }
}
