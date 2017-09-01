using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibLicitacion
{
    public class Cucop
    {
        public Cucop()
        {

        }

        public Cucop(int id, string clave, string descripcion, string especialidad, string presentacion, int cantidad, string contenedor, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.Clave = clave;
            this.Descripcion = descripcion;
            this.Especialidad = especialidad;
            this.Presentacion = presentacion;
            this.Cantidad = cantidad;
            this.Contenedor = contenedor;
            this.Created = creado;
            this.Updated = actualizado;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

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

        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        private string especialidad;

        public string Presentacion
        {
            get { return presentacion; }
            set { presentacion = value; }
        }

        private string presentacion;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private int cantidad;

        public string Contenedor
        {
            get { return contenedor; }
            set { contenedor = value; }
        }

        private string contenedor;

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
        public static List<Cucop> GetCucops()
        {
            Cucop.AllCucops.Clear();
            if (Cucop.AllCucops.Count == 0)
                Cucop.AllCucops = Cucop.InicializarCucops();
            return Cucop.AllCucops;
        }

        private static List<Cucop> InicializarCucops()
        {
            List<Cucop> cucops = new List<Cucop>();
            MainConfig mc = new MainConfig();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT id_cucop,clave,descripcion,especialidad,presentacion_tipo,presentacion_cant,presentacion_cont,creado_en,actualizado_en FROM cucop", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            Cucop c = new Cucop();
                            c.Id = Convert.ToInt32(dr["id_cucop"]);
                            c.Clave = dr["clave"].ToString();
                            c.Descripcion = dr["descripcion"].ToString();
                            c.Especialidad = dr["especialidad"].ToString();
                            c.Presentacion = dr["presentacion_tipo"].ToString();
                            c.Cantidad = Convert.ToInt32(dr["presentacion_cant"]);
                            c.Contenedor = dr["presentacion_cont"].ToString();
                            c.Created = Convert.ToDateTime(dr["creado_en"]);
                            c.Updated = Convert.ToDateTime(dr["actualizado_en"]);
                            cucops.Add(c);
                        }
                    }

                }
            }
            return cucops;
        }

        private static List<Cucop> AllCucops = new List<Cucop>();

        //obtener los vinculos correspondientes a cada cucop
        public List<CucopVinculos> Vinculos
        {
            get
            {
                if (this.id != 0)
                    this.vinculos = CucopVinculos.GetVinculacionesPorCucop(this.id);
                return this.vinculos;
            }
        }

        private List<CucopVinculos> vinculos;
    }

    public class CucopVinculos
    {
        public CucopVinculos()
        {

        }

        public CucopVinculos(int id, int opcion, int idCucop, string Nombre, int cartaApoyo, DateTime creado, DateTime actualizado )
        {
            this.Id = id;
            this.Opcion = opcion;
            this.IdCucop = idCucop;
            this.Nombre = Nombre;
            this.CartaApoyo = cartaApoyo;
            this.Created = creado;
            this.Updated = actualizado;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

        public int Opcion
        {
            get { return opcion; }
            set { opcion = value; }
        }

        private int opcion;

        public int IdCucop
        {
            get { return idcucop; }
            set { idcucop = value; }
        }

        private int idcucop;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string nombre;

        public int CartaApoyo
        {
            get { return carta; }
            set { carta = value; }
        }

        private int carta;

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

        //los siguientes 2 metodos llenan un objeto con las Vinculaciones
        //verifica si el objeto esta vacio
        static public List<CucopVinculos> GetVinculaciones()
        {
            CucopVinculos.AllVinculaciones.Clear();
            if (CucopVinculos.AllVinculaciones.Count == 0)
                CucopVinculos.AllVinculaciones = CucopVinculos.InicializarVinculaciones();
            return CucopVinculos.AllVinculaciones;
        }

        //crea el objeto con las vinculaciones 
        //llenar con un query
        static private List<CucopVinculos> InicializarVinculaciones()
        {
            MainConfig mc = new MainConfig();
            List<CucopVinculos> vinculos = new List<CucopVinculos>();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM cucop_vinculos", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            CucopVinculos v = new CucopVinculos();
                            v.Id = (Int32)dr["id_vinculacion"];
                            v.Opcion = (Int32)dr["opcion"];
                            v.IdCucop = (Int32)dr["id_cucop_item"];
                            v.Nombre = (string)dr["nombre"];
                            v.CartaApoyo = Convert.ToInt32(dr["carta_apoyo"]);
                            v.Created = (DateTime)dr["creado_en"];
                            v.Updated = (DateTime)dr["actualizado_en"];
                            vinculos.Add(v);
                        }
                    }
                }
            }
            return vinculos;
        }

        //objeto donde se almacenan las vinculaciones
        static private List<CucopVinculos> AllVinculaciones = new List<CucopVinculos>();

        //obtener los items del vinculos de los cucop (opciones)

        //obtener vinculos por cucop
        static public List<CucopVinculos> GetVinculacionesPorCucop(int cucop)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<CucopVinculos> vinculaciones = new List<CucopVinculos>();
            foreach (CucopVinculos v in CucopVinculos.GetVinculaciones())
            {
                if (v.IdCucop == cucop && !yaAgregado.ContainsKey(v.id))
                {
                    yaAgregado[v.id] = true;
                    vinculaciones.Add(new CucopVinculos(v.Id, v.Opcion, v.IdCucop, v.Nombre, v.CartaApoyo, v.Created, v.Updated));
                }
            }
            return vinculaciones;
        }

        //obtener los vinculos de registros correspondientes a cada vinculacion(opcion)
        public List<VinculoRegistros> Registros
        {
            get
            {
                if (this.id != 0)
                    this.registros = VinculoRegistros.GetRegistrosPorVinculoCucop(this.id);
                return this.registros;
            }
        }

        private List<VinculoRegistros> registros;

        //obtener los vinculos de certificados correspondientes a cada vinculacion(opcion)
        public List<VinculoCertificados> Certificados
        {
            get
            {
                if (this.id != 0)
                    this.certificados = VinculoCertificados.GetCertificadosPorVinculoCucop(this.id);
                return this.certificados;
            }
        }

        private List<VinculoCertificados> certificados;

        //obtener los vinculos de catalogos correspondientes a cada vinculacion(opcion)
        public List<VinculoCatalogos> Catalogos
        {
            get
            {
                if (this.id != 0)
                    this.catalogos = VinculoCatalogos.GetCatalogosPorVinculoCucop(this.id);
                return this.catalogos;
            }
        }

        private List<VinculoCatalogos> catalogos;

    }

    public class VinculoRegistros
    {
        public VinculoRegistros()
        {

        }

        public VinculoRegistros(int id, int cucopVinculo, int registro, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.CucopVinculo = cucopVinculo;
            this.Registro = registro;
            this.Created = creado;
            this.Updated = actualizado;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

        public int CucopVinculo
        {
            get { return cucopVinculo; }
            set { cucopVinculo = value; }
        }

        private int cucopVinculo;

        public int Registro
        {
            get { return registro; }
            set { registro = value; }
        }

        private int registro;

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

        static public List<VinculoRegistros> GetVinculosRegistros()
        {
            VinculoRegistros.AllRegistros.Clear();
            if (VinculoRegistros.AllRegistros.Count == 0)
                VinculoRegistros.AllRegistros = VinculoRegistros.InicializarVinculosRegistros();
            return VinculoRegistros.AllRegistros;
        }

        //crea el objeto con las vinculaciones de registros sanitarios 
        //llenar con un query
        static private List<VinculoRegistros> InicializarVinculosRegistros()
        {
            MainConfig mc = new MainConfig();
            List<VinculoRegistros> registros = new List<VinculoRegistros>();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM cucop_vinculos_registros", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            VinculoRegistros v = new VinculoRegistros();
                            v.Id = (Int32)dr["id"];
                            v.CucopVinculo = (Int32)dr["id_cucop_vinculo"];
                            v.Registro = (Int32)dr["id_registro"];
                            v.Created = (DateTime)dr["creado_en"];
                            v.Updated = (DateTime)dr["actualizado_en"];
                            registros.Add(v);
                        }
                    }
                }
            }
            return registros;
        }

        //objeto donde se almacenan las vinculaciones de registros sanitarios
        static private List<VinculoRegistros> AllRegistros = new List<VinculoRegistros>();

        //obtener los registros vinculados a ese vinculo(opcion) de cucop

        //obtener registros por opcion
        static public List<VinculoRegistros> GetRegistrosPorVinculoCucop(int cucopVinc)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<VinculoRegistros> registros = new List<VinculoRegistros>();
            foreach (VinculoRegistros v in VinculoRegistros.GetVinculosRegistros())
            {
                if (v.CucopVinculo == cucopVinc && !yaAgregado.ContainsKey(v.id))
                {
                    yaAgregado[v.id] = true;
                    registros.Add(new VinculoRegistros(v.Id, v.CucopVinculo, v.Registro, v.Created, v.Updated));
                }
            }
            return registros;
        }
    }

    public class VinculoCertificados
    {
        public VinculoCertificados()
        {

        }

        public VinculoCertificados(int id, int cucopVinculo, int certificado, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.CucopVinculo = cucopVinculo;
            this.Certificado = certificado;
            this.Created = creado;
            this.Updated = actualizado;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

        public int CucopVinculo
        {
            get { return cucopVinculo; }
            set { cucopVinculo = value; }
        }

        private int cucopVinculo;

        public int Certificado
        {
            get { return certificado; }
            set { certificado = value; }
        }

        private int certificado;

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

        static public List<VinculoCertificados> GetVinculosCertificados()
        {
            VinculoCertificados.AllCertificados.Clear();
            if (VinculoCertificados.AllCertificados.Count == 0)
                VinculoCertificados.AllCertificados = VinculoCertificados.InicializarVinculosCertificados();
            return VinculoCertificados.AllCertificados;
        }

        //crea el objeto con las vinculaciones de los certificados
        //llenar con un query
        static private List<VinculoCertificados> InicializarVinculosCertificados()
        {
            MainConfig mc = new MainConfig();
            List<VinculoCertificados> certificados = new List<VinculoCertificados>();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM cucop_vinculos_certificados", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            VinculoCertificados v = new VinculoCertificados();
                            v.Id = (Int32)dr["id"];
                            v.CucopVinculo = (Int32)dr["id_cucop_vinculo"];
                            v.Certificado = (Int32)dr["id_certificados"];
                            v.Created = (DateTime)dr["creado_en"];
                            v.Updated = (DateTime)dr["actualizado_en"];
                            certificados.Add(v);
                        }
                    }
                }
            }
            return certificados;
        }

        //objeto donde se almacenan las vinculaciones de certificados
        static private List<VinculoCertificados> AllCertificados = new List<VinculoCertificados>();

        //obtener los certificados vinculados a ese vinculo(opcion) de cucop

        //obtener certificados por opcion
        static public List<VinculoCertificados> GetCertificadosPorVinculoCucop(int cucopVinc)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<VinculoCertificados> certificados = new List<VinculoCertificados>();
            foreach (VinculoCertificados v in VinculoCertificados.GetVinculosCertificados())
            {
                if (v.CucopVinculo == cucopVinc && !yaAgregado.ContainsKey(v.id))
                {
                    yaAgregado[v.id] = true;
                    certificados.Add(new VinculoCertificados(v.Id, v.CucopVinculo, v.Certificado, v.Created, v.Updated));
                }
            }
            return certificados;
        }
    }

    public class VinculoCatalogos
    {
        public VinculoCatalogos()
        {

        }

        public VinculoCatalogos(int id, int cucopVinculo, int catalogo, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.CucopVinculo = cucopVinculo;
            this.Catalogo = catalogo;
            this.Created = creado;
            this.Updated = actualizado;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

        public int CucopVinculo
        {
            get { return cucopVinculo; }
            set { cucopVinculo = value; }
        }

        private int cucopVinculo;

        public int Catalogo
        {
            get { return catalogo; }
            set { catalogo = value; }
        }

        private int catalogo;

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

        static public List<VinculoCatalogos> GetVinculosCatalogos()
        {
            VinculoCatalogos.AllCatalogos.Clear();
            if (VinculoCatalogos.AllCatalogos.Count == 0)
                VinculoCatalogos.AllCatalogos = VinculoCatalogos.InicializarVinculosCatalogos();
            return VinculoCatalogos.AllCatalogos;
        }

        //crea el objeto con las vinculaciones de los catalogos
        //llenar con un query
        static private List<VinculoCatalogos> InicializarVinculosCatalogos()
        {
            MainConfig mc = new MainConfig();
            List<VinculoCatalogos> catalogos = new List<VinculoCatalogos>();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM cucop_vinculos_catalogos", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            VinculoCatalogos v = new VinculoCatalogos();
                            v.Id = (Int32)dr["id"];
                            v.CucopVinculo = (Int32)dr["id_cucop_vinculo"];
                            v.Catalogo = (Int32)dr["id_catalogo"];
                            v.Created = (DateTime)dr["creado_en"];
                            v.Updated = (DateTime)dr["actualizado_en"];
                            catalogos.Add(v);
                        }
                    }
                }
            }
            return catalogos;
        }

        //objeto donde se almacenan las vinculaciones de catalogos
        static private List<VinculoCatalogos> AllCatalogos = new List<VinculoCatalogos>();

        //obtener los catalogos vinculados a ese vinculo(opcion) de cucop

        //obtener catalogos por opcion
        static public List<VinculoCatalogos> GetCatalogosPorVinculoCucop(int cucopVinc)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<VinculoCatalogos> catalogos = new List<VinculoCatalogos>();
            foreach (VinculoCatalogos v in VinculoCatalogos.GetVinculosCatalogos())
            {
                if (v.CucopVinculo == cucopVinc && !yaAgregado.ContainsKey(v.id))
                {
                    yaAgregado[v.id] = true;
                    catalogos.Add(new VinculoCatalogos(v.Id, v.CucopVinculo, v.Catalogo, v.Created, v.Updated));
                }
            }
            return catalogos;
        }
    }
}
 