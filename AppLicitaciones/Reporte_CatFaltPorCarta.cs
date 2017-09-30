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
    public partial class Reporte_CatFaltPorCarta : UserControl
    {
        MainConfig mc = new MainConfig();
        int idLicit = 0;
        public Reporte_CatFaltPorCarta()
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

        private void Reporte_CatFaltPorCarta_Load(object sender, EventArgs e)
        {
            radAct.Checked = true;
        }

        private void cmbNumLicit_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idlicit = Convert.ToInt32((cmbNumLicit.SelectedItem as ComboboxItem).Value);
            mostrarCatalogosFaltantes(idlicit);
        }

        private void mostrarCatalogosFaltantes(int idBases)
        {
            DateTime fechaOptima = DateTime.Today.AddDays(-60);
            this.idLicit = idBases;
            this.tlvReg.CanExpandGetter = delegate (Object x)
            {
                return (x is Carta) || (x is Item) || (x is CucopVinculos) || (x is VinculoCatalogos);
            };

            this.tlvReg.ChildrenGetter = delegate (Object x)
            {
                if (x is Carta)
                    return ((Carta)x).ItemsPorLicitacion(idBases);
                if (x is Item)
                    return ((Item)x).Vinculos;
                if (x is CucopVinculos)
                    return ((CucopVinculos)x).Catalogos;
                if (x is VinculoCatalogos)
                    return CatalogoProductos.getCatalogos().Where(y => y.Id == ((VinculoCatalogos)x).Nombre);
                throw new ArgumentException("Error");
            };
            var vinculos = Licitacion.GetBases().FirstOrDefault(x => x.Id == idBases).Partidas.SelectMany(x => x.Procedimientos).SelectMany(x => x.Items).SelectMany(x => x.Vinculos).ToList();
            List<Int32> idCartas = new List<Int32>();
            foreach (CucopVinculos vinc in vinculos)
            {
                idCartas.Add(vinc.CartaApoyo);

            }
            List<Int32> unicas = idCartas.Distinct().ToList();
            List<Carta> cartas = new List<Carta>();
            foreach (int i in unicas)
            {
                if (Carta.GetCartas().Where(x => x.Id.Equals(i)).Any())
                {
                    cartas.Add(Carta.GetCartas().Where(x => x.Id.Equals(i)).Single());
                }
            }
            this.tlvReg.SetObjects(cartas);
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            Licitacion licit = Licitacion.GetBases().FirstOrDefault(x => x.Id == idLicit);
            FolderBrowserDialog svg = new FolderBrowserDialog();

            svg.ShowDialog();

            var vinculos = Licitacion.GetBases().FirstOrDefault(x => x.Id == idLicit).Partidas.SelectMany(x => x.Procedimientos).SelectMany(x => x.Items).SelectMany(x => x.Vinculos).ToList();
            List<Int32> idCartas = new List<Int32>();
            foreach (CucopVinculos vinc in vinculos)
            {
                idCartas.Add(vinc.CartaApoyo);

            }
            List<Int32> unicas = idCartas.Distinct().ToList();
            List<Carta> cartas = new List<Carta>();
            foreach (int i in unicas)
            {
                if (Carta.GetCartas().Where(x => x.Id.Equals(i)).Any())
                {
                    cartas.Add(Carta.GetCartas().Where(x => x.Id.Equals(i)).Single());
                }
            }
            foreach (Carta c in cartas)
            {
                using (MemoryStream myMemoryStream = new MemoryStream())
                {
                    BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font times = new iTextSharp.text.Font(bfTimes, 8);
                    Document myDocument = new Document();
                    PdfWriter myPDFWriter = PdfWriter.GetInstance(myDocument, myMemoryStream);
                    myDocument.Open();
                    //creacion del header
                    Paragraph header = new Paragraph("Listado de items de: " + c.Nombre, times);
                    header.Alignment = Element.ALIGN_CENTER;
                    myDocument.Add(header);
                    myDocument.Add(new Phrase("\n"));
                    PdfPTable table = new PdfPTable(4);

                    table.TotalWidth = 500f;
                    table.LockedWidth = true;
                    table.HorizontalAlignment = 0;
                    float[] widths = new float[] { 100f, 20f, 20f, 20f };
                    table.SetWidths(widths);
                    PdfPCell numlicit = new PdfPCell(new Phrase(licit.NumeroLicitacion));
                    numlicit.Colspan = 4;
                    numlicit.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                    table.AddCell(numlicit);
                    table.AddCell(new Phrase("Descripcion", times));
                    table.AddCell(new Phrase("Registro", times));
                    table.AddCell(new Phrase("Fabricante", times));
                    table.AddCell(new Phrase("Referencias", times));

                    foreach (Item item in c.ItemsPorLicitacion(idLicit))
                    {
                        string catalogos = "";                       
                        string referencias = "";
                        foreach (CucopVinculos cu in item.Vinculos)
                        {
                            if (!cu.Catalogos.Any())
                            {
                                catalogos = "No tiene Catalogos";
                                referencias = "No tiene Referencias";
                            }
                        }
                        table.AddCell(new Phrase(item.Nombre, times));
                        table.AddCell(new Phrase(catalogos, times));                        
                        table.AddCell(new Phrase(c.Nombre, times));
                        table.AddCell(new Phrase(referencias, times));
                    }
                    myDocument.Add(table);
                    myDocument.Close();

                    byte[] content = myMemoryStream.ToArray();

                    // Write out PDF from memory stream.//error
                    string finaldest = svg.SelectedPath + @"\Reporte de Catalogos faltantes de " + c.Nombre + " en " + licit.NumeroLicitacion + ".pdf";
                    using (FileStream fs = File.Create(finaldest))
                    {
                        fs.Write(content, 0, (int)content.Length);
                    }
                }

            }
            MessageBox.Show("Guardado");
        }
    
    }
}
