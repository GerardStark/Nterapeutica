using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibLicitacion
{
    public class Licitacion
    {
        public Licitacion()
        {

        }

        public Licitacion(int id, string numLicit, string unidadComp, int entiFedr, string spec, string durContr, string tipoContr,
           long expediente, string tipoLicit, int tipoExp, string nombOper,
           string emailOper, string descrip, string archivo, DateTime created, DateTime updated)
        {
            this.Id = id;
            this.NumeroLicitacion = numLicit;
            this.UnidadCompradora = unidadComp;
            this.EntidadFederativa = entiFedr;
            this.Especialidad = spec;
            this.DuracionContrato = durContr;
            this.TipoContrato = tipoContr;
            this.Expediente = expediente;
            this.TipoLicitacion = tipoLicit;
            this.TipoExpediente = tipoExp;
            this.NombreOperador = nombOper;
            this.EmailOperador = emailOper;
            this.Descripcion = descrip;
            this.NombreArchivo = archivo;
            this.Created = created;
            this.Updated = updated;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

        public string NumeroLicitacion
        {
            get { return numLicit; }
            set { numLicit = value; }
        }

        private string numLicit;

        public string UnidadCompradora
        {
            get { return unidadComp; }
            set { unidadComp = value; }
        }

        private string unidadComp;

        public int EntidadFederativa
        {
            get { return entiFedr; }
            set { entiFedr = value; }
        }

        private int entiFedr;

        public string Especialidad
        {
            get { return spec; }
            set { spec = value; }
        }

        private string spec;

        public string DuracionContrato
        {
            get { return durContr; }
            set { durContr = value; }
        }

        private string durContr;

        public string TipoContrato
        {
            get { return tipoContr; }
            set { tipoContr = value; }
        }

        private string tipoContr;

        public long Expediente
        {
            get { return expediente; }
            set { expediente = value; }
        }

        private long expediente;

        public string TipoLicitacion
        {
            get { return tipoLicit; }
            set { tipoLicit = value; }
        }

        private string tipoLicit;

        public int TipoExpediente
        {
            get { return tipoExp; }
            set { tipoExp = value; }
        }

        private int tipoExp;

        public string NombreOperador
        {
            get { return nombOper; }
            set { nombOper = value; }
        }

        private string nombOper;

        public string EmailOperador
        {
            get { return emailOper; }
            set { emailOper = value; }
        }

        private string emailOper;

        public string Descripcion
        {
            get { return descrip; }
            set { descrip = value; }
        }

        private string descrip;

        public string NombreArchivo
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

        //operaciones   


        //los siguientes 2 metodos llenan la lista de bases
        //verifica si la lista esta vacia
        static public List<Licitacion> GetBases()
        {
            Licitacion.AllBases.Clear();
            if (Licitacion.AllBases.Count == 0)
                Licitacion.AllBases = Licitacion.InicializarBases();
            return Licitacion.AllBases;
        }

        //crea el objeto con las bases 
        //llenar con un query
        static private List<Licitacion> InicializarBases()
        {
            MainConfig mc = new MainConfig();
            List<Licitacion> bases = new List<Licitacion>();

            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * from licitacion_bases", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            Licitacion b = new Licitacion();
                            b.Id = (Int32)dr["id_bases"];
                            b.NumeroLicitacion = (string)dr["numero_licitacion"];
                            b.UnidadCompradora = (string)dr["unidad_compradora"];
                            b.EntidadFederativa = (Int32)dr["entidad_federativa"];
                            b.Especialidad = (string)dr["especialidad"];
                            b.DuracionContrato = (string)dr["duracion_contrato"];
                            b.TipoContrato = (string)dr["tipo_contratacion"];
                            b.Expediente = (long)dr["expediente"];
                            b.TipoLicitacion = (string)dr["tipo_licitacion"];
                            b.TipoExpediente = (Int32)dr["tipo_expediente"];
                            b.NombreOperador = (string)dr["operador_nombre"];
                            b.EmailOperador = (string)dr["operador_correo"];
                            b.Descripcion = (string)dr["descripcion"];
                            b.NombreArchivo = (string)dr["dir_archivo"];
                            b.Created = (DateTime)dr["creado_en"];
                            b.Updated = (DateTime)dr["actualizado_en"];
                            bases.Add(b);
                        }
                    }
                }
            }
            return bases;
        }

        //objeto donde se almacenan las bases
        static private List<Licitacion> AllBases = new List<Licitacion>();

        //obtener partidas correspondientes a cada base
        public List<Partida> Partidas
        {
            get
            {
                if (this.Id != 0)
                    this.partidas = Partida.GetPartidasPorBase(this.Id);
                return this.partidas;
            }
        }

        private List<Partida> partidas;

        public List<Acta> Actas
        {
            get
            {
                if (this.Id != 0)
                    this.actas = Acta.GetActasPorLicitacion(this.Id);
                return this.actas;
            }
        }

        private List<Acta> actas;

        public List<Calendario> Calendarios
        {
            get
            {
                if (this.Id != 0)
                    this.calendarios = Calendario.GetCalendarioPorLicitacion(this.Id);
                return this.calendarios;
            }
        }

        private List<Calendario> calendarios;


    }    

    public class Partida
    {
        public Partida()
        {

        }

        //clase principal de las partidas
        public Partida(int id, int idBases, int numPartida, string nombPartida, string especialidad, long minimo, long maximo, DateTime created, DateTime updated)
        {
            this.Id = id;
            this.IdBases = idBases;
            this.Numero = numPartida;
            this.Nombre = nombPartida;
            this.Especialidad = especialidad;
            this.Minimo = minimo;
            this.Maximo = maximo;
            this.Created = created;
            this.Updated = updated;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

        public int IdBases
        {
            get { return idBases; }
            set { idBases = value; }
        }

        private int idBases;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private int numero;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string nombre;

        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        private string especialidad;

        public DateTime Created
        {
            get { return created; }
            set { created = value; }
        }

        public long Minimo
        {
            get { return minimo; }
            set { minimo = value; }
        }

        private long minimo;

        public long Maximo
        {
            get { return maximo; }
            set { maximo = value; }
        }

        private long maximo;

        private DateTime created;

        public DateTime Updated
        {
            get { return updated; }
            set { updated = value; }
        }

        private DateTime updated;

        //procedimientos

        //los siguientes 2 metodos llenan un objeto con las Partidas
        //verifica si el objeto esta vacio
        static public List<Partida> GetPartidas()
        {
            Partida.AllPartidas.Clear();
            if (Partida.AllPartidas.Count == 0)
                Partida.AllPartidas = Partida.InicializarPartidas();
            return Partida.AllPartidas;
        }

        //crea el objeto con las partidas 
        //llenar con un query
        static private List<Partida> InicializarPartidas()
        {
            MainConfig mc = new MainConfig();
            List<Partida> partidas = new List<Partida>();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * from licitacion_partidas", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            Partida p = new Partida();
                            p.Id = (Int32)dr["id"];
                            p.IdBases = (Int32)dr["id_bases"];
                            p.Nombre = (string)dr["nombre_partida"];
                            p.Numero = (Int32)dr["numero_partida"];
                            p.Especialidad = (string)dr["especialidad"];
                            p.Minimo = (long)dr["minimo"];
                            p.Maximo = (long)dr["maximo"];
                            p.Created = (DateTime)dr["creado_en"];
                            p.Updated = (DateTime)dr["actualizado_en"];
                            partidas.Add(p);
                        }
                    }
                }
            }
            return partidas;
        }

        //objeto donde se almacenan las partidas
        static private List<Partida> AllPartidas = new List<Partida>();

        //obtener las partidas de cada base
        static public List<Partida> GetPartidasPorBase(int idBases)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<Partida> partidas = new List<Partida>();
            foreach (Partida p in Partida.GetPartidas())
            {
                if (p.idBases == idBases && !yaAgregado.ContainsKey(p.Id))
                {
                    yaAgregado[p.Id] = true;
                    partidas.Add(new Partida(p.Id, p.IdBases, p.Numero, p.Nombre, p.Especialidad, p.Minimo, p.Maximo, p.Created, p.Updated));
                }
            }
            return partidas;
        }

        //obtener los procedimientos correspondientes a cada partida
        public List<Procedimiento> Procedimientos
        {
            get
            {
                if (this.Id != 0)
                    this.procedimientos = Procedimiento.GetProcedimientosPorPartidas(this.Id);
                return this.procedimientos;
            }
        }

        private List<Procedimiento> procedimientos;


    }

    public class Procedimiento
    {
        public Procedimiento()
        {

        }

        //clase principal de los procedimientos/subpartidas
        public Procedimiento(int id, int partida, int numero, string nombre, long minimo, long maximo, DateTime created, DateTime updated)
        {
            this.Id = id;
            this.Partida = partida;
            this.Numero = numero;
            this.Nombre = nombre;
            this.Minimo = minimo;
            this.Maximo = maximo;
            this.Created = created;
            this.Updated = updated;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

        public int Partida
        {
            get { return partida; }
            set { partida = value; }
        }

        private int partida;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private int numero;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string nombre;

        public long Minimo
        {
            get { return minimo; }
            set { minimo = value; }
        }

        private long minimo;

        public long Maximo
        {
            get { return maximo; }
            set { maximo = value; }
        }

        private long maximo;

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

        //los siguientes 2 metodos llenan un objeto con los Procedimientos
        //verifica si el objeto esta vacio
        static public List<Procedimiento> GetProcedimientos()
        {
            Procedimiento.AllProcedimientos.Clear();
            if (Procedimiento.AllProcedimientos.Count == 0)
                Procedimiento.AllProcedimientos = Procedimiento.InicializarProcedimientos();
            return Procedimiento.AllProcedimientos;
        }

        //crea el objeto con los procedimientos 
        //llenar con un query
        static private List<Procedimiento> InicializarProcedimientos()
        {
            MainConfig mc = new MainConfig();
            List<Procedimiento> procedimientos = new List<Procedimiento>();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM licitacion_subpar_proce", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            Procedimiento p = new Procedimiento();
                            p.Id = (Int32)dr["id"];
                            p.partida = (Int32)dr["id_partida"];
                            p.Numero = (Int32)dr["numero_subpartida"];
                            p.Nombre = (string)dr["nombre_subpartida"];
                            p.Minimo = (long)dr["minimo"];
                            p.Maximo = (long)dr["maximo"];
                            p.Created = (DateTime)dr["creado_en"];
                            p.Updated = (DateTime)dr["actualizado_en"];
                            procedimientos.Add(p);
                        }
                    }
                }
            }
            return procedimientos;
        }

        //objeto donde se almacenan los procedimientos
        static private List<Procedimiento> AllProcedimientos = new List<Procedimiento>();

        //obtener procedimientos por partida
        static public List<Procedimiento> GetProcedimientosPorPartidas(int partida)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<Procedimiento> procedimientos = new List<Procedimiento>();
            foreach (Procedimiento p in Procedimiento.GetProcedimientos())
            {
                if (p.partida == partida && !yaAgregado.ContainsKey(p.Id))
                {
                    yaAgregado[p.Id] = true;
                    procedimientos.Add(new Procedimiento(p.Id, p.Partida, p.Numero, p.Nombre, p.Minimo, p.Maximo, p.Created, p.Updated));
                }
            }
            return procedimientos;
        }

        //obtener los items del procedimiento
        public List<Item> Items
        {
            get
            {
                if (this.Id != 0)
                    this.items = Item.GetItemsPorProcedimiento(this.Id);
                return this.items;
            }
        }

        private List<Item> items;

        public List<ProceInfoAd> Infos
        {
            get
            {
                if (this.Id != 0)
                    this.infos = ProceInfoAd.GetInfosPorProcedimiento(this.Id);
                return this.infos;
            }
        }

        private List<ProceInfoAd> infos;

    }

    public class Item
    {
        public Item()
        {

        }

        //clase principal de los items de la licitacion
        public Item(int id, int procedimiento, long numero, string ccb, string descripcion, string unidad, long cantidad, string contenedor, long minimo, long maximo, DateTime created, DateTime updated)
        {
            this.Id = id;
            this.Procedimiento = procedimiento;
            this.Numero = numero;
            this.Ccb = ccb;
            this.Nombre = descripcion;
            this.Unidad = unidad;
            this.Cantidad = cantidad;
            this.Contenedor = contenedor;
            this.Minimo = minimo;
            this.Maximo = maximo;
            this.Created = created;
            this.Updated = updated;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

        public int Procedimiento
        {
            get { return procedimiento; }
            set { procedimiento = value; }
        }

        private int procedimiento;

        public long Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private long numero;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string nombre;

        public string Ccb
        {
            get { return ccb; }
            set { ccb = value; }
        }

        private string ccb;

        public string Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }

        private string unidad;

        public long Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private long cantidad;

        public string Contenedor
        {
            get { return contenedor; }
            set { contenedor = value; }
        }

        private string contenedor;

        public long Minimo
        {
            get { return minimo; }
            set { minimo = value; }
        }

        private long minimo;

        public long Maximo
        {
            get { return maximo; }
            set { maximo = value; }
        }

        private long maximo;

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

        //los siguientes 2 metodos llenan un objeto con los Items
        //verifica si el objeto esta vacio
        static public List<Item> GetItems()
        {
            Item.AllItems.Clear();
            if (Item.AllItems.Count == 0)
                Item.AllItems = Item.InicializarItems();
            return Item.AllItems;
        }

        //crea el objeto con las items 
        //llenar con un query
        static private List<Item> InicializarItems()
        {
            MainConfig mc = new MainConfig();
            List<Item> items = new List<Item>();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM licitacion_items",con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            Item i = new Item();
                            i.Id = (Int32)dr["id_item"];
                            i.Procedimiento = (Int32)dr["id_paquete"];
                            i.Numero = (long)dr["numero"];
                            i.Ccb = dr["codigo_cuadro_basico"].ToString();
                            i.Nombre = (string)dr["descripcion"];
                            i.Unidad = (string)dr["unidad_venta"];
                            i.Minimo = (long)dr["minimo"];
                            i.Maximo = (long)dr["maximo"];
                            i.Created = (DateTime)dr["creado_en"];
                            i.Updated = (DateTime)dr["actualizado_en"];
                            items.Add(i);
                        }
                    }
                }
            }

            return items;
        }

        //objeto donde se almacenan las items
        static private List<Item> AllItems = new List<Item>();

        //obtener los items de cada procedimiento
        static public List<Item> GetItemsPorProcedimiento(int proce)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<Item> items = new List<Item>();
            foreach (Item i in Item.GetItems())
            {
                if (i.procedimiento == proce && !yaAgregado.ContainsKey(i.Id))
                {
                    yaAgregado[i.Id] = true;
                    items.Add(new Item(i.Id, i.Procedimiento, i.Numero, i.Ccb,i.Nombre, i.Unidad, i.Cantidad, i.Contenedor, i.Minimo, i.Maximo,i.Created, i.Updated));
                }
            }
            return items;
        }

        //obtener los items del vinculos de los items
        public List<CucopVinculos> Vinculos
        {
            get
            {
                if (this.Id != 0)
                    this.vinculos = CucopVinculos.GetVinculacionesPorItem(this.Id);
                return this.vinculos;
            }
        }

        private List<CucopVinculos> vinculos;

        public List<ItemInfoAd> Infos
        {
            get
            {
                if (this.Id != 0)
                    this.infos = ItemInfoAd.GetInfosPorItem(this.Id);
                return this.infos;
            }
        }

        private List<ItemInfoAd> infos;

        public List<Pregunta> Preguntas
        {
            get
            {
                if (this.Id != 0)
                    this.preguntas = Pregunta.GetPreguntasPorVinculacion(this.Id);
                return this.preguntas;
            }
        }

        private List<Pregunta> preguntas;

    }

    public class CucopVinculos
    {
        public CucopVinculos()
        {

        }

        public CucopVinculos(int id, int opcion, int idItem, string Nombre, int cartaApoyo, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.Opcion = opcion;
            this.IdItem = idItem;
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

        public int IdItem
        {
            get { return iditem; }
            set { iditem = value; }
        }

        private int iditem;

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
                            v.IdItem = (Int32)dr["id_item"];
                            if (dr["nombre"] != DBNull.Value)
                            {
                                v.Nombre = (string)dr["nombre"];
                            }

                            if (dr["carta_apoyo"] != DBNull.Value)
                            {
                                v.CartaApoyo = Convert.ToInt32(dr["carta_apoyo"]);
                            }                           
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
        static public List<CucopVinculos> GetVinculacionesPorItem(int item)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<CucopVinculos> vinculaciones = new List<CucopVinculos>();
            foreach (CucopVinculos v in CucopVinculos.GetVinculaciones())
            {
                if (v.IdItem == item && !yaAgregado.ContainsKey(v.id))
                {
                    yaAgregado[v.id] = true;
                    vinculaciones.Add(new CucopVinculos(v.Id, v.Opcion, v.IdItem, v.Nombre, v.CartaApoyo, v.Created, v.Updated));
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

        public List<vinculoRegistroReferencia> Referencias
        {
            get
            {
                if (this.Id != 0)
                    this.referencias = vinculoRegistroReferencia.GerRefPorVincReg(this.Id);
                return this.referencias;
            }
        }

        private List<vinculoRegistroReferencia> referencias;

    }

    public class vinculoRegistroReferencia
    {
        public vinculoRegistroReferencia()
        {

        }

        public vinculoRegistroReferencia(int id, int vincReg, int referencia, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.VinculoRegistro = vincReg;
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

        public int VinculoRegistro
        {
            get { return vincReg; }
            set { vincReg = value; }
        }

        private int vincReg;

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

        static public List<vinculoRegistroReferencia> GetVinculoRegistroReferencias()
        {
            vinculoRegistroReferencia.AllReferencias.Clear();
            if (vinculoRegistroReferencia.AllReferencias.Count == 0)
                vinculoRegistroReferencia.AllReferencias = vinculoRegistroReferencia.InicializarVinculoRegistroReferencias();
            return vinculoRegistroReferencia.AllReferencias;
        }

        //crea el objeto con las vinculaciones de los catalogos
        //llenar con un query
        static private List<vinculoRegistroReferencia> InicializarVinculoRegistroReferencias()
        {
            MainConfig mc = new MainConfig();
            List<vinculoRegistroReferencia> referencias = new List<vinculoRegistroReferencia>();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM cucop_vinculos_catalogos_referencias", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            vinculoRegistroReferencia v = new vinculoRegistroReferencia();
                            v.Id = (Int32)dr["id"];
                            v.VinculoRegistro = (Int32)dr["id_vinculo_catalogo"];
                            v.Referencia = (Int32)dr["id_referencia"];
                            v.Created = (DateTime)dr["creado_en"];
                            v.Updated = (DateTime)dr["actualizado_en"];
                            referencias.Add(v);
                        }
                    }
                }
            }
            return referencias;
        }

        //objeto donde se almacenan las vinculaciones de catalogos
        static private List<vinculoRegistroReferencia> AllReferencias = new List<vinculoRegistroReferencia>();

        //obtener los catalogos vinculados a ese vinculo(opcion) de cucop

        //obtener catalogos por opcion
        static public List<vinculoRegistroReferencia> GerRefPorVincReg(int vincreg)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<vinculoRegistroReferencia> referencias = new List<vinculoRegistroReferencia>();
            foreach (vinculoRegistroReferencia v in vinculoRegistroReferencia.GetVinculoRegistroReferencias())
            {
                if (v.VinculoRegistro == vincreg && !yaAgregado.ContainsKey(v.id))
                {
                    yaAgregado[v.id] = true;
                    referencias.Add(v);
                }
            }
            return referencias;
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

        public List<vinculoCatalogoReferencia> Referencias
        {
            get
            {
                if (this.Id != 0)
                    this.referencias = vinculoCatalogoReferencia.GerRefPorVincCat(this.Id);
                return this.referencias;
            }
        }

        private List<vinculoCatalogoReferencia> referencias;
    } 

    public class vinculoCatalogoReferencia
    {
        public vinculoCatalogoReferencia()
        {

        }

        public vinculoCatalogoReferencia(int id, int vincCat, int referencia, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.VinculoCatalogo = vincCat;
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

        public int VinculoCatalogo
        {
            get { return vincCat; }
            set { vincCat = value; }
        }

        private int vincCat;

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

        static public List<vinculoCatalogoReferencia> GetVinculoCatalogosReferencias()
        {
            vinculoCatalogoReferencia.AllReferencias.Clear();
            if (vinculoCatalogoReferencia.AllReferencias.Count == 0)
                vinculoCatalogoReferencia.AllReferencias = vinculoCatalogoReferencia.InicializarVinculoCatalogoReferencias();
            return vinculoCatalogoReferencia.AllReferencias;
        }

        //crea el objeto con las vinculaciones de los catalogos
        //llenar con un query
        static private List<vinculoCatalogoReferencia> InicializarVinculoCatalogoReferencias()
        {
            MainConfig mc = new MainConfig();
            List<vinculoCatalogoReferencia> referencias = new List<vinculoCatalogoReferencia>();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM cucop_vinculos_catalogos_referencias", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            vinculoCatalogoReferencia v = new vinculoCatalogoReferencia();
                            v.Id = (Int32)dr["id"];
                            v.VinculoCatalogo = (Int32)dr["id_vinculo_catalogo"];
                            v.Referencia = (Int32)dr["id_referencia"];
                            v.Created = (DateTime)dr["creado_en"];
                            v.Updated = (DateTime)dr["actualizado_en"];
                            referencias.Add(v);
                        }
                    }
                }
            }
            return referencias;
        }

        //objeto donde se almacenan las vinculaciones de catalogos
        static private List<vinculoCatalogoReferencia> AllReferencias = new List<vinculoCatalogoReferencia>();

        //obtener los catalogos vinculados a ese vinculo(opcion) de cucop

        //obtener catalogos por opcion
        static public List<vinculoCatalogoReferencia> GerRefPorVincCat(int vincreg)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<vinculoCatalogoReferencia> referencias = new List<vinculoCatalogoReferencia>();
            foreach (vinculoCatalogoReferencia v in vinculoCatalogoReferencia.GetVinculoCatalogosReferencias())
            {
                if (v.VinculoCatalogo == vincreg && !yaAgregado.ContainsKey(v.Id))
                {
                    yaAgregado[v.Id] = true;
                    referencias.Add(v);
                }
            }
            return referencias;
        }
    }

    public class Acta
    {
        public Acta()
        {

        }

        //clase principal de las actas de la licitacion
        public Acta(int id, int idLicit, int tipo, string descripcion, DateTime emision, string archivo,DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.Tipo = tipo;
            this.IdBases = idLicit;
            this.Descripcion = descripcion;
            this.Emision = emision;
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

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private int tipo;

        public int IdBases
        {
            get { return idBases; }
            set { idBases = value; }
        }

        private int idBases;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private string descripcion;

        public DateTime Emision
        {
            get { return emision; }
            set { emision = value; }
        }

        private DateTime emision;

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

        //los siguientes 2 metodos llenan un objeto con las Actas
        //verifica si el objeto esta vacio
        static public List<Acta> GetActas()
        {
            Acta.AllActas.Clear();
            if (Acta.AllActas.Count == 0)
                Acta.AllActas = Acta.InicializarActas();
            return Acta.AllActas;
        }

        //crea el objeto con las actas 
        //llenar con un query
        static private List<Acta> InicializarActas()
        {
            MainConfig mc = new MainConfig();
            List<Acta> actas = new List<Acta>();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM licitacion_actas", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            Acta a = new Acta();
                            a.Id = (Int32)dr["id"];
                            a.Tipo = (Int32)dr["tipo_acta"];
                            a.Descripcion = dr["descripcion"].ToString();
                            a.Emision = (DateTime)dr["fecha_emision"];
                            a.Updated = (DateTime)dr["actualizado_en"];
                            a.IdBases = (Int32)dr["id_licitacion"];
                            a.Archivo = dr["dir_archivo"].ToString();
                            actas.Add(a);
                        }
                    }
                }
            }
            return actas;
        }

        //objeto donde se almacenan las actas
        static private List<Acta> AllActas = new List<Acta>();


        //obtener actas por licitacion
        static public List<Acta> GetActasPorLicitacion(int bases)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<Acta> actas = new List<Acta>();
            foreach (Acta a in Acta.GetActas())
            {
                if (a.IdBases == bases && !yaAgregado.ContainsKey(a.Id))
                {
                    yaAgregado[a.Id] = true;
                    actas.Add(new Acta(a.Id, a.IdBases, a.Tipo, a.Descripcion,a.Emision, a.Archivo,a.Created, a.Updated));
                }
            }
            return actas;
        }
    }

    public class Pregunta
    {
        public Pregunta()
        {

        }

        public Pregunta(int id, int vinculacion, string enunciado, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.Vinculacion = vinculacion;
            this.Enunciado = enunciado;
            this.Created = creado;
            this.Updated = actualizado;
        }        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

        public int Vinculacion
        {
            get { return vinculacion; }
            set { vinculacion = value; }
        }

        private int vinculacion;

        public string Enunciado
        {
            get { return enunciado; }
            set { enunciado = value; }
        }

        private string enunciado;

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

        public static List<Pregunta> GetPreguntas()
        {
            Pregunta.AllPreguntas.Clear();
            if (Pregunta.AllPreguntas.Count == 0)
                Pregunta.AllPreguntas = Pregunta.InicializarPreguntas();
            return Pregunta.AllPreguntas;
        }

        private static List<Pregunta> InicializarPreguntas()
        {
            MainConfig mc = new MainConfig();
            List<Pregunta> preguntas = new List<Pregunta>();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM licitacion_preguntas";
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            Pregunta p = new Pregunta();
                            p.Id = (Int32)dr["id"];
                            p.Vinculacion = (Int32)dr["id_vinculacion"];
                            p.Enunciado = dr["pregunta"].ToString();
                            p.Created = (DateTime)dr["creado_en"];
                            p.Updated = (DateTime)dr["actualizado_en"];
                            preguntas.Add(p);
                        }
                    }
                    
                }
            }
            return preguntas;
        }

        private static List<Pregunta> AllPreguntas = new List<Pregunta>();

        public static List<Pregunta> GetPreguntasPorVinculacion(int vinc)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<Pregunta> preguntas = new List<Pregunta>();
            foreach (Pregunta p in Pregunta.GetPreguntas())
            {
                if (p.Vinculacion == vinc && !yaAgregado.ContainsKey(p.Id))
                {
                    yaAgregado[p.Id] = true;
                    preguntas.Add(new Pregunta(p.Id, p.Vinculacion, p.Enunciado, p.Created, p.Updated));
                }
            }
            return preguntas;
        }
    }
    
    public class Calendario
    {
        public Calendario()
        {

        }

        public Calendario(int id, int bases, DateTime publicacion, DateTime dof, DateTime junta, DateTime apertura, DateTime fallo, DateTime firma, DateTime visita, DateTime muestras, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.Bases = bases;
            this.Publicacion = publicacion;
            this.PublicacionDof = dof;
            this.Junta = junta;
            this.Apertura = apertura;
            this.Fallo = fallo;
            this.Firma = firma;
            this.Visita = visita;
            this.Muestras = muestras;
            this.Created = creado;
            this.Updated = actualizado;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

        public int Bases
        {
            get { return bases; }
            set { bases = value; }
        }

        private int bases;

        public DateTime Publicacion
        {
            get { return publicacion; }
            set { publicacion = value; }
        }

        private DateTime publicacion;

        public DateTime PublicacionDof
        {
            get { return publicaciondof; }
            set { publicaciondof = value; }
        }

        private DateTime publicaciondof;

        public DateTime Junta
        {
            get { return junta; }
            set { junta = value; }
        }

        private DateTime junta;

        public DateTime Apertura
        {
            get { return apertura; }
            set { apertura = value; }
        }

        private DateTime apertura;

        public DateTime Fallo
        {
            get { return fallo; }
            set { fallo = value; }
        }

        private DateTime fallo;

        public DateTime Firma
        {
            get { return firma; }
            set { firma = value; }
        }

        private DateTime firma;

        public DateTime Visita
        {
            get { return visita; }
            set { visita = value; }
        }

        private DateTime visita;

        public DateTime Muestras
        {
            get { return muestras; }
            set { muestras = value; }
        }

        private DateTime muestras;

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

        public static List<Calendario> GetCalendarios()
        {
            Calendario.AllCalendarios.Clear();
            if (Calendario.AllCalendarios.Count == 0)
                Calendario.AllCalendarios = Calendario.InicializarCalendarios();
            return Calendario.AllCalendarios;
        }

        private static List<Calendario> InicializarCalendarios()
        {
            MainConfig mc = new MainConfig();
            List<Calendario> calendarios = new List<Calendario>();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM licitacion_calendario";
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            Calendario c = new Calendario();
                            c.Id = (Int32)dr["id_calendario"];
                            c.Bases = (Int32)dr["id_bases"];
                            c.Publicacion = (DateTime)dr["fecha_publicacion_cnet"];
                            c.PublicacionDof = (DateTime)dr["fecha_publicacion_dof"];
                            c.Junta = (DateTime)dr["fecha_junta_aclaraciones"];
                            c.Apertura = (DateTime)dr["fecha_apertura"];
                            c.Fallo = (DateTime)dr["fecha_fallo"];
                            c.Firma = (DateTime)dr["fecha_firma"];
                            c.Visita = (DateTime)dr["fecha_visita"];
                            c.Muestras = (DateTime)dr["fecha_muestras"];
                            c.Created = (DateTime)dr["creado_en"];
                            c.Updated = (DateTime)dr["actualizado_en"];
                            calendarios.Add(c);
                        }
                    }

                }
            }
            return calendarios;
        }

        private static List<Calendario> AllCalendarios = new List<Calendario>();

        public static List<Calendario> GetCalendarioPorLicitacion(int bases)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<Calendario> calendarios = new List<Calendario>();
            foreach (Calendario c in Calendario.GetCalendarios())
            {
                if (c.Bases == bases && !yaAgregado.ContainsKey(c.Id))
                {
                    yaAgregado[c.Id] = true;
                    calendarios.Add(new Calendario(c.Id,c.Bases,c.Publicacion, c.PublicacionDof, c.Junta,c.Apertura,c.Fallo,c.Firma,c.Visita,c.Muestras, c.Created,c.Updated));
                }
            }
            return calendarios;
        }
    }

    public class ProceInfoAd
    {

        public ProceInfoAd(){

        }

        public ProceInfoAd(int id, int subpartida, string nombre, string valor, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.Subpartida = subpartida;
            this.Nombre = nombre;
            this.Valor = valor;
            this.Created = creado;
            this.Updated = actualizado;
        }

        public int Id
        {
            get{return id;}
            set{id = value;}            
        }

        private int id;

        private int Subpartida
        {
            get{return subpartida;}
            set{ subpartida = value;}
        }
        
        private int subpartida;

        public string Nombre
        {
            get{return nombre;}
            set{nombre = value;}
        }

        private string nombre;

        public string Valor
        {
            get{return valor;}
            set{valor = value;}
        }

        private string valor;

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

        public static List<ProceInfoAd> GetInfos()
        {
            ProceInfoAd.AllInfos.Clear();
            if (ProceInfoAd.AllInfos.Count == 0)
                ProceInfoAd.AllInfos = ProceInfoAd.InicializarInfos();
            return ProceInfoAd.AllInfos;
        }

        private static List<ProceInfoAd> InicializarInfos()
        {
            MainConfig mc = new MainConfig();
            List<ProceInfoAd> infos = new List<ProceInfoAd>();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM licitacion_items_info_Ad";
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            ProceInfoAd c = new ProceInfoAd();
                            c.Id = (Int32)dr["id"];
                            c.subpartida = (Int32)dr["id_proce"];
                            c.Nombre  = dr["nombre_adicional"].ToString();
                            c.Valor   = dr["numero_adicional"].ToString();                            
                            c.Created = (DateTime)dr["creado_en"];                            
                            c.Updated = (DateTime)dr["actualizado_en"];
                            infos.Add(c);
                        }
                    }

                }
            }
            return infos;
        }

        private static List<ProceInfoAd> AllInfos = new List<ProceInfoAd>();

        public static List<ProceInfoAd> GetInfosPorProcedimiento(int sub)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<ProceInfoAd> infos = new List<ProceInfoAd>();
            foreach (ProceInfoAd c in ProceInfoAd.GetInfos())
            {
                if (c.subpartida == sub && !yaAgregado.ContainsKey(c.Id))
                {
                    yaAgregado[c.Id] = true;
                    infos.Add(c);
                }
            }
            return infos;
        }
    }

    public class ItemInfoAd
    {
        public ItemInfoAd()
        {

        }

        public ItemInfoAd(int id, int info, int item, string valor, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.Info = info;
            this.Item = item;
            this.Valor = valor;
            this.Created = creado;
            this.Updated = actualizado;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

        public int Info
        {
            get { return info; }
            set { info = value; }
        }

        private int info;

        public int Item
        {
            get { return item; }
            set { item = value; }
        }

        private int item;

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private string valor;

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

        public static List<ItemInfoAd> GetInfos()
        {
            ItemInfoAd.AllInfos.Clear();
            if (ItemInfoAd.AllInfos.Count == 0)
                ItemInfoAd.AllInfos = ItemInfoAd.InicializarInfos();
            return ItemInfoAd.AllInfos;
        }

        private static List<ItemInfoAd> InicializarInfos()
        {
            MainConfig mc = new MainConfig();
            List<ItemInfoAd> infos = new List<ItemInfoAd>();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM licitacion_info_ad_vinc";
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            ItemInfoAd c = new ItemInfoAd();
                            c.Id = (Int32)dr["id"];
                            c.Info = (Int32)dr["id_info"];
                            c.Item = (Int32)dr["id_item"];
                            c.Valor = dr["valor"].ToString();
                            c.Created = (DateTime)dr["creado_en"];
                            c.Updated = (DateTime)dr["actualizado_en"];
                            infos.Add(c);
                        }
                    }

                }
            }
            return infos;
        }

        private static List<ItemInfoAd> AllInfos = new List<ItemInfoAd>();

        public static List<ItemInfoAd> GetInfosPorItem(int item)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<ItemInfoAd> infos = new List<ItemInfoAd>();
            foreach (ItemInfoAd c in ItemInfoAd.GetInfos())
            {
                if (c.Item == item && !yaAgregado.ContainsKey(c.Id))
                {
                    yaAgregado[c.Id] = true;
                    infos.Add(c);
                }
            }
            return infos;
        }

    }


}


