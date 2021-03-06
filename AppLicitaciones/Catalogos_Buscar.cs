﻿using System;
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
    public partial class Catalogos_Buscar : Form
    {
        MainConfig mc = new MainConfig();
        public string ctrl = "";  
        public string valor = "";
        
                      
        public Catalogos_Buscar()
        {
            InitializeComponent();
            string[] array_filtros_catalogos = { "Seleccione un filtro", "Nombre", "Tipo", "Año", "Especialidad", "Fabricante", "Referencia" };
            string[] array_tipos_catalogo = { "Catálogo", "Brochure", "Manual", "Ficha Técnica", };
            string[] array_specs = {
                "Cirugia Cardiovascular",
                "Hemodinamia",
                "Urología",
                "Minima Invasion",
                "Endoscopia",
                "Terapia Endovascular Neurologica",
                "Marcapasos",
                "Material de Curacion",
                "Subrogados" };
            mc.llenarcombobox(array_tipos_catalogo, cmb_tipo);
            mc.llenarcombobox(array_specs, cmb_spec);
            mc.llenarcombobox(array_filtros_catalogos, cmb_filtros);
            cmb_filtros.SelectedIndex = 0;
        }

        private void cmb_filtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_parametros.Visible = false;
            
            int value = Convert.ToInt32(((ComboboxItem)cmb_filtros.SelectedItem).Value);
            switch (value)
            {
                case 1:
                    lbl_tipo_filtro.Text = "";                    
                    break;
                case 2:
                    lbl_tipo_filtro.Text = "Nombre:";
                    txt_parametros.Visible = true;
                    break;
                case 3:
                    lbl_tipo_filtro.Text = "Tipo:";
                    txt_parametros.Visible = false;
                    cmb_tipo.Visible = true;
                    break;
                case 4:
                    lbl_tipo_filtro.Text = "Año:";
                    txt_parametros.Visible = true;
                    break;
                case 5:
                    lbl_tipo_filtro.Text = "Especialidad:";
                    txt_parametros.Visible = false;
                    cmb_spec.Visible = true;
                    break;
                case 6:
                    lbl_tipo_filtro.Text = "Fabricante:";
                    txt_parametros.Visible = true;
                    break;
                case 7:
                    lbl_tipo_filtro.Text = "Referencia";
                    txt_parametros.Visible = true;
                    break;
            }
        }

        private void btn_cat_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(((ComboboxItem)cmb_filtros.SelectedItem).Value);
                switch (value)
                {
                    case 2:
                        ctrl = "nombre_catalogo";
                        valor = txt_parametros.Text;
                        break;
                    case 3:
                        ctrl = "tipo_catalogo";
                        valor = ((ComboboxItem)cmb_tipo.SelectedItem).Text;
                        break;
                    case 4:
                        ctrl = "publicacion";
                        valor = txt_parametros.Text;
                        break;
                    case 5:
                        ctrl = "spec_catalogo";
                        valor = ((ComboboxItem)cmb_spec.SelectedItem).Text;
                        break;
                    case 6:
                        ctrl = "fabricante";
                        valor = txt_parametros.Text;
                        break;
                    case 7:
                        ctrl = "referencia";
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

        private void Catalogos_Buscar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.fabricantes_titulares_distribuidores' Puede moverla o quitarla según sea necesario.
            this.fabricantes_titulares_distribuidoresTableAdapter.Fill(this.licitacionesDataSet.fabricantes_titulares_distribuidores);
        }
    }
}
