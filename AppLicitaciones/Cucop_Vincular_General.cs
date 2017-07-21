using LibLicitacion;
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
using CtrlsLicitacion;

namespace AppLicitaciones
{
    public partial class Cucop_Vincular_General : Form
    {
        MainConfig mc = new MainConfig();
        
        int cont = 0;
        public Cucop_Vincular_General()
        {
            InitializeComponent();
            if (tabOpciones.TabCount <= 0)
            {
                btn_quitar.Enabled = false;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            cont = cont + 1;            
            TabPage opcion = new TabPage();
            opcion.Text = "Opcion " + cont;
            opcion.Controls.Add(new NuevaOpcion());
            tabOpciones.Controls.Add(opcion);
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            int tab = tabOpciones.SelectedIndex;
            tabOpciones.Controls.RemoveAt(tab);
            cont = cont - 1;
        }
        public void obtenerdatoscontrol()
        {
            
        }
    }  
}
