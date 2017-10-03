using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using LibLicitacion;
using System.IO;

namespace AppLicitaciones
{
    public partial class Licitacion_Reportes : Form
    {
        MainConfig mc = new MainConfig();
        int idBases;
        public Licitacion_Reportes()
        {
            InitializeComponent();
            string[] reportes = {
                "Seleccionar...",
                "Información y Avance de las Licitaciones",
                "Lista de Cartas de Apoyo",                
                "Registros vencidos por carta de apoyo",                
                "Registros por vencer por canta de apoyo",                
                "Catalogos faltantes por carta de apoyo",                
                "Certificados vencidos por carta de apoyo",                
                "Certificados por vencer por canta de apoyo",                                
                "Referencias",
                "Listado en Excel"
            };
            mc.llenarcombobox(reportes,cmbRep);
            //radAct.CheckedChanged += radioEstadosLicic;
            //radConc.CheckedChanged += radioEstadosLicic;
        }

        public void pasaridBases(int idBases)
        {
            this.idBases = idBases;
            foreach (Partida pa in Partida.GetPartidasPorBase(idBases))
            {
                foreach (Procedimiento po in Procedimiento.GetProcedimientosPorPartidas(pa.Id))
                {
                    foreach (Item item in Item.GetItemsPorProcedimiento(po.Id))
                    {
                        foreach (CucopVinculos vinc in CucopVinculos.GetVinculacionesPorItem(item.Id))
                        {
                            foreach (VinculoRegistros re in VinculoRegistros.GetRegistrosPorVinculoCucop(vinc.Id))
                            {
                                foreach (vinculoRegistroReferencia reref in vinculoRegistroReferencia.GerRefPorVincReg(re.Id))
                                {

                                }
                            }

                            foreach (VinculoCatalogos ca in VinculoCatalogos.GetCatalogosPorVinculoCucop(vinc.Id))
                            {
                                foreach (vinculoCatalogoReferencia reref in vinculoCatalogoReferencia.GerRefPorVincCat(ca.Id))
                                {

                                }
                            }

                            foreach (VinculoCertificados re in VinculoCertificados.GetCertificadosPorVinculoCucop(vinc.Id))
                            {

                            }
                        }
                    }
                }
            }
        }

        private void Licitacion_Reportes_Load(object sender, EventArgs e)
        {
            cmbRep.SelectedIndex = 0;
            //radAct.Checked = true;           
        }        

        private void cmbRep_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlFormatReport.Controls.Clear();
            if (cmbRep.SelectedIndex != 0)
            {
                switch (cmbRep.SelectedIndex)
                {
                    default:
                        break;
                    case 1:                 
                        Reporte_InfoLicitacion infoLic = new Reporte_InfoLicitacion();
                        pnlFormatReport.Controls.Add(infoLic);
                        break;
                    case 2:
                        Reporte_ListaCartas  liCa= new Reporte_ListaCartas();
                        pnlFormatReport.Controls.Add(liCa);
                        break;
                    case 3:
                        Reporte_RegVencPorCarta reVPC = new Reporte_RegVencPorCarta();
                        pnlFormatReport.Controls.Add(reVPC);
                        break;
                    case 4:
                        Reporte_RegXVencPorCarta reXVPC = new Reporte_RegXVencPorCarta();
                        pnlFormatReport.Controls.Add(reXVPC);
                        break;
                    case 5:
                        Reporte_CatFaltPorCarta caFPC = new Reporte_CatFaltPorCarta();
                        pnlFormatReport.Controls.Add(caFPC);
                        break;
                    case 6:
                        Reporte_CertVencPorCarta ceFPC = new Reporte_CertVencPorCarta();
                        pnlFormatReport.Controls.Add(ceFPC);
                        break;
                    case 7:
                        Reporte_CertXVencPorCarta ceXFPC = new Reporte_CertXVencPorCarta();
                        pnlFormatReport.Controls.Add(ceXFPC);
                        break;
                    case 8:
                        Reporte_Referencias refRep = new Reporte_Referencias();
                        pnlFormatReport.Controls.Add(refRep);
                        break;
                    case 9:
                        Reporte_ListadoExcel listex = new Reporte_ListadoExcel();
                        pnlFormatReport.Controls.Add(listex);
                        break;
                }
            }
        }        
    }
}
