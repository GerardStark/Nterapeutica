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
    public partial class Reporte_InfoLicitacion : UserControl
    {
        MainConfig mc = new MainConfig();
        int idLicit = 0;
        public Reporte_InfoLicitacion()
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

        private void Reporte_InfoLicitacion_Load(object sender, EventArgs e)
        {
            radAct.Checked = true;
        }

        private void cmbNumLicit_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idlicit = Convert.ToInt32((cmbNumLicit.SelectedItem as ComboboxItem).Value);
            mostrarInfoBases(idlicit);
        }

        public void mostrarInfoBases(int idLicitacion)
        {
            this.idLicit = idLicitacion;
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM licitacion_bases WHERE id_bases = @idBases", con))
                {
                    cmd.Parameters.AddWithValue("@idBases", idLicitacion);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        
                        lbl_numero.Text = dt.Rows[0]["numero_licitacion"].ToString();
                        lbl_unidad.Text = dt.Rows[0]["unidad_compradora"].ToString();
                        lbl_entidad.Text = obtenerNombreEntidadFederativa((Int32)dt.Rows[0]["entidad_federativa"]);//obtener texto                                                          
                        lbl_tipocontrato.Text = dt.Rows[0]["tipo_contratacion"].ToString();
                        lbl_durcontrato.Text = dt.Rows[0]["duracion_contrato"].ToString();
                        lbl_numexped.Text = dt.Rows[0]["expediente"].ToString();
                        lbl_tipoexp.Text = obtenerTipoExpediente((Int32)dt.Rows[0]["tipo_expediente"]);//obtener texto
                        lbl_operador.Text = dt.Rows[0]["operador_nombre"].ToString();
                        lbl_correo.Text = dt.Rows[0]["operador_correo"].ToString();
                        lbl_desc.Text = dt.Rows[0]["descripcion"].ToString();                       
                        obtenercalendario(idLicitacion);
                    }
                }
            }
        }
        public void obtenercalendario(int idlicit)
        {
            var bases = Licitacion.GetBases().Where(x => x.Id == idlicit).Single();
            var c = bases.Calendarios.Single();
            lblCnet.Text = c.Publicacion.ToString();
            lblDof.Text = c.PublicacionDof.ToString();
            lblJA.Text = c.Junta.ToString();
            lblApertura.Text = c.Apertura.ToString();
            lblFallo.Text = c.Fallo.ToString();
            lblFirma.Text = c.Firma.ToString();
            lblVisita.Text = c.Visita.ToString();
            lblMuestras.Text = c.Muestras.ToString();

            PropertyInfo[] p = c.GetType().GetProperties();
            for (int i = 2; i < p.Length - 2; i++)
            {


                if ((DateTime)p[i].GetValue(c) == DateTimePicker.MinimumDateTime)
                {
                    switch (p[i].Name)
                    {
                        case "Publicacion":
                            lblCnet.Text = "No aplica";
                            break;
                        case "PublicacionDof":
                            lblDof.Text = "No aplica";
                            break;
                        case "Junta":
                            lblJA.Text = "No aplica";
                            break;
                        case "Apertura":
                            lblApertura.Text = "No aplica";
                            break;
                        case "Fallo":
                            lblFallo.Text = "No aplica";
                            break;
                        case "Firma":
                            lblFirma.Text = "No aplica";
                            break;
                        case "Visita":
                            lblVisita.Text = "No aplica";
                            break;
                    }
                }
            }


        }
        private string obtenerNombreEntidadFederativa(int id)
        {
            string nombre = "";
            if (id != 0)
            {
                SqlConnection conec = new SqlConnection(mc.con);
                conec.Open();
                SqlCommand cmd = new SqlCommand("Select * from aux_entidades_federativas where id=@id", conec);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds, "entidades");
                conec.Close();
                if (ds.Tables["entidades"].Rows.Count > 0)
                {
                    nombre = ds.Tables["entidades"].Rows[0]["nombre_estado"].ToString();
                }
                else
                {
                    nombre = "(Vacio)";
                }
            }
            else
            {
                nombre = "(Vacio)";
            }
            return nombre;
        }

        private string obtenerTipoExpediente(int id)
        {
            string nombre = "";
            if (id != 0)
            {
                SqlConnection conec = new SqlConnection(mc.con);
                conec.Open();
                SqlCommand cmd = new SqlCommand("Select * from aux_tipos_expediente where id=@id", conec);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds, "expedientes");
                conec.Close();
                if (ds.Tables["expedientes"].Rows.Count > 0)
                {
                    nombre = ds.Tables["expedientes"].Rows[0]["tipo_expediente"].ToString();
                }
                else
                {
                    nombre = "(Vacio)";
                }
            }
            else
            {
                nombre = "(Vacio)";
            }
            return nombre;
        }

        private void imprimir(object sender, EventArgs e)
        {
            Licitacion licit = Licitacion.GetBases().FirstOrDefault(x => x.Id == idLicit);
            FolderBrowserDialog svg = new FolderBrowserDialog();
            
            svg.ShowDialog();

            using (MemoryStream myMemoryStream = new MemoryStream())
            {
                Document myDocument = new Document();
                PdfWriter myPDFWriter = PdfWriter.GetInstance(myDocument, myMemoryStream);
                myDocument.Open();
                //creacion del header
                Paragraph header = new Paragraph("Informacion de la licitacion");
                header.Alignment = Element.ALIGN_CENTER;
                myDocument.Add(header);

                //agregando contenido

                myDocument.Add(new Paragraph("# de Licitacion: \t" + lbl_numero.Text));
                myDocument.Add(new Paragraph("Unidad Compradora: \t" + lbl_unidad.Text));
                myDocument.Add(new Paragraph("Entidad Federativa: v" + lbl_entidad.Text));
                myDocument.Add(new Paragraph("Tipo de Contrato: \t" + lbl_tipocontrato.Text));
                myDocument.Add(new Paragraph("Duracion del Contrato: \t" + lbl_durcontrato.Text));
                myDocument.Add(new Paragraph("# de Expediente: \t" + lbl_numexped.Text));
                myDocument.Add(new Paragraph("Tipo de Expediente: \t" + lbl_tipoexp.Text));
                myDocument.Add(new Paragraph("Nombre del Operador: \t" + lbl_operador.Text));
                myDocument.Add(new Paragraph("Correo del Operador: \t" + lbl_correo.Text));
                myDocument.Add(new Paragraph("Descripcion: \t" + lbl_desc.Text));
                myDocument.Add(new Paragraph("Publicacion en Compranet: \t" + lblCnet.Text));
                myDocument.Add(new Paragraph("Publicacion en el DOF: \t" + lblDof.Text));
                myDocument.Add(new Paragraph("Primera Junta de Aclaraciones: \t" + lblJA.Text));
                myDocument.Add(new Paragraph("Apertura de Propuestas: \t" + lblApertura.Text));
                myDocument.Add(new Paragraph("Emision del Acta de Fallo: \t" + lblFallo.Text));
                myDocument.Add(new Paragraph("Firma del Contrato: \t" + lblFirma.Text));
                myDocument.Add(new Paragraph("Visita a Instalaciones: \t" + lblVisita.Text));
                myDocument.Add(new Paragraph("Entrega de Muestras: \t" + lblMuestras.Text));
                if (chkTec.Checked == true)
                {
                    int partidas = 0;
                    int items = 0;
                    int itemsRe = 0;
                    int itemsCa = 0;
                    int itemsCe = 0;
                    foreach (Partida par in licit.Partidas)
                    {
                        partidas++;
                        foreach (Procedimiento pro in par.Procedimientos)
                        {
                            items = items + pro.Items.Count;
                            foreach (Item item in pro.Items)
                            {
                                foreach (CucopVinculos cv in item.Vinculos)
                                {
                                    if (cv.Registros.Any())
                                    {
                                        itemsRe++;
                                    }

                                    if (cv.Catalogos.Any())
                                    {
                                        itemsCa++;
                                    }

                                    if (cv.Certificados.Any())
                                    {
                                        itemsCe++;
                                    }
                                }
                            }
                        }

                    }
                    myDocument.Add(new Paragraph("Total de Partidas:" + partidas));
                    myDocument.Add(new Paragraph("Total de Items en las partidas: " + items));
                    myDocument.Add(new Paragraph("Total de Items Sin Registro Sanitario: \t" + (items - itemsRe)));
                    myDocument.Add(new Paragraph("Total de Items Sin Catálogos de Productos: \t" + (items - itemsCa)));
                    myDocument.Add(new Paragraph("Total de Items Sin Certificado de Calidad: \t" + (items - itemsCe)));

                }
                myDocument.Close();

                byte[] content = myMemoryStream.ToArray();

                // Write out PDF from memory stream.//error
                string finaldest = svg.SelectedPath + @"\Reporte de Datos de " + licit.NumeroLicitacion + ".pdf";
                using (FileStream fs = File.Create(finaldest))
                {
                    fs.Write(content, 0, (int)content.Length);
                    MessageBox.Show("Guardado");
                }            
            }
        }       
    }
}
