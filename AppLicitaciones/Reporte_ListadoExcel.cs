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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.SqlClient;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using ClosedXML.Excel;

namespace AppLicitaciones
{
    public partial class Reporte_ListadoExcel : UserControl
    {
        MainConfig mc = new MainConfig();
        int idLicit = 0;
        public Reporte_ListadoExcel()
        {
            InitializeComponent();
            mc.DoubleBuffered(dgvListado, true);
            radAct.CheckedChanged += radioEstadosLicic;
            radConc.CheckedChanged += radioEstadosLicic;
        }

        private void radioEstadosLicic(object sender, EventArgs e)
        {
            cmbNumLicit.Items.Clear();
            var bases = Licitacion.GetBases();
            RadioButton rad = sender as RadioButton;
            if (rad.Name == "radAct")
            {
                for (int i = 0; i < bases.Count; i++)
                {
                    if (bases[i].Estado == 1)
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = bases[i].NumeroLicitacion;
                        item.Value = bases[i].Id;
                        cmbNumLicit.Items.Add(item);
                    }
                }
            }
            else if (rad.Name == "radConc")
            {
                for (int i = 0; i < bases.Count; i++)
                {
                    if ((bases[i].Estado != 1))
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = bases[i].NumeroLicitacion;
                        item.Value = bases[i].Id;
                        cmbNumLicit.Items.Add(item);
                    }
                }
            }
        }

        private void Reporte_ListadoExcel_Load(object sender, EventArgs e)
        {
            radAct.Checked = true;
        }

        private void cmbNumLicit_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvListado.Rows.Clear();
            int idlicit = Convert.ToInt32((cmbNumLicit.SelectedItem as ComboboxItem).Value);
            mostrarTablaListado(idlicit);
        }

        public void mostrarTablaListado(int idBases)
        {
            //crear el listado de la licitacion
            this.idLicit = idBases;
            string[] columnas = new string[] {
                "Consecutivo",
                "Procedimiento",
                "# Item",
                "Clave CCB",                
                "Descripcion",
                "Presentacion",
                "Cantidad",
                "Contenedor",
                "Minimo",
                "Maximo",
                "opcion",
                "Carta de Apoyo",
                "RFC",
                "Apoyo",
                "Mayorista",
                "Fabricante",
                "Contacto",
                "Marca",
                "Pais",
                "Tratado",
                "Nombre del Producto",                
                "Registro",
                "Vencimiento Registro",
                "% Registros",
                "Certificado CFS/FDA",
                "Vencimiento CFS/FDA",
                "Certificado CE/ISO",
                "Vencimiento CE/ISO",
                "% Certificados",
                "Nombre Catalogo",
                "Referencia",
                "Pagina",
                "Pagina PDF",
                "% Catalogos",
                "Observaciones",
                "Pregunta de JA"
,            };
            
            //agrega las columnas
            for (int i = 0; i < columnas.Length; i++)
            {
                DataGridViewColumn c = new DataGridViewColumn();
                c.HeaderText = columnas[i];
                c.Width = 150;
                c.CellTemplate = new DataGridViewTextBoxCell();
                dgvListado.Columns.Add(c);
            }

            //llena las filas
            var partidas = Partida.GetPartidasPorBase(idBases);
            var procedimientos = partidas.SelectMany(x => x.Procedimientos);
            var items = (from li in Licitacion.GetBases().Where(x => x.Id == idBases)
                         from pa in li.Partidas
                         from pr in pa.Procedimientos
                         from it in pr.Items
                         select it).ToList();
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Vinculos.Any())
                {
                    foreach (CucopVinculos vinc in items[i].Vinculos)
                    {
                        dgvListado.Rows.Add(
                        i + 1,
                        procedimientos.Where(x => x.Id == items[i].Procedimiento).FirstOrDefault().Nombre,
                        procedimientos.Where(x => x.Id == items[i].Procedimiento).FirstOrDefault().Numero + "." + items[i].Numero,
                        items[i].Ccb,
                        items[i].Nombre,
                        items[i].Unidad,
                        items[i].Cantidad,
                        items[i].Contenedor,
                        items[i].Minimo,
                        items[i].Maximo,
                        vinc.Opcion.ToString(),
                        Carta.GetCartas().Where(x => x.Id == vinc.CartaApoyo).FirstOrDefault().Nombre,
                        Carta.GetCartas().Where(x => x.Id == vinc.CartaApoyo).FirstOrDefault().RFC,
                        Carta.GetCartas().Where(x => x.Id == vinc.CartaApoyo).FirstOrDefault().Apoyo,
                        Carta.GetCartas().Where(x => x.Id == vinc.CartaApoyo).FirstOrDefault().Mayorista,
                        getFabricantes(vinc.Id),
                        getContactos(vinc.CartaApoyo),
                        getMarcas(vinc.Id),
                        getPaises(vinc.Id),
                        getTratados(vinc.Id),
                        vinc.Nombre,
                        getRegistros(vinc.Registros),
                        getRegVencimientos(vinc.Registros),
                        getRegPorcent(vinc.Registros),
                        getCfsFda(vinc.Certificados),
                        getCfsFdaVencimientos(vinc.Certificados),
                        getCeIso(vinc.Certificados),
                        getCeIsoVencimientos(vinc.Certificados),
                        getCertPorcent(vinc.Certificados),
                        getCatNombres(vinc.Catalogos),
                        getCatReferencias(vinc.Catalogos),
                        getCatPaginas(vinc.Catalogos),
                        getCatPaginasPdf(vinc.Catalogos),
                        getCatPorcent(vinc.Catalogos),
                        "",
                        ""
                        );

                    }
                }
                else
                {
                    dgvListado.Rows.Add(
                        i + 1,
                        procedimientos.Where(x => x.Id == items[i].Procedimiento).FirstOrDefault().Nombre,
                        procedimientos.Where(x => x.Id == items[i].Procedimiento).FirstOrDefault().Numero + "." + items[i].Numero,
                        items[i].Ccb,
                        items[i].Nombre,
                        items[i].Unidad,
                        items[i].Cantidad,
                        items[i].Contenedor,
                        items[i].Minimo,
                        items[i].Maximo,
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "");
                }
            
            }
        }

        private object getPreguntas(CucopVinculos vinc)
        {
            var pregunta = (from it in Item.GetItems()
                           from pr in it.Preguntas
                           where it.Id == vinc.IdItem
                           select pr.Enunciado).FirstOrDefault();
            return pregunta;
        }

        private object getCatPorcent(List<VinculoCatalogos> catalogos)
        {
            if (catalogos.Any())
                return 1;
            return 0;
        }

        private object getCatPaginasPdf(List<VinculoCatalogos> catalogos)
        {
            string stpags = "";
            foreach (VinculoCatalogos vca in catalogos)
            {
                foreach (vinculoCatalogoReferencia item in vca.Referencias)
                {
                    var pag = (from cr in ReferenciaCatalogo.GetReferencias()
                               where cr.Catalogo == vca.Nombre
                               select cr.PaginaPDF).FirstOrDefault();
                    stpags = stpags + pag + "/";
                }
            }
            return stpags;
        }

        private object getCatPaginas(List<VinculoCatalogos> catalogos)
        {
            string stpags = "";
            foreach (VinculoCatalogos vca in catalogos)
            {
                foreach (vinculoCatalogoReferencia item in vca.Referencias)
                {
                    var pag = (from cr in ReferenciaCatalogo.GetReferencias()
                                where cr.Catalogo == vca.Nombre
                                select cr.PaginaCat).FirstOrDefault();
                    stpags = stpags + pag + "/";
                }
            }
            return stpags;
        }

        private object getCatReferencias(List<VinculoCatalogos> catalogos)
        {
            string strefs = "";
            foreach (VinculoCatalogos vca in catalogos)
            {
                foreach (vinculoCatalogoReferencia item in vca.Referencias)
                {
                    var cref = (from cr in ReferenciaCatalogo.GetReferencias()
                                where cr.Catalogo == vca.Nombre
                                select cr.Referencia).FirstOrDefault();
                    strefs = strefs + cref + "/";
                }                
            }
            return strefs;
        }

        private object getCatNombres(List<VinculoCatalogos> catalogos)
        {
            string stcats = "";
            foreach (VinculoCatalogos vce in catalogos)
            {
                var cat = (from ca in CatalogoProductos.getCatalogos()
                           where ca.Id == vce.Nombre
                           select ca.Nombre).FirstOrDefault();
                stcats = stcats + cat + "/";
            }
            return stcats;
        }

        private object getCertPorcent(List<VinculoCertificados> certificados)
        {
            foreach (VinculoCertificados vre in certificados)
            {
                var cert = (from re in CertificadoCalidad.GetCertificados()
                           where re.Id == vre.Nombre
                           select re.Vencimiento).FirstOrDefault();
                if (cert > DateTime.Today.AddDays(-150))
                    return 1;
            }
            return 0;
        }

        private object getCeIsoVencimientos(List<VinculoCertificados> certificados)
        {
            string stvencimientos = "";
            foreach (VinculoCertificados vce in certificados)
            {
                var cert = (from ce in CertificadoCalidad.GetCertificados()
                            where ce.Id == vce.Nombre && ce.Tipo != "FDA"
                            select ce.Vencimiento).FirstOrDefault();
                stvencimientos = stvencimientos + cert + "/";
            }
            return stvencimientos;
        }

        private object getCeIso(List<VinculoCertificados> certificados)
        {
            string stcert = "";
            foreach (VinculoCertificados vce in certificados)
            {
                var cert = (from ce in CertificadoCalidad.GetCertificados()
                            where ce.Id == vce.Nombre && ce.Tipo != "FDA"
                            select ce.Nombre).FirstOrDefault();
                stcert = stcert + cert + "/";
            }
            return stcert;
        }

        private object getCfsFdaVencimientos(List<VinculoCertificados> certificados)
        {
            string stvencimientos = "";
            foreach (VinculoCertificados vce in certificados)
            {
                var cert = (from ce in CertificadoCalidad.GetCertificados()
                            where ce.Id == vce.Nombre && ce.Tipo == "FDA"
                            select ce.Vencimiento).FirstOrDefault();
                stvencimientos = stvencimientos + cert + "/";
            }
            return stvencimientos;
        }

        private object getCfsFda(List<VinculoCertificados> certificados)
        {
            string stcert = "";
            foreach (VinculoCertificados vce in certificados)
            {
                var cert = (from ce in CertificadoCalidad.GetCertificados()
                            where ce.Id == vce.Nombre && ce.Tipo == "FDA"
                           select ce.Nombre).FirstOrDefault();
                stcert = stcert + cert + "/";
            }
            return stcert;
        }

        private object getRegPorcent(List<VinculoRegistros> registros)
        {            
            foreach (VinculoRegistros vre in registros)
            {
                var reg = (from re in RegistroSanitario.GetRegistros()
                           where re.Id == vre.Nombre
                           select re).First();
                if (reg.Vencimiento > DateTime.Today.AddDays(-150))
                    return 1;
            }
            return 0;
        }

        private object getRegVencimientos(List<VinculoRegistros> registros)
        {
            string stvencimientos = "";
            foreach (VinculoRegistros vre in registros)
            {
                var reg = (from re in RegistroSanitario.GetRegistros()
                           where re.Id == vre.Nombre
                           select re).First();
                stvencimientos = stvencimientos + reg.Vencimiento + "/";
            }
            return stvencimientos;
        }

        private object getRegistros(List<VinculoRegistros> registros)
        {
            string stregistros = "";
            foreach (VinculoRegistros vre in registros)
            {
                var reg = (from re in RegistroSanitario.GetRegistros()
                            where re.Id == vre.Nombre
                            select re).First();
                stregistros = stregistros + reg.Nombre + "/";
            }
            return stregistros;
        }
            

        private object getTratados(int vinc)
        {
            string tratados = "";
            var vc = from v in CucopVinculos.GetVinculaciones()
                     where v.Id == vinc
                     select v;
            foreach (VinculoRegistros vre in vc.Single().Registros)
            {
                var pais = (from re in RegistroSanitario.GetRegistros()
                            where re.Id == vre.Nombre
                            select re).First().Pais;
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT * FROM paises_origen WHERE id_pais = " + pais;
                        using (SqlDataAdapter adapt = new SqlDataAdapter())
                        {
                            adapt.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                adapt.Fill(dt);
                                tratados = tratados + dt.Rows[0]["tratado de comercio"].ToString() + "/";
                            }
                        }
                    }
                }
            }
            return tratados;
        }

        private object getPaises(int vinc)
        {
            string paises = "";
            var vc = from v in CucopVinculos.GetVinculaciones()
                     where v.Id == vinc
                     select v;
            foreach (VinculoRegistros vre in vc.Single().Registros)
            {
                var pais = (from re in RegistroSanitario.GetRegistros()
                             where re.Id == vre.Nombre
                             select re).First().Pais;
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT * FROM paises_origen WHERE id_pais = " + pais;
                        using (SqlDataAdapter adapt = new SqlDataAdapter())
                        {
                            adapt.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                adapt.Fill(dt);
                                paises = paises + dt.Rows[0]["nombre"].ToString() +"/";
                            }
                        }
                    }
                }
            }
            return paises;
        }

        private object getMarcas(int vinc)
        {
            string marcas = "";
            var vc = from v in CucopVinculos.GetVinculaciones()
                       where v.Id == vinc select v;
            foreach (VinculoRegistros vre in vc.Single().Registros)
            {
                var marca = (from re in RegistroSanitario.GetRegistros()
                          where re.Id == vre.Nombre
                          select re).First().Marca;
                marcas = marcas + marca + "/";
                
            }
            return marcas;
        }

        private object getContactos(int cartaApoyo)
        {
            string contactos = "";
            var cartas = (from ct in Carta.GetCartas()
                         where ct.Id == cartaApoyo select ct).Single();
            if (cartas.Contactos.Any())
            {
                foreach (CartaContacto item in cartas.Contactos)
                {
                    contactos += item.Nombre + " " + item.Telefono + " " + item.Correo + " " + item.Comentarios +"/";
                }
            }
            return contactos;
        }

        private object getFabricantes(int vinc)
        {
            string fabricantes = "";
            var reg = (from vc in CucopVinculos.GetVinculaciones().Where(x => x.Id == vinc)
                      from rg in vc.Registros
                      select rg).ToList();
            foreach (VinculoRegistros vre in reg)
            {
                if (RegistroSanitario.GetRegistros().Where(x => x.Id == vre.Nombre).Any())
                {
                    fabricantes += RegistroSanitario.GetRegistros().Where(x => x.Id == vre.Nombre).FirstOrDefault().Fabricante + "/";
                }
            }
            return fabricantes;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Creating a Excel object. 
            if (idLicit != 0)
            {
                var numLicit = (from bs in Licitacion.GetBases()
                               where bs.Id == idLicit
                               select bs.NumeroLicitacion).FirstOrDefault();
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add(numLicit);

                try
                {
                   

                    int cellRowIndex = 1;
                    int cellColumnIndex = 1;

                    //Loop through each row and read value from each column. 
                    for (int i = 0; i < dgvListado.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvListado.Columns.Count; j++)
                        {
                            // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                            if (cellRowIndex == 1)
                            {

                                worksheet.Cell(cellRowIndex, cellColumnIndex).Value = dgvListado.Columns[j].HeaderText;
                                worksheet.Cell(cellRowIndex, cellColumnIndex).Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
                                worksheet.Cell(cellRowIndex, cellColumnIndex).Style.Fill.BackgroundColor = XLColor.LightGreen;

                            }
                            else
                            {
                                worksheet.Cell(cellRowIndex, cellColumnIndex).Value = dgvListado.Rows[i].Cells[j].Value.ToString();
                            }
                            cellColumnIndex++;
                        }
                        cellColumnIndex = 1;
                        cellRowIndex++;
                    }

                    //Getting the location and file name of the excel to save from user. 
                    FolderBrowserDialog svg = new FolderBrowserDialog();
                    if (svg.ShowDialog() == DialogResult.OK)
                    {
                        worksheet.Rows().AdjustToContents();
                        worksheet.Columns().Width = 15;
                        worksheet.Style.Alignment.WrapText = true;
                        workbook.SaveAs(svg.SelectedPath + @"\"+ numLicit + ".xlsx");
                        MessageBox.Show("Export Successful");
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            } 
        }
    }    
}
