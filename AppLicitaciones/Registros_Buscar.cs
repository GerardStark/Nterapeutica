using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLicitacion;

namespace AppLicitaciones
{
    public partial class Registros_Buscar : Form
    {
        MainConfig mc = new MainConfig();
        public string ctrl = "";
        public string valor="";
        public Registros_Buscar()
        {
            InitializeComponent();
            string[] opciones_busqueda = {"Seleccione un filtro","Numero", "Referencia", "Solicitud", "Titular", "Fabricante", "Marca", "Denominación Generica","Denominación Distintiva" };
            mc.llenarcombobox(opciones_busqueda,cmb_opciones_buscqueda);            
        }

        private void cmb_opciones_buscqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_parametro.Text = "";
            txt_parametros.Visible = false;
            int value = Convert.ToInt32(((ComboboxItem)cmb_opciones_buscqueda.SelectedItem).Value);
            switch (value)
            {
                case 2:
                    lbl_parametro.Text = "Numero de RS:";
                    txt_parametros.Visible = true;
                    break;
                case 3:
                    lbl_parametro.Text = "Referencia:";
                    txt_parametros.Visible = true;
                    break;
                case 4:
                    lbl_parametro.Text = "Numemro de Solicitud:";
                    txt_parametros.Visible = true;
                    break;
                case 5:
                    lbl_parametro.Text = "Titular:";
                    txt_parametros.Visible = true;
                    break;
                case 6:
                    lbl_parametro.Text = "Fabricante:";
                    txt_parametros.Visible = true;
                    break;
                case 7:
                    lbl_parametro.Text = "Marca:";
                    txt_parametros.Visible = true;
                    break;
                case 8:
                    lbl_parametro.Text = "Denominación Generica";
                    txt_parametros.Visible = true;
                    break;
                case 9:
                    lbl_parametro.Text = "Denominación Distintiva";
                    txt_parametros.Visible = true;
                    break;
            }
        }

        private void btn_reg_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(((ComboboxItem)cmb_opciones_buscqueda.SelectedItem).Value);
                switch (value)
                {
                    case 2:
                        ctrl = "numero_registro";
                        valor = txt_parametros.Text;
                        break;
                    case 3:
                        ctrl = "referencia";
                        valor = txt_parametros.Text;
                        break;
                    case 4:
                        ctrl = "numero_solicitud";
                        valor = txt_parametros.Text;
                        break;
                    case 5:
                        ctrl = "titular";
                        valor = txt_parametros.Text;
                        break;
                    case 6:
                        ctrl = "fabricante";
                        valor = txt_parametros.Text;
                        break;
                    case 7:
                        ctrl = "marca";
                        valor = txt_parametros.Text;
                        break;
                    case 8:
                        ctrl = "denom_distintiva";
                        valor = txt_parametros.Text;
                        break;
                    case 9:
                        ctrl = "denom_generica";
                        valor = txt_parametros.Text;
                        break;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException)
                {
                    MessageBox.Show("Selecciona una opcion");
                }
            }
        }

        private void btn_buscar_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
    }
}
