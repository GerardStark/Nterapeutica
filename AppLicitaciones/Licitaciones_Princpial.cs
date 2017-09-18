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
using System.Reflection;

namespace AppLicitaciones
{
    public partial class Licitaciones_Princpial : Form
    {
        public Licitaciones_Princpial()
        {
            InitializeComponent();
        }

        private void btn_nuevas_Click(object sender, EventArgs e)
        {
            Licitacion_Nueva_Abierta form = new Licitacion_Nueva_Abierta();            
            form.ShowDialog();
        }

        private void btn_activas_Click(object sender, EventArgs e)
        {
            Licitacion_Actuales form = new Licitacion_Actuales();
            form.mostrarLicitacionesActivas(1);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                //something
            }
        }

        private void btn_historico_Click(object sender, EventArgs e)
        {
            Licitacion_Actuales form = new Licitacion_Actuales();
            form.mostrarLicitacionesActivas(0);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                //something
            }
        }

        private void btn_todas_Click(object sender, EventArgs e)
        {
            Licitacion_Actuales form = new Licitacion_Actuales();
            form.mostrarLicitacionesActivas(2);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                //something
            }
        }

        private void Licitaciones_Princpial_Load(object sender, EventArgs e)
        {
          
            // TODO: esta línea de código carga datos en la tabla 'licitacionesDataSet.licitacion_bases' Puede moverla o quitarla según sea necesario.
            this.licitacion_basesTableAdapter.Fill(this.licitacionesDataSet.licitacion_bases);
            mostrarEventosProximos();
        }

        private void mostrarEventosProximos()
        {
            DateTime min = DateTime.Today;
            DateTime max = DateTime.Today.AddDays(7);            
            foreach (Calendario c in Calendario.GetCalendarios())
            {
 
                PropertyInfo[] p = c.GetType().GetProperties();
                for (int i = 2; i < p.Length - 2; i++)
                {
                    if ((DateTime)p[i].GetValue(c) > min && (DateTime)p[i].GetValue(c) < max)
                    {
                        Licitacion_Calendario_Principal l = new Licitacion_Calendario_Principal();
                        l.mostrarInfoEvento(c, p[i].Name, p[i].GetValue(c));
                        panelEventos.Controls.Add(l);
                    }                   
                }
            }
        }

        private void cmb_licitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mostrar informacion util para los licitantes:
            //numero total de items, registros, certificados y catalogos, asi como si son vigentes, fueron tramitados a tiempo o 
            try
            {
                int licit = (Int32)cmb_licitacion.SelectedValue;
                int _totalRegistros = 0;
                int _totalRegVencidos = 0;
                int _totalItemes = 0;
                int _registrosConProrroga = 0;
                int _totalCertificados = 0;
                int __totalCerVencidos = 0;
                int _totalCatalogos = 0;
                int _itemsConPregunta = 0;
                if (licit > 0)
                {
                    Licitacion l = Licitacion.GetBases().Where(x => x.Id == licit).Single();
                    foreach (Partida partida in l.Partidas)
                    {
                        foreach (Procedimiento proce in partida.Procedimientos)
                        {
                            foreach (Item item in proce.Items)
                            {
                                _totalItemes++;
                                foreach (Vinculacion vinc in item.Vinculos)
                                {
                                    Cucop asigned = Cucop.GetCucops().Where(x => x.Id == vinc.Cucop).Single();
                                    if (vinc.Preguntas.Count > 0)
                                    {
                                        _itemsConPregunta++;
                                    }
                                    foreach (CucopVinculos cvinc in asigned.Vinculos)
                                    {
                                        foreach (VinculoRegistros regvinc in cvinc.Registros)
                                        {
                                            _totalRegistros++;
                                            RegistroSanitario reg = RegistroSanitario.GetRegistros().Where(x => x.Id == regvinc.Registro).Single();
                                            foreach (RegistroSanitario vencido in RegistroSanitario.GetVencidos())
                                            {
                                                if (reg.Id == vencido.Id)
                                                {
                                                    _totalRegVencidos++;
                                                    if (reg.Prorrogas.Count > 0)
                                                    {
                                                        _registrosConProrroga++;
                                                    }
                                                }
                                            }

                                        }

                                        foreach (VinculoCatalogos catvinc in cvinc.Catalogos)
                                        {
                                            _totalCatalogos++;
                                            CatalogoProductos cat = CatalogoProductos.getCatalogos().Where(x => x.Id == catvinc.Catalogo).Single();
                                        }

                                        foreach (VinculoCertificados cervinc in cvinc.Certificados)
                                        {
                                            _totalCertificados++;
                                            CertificadoCalidad cer = CertificadoCalidad.GetCertificados().Where(x => x.Id == cervinc.Certificado).Single();
                                            foreach (CertificadoCalidad vencido in CertificadoCalidad.GetVencidos())
                                            {
                                                if (cer.Id == vencido.Id)
                                                {
                                                    __totalCerVencidos++;
                                                }
                                            }
                                        }
                                    }                                    
                                }
                            }
                        }
                    }
                    MessageBox.Show(""+_itemsConPregunta+_registrosConProrroga+_totalCatalogos+_totalCertificados+_totalItemes+_totalRegistros+_totalRegVencidos+__totalCerVencidos);
                }

            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException)
                {
                    
                }
            }
        }
    }
}
