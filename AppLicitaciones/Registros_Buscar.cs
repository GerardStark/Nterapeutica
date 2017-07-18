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
            string[] opciones_busqueda = {"Seleccione un filtro","Numero", "Solicitud", "Titular", "Fabricante", "Marca", "Nacionalidad","Tratado de Libre Comercio","Denominación Generica","Denominación Distintiva" };
            mc.llenarcombobox(opciones_busqueda,cmb_opciones_buscqueda);
            cmb_opciones_buscqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void llenarcombobox(string[] arreglo_items)
        {
            for (int i = 0; i < arreglo_items.Length; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = arreglo_items[i].ToString();
                item.Value = i+1;
                cmb_opciones_buscqueda.Items.Add(item);
            }
        }
        public void escondercontroles()
        {
            //variables
            ctrl = "";
            valor = "";
            //labels
            lbl_numero.Visible = false;
            lbl_solicitud.Visible = false;
            lbl_titular.Visible = false;
            lbl_fabricante.Visible = false;
            lbl_marca.Visible = false;
            lbl_nacionalidad.Visible = false;
            lbl_tlc.Visible = false;
            lbl_distintiva.Visible = false;
            lbl_generica.Visible = false;
            //txts
            txt_buscar_numero.Visible = false;
            txt_buscar_solicitud.Visible = false;
            txt_buscar_titular.Visible = false;
            txt_fabricante.Visible = false;
            txt_buscar_marca.Visible = false;
            txt_buscar_nacionalidad.Visible = false;
            txt_buscar_tlc.Visible = false;
            txt_buscar_distintiva.Visible = false;
            txt_buscar_generica.Visible = false;
        }

        private void btn_reg_buscar_Click(object sender, EventArgs e)
        {
            escondercontroles();
            int value = Convert.ToInt32(((ComboboxItem)cmb_opciones_buscqueda.SelectedItem).Value);
            switch (value)
            {
                case 2:
                    ctrl = "numero_registro";
                    valor = txt_buscar_numero.Text;
                    break;
                case 3:
                    ctrl = "numero_solicitud";
                    valor = txt_buscar_solicitud.Text;                    
                    break;
                case 4:
                    ctrl = "titular";
                    valor = txt_buscar_titular.Text;
                    break;
                case 5:
                    ctrl = "fabricante";
                    valor = txt_fabricante.Text;
                    break;
                case 6:
                    ctrl = "marca";
                    valor = txt_buscar_marca.Text;
                    break;
                case 7:
                    ctrl = "nacionalidad";
                    valor = txt_buscar_nacionalidad.Text;
                    break;
                case 8:
                    ctrl = "tratado_comercio";
                    valor = txt_buscar_tlc.Text;
                    break;
                case 9:
                    ctrl = "denom_generica";
                    valor = txt_buscar_generica.Text;
                    break;
                case 10:
                    ctrl = "denom_distintiva";
                    valor = txt_buscar_distintiva.Text;
                    break;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_buscar_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

       
        private void cmb_opciones_buscqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            escondercontroles();
            int value = Convert.ToInt32(((ComboboxItem)cmb_opciones_buscqueda.SelectedItem).Value);
            switch (value)
            {               
                case 2:
                    lbl_numero.Visible = true;
                    txt_buscar_numero.Visible = true;
                    break;
                case 3:
                    lbl_solicitud.Visible = true;
                    txt_buscar_solicitud.Visible = true;
                    break;
                case 4:
                    lbl_titular.Visible = true;
                    txt_buscar_titular.Visible = true;
                    break;
                case 5:
                    lbl_fabricante.Visible = true;
                    txt_fabricante.Visible = true;                   
                    break;
                case 6:
                    lbl_marca.Visible = true;
                    txt_buscar_marca.Visible = true;
                    break;
                case 7:
                    lbl_nacionalidad.Visible = true;
                    txt_buscar_nacionalidad.Visible = true;
                    break;
                case 8:
                    lbl_tlc.Visible = true;
                    txt_buscar_tlc.Visible = true;
                    break;
                case 9:
                    lbl_distintiva.Visible = true;
                    txt_buscar_distintiva.Visible = true;
                    break;
                case 10:
                    lbl_generica.Visible = true;
                    txt_buscar_generica.Visible = true;
                    break;
            }
        }
    }
}
