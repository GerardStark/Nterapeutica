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
    public partial class Cucop_Nuevo : Form
    {
        public Cucop_Nuevo()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //todo insertar en la tabla cucop
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_descartar_Click(object sender, EventArgs e)
        {
            txt_nombre_gen.Text = "";
            txt_grupo.Text = "";
            txt_codigo.Text = "";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
