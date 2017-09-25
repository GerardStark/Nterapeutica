using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using LibLicitacion;

namespace LibLicitacion
{
    public class Reporte
    {
        public abstract class FormatoReporte
        {
            public string Encabezado(string texto)
            {
                return texto;
            }
            public abstract string Contenido();
            public string Folio(string texto)
            {
                return texto;
            }
            public string Pie(string texto)
            {
                return texto;
            }            
        }

        public class InfoLicitacion : FormatoReporte
        {
            public override string Contenido()
            {
                return "Info de la Licitacion";
            }
        }

        public class AvanceLicitacion : FormatoReporte
        {
            public override string Contenido()
            {
                return "Avance de la licitacion";
            }
        }

        public class RegVenPorCarta : FormatoReporte
        {
            public override string Contenido()
            {
                return "Registros Vencidos Por Carta de Apoyo";
            }
        }

        public class RegVenGeneral : FormatoReporte
        {
            public override string Contenido()
            {
                return "Registros Vencidos de la Licitacion";
            }
        }

        public class RegXVenPorCarta : FormatoReporte
        {
            public override string Contenido()
            {
                return "Registros Por Vencer Por Carta de Apoyo";
            }
        }

        public class RegXVenGeneral : FormatoReporte
        {
            public override string Contenido()
            {
                return "Registros Por Vencer de la Licitacion";
            }
        }

        public class CatFaltPorCarta : FormatoReporte
        {
            public override string Contenido()
            {
                return "Catalogos Faltantes por Carta de Apoyo";
            }
        }

        public class CatFaltGeneral : FormatoReporte
        {
            public override string Contenido()
            {
                return "Catalogos Faltantes de la Licitacion";
            }
        }

        public class CertVenPorCart : FormatoReporte
        {
            public override string Contenido()
            {
                return "Certificados Vencidos por Carta de Apoyo";
            }
        }

        public class CertVenGeneral : FormatoReporte
        {
            public override string Contenido()
            {
                return "Certificados Vencidos de la Licitacion";
            }
        }

        public class CertXVenPorCarta : FormatoReporte
        {
            public override string Contenido()
            {
                return "Certificados Por Vencer Por Carta de Apoyo";
            }
        }

        public class CertXVenGeneral : FormatoReporte
        {
            public override string Contenido()
            {
                return "Certificados Por Vencer de la Licitacion";
            }
        }

        public class ListaCartas : FormatoReporte
        {
            public override string Contenido()
            {
                return "Lista de Cartas de Apoyo de la Licitacion";
            }
        }

        public class ReferenciasLicitacion : FormatoReporte
        {
            public override string Contenido()
            {
                return "Referencias de RECACE de la licitacion";
            }
        }


        public void crearPDF()
        {
            SaveFileDialog svg = new SaveFileDialog();
            svg.ShowDialog();

            using (MemoryStream myMemoryStream = new MemoryStream())
            {
                Document myDocument = new Document();
                PdfWriter myPDFWriter = PdfWriter.GetInstance(myDocument, myMemoryStream);

                myDocument.Open();

                // Add to content to your PDF here...
                myDocument.Add(new Paragraph("I hope this works for you."));

                // We're done adding stuff to our PDF.
                myDocument.Close();

                byte[] content = myMemoryStream.ToArray();

                // Write out PDF from memory stream.
                using (FileStream fs = File.Create(svg.FileName + ".pdf"))
                {
                    fs.Write(content, 0, (int)content.Length);
                }
            }
        }
    }
}
