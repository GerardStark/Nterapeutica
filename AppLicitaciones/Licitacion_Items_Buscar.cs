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
    public partial class Licitacion_Items_Buscar : Form
    {
        public string filtro = "";
        public int chkTodos = 0;
        public Licitacion_Items_Buscar()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            this.filtro = txt_filtro.Text;
            this.DialogResult = DialogResult.OK;
            
        }

        private void btnTodos_CheckedChanged(object sender, EventArgs e)
        {
            chkTodos = 1;
        }
    }
}
