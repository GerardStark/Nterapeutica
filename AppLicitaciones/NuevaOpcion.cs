using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLicitacion;

namespace AppLicitaciones
{
    public partial class NuevaOpcion : UserControl
    {
        Cucop_Vincular_General cvg = new Cucop_Vincular_General();
        int idCucop = 0;
        public NuevaOpcion()
        {
            InitializeComponent();
        }

        public void pasaridcucop(int idCucop)
        {
            this.idCucop = idCucop;
        }

        private void btn_reg_vincular_Click(object sender, EventArgs e)
        {
            Cucop_Vincular_Registro newForm = new Cucop_Vincular_Registro();
            newForm.mostrarVinculosRegistros(idCucop);
            DialogResult result = newForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //foreach (var item in )
                //{
                //    list_vinc_reg.Items.Add(item);
                //}
            }
        }

        private void btm_cat_vincular_Click(object sender, EventArgs e)
        {
            Cucop_Vincular_Catalogo newForm = new Cucop_Vincular_Catalogo();
            DialogResult result = newForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //something
            }
        }

        private void btn_cert_vincular_Click(object sender, EventArgs e)
        {
            Cucop_Vincular_Certificado newForm = new Cucop_Vincular_Certificado();
            DialogResult result = newForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //something
            }
        }
    }
}
