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
using LibLicitacion;

namespace AppLicitaciones
{
    public partial class Registros_Principal : Form
    {
        MainConfig mc = new MainConfig();
        public Registros_Principal()
        {
            InitializeComponent();
            //llenartablaregistros();
        }

        private void Registros_Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.registros_sanitarios' Puede moverla o quitarla según sea necesario.
            this.registros_sanitariosTableAdapter.Fill(this.licitacionesDataSet.registros_sanitarios);
        }

        private void btn_reg_nuevo_Click(object sender, EventArgs e)
        {
            Registros_Nuevo rn = new Registros_Nuevo();
            rn.ShowDialog();
        }
    }
    
    
}
