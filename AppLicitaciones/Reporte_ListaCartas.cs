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
using BrightIdeasSoftware;

namespace AppLicitaciones
{
    public partial class Reporte_ListaCartas : UserControl
    {
        MainConfig mc = new MainConfig();
        int idLicit = 0;
        List<string> datos = new List<string>();
        public Reporte_ListaCartas()
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

        private void Reporte_ListaCartas_Load(object sender, EventArgs e)
        {
            radAct.Checked = true;         
        }

        private void cmbNumLicit_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idlicit = Convert.ToInt32((cmbNumLicit.SelectedItem as ComboboxItem).Value);
            mostrarCartasDeApoyo(idlicit);
        }

        public void mostrarCartasDeApoyo(int idLicitacion)
        {
            
            
            this.idLicit = idLicitacion;
            this.tlvCartas.CanExpandGetter = delegate (Object x)
            {
                return (x is Carta);
            };

            this.tlvCartas.ChildrenGetter = delegate (Object x)
            {
                if (x is Carta)
                    return ((Carta)x).ItemsPorLicitacion(idLicitacion);
                throw new ArgumentException("Error");
            };
            var vinculos = Licitacion.GetBases().FirstOrDefault(x => x.Id == idLicitacion).Partidas.SelectMany(x => x.Procedimientos).SelectMany(x => x.Items).SelectMany(x => x.Vinculos).ToList();
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
            this.tlvCartas.SetObjects(cartas);
        }       

        private void imprimir(object sender, EventArgs e)
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
                    PdfPTable table = new PdfPTable(9);
                    
                    table.TotalWidth = 500f;
                    table.LockedWidth = true;
                    table.HorizontalAlignment = 0;
                    float[] widths = new float[] { 20f, 20f, 20f, 100f, 20f, 20f, 20f, 20f ,20f};
                    table.SetWidths(widths);
                    PdfPCell numlicit = new PdfPCell(new Phrase(licit.NumeroLicitacion));
                    numlicit.Colspan = 9;
                    numlicit.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                    table.AddCell(numlicit);
                    table.AddCell(new Phrase("Partida", times));
                    table.AddCell(new Phrase("Procedimiento", times));
                    table.AddCell(new Phrase("Clave", times));
                    table.AddCell(new Phrase("Descripcion", times));
                    table.AddCell(new Phrase("Presentacion", times));
                    table.AddCell(new Phrase("Cantidad", times));
                    table.AddCell(new Phrase("Contenedor", times));
                    table.AddCell(new Phrase("Minimo", times));
                    table.AddCell(new Phrase("Maximo", times));
                                    
                    foreach (Item item in c.ItemsPorLicitacion(idLicit))
                    {
                        var partida = Procedimiento.GetProcedimientos().Where(x => x.Id == item.Procedimiento).Single().Partida;
                        //var partida = Partida.GetPartidasPorBase(idLicit).SelectMany(x => x.Procedimientos)
                        table.AddCell(new Phrase(Partida.GetPartidas().Where(x => x.Id == partida).Single().Numero.ToString(), times));
                        table.AddCell(new Phrase(Procedimiento.GetProcedimientos().Where(x => x.Id == item.Procedimiento).Single().Nombre, times));
                        table.AddCell(new Phrase(item.Ccb, times));
                        table.AddCell(new Phrase(item.Nombre, times));
                        table.AddCell(new Phrase(item.Unidad, times));
                        table.AddCell(new Phrase(item.Cantidad.ToString(), times));
                        table.AddCell(new Phrase(item.Contenedor, times));
                        table.AddCell(new Phrase(item.Minimo.ToString(), times));
                        table.AddCell(new Phrase(item.Maximo.ToString(), times));
                       
                    }
                    myDocument.Add(table);
                    myDocument.Close();

                    byte[] content = myMemoryStream.ToArray();

                    // Write out PDF from memory stream.//error
                    string finaldest = svg.SelectedPath + @"\Reporte de Cartas de Apoyo de " +c.Nombre+" en "+ licit.NumeroLicitacion + ".pdf";
                    using (FileStream fs = File.Create(finaldest))
                    {
                        fs.Write(content, 0, (int)content.Length);
                       
                    }
                }

            }
            MessageBox.Show("Guardado");

        }

        private void datosChecados(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk.Checked == true)
            {
                datos.Add(chk.Text);
            }
            else
            {
                datos.Remove(chk.Text);
            }
        }
    }
}
