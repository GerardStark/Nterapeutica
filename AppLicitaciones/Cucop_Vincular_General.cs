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

namespace AppLicitaciones
{
    public partial class Cucop_Vincular_General : Form
    {
        MainConfig mc = new MainConfig();
        public int idCucop = 0;
        public int cont = 0;
        public Cucop_Vincular_General()
        {
            InitializeComponent();
            if (tabOpciones.TabCount <= 0)
            {
                btn_quitar.Enabled = false;
            }
        }
        public void mostrarvinculoscucop(int idCucop)
        {
            this.idCucop = idCucop;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            cont = cont + 1;            
            TabPage opcion = new TabPage();
            opcion.Text = "Opcion " + cont;
            NuevaOpcion opt = new NuevaOpcion();
            opt.pasaridcucop(idCucop);
            opcion.Controls.Add(opt);
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
