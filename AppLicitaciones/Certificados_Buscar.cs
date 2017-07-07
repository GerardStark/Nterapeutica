using LibLicitacion;
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
    public partial class Certificados_Buscar : Form
    {
        MainConfig mc = new MainConfig();
        public string ctrl = "";
        public string valor = "";
        public Certificados_Buscar()
        {
            InitializeComponent();
            string[] array_filtros_certificados = { "Seleccione un filtro", "Clave/Referencia", "Tipo", "Descripcion", "Fabricante" };
            mc.llenarcombobox(array_filtros_certificados, cmb_filtros);
            cmb_filtros.SelectedIndex = 0;
                      
        }

        private void btn_buscar_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btn_cat_buscar_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(((ComboboxItem)cmb_filtros.SelectedItem).Value);
            switch (value)
            {
                case 2:
                    ctrl = "numero_identificador";
                    valor = txt_parametros.Text;
                    break;
                case 3:
                    ctrl = "tipo";
                    valor = txt_parametros.Text;
                    break;
                case 4:
                    ctrl = "descripcion_detallada";
                    valor = txt_parametros.Text;
                    break;
                case 5:
                    ctrl = "fabricante";
                    valor = cmb_buscar_fabricante.SelectedValue.ToString();
                    break;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmb_filtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_parametros.Visible = false;
            cmb_buscar_fabricante.Visible = false;
            int value = Convert.ToInt32(((ComboboxItem)cmb_filtros.SelectedItem).Value);
            switch (value)
            {
                case 1:
                    lbl_tipo_filtro.Text = "";
                    break;
                case 2:
                    lbl_tipo_filtro.Text = "Clave/Referencia:";
                    txt_parametros.Visible = true;
                    break;
                case 3:
                    lbl_tipo_filtro.Text = "Tipo:";
                    txt_parametros.Visible = true;
                    break;
                case 4:
                    lbl_tipo_filtro.Text = "Descripcion:";
                    txt_parametros.Visible = true;
                    break;
                case 5:
                    lbl_tipo_filtro.Text = "Fabricante:";
                    txt_parametros.Visible = true;
                    break;             
            }
        }
    }
}
