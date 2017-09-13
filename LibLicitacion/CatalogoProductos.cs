using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibLicitacion
{
    public class CatalogoProductos
    {
        public CatalogoProductos()
        {

        }

        public CatalogoProductos(int id, string tipo, string nombre, int publicacion, string especialidad, string fabricante, string marca, string idioma, string archivo, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.Tipo = tipo;
            this.Nombre = nombre;
            this.Publicacion = publicacion;
            this.Especialidad = especialidad;
            this.Fabricante = fabricante;
            this.Marca = marca;
            this.Idioma = idioma;
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

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private string tipo;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string nombre;

        public int Publicacion
        {
            get { return publicacion; }
            set { publicacion = value; }
        }

        private int publicacion;

        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        private string especialidad;

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

        //llenado de los catalogos
        public static List<CatalogoProductos> getCatalogos()
        {
            CatalogoProductos.AllCatalogos.Clear();
            if (CatalogoProductos.AllCatalogos.Count == 0)
                CatalogoProductos.AllCatalogos = CatalogoProductos.InicializarCatalogos();
            return CatalogoProductos.AllCatalogos;
        }

        private static List<CatalogoProductos> InicializarCatalogos()
        {
            List<CatalogoProductos> catalogos = new List<CatalogoProductos>();
            MainConfig mc = new MainConfig();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM catalogos_info_general", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            CatalogoProductos c = new CatalogoProductos();
                            c.Id = Convert.ToInt32(dr["id_catalogo"]);
                            c.Tipo = dr["tipo_catalogo"].ToString();
                            c.Nombre = dr["nombre_catalogo"].ToString();
                            c.Publicacion = (Int32)dr["publicacion"];
                            c.Especialidad = dr["spec_catalogo"].ToString();
                            c.Fabricante = dr["fabricante"].ToString();
                            c.Marca = dr["marca"].ToString();
                            c.Idioma = dr["idioma"].ToString();
                            c.Archivo = dr["dir_archivo"].ToString();                            
                            c.Created = Convert.ToDateTime(dr["creado_en"]);
                            c.Updated = Convert.ToDateTime(dr["actualizado_en"]);
                            catalogos.Add(c);
                        }
                    }

                }
            }
            return catalogos;
        }

        private static List<CatalogoProductos> AllCatalogos = new List<CatalogoProductos>();

        public List<ReferenciaCatalogo> Referencias
        {
            get
            {
                if (this.id != 0)
                    this.referencias = ReferenciaCatalogo.GetReferenciasPorCatalogo(this.id);
                return this.referencias;
            }
        }

        private List<ReferenciaCatalogo> referencias;

        public List<TraduccionCatalogo> Traducciones
        {
            get
            {
                if (this.id != 0)
                    this.traducciones = TraduccionCatalogo.GetTraduccionesPorCatalogo(this.id);
                return this.traducciones;
            }
        }

        private List<TraduccionCatalogo> traducciones;
    }
    
    public class ReferenciaCatalogo
    {
        public ReferenciaCatalogo()
        {

        }

        public ReferenciaCatalogo(int id, int catalogo, string referencia, string descripcion, string unidad, string paginaPdf, string paginaCat, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.Catalogo = catalogo;
            this.Referencia = referencia;
            this.Descripcion = descripcion;
            this.Unidad = unidad;
            this.PaginaPDF = paginaPdf;
            this.PaginaCat = paginaCat;
            this.Created = creado;
            this.Updated = actualizado;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

        public int Catalogo
        {
            get { return catalogo; }
            set { catalogo = value; }
        }

        private int catalogo;

        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }

        private string referencia;


        public string Descripcion
        {
            get { return descrípcion; }
            set { descrípcion = value; }
        }

        private string descrípcion;


        public string Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }

        private string unidad;


        public string PaginaPDF
        {
            get { return paginapdf; }
            set { paginapdf = value; }
        }

        private string paginapdf;


        public string PaginaCat
        {
            get { return paginacat; }
            set { paginacat = value; }
        }

        private string paginacat;


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

        //llenado de los referencias de catalogos
        public static List<ReferenciaCatalogo> GetReferencias()
        {
            ReferenciaCatalogo.AllReferencias.Clear();
            if (ReferenciaCatalogo.AllReferencias.Count == 0)
                ReferenciaCatalogo.AllReferencias = ReferenciaCatalogo.InicializarReferencias();
            return ReferenciaCatalogo.AllReferencias;
        }

        private static List<ReferenciaCatalogo> InicializarReferencias()
        {
            List<ReferenciaCatalogo> referencias = new List<ReferenciaCatalogo>();
            MainConfig mc = new MainConfig();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM catalogos_claves_referencias", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            ReferenciaCatalogo c = new ReferenciaCatalogo();
                            c.Id = Convert.ToInt32(dr["id_clave_catalogo"]);
                            c.Catalogo = (Int32)dr["id_catalogo_productos"];
                            c.Referencia = dr["clave_ref_cod"].ToString();
                            c.Descripcion = dr["descripcion"].ToString();
                            c.Unidad = dr["unidad_venta"].ToString();
                            c.PaginaPDF = dr["pagina_pdf"].ToString();
                            c.PaginaCat = dr["pagina_cat"].ToString();
                            c.Created = Convert.ToDateTime(dr["creado_en"]);
                            c.Updated = Convert.ToDateTime(dr["actualizado_en"]);
                            referencias.Add(c);
                        }
                    }

                }
            }
            return referencias;
        }

        private static List<ReferenciaCatalogo> AllReferencias = new List<ReferenciaCatalogo>();

        static public List<ReferenciaCatalogo> GetReferenciasPorCatalogo(int cat)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<ReferenciaCatalogo> referencias = new List<ReferenciaCatalogo>();
            foreach (ReferenciaCatalogo r in ReferenciaCatalogo.GetReferencias())
            {
                if (r.Catalogo == cat && !yaAgregado.ContainsKey(r.Id))
                {
                    yaAgregado[r.Id] = true;
                    referencias.Add(r);
                }
            }
            return referencias;
        }
    }

    public class TraduccionCatalogo
    {
        public TraduccionCatalogo()
        {

        }

        public TraduccionCatalogo(int id, int catalogo, string descripcion, string archivo, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.Catalogo = catalogo;
            this.Descripcion = descripcion;
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

        public int Catalogo
        {
            get { return catalogo; }
            set { catalogo = value; }
        }

        private int catalogo;

        public string Descripcion
        {
            get { return descrípcion; }
            set { descrípcion = value; }
        }

        private string descrípcion;

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

        //llenado de los traducciones de catalogos
        public static List<TraduccionCatalogo> GetTraducciones()
        {
            TraduccionCatalogo.AllTraducciones.Clear();
            if (TraduccionCatalogo.AllTraducciones.Count == 0)
                TraduccionCatalogo.AllTraducciones = TraduccionCatalogo.InicializarTraducciones();
            return TraduccionCatalogo.AllTraducciones;
        }

        private static List<TraduccionCatalogo> InicializarTraducciones()
        {
            List<TraduccionCatalogo> traducciones = new List<TraduccionCatalogo>();
            MainConfig mc = new MainConfig();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM catalogos_traducciones", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            TraduccionCatalogo c = new TraduccionCatalogo();
                            c.Id = Convert.ToInt32(dr["id_traduccion_cat"]);
                            c.Catalogo = (Int32)dr["id_catalogo_productos"];                           
                            c.Descripcion = dr["descripcion_corta"].ToString();
                            c.Archivo = dr["dir_archivo"].ToString();
                            c.Created = Convert.ToDateTime(dr["creado_en"]);
                            c.Updated = Convert.ToDateTime(dr["actualizado_en"]);
                            traducciones.Add(c);
                        }
                    }

                }
            }
            return traducciones;
        }

        private static List<TraduccionCatalogo> AllTraducciones = new List<TraduccionCatalogo>();

        static public List<TraduccionCatalogo> GetTraduccionesPorCatalogo(int cat)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<TraduccionCatalogo> traducciones = new List<TraduccionCatalogo>();
            foreach (TraduccionCatalogo r in TraduccionCatalogo.GetTraducciones())
            {
                if (r.Catalogo == cat && !yaAgregado.ContainsKey(r.Id))
                {
                    yaAgregado[r.Id] = true;
                    traducciones.Add(r);
                }
            }
            return traducciones;
        }

        public List<RefTradCatalogo> Referencias
        {
            get
            {
                if (this.id != 0)
                    this.referencias = RefTradCatalogo.GetReferenciasPorTraduccion(this.id);
                return this.referencias;
            }
        }

        private List<RefTradCatalogo> referencias;
    }

    public class RefTradCatalogo
    {
        public RefTradCatalogo()
        {

        }

        public RefTradCatalogo(int id, int traduccion, int referencia, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.Traduccion = traduccion;
            this.Referencia = referencia;
            this.Created = creado;
            this.Updated = actualizado;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

        public int Traduccion
        {
            get { return traduccion; }
            set { traduccion = value; }
        }

        private int traduccion;

        public int Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }

        private int referencia;

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

        //llenado de los referencias en traducciones
        public static List<RefTradCatalogo> GetRefTrad()
        {
            RefTradCatalogo.AllRefTrad.Clear();
            if (RefTradCatalogo.AllRefTrad.Count == 0)
                RefTradCatalogo.AllRefTrad = RefTradCatalogo.InicializarRefTrad();
            return RefTradCatalogo.AllRefTrad;
        }

        private static List<RefTradCatalogo> InicializarRefTrad()
        {
            List<RefTradCatalogo> reftrad = new List<RefTradCatalogo>();
            MainConfig mc = new MainConfig();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM aux_cat_trad_ref", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            RefTradCatalogo c = new RefTradCatalogo();
                            c.Id = Convert.ToInt32(dr["id_trad_ref"]);
                            c.Traduccion = (Int32)dr["id_traduccion"];
                            c.Referencia = (Int32)dr["id_referencia"];                           
                            c.Created = Convert.ToDateTime(dr["creado_en"]);
                            c.Updated = Convert.ToDateTime(dr["actualizado_en"]);
                            reftrad.Add(c);
                        }
                    }

                }
            }
            return reftrad;
        }

        private static List<RefTradCatalogo> AllRefTrad = new List<RefTradCatalogo>();

        static public List<RefTradCatalogo> GetReferenciasPorTraduccion(int trad)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<RefTradCatalogo> traducciones = new List<RefTradCatalogo>();
            foreach (RefTradCatalogo r in RefTradCatalogo.GetRefTrad())
            {
                if (r.Traduccion == trad && !yaAgregado.ContainsKey(r.Id))
                {
                    yaAgregado[r.Id] = true;
                    traducciones.Add(r);
                }
            }
            return traducciones;
        }
    }
}
