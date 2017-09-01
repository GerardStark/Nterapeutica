using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibLicitacion
{
    public class RegistroSanitario
    {
        public RegistroSanitario()
        {

        }

        public RegistroSanitario(int id, string numero, string solicitud, string titular, string rfc, string distintiva, string generica, string fabricante,
            string marca, int pais,DateTime emision, DateTime vencimiento, string archivo, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.Numero = numero;
            this.Solicitud = solicitud;
            this.Titular = titular;
            this.RFC = rfc;
            this.Distintiva = distintiva;
            this.Generica = generica;
            this.Fabricante = fabricante;
            this.Marca = marca;
            this.Pais = pais;
            this.Emision = emision;
            this.Vencimiento = vencimiento;
            this.Archivo = archivo;
            this.Created = creado;
            this.Updated = actualizado;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string numero;

        public string Solicitud
        {
            get { return solicitud; }
            set { solicitud = value; }
        }

        private string solicitud;

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        private string titular;

        public string RFC
        {
            get { return rfc; }
            set { rfc = value; }
        }

        private string rfc;

        public string Distintiva
        {
            get { return distintiva; }
            set { distintiva = value; }
        }

        private string distintiva;

        public string Generica
        {
            get { return generica; }
            set { generica = value; }
        }

        private string generica;

        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        private string fabricante;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string marca;

        public int Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        private int pais;

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

        public string Archivo
        {
            get { return archivo; }
            set { archivo = value; }
        }

        private string archivo;

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

        //llenado de los cucops
        public static List<RegistroSanitario> GetRegistros()
        {
            RegistroSanitario.AllRegistros.Clear();
            if (RegistroSanitario.AllRegistros.Count == 0)
                RegistroSanitario.AllRegistros = RegistroSanitario.InicializarRegistros();
            return RegistroSanitario.AllRegistros;
        }

        private static List<RegistroSanitario> InicializarRegistros()
        {
            List<RegistroSanitario> registros = new List<RegistroSanitario>();
            MainConfig mc = new MainConfig();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM registros_sanitarios", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            RegistroSanitario c = new RegistroSanitario();
                            c.Id = Convert.ToInt32(dr["id_cucop"]);
                            c.Numero = dr["numero_registro"].ToString();
                            c.Solicitud = dr["numero_solicitud"].ToString();
                            c.Titular = dr["titular"].ToString();
                            c.RFC = dr["rfc"].ToString();
                            c.Distintiva = dr["denom_distintiva"].ToString();
                            c.Generica = dr["denom_generica"].ToString();
                            c.Fabricante = dr["fabricante"].ToString();
                            c.Marca = dr["marca"].ToString();
                            c.Pais = Convert.ToInt32(dr["pais_origen"]);
                            c.Emision = Convert.ToDateTime(dr["fecha_emision"]);
                            c.Vencimiento = Convert.ToDateTime(dr["fecha_vencimiento"]);
                            c.Archivo = dr["dir_archivo"].ToString();
                            c.Created = Convert.ToDateTime(dr["creado_en"]);
                            c.Updated = Convert.ToDateTime(dr["actualizado_en"]);
                            registros.Add(c);
                        }
                    }

                }
            }
            return registros;
        }

        private static List<RegistroSanitario> AllRegistros = new List<RegistroSanitario>();

        public List<ReferenciaRegistro> Referencias
        {
            get
            {
                if (this.id != 0)
                    this.referencias = ReferenciaRegistro.GetReferenciasPorRegistro(this.id);
                return this.referencias;
            }
        }

        private List<ReferenciaRegistro> referencias;
    }

    public class ReferenciaRegistro
    {
        public ReferenciaRegistro()
        {

        }

        public ReferenciaRegistro(int id, int registro, string clave, string descripcion, string unidad, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.Registro = registro;
            this.Clave = clave;
            this.Descripcion = descripcion;
            this.Unidad = unidad;
            this.Created = creado;
            this.Updated = actualizado;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

        public int Registro
        {
            get { return registro; }
            set { registro = value; }
        }

        private int registro;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        private string clave;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private string descripcion;

        public string Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }

        private string unidad;

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

        static public List<ReferenciaRegistro> GetReferencias()
        {
            ReferenciaRegistro.AllReferencias.Clear();
            if (ReferenciaRegistro.AllReferencias.Count == 0)
                ReferenciaRegistro.AllReferencias = ReferenciaRegistro.InicializarReferencias();
            return ReferenciaRegistro.AllReferencias;
        }

        //crea el objeto con las vinculaciones 
        //llenar con un query
        static private List<ReferenciaRegistro> InicializarReferencias()
        {
            MainConfig mc = new MainConfig();
            List<ReferenciaRegistro> referencias = new List<ReferenciaRegistro>();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM registros_claves_referencias", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            ReferenciaRegistro r = new ReferenciaRegistro();
                            r.Id = (Int32)dr["id_vinculacion"];
                            r.Registro = (Int32)dr["id_registro_sanitario"];
                            r.Clave = dr["clave_ref_cod"].ToString();
                            r.Descripcion = dr["descripcion"].ToString();
                            r.Unidad = dr["unidad_venta"].ToString();
                            r.Created = (DateTime)dr["creado_en"];
                            r.Updated = (DateTime)dr["actualizado_en"];
                            referencias.Add(r);
                        }
                    }
                }
            }
            return referencias;
        }

        //objeto donde se almacenan las vinculaciones
        static private List<ReferenciaRegistro> AllReferencias = new List<ReferenciaRegistro>();

        //obtener los items del vinculos de los cucop (opciones)

        //obtener vinculos por cucop
        static public List<ReferenciaRegistro> GetReferenciasPorRegistro(int reg)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<ReferenciaRegistro> referencias = new List<ReferenciaRegistro>();
            foreach (ReferenciaRegistro r in ReferenciaRegistro.GetReferencias())
            {
                if (r.Registro == reg && !yaAgregado.ContainsKey(r.Id))
                {
                    yaAgregado[r.Id] = true;
                    referencias.Add(new ReferenciaRegistro(r.Id, r.Registro, r.Clave, r.Descripcion, r.Unidad, r.Created, r.Updated));
                }
            }
            return referencias;
        }
    }
}
