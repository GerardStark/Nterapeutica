using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibLicitacion
{
    public class CertificadoCalidad
    {
        public CertificadoCalidad()
        {

        }

        public CertificadoCalidad(int id, string numero, string tipo, string descripcion, string fabricante, DateTime emision, DateTime vencimiento, string idioma, string archivo, string traduccion, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.Nombre = numero;
            this.Tipo = tipo;
            this.Descripcion = descripcion;
            this.Fabricante = fabricante;
            this.Emision = emision;
            this.Vencimiento = vencimiento;
            this.Idioma = idioma;
            this.Archivo = archivo;
            this.Traduccion = traduccion;
            this.Created = creado;
            this.Updated = actualizado;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

        public string Nombre
        {
            get {return numero; }
            set {numero = value; }
        }

        private string numero;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private string tipo;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private string descripcion;

        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        private string fabricante;

        public DateTime Emision
        {
            get { return emision; }
            set { emision = value; }
        }

        private DateTime emision;

        public DateTime Vencimiento
        {
            get { return vencimiento; }
            set { vencimiento = value; }
        }

        private DateTime vencimiento;

        public string Idioma
        {
            get { return idioma; }
            set { idioma = value; }
        }

        private string idioma;

        public string Archivo
        {
            get { return archivo; }
            set { archivo = value; }
        }

        private string archivo;

        public string Traduccion
        {
            get { return traduccion; }
            set { traduccion = value; }
        }

        private string traduccion;

        public DateTime Created
        {
            get { return created; }
            set { created = value; }
        }

        private DateTime created;

        public DateTime Updated
        {
            get { return updated; }
            set { updated = value; }
        }

        private DateTime updated;

        //llenado de los certificados
        public static List<CertificadoCalidad> GetCertificados()
        {
            CertificadoCalidad.AllCertificados.Clear();
            if (CertificadoCalidad.AllCertificados.Count == 0)
                CertificadoCalidad.AllCertificados = CertificadoCalidad.InicializarCertificados();
            return CertificadoCalidad.AllCertificados;
        }

        private static List<CertificadoCalidad> InicializarCertificados()
        {
            List<CertificadoCalidad> certificados = new List<CertificadoCalidad>();
            MainConfig mc = new MainConfig();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM certificados_calidad", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            CertificadoCalidad c = new CertificadoCalidad();
                            c.Id = Convert.ToInt32(dr["id_certificado"]);
                            c.Nombre = dr["numero_identificador"].ToString();
                            c.Tipo = dr["tipo"].ToString();
                            c.Descripcion = dr["descripcion_detallada"].ToString();
                            c.Fabricante = dr["fabricante"].ToString();                            
                            c.Emision = Convert.ToDateTime(dr["fecha_emision"]);
                            c.Vencimiento = Convert.ToDateTime(dr["fecha_vencimiento"]);
                            c.Idioma = dr["idioma"].ToString();
                            c.Archivo = dr["dir_archivo"].ToString();
                            c.Traduccion = dr["dir_archivo_traduccion"].ToString();
                            c.Created = Convert.ToDateTime(dr["creado_en"]);
                            c.Updated = Convert.ToDateTime(dr["actualizado_en"]);
                            certificados.Add(c);
                        }
                    }

                }
            }
            return certificados;
        }

        private static List<CertificadoCalidad> AllCertificados = new List<CertificadoCalidad>();

        static public List<CertificadoCalidad> GetVencidos()
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<CertificadoCalidad> vencidos = new List<CertificadoCalidad>();
            foreach (CertificadoCalidad r in CertificadoCalidad.GetCertificados())
            {
                if (r.vencimiento <= DateTime.Today && !yaAgregado.ContainsKey(r.Id))
                {
                    yaAgregado[r.Id] = true;
                    vencidos.Add(r);
                }
            }
            return vencidos;
        }
    }
}
