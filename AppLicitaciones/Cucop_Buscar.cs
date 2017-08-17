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
    public partial class Cucop_Buscar : Form
    {
        MainConfig mc = new MainConfig();
        public string ctrl = "";
        public string valor = "";
        public Cucop_Buscar()
        {
            InitializeComponent();
            string[] array_filtros_certificados = { "Seleccione un filtro", "Descripcion", "Especialidad", };
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
            try
            {
                int value = Convert.ToInt32(((ComboboxItem)cmb_filtros.SelectedItem).Value);
                switch (value)
                {
                    case 2:
                        ctrl = "descripcion";
                        valor = txt_parametros.Text;
                        break;
                    case 3:
                        ctrl = "especialidad";
                        valor = txt_parametros.Text;
                        break;

                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void cmb_filtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_parametros.Visible = false;
            lbl_tipo_filtro.Text = "";
            int value = Convert.ToInt32(((ComboboxItem)cmb_filtros.SelectedItem).Value);
            switch (value)
            {
                case 2:
                    lbl_tipo_filtro.Text = "Descripción:";
                    txt_parametros.Visible = true;
                    break;
                case 3:
                    lbl_tipo_filtro.Text = "Especialidad:";
                    txt_parametros.Visible = true;
                    break;
               
            }
        }
    }
}
