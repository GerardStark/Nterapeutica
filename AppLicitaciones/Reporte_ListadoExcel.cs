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
    public partial class Reporte_ListadoExcel : UserControl
    {
        MainConfig mc = new MainConfig();
        int idLicit = 0;
        public Reporte_ListadoExcel()
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

        private void Reporte_ListadoExcel_Load(object sender, EventArgs e)
        {
            radAct.Checked = true;
        }

        private void cmbNumLicit_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                    vinc.CartaApoyo,
                    Carta.GetCartas().Where(x => x.Id == vinc.CartaApoyo).FirstOrDefault().RFC,
                    Carta.GetCartas().Where(x => x.Id == vinc.CartaApoyo).FirstOrDefault().Apoyo,
                    Carta.GetCartas().Where(x => x.Id == vinc.CartaApoyo).FirstOrDefault().Mayorista,
                    getFabricantes(vinc.Id),
                    getContactos(vinc.CartaApoyo),
                    //getMarcas(vinc.Id),                    
                    //getPaises(vinc.Id),
                    //getTratados(vinc.Id),
                    vinc.Nombre,
                    //getRegistros(vinc.Registros),
                    //getRegVencimientos(vinc.Registros),
                    //getRegPorcent(vinc.Registros),
                    //getCfsFda(vinc.Certificados),
                    //getCfsFdaVencimientos(vinc.Certificados),
                    //getCeIso(vinc.Certificados),
                    //getCeIsoVencimientos(vinc.Certificados),
                    //getCertPorcent(vinc.Certificados),
                    //getCatNombres(vinc.Catalogos),
                    //getCatReferencias(vinc.Catalogos),
                    //getCatPaginas(vinc.Catalogos),
                    //getCatPaginasPdf(vinc.Catalogos),
                    //getCatPorcent(vinc.Catalogos),
                    ""
                    //getPreguntas(vinc.Id)
                    );

                }
            
            }
        }

        private object getContactos(int cartaApoyo)
        {
            string contactos = "";
            var cartas = (from ct in Carta.GetCartas()
                         where ct.Id == cartaApoyo select ct).Single();
            foreach (CartaContacto item in cartas.Contactos)
            {
                contactos += item.Nombre + "\n" + item.Telefono + "\n" + item.Correo + "\n" + item.Comentarios;
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
                    fabricantes += "\n" + RegistroSanitario.GetRegistros().Where(x => x.Id == vre.Nombre).FirstOrDefault().Fabricante;
                }
            }
            return fabricantes;
        } 
    }

    class ObjListado
    {
        public int Consecutivo { get; set; }
        public string Procedimiento { get; set; }
        public float NumItem { get; set; }
        public string Descripcion { get; set; }
        public string Presentacion { get; set; }
        public long Cantidad { get; set; }
        public string Contenedor { get; set; }
        public long Minimo { get; set; }
        public long Maximo { get; set; }
        public string Carta { get; set; }
        public string RFC { get; set; }
        public string Apoyo { get; set; }
        public string Mayorista { get; set; }
        public string Fabricante { get; set; }
        public string Contacto { get; set; }
        public string Marca { get; set; }
        public string NombreProducto { get; set; }
        public string Pais { get; set; }
        public string Tratado { get; set; }
        public string Registro { get; set; }
        public DateTime VencimientoRegistro { get; set; }
        public int PorcentajeReg { get; set; }
        public string CertificadoCfsFda { get; set; }
        public DateTime VencimientoCfsFda { get; set; }
        public string CertificadoCeIso { get; set; }
        public DateTime VencimientoCeIso { get; set; }
        public int PorcentajeCert { get; set; }
        public string NombreCatalogo { get; set; }
        public string Referencia { get; set; }
        public string Pagina { get; set; }
        public string PaginaPdf { get; set; }
        public int ProcentajeCat { get; set; }
        public string Observaciones { get; set; }
        public string PreguntaJa { get; set; }
    }
}
