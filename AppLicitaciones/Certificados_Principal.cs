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
    public partial class Certificados_Principal : Form
    {
        public Certificados_Principal()
        {
            InitializeComponent();
        }

        private void Certificados_Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.certificados_calidad' Puede moverla o quitarla según sea necesario.
            this.certificados_calidadTableAdapter.Fill(this.licitacionesDataSet.certificados_calidad);

        }
    }
}
