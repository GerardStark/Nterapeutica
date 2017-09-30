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

namespace AppLicitaciones
{
    public partial class Reporte_Referencias : UserControl
    {
        MainConfig mc = new MainConfig();
        int idLicit = 0;
        public Reporte_Referencias()
        {
            InitializeComponent();
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
                    if (bases[i].Calendarios.Single().Firma > DateTime.Today)
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
                    if (bases[i].Calendarios.Single().Firma < DateTime.Today)
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = bases[i].NumeroLicitacion;
                        item.Value = bases[i].Id;
                        cmbNumLicit.Items.Add(item);
                    }
                }
            }
        }

        private void Reporte_Referencias_Load(object sender, EventArgs e)
        {
            radAct.Checked = true;
        }

        private void cmbNumLicit_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idlicit = Convert.ToInt32((cmbNumLicit.SelectedItem as ComboboxItem).Value);
            mostrarAvanceTecnico(idlicit);
        }

        public void mostrarAvanceTecnico(int idBases)
        {
            this.idLicit = idBases;
            this.tlvReg.CanExpandGetter = delegate (Object x)
            {
                return (x is Partida)
                || (x is Procedimiento)
                || (x is Item)
                || (x is CucopVinculos);
                
            };

            this.tlvReg.ChildrenGetter = delegate (Object x)
            {
                if (x is Partida)
                    return ((Partida)x).Procedimientos;
                if (x is Procedimiento)
                    return ((Procedimiento)x).Items;
                if (x is Item)
                    return ((Item)x).Vinculos;
                if (x is CucopVinculos)
                    return ((CucopVinculos)x).Registros;
                throw new ArgumentException("Error");
            };
            
            this.tlvReg.SetObjects(Partida.GetPartidasPorBase(idBases));

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            if (idLicit != 0)
            {
                Licitacion licit = Licitacion.GetBases().FirstOrDefault(x => x.Id == idLicit);
                FolderBrowserDialog svg = new FolderBrowserDialog();

                svg.ShowDialog();

                var vinculos = Licitacion.GetBases().FirstOrDefault(x => x.Id == idLicit).Partidas.SelectMany(x => x.Procedimientos).SelectMany(x => x.Items).SelectMany(x => x.Vinculos).ToList();
                var items = Licitacion.GetBases().FirstOrDefault(x => x.Id == idLicit).Partidas.SelectMany(x => x.Procedimientos).SelectMany(x => x.Items);
                List<Int32> idCartas = new List<Int32>();
                List<int> registros = new List<int>();
                List<int> catalogos = new List<int>();
                List<int> certificados = new List<int>();
                foreach (CucopVinculos vinc in vinculos)
                {
                    foreach (VinculoRegistros re in vinc.Registros)
                    {
                        registros.Add(re.Nombre);
                    }

                    foreach (VinculoCatalogos ca in vinc.Catalogos)
                    {
                        catalogos.Add(ca.Nombre);
                    }

                    foreach (VinculoCertificados ce in vinc.Certificados)
                    {
                        certificados.Add(ce.Nombre);
                    }
                }
                List<int> registrosU = registros.Distinct().ToList();
                List<int> catalogosU = catalogos.Distinct().ToList();
                List<int> certificadosU = certificados.Distinct().ToList();



                //registros
                for (int i = 0; i < registrosU.Count; i++)
                {
                    //obtener todos los vinculos de la licitacion, que contengan el id del registro sanitario, sacar los datos, copiar el archivo de RS
                    //e imprimirlos por registro,
                    int idreg = registrosU[i];
                    var vreg = (from pa in Partida.GetPartidasPorBase(idLicit)
                                from pr in pa.Procedimientos
                                from it in pr.Items
                                from cv in it.Vinculos
                                from re in cv.Registros
                                where re.Nombre == idreg
                                select re.Nombre).First();
                    var reg = RegistroSanitario.GetRegistros().Where(x => x.Id == vreg).First();
                    using (MemoryStream myMemoryStream = new MemoryStream())
                    {
                        BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                        iTextSharp.text.Font times = new iTextSharp.text.Font(bfTimes, 8);
                        Document myDocument = new Document();
                        PdfWriter myPDFWriter = PdfWriter.GetInstance(myDocument, myMemoryStream);
                        myDocument.Open();
                        //creacion del header

                        Paragraph header = new Paragraph(txtHeader.Text, times);
                        header.Alignment = Element.ALIGN_CENTER;
                        myDocument.Add(header);
                        myDocument.Add(new Phrase("\n"));
                        PdfPTable table = new PdfPTable(6);

                        table.TotalWidth = 500f;
                        table.LockedWidth = true;
                        table.HorizontalAlignment = 0;
                        float[] widths = new float[] { 20f, 20f, 100f, 20f, 20f, 20f };
                        table.SetWidths(widths);
                        PdfPCell numlicit = new PdfPCell(new Phrase(licit.NumeroLicitacion));
                        numlicit.Colspan = 6;
                        numlicit.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                        table.AddCell(numlicit);
                        table.AddCell(new Phrase("Partida", times));
                        table.AddCell(new Phrase("Clave CB", times));
                        table.AddCell(new Phrase("Descripcion", times));
                        table.AddCell(new Phrase("Presentacion", times));
                        table.AddCell(new Phrase("Cantidad", times));
                        table.AddCell(new Phrase("Contenedor", times));
                        var vinc = from pa in Partida.GetPartidasPorBase(idLicit)
                                   from pr in pa.Procedimientos
                                   from it in pr.Items
                                   from cv in it.Vinculos
                                   from re in cv.Registros
                                   where re.Nombre == idreg
                                   select cv;

                        //contenido de la tabla 
                        foreach (CucopVinculos vin in vinc)
                        {
                            table.AddCell(new Phrase((from pa in Partida.GetPartidasPorBase(idLicit)
                                                      from pr in pa.Procedimientos
                                                      from it in pr.Items
                                                      where it.Id == vin.IdItem
                                                      select pa.Numero).First().ToString(), times));
                            table.AddCell(new Phrase((from it in items
                                                      where it.Id == vin.IdItem
                                                      select it.Ccb).First().ToString(), times));
                            table.AddCell(new Phrase((from it in items
                                                      where it.Id == vin.IdItem
                                                      select it.Nombre).First().ToString(), times));
                            table.AddCell(new Phrase((from it in items
                                                      where it.Id == vin.IdItem
                                                      select it.Unidad).First().ToString(), times));
                            table.AddCell(new Phrase((from it in items
                                                      where it.Id == vin.IdItem
                                                      select it.Cantidad).First().ToString(), times));
                            table.AddCell(new Phrase((from it in items
                                                      where it.Id == vin.IdItem
                                                      select it.Contenedor).First().ToString(), times));
                        }
                        myDocument.Add(table);
                        //agregar folio
                        //myDocument.Add(new Phrase("\n"));
                        //Paragraph footer = new Paragraph(txtFolio.Text);
                        //footer.Alignment = Element.ALIGN_CENTER;
                        //myDocument.Add(footer);




                        myDocument.Close();

                        byte[] content = myMemoryStream.ToArray();

                        // Write out PDF from memory stream.//error
                        string path = svg.SelectedPath;
                        string directory = path + @"\registros\";
                        string finaldest = path + @"\registros\" + reg.Nombre + " REF.pdf";
                        if (!Directory.Exists(directory))
                            Directory.CreateDirectory(directory);
                        using (FileStream fs = File.Create(finaldest))                        {
                            fs.Write(content, 0, (int)content.Length);
                            string newpath = Path.GetDirectoryName(Application.ExecutablePath) + @"\DocumentosNT\Registros-Sanitarios\";
                            string pathanexos = newpath + "\\" + reg.Id + "\\" + reg.Archivo;
                            
                            if (!File.Exists(Path.Combine(directory, reg.Nombre + ".pdf")))
                            {
                                File.Copy(pathanexos, Path.Combine(directory, reg.Nombre + ".pdf"));
                            }
                            
                        }
                    }
                }
                MessageBox.Show("Guardado");




                //certificados
                for (int i = 0; i < certificadosU.Count; i++)
                {
                    //obtener todos los vinculos de la licitacion, que contengan el id del registro sanitario, sacar los datos, copiar el archivo de RS
                    //e imprimirlos por registro,
                    int idcer = certificadosU[i];
                    var vcer = (from pa in Partida.GetPartidasPorBase(idLicit)
                                from pr in pa.Procedimientos
                                from it in pr.Items
                                from cv in it.Vinculos
                                from ce in cv.Certificados
                                where ce.Nombre == idcer
                                select ce.Nombre).First();
                    var cer = CertificadoCalidad.GetCertificados().Where(x => x.Id == vcer).First();
                    using (MemoryStream myMemoryStream = new MemoryStream())
                    {
                        BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                        iTextSharp.text.Font times = new iTextSharp.text.Font(bfTimes, 8);
                        Document myDocument = new Document();
                        PdfWriter myPDFWriter = PdfWriter.GetInstance(myDocument, myMemoryStream);
                        myDocument.Open();
                        //creacion del header

                        Paragraph header = new Paragraph(txtHeader.Text, times);
                        header.Alignment = Element.ALIGN_CENTER;
                        myDocument.Add(header);
                        myDocument.Add(new Phrase("\n"));
                        PdfPTable table = new PdfPTable(6);

                        table.TotalWidth = 500f;
                        table.LockedWidth = true;
                        table.HorizontalAlignment = 0;
                        float[] widths = new float[] { 20f, 20f, 100f, 20f, 20f, 20f };
                        table.SetWidths(widths);
                        PdfPCell numlicit = new PdfPCell(new Phrase(licit.NumeroLicitacion));
                        numlicit.Colspan = 6;
                        numlicit.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                        table.AddCell(numlicit);
                        table.AddCell(new Phrase("Partida", times));
                        table.AddCell(new Phrase("Clave CB", times));
                        table.AddCell(new Phrase("Descripcion", times));
                        table.AddCell(new Phrase("Presentacion", times));
                        table.AddCell(new Phrase("Cantidad", times));
                        table.AddCell(new Phrase("Contenedor", times));
                        var vinc = from pa in Partida.GetPartidasPorBase(idLicit)
                                   from pr in pa.Procedimientos
                                   from it in pr.Items
                                   from cv in it.Vinculos
                                   from ce in cv.Certificados
                                   where ce.Nombre == idcer
                                   select cv;

                        //contenido de la tabla 
                        foreach (CucopVinculos vin in vinc)
                        {
                            table.AddCell(new Phrase((from pa in Partida.GetPartidasPorBase(idLicit)
                                                      from pr in pa.Procedimientos
                                                      from it in pr.Items
                                                      where it.Id == vin.IdItem
                                                      select pa.Numero).First().ToString(), times));
                            table.AddCell(new Phrase((from it in items
                                                      where it.Id == vin.IdItem
                                                      select it.Ccb).First().ToString(), times));
                            table.AddCell(new Phrase((from it in items
                                                      where it.Id == vin.IdItem
                                                      select it.Nombre).First().ToString(), times));
                            table.AddCell(new Phrase((from it in items
                                                      where it.Id == vin.IdItem
                                                      select it.Unidad).First().ToString(), times));
                            table.AddCell(new Phrase((from it in items
                                                      where it.Id == vin.IdItem
                                                      select it.Cantidad).First().ToString(), times));
                            table.AddCell(new Phrase((from it in items
                                                      where it.Id == vin.IdItem
                                                      select it.Contenedor).First().ToString(), times));
                        }
                        myDocument.Add(table);
                        //agregar folio
                        //myDocument.Add(new Phrase("\n"));
                        //Paragraph footer = new Paragraph(txtFolio.Text);
                        //footer.Alignment = Element.ALIGN_CENTER;
                        //myDocument.Add(footer);




                        myDocument.Close();

                        byte[] content = myMemoryStream.ToArray();

                        // Write out PDF from memory stream.//error
                        string directory = svg.SelectedPath + @"\certificados\";
                        string finaldest = svg.SelectedPath + @"\certificados\" + cer.Nombre + " REF.pdf";
                        if (!Directory.Exists(directory))
                            Directory.CreateDirectory(directory);
                        using (FileStream fs = File.Create(finaldest))
                        {
                            fs.Write(content, 0, (int)content.Length);
                            string newpath = Path.GetDirectoryName(Application.ExecutablePath) + @"\DocumentosNT\Certificados-Calidad\";
                            string pathanexos = newpath + "\\" + cer.Id + "\\" + cer.Archivo;                            
                            if (!File.Exists(Path.Combine(directory, cer.Nombre + ".pdf")))
                            {
                                File.Copy(pathanexos, Path.Combine(directory, cer.Nombre + ".pdf"));
                            }
                        }
                    }
                }
                MessageBox.Show("Guardado");



                //catalogos
                for (int i = 0; i < catalogosU.Count; i++)
                {
                    //obtener todos los vinculos de la licitacion, que contengan el id del registro sanitario, sacar los datos, copiar el archivo de RS
                    //e imprimirlos por registro,
                    int idcat = catalogosU[i];
                    var vcat = (from pa in Partida.GetPartidasPorBase(idLicit)
                                from pr in pa.Procedimientos
                                from it in pr.Items
                                from cv in it.Vinculos
                                from ce in cv.Catalogos
                                where ce.Nombre == idcat
                                select ce.Nombre).First();
                    var cat = CatalogoProductos.getCatalogos().Where(x => x.Id == vcat).First();
                    using (MemoryStream myMemoryStream = new MemoryStream())
                    {
                        BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                        iTextSharp.text.Font times = new iTextSharp.text.Font(bfTimes, 8);
                        Document myDocument = new Document();
                        PdfWriter myPDFWriter = PdfWriter.GetInstance(myDocument, myMemoryStream);
                        myDocument.Open();
                        //creacion del header

                        Paragraph header = new Paragraph(txtHeader.Text, times);
                        header.Alignment = Element.ALIGN_CENTER;
                        myDocument.Add(header);
                        myDocument.Add(new Phrase("\n"));
                        PdfPTable table = new PdfPTable(8);

                        table.TotalWidth = 500f;
                        table.LockedWidth = true;
                        table.HorizontalAlignment = 0;
                        float[] widths = new float[] { 20f, 20f, 100f, 20f, 20f, 20f, 20f,20f };
                        table.SetWidths(widths);
                        PdfPCell numlicit = new PdfPCell(new Phrase(licit.NumeroLicitacion));
                        numlicit.Colspan = 8;
                        numlicit.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                        table.AddCell(numlicit);
                        table.AddCell(new Phrase("Partida", times));
                        table.AddCell(new Phrase("Clave CB", times));
                        table.AddCell(new Phrase("Descripcion", times));
                        table.AddCell(new Phrase("Presentacion", times));
                        table.AddCell(new Phrase("Cantidad", times));
                        table.AddCell(new Phrase("Contenedor", times));
                        table.AddCell(new Phrase("Paginas", times));
                        table.AddCell(new Phrase("Referencias", times));
                        var vinc = from pa in Partida.GetPartidasPorBase(idLicit)
                                   from pr in pa.Procedimientos
                                   from it in pr.Items
                                   from cv in it.Vinculos
                                   from ce in cv.Catalogos
                                   where ce.Nombre == idcat
                                   select cv;

                        //contenido de la tabla 
                        foreach (CucopVinculos vin in vinc)
                        {
                            table.AddCell(new Phrase((from pa in Partida.GetPartidasPorBase(idLicit)
                                                      from pr in pa.Procedimientos
                                                      from it in pr.Items
                                                      where it.Id == vin.IdItem
                                                      select pa.Numero).First().ToString(), times));
                            table.AddCell(new Phrase((from it in items
                                                      where it.Id == vin.IdItem
                                                      select it.Ccb).First().ToString(), times));
                            table.AddCell(new Phrase((from it in items
                                                      where it.Id == vin.IdItem
                                                      select it.Nombre).First().ToString(), times));
                            table.AddCell(new Phrase((from it in items
                                                      where it.Id == vin.IdItem
                                                      select it.Unidad).First().ToString(), times));
                            table.AddCell(new Phrase((from it in items
                                                      where it.Id == vin.IdItem
                                                      select it.Cantidad).First().ToString(), times));
                            table.AddCell(new Phrase((from it in items
                                                      where it.Id == vin.IdItem
                                                      select it.Contenedor).First().ToString(), times));
                            //cat onlys
                            string referencias = "";
                            string paginas = "";
                            var refs = from ca in vin.Catalogos
                                       from rf in ca.Referencias
                                       where rf.VinculoCatalogo == ca.Id
                                       select rf;
                            foreach (vinculoCatalogoReferencia item in refs)
                            {
                                if (ReferenciaCatalogo.GetReferencias().Where(x => x.Id == item.Referencia).Any())
                                {
                                    referencias += "\n" + ReferenciaCatalogo.GetReferencias().Where(x => x.Id == item.Referencia).Single().Referencia;
                                    paginas += "\n" + ReferenciaCatalogo.GetReferencias().Where(x => x.Id == item.Referencia).Single().PaginaCat;
                                }
                            }
                            table.AddCell(new Phrase(paginas, times));
                            table.AddCell(new Phrase(referencias, times));
                        }
                        myDocument.Add(table);
                        //agregar folio
                        //myDocument.Add(new Phrase("\n"));
                        //Paragraph footer = new Paragraph(txtFolio.Text);
                        //footer.Alignment = Element.ALIGN_CENTER;
                        //myDocument.Add(footer);




                        myDocument.Close();

                        byte[] content = myMemoryStream.ToArray();

                        // Write out PDF from memory stream.//error
                        string directory = svg.SelectedPath + @"\catalogo\";
                        string finaldest = svg.SelectedPath + @"\catalogo\" + cat.Nombre + " REF.pdf";
                        if (!Directory.Exists(directory))
                            Directory.CreateDirectory(directory);
                        using (FileStream fs = File.Create(finaldest))
                        {
                            fs.Write(content, 0, (int)content.Length);
                            string newpath = Path.GetDirectoryName(Application.ExecutablePath) + @"\DocumentosNT\Catalogos-Productos\";
                            string pathanexos = newpath + "\\" + cat.Id + "\\" + cat.Archivo;                            
                            if (!File.Exists(Path.Combine(directory, cat.Nombre + ".pdf")))                            
                                File.Copy(pathanexos, Path.Combine(directory, cat.Nombre + ".pdf"));
                            
                            
                        }
                    }
                }
                MessageBox.Show("Guardado");

            }
        }
    }    
}
