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
                            b.Expediente = (Int32)dr["expediente"];
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
        public Partida(int id, int idBases, int numPartida, string nombPartida, string especialidad, DateTime created, DateTime updated)
        {
            this.Id = id;
            this.IdBases = idBases;
            this.Numero = numPartida;
            this.Nombre = nombPartida;
            this.Especialidad = especialidad;
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
                            p.Especialidad = (string)dr["especialidad"];
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
                    partidas.Add(new Partida(p.Id, p.IdBases, p.Numero, p.Nombre, p.Especialidad, p.Created, p.Updated));
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
        public Procedimiento(int id, int partida, int numero, string nombre, DateTime created, DateTime updated)
        {
            this.Id = id;
            this.Partida = partida;
            this.Numero = numero;
            this.Nombre = nombre;
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
                            //p.Created = Convert.ToDateTime( dr["creado_en"]);
                            //p.pdated = Convert.ToDateTime( dr["actualizado_en"]);
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
                    procedimientos.Add(new Procedimiento(p.Id, p.Partida, p.Numero, p.Nombre, p.Created, p.Updated));
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

    }

    public class Item
    {
        public Item()
        {

        }

        //clase principal de los items de la licitacion
        public Item(int id, int procedimiento, string descripcion, string unidad, long cantidad, string contenedor, DateTime created, DateTime updated)
        {
            this.Id = id;
            this.Procedimiento = procedimiento;
            this.Nombre = descripcion;
            this.Unidad = unidad;
            this.Cantidad = cantidad;
            this.Contenedor = contenedor;
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

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string nombre;

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
                            i.Nombre = (string)dr["descripcion"];
                            i.Unidad = (string)dr["unidad_venta"];
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
                    items.Add(new Item(i.Id, i.Procedimiento, i.Nombre, i.Unidad, i.Cantidad, i.Contenedor, i.Created, i.Updated));
                }
            }
            return items;
        }

        //obtener los items del vinculos de los items
        public List<Vinculacion> Vinculos
        {
            get
            {
                if (this.Id != 0)
                    this.vinculos = Vinculacion.GetVinculacionesPorItem(this.Id);
                return this.vinculos;
            }
        }

        private List<Vinculacion> vinculos;
    }

    public class Vinculacion
    {
        public Vinculacion()
        {

        }

        //clase principal de los vinculos de la licitacion
        public Vinculacion(int id, int item, int cucop, int carta, DateTime created, DateTime updated)
        {
            this.Id = id;
            this.Item = item;
            this.Cucop = cucop;
            this.Carta = carta;
            this.Created = created;
            this.Updated = updated;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id;

        public int Item
        {
            get { return item; }
            set { item = value; }
        }

        private int item;

        public int Cucop
        {
            get { return cucop; }
            set { cucop = value; }
        }

        private int cucop;

        public int Carta
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
        static public List<Vinculacion> GetVinculaciones()
        {
            Vinculacion.AllVinculaciones.Clear();
            if (Vinculacion.AllVinculaciones.Count == 0)
                Vinculacion.AllVinculaciones = Vinculacion.InicializarVinculaciones();
            return Vinculacion.AllVinculaciones;
        }

        //crea el objeto con las vinculaciones 
        //llenar con un query
        static private List<Vinculacion> InicializarVinculaciones()
        {
            MainConfig mc = new MainConfig();
            List<Vinculacion> vinculos = new List<Vinculacion>();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM licitacion_vinculacion", con))
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            Vinculacion v = new Vinculacion();
                            v.Id    =   (Int32)dr["id_vinculacion"];
                            v.Item  =   (Int32)dr["id_item"];
                            if (dr["id_cucop"] != DBNull.Value)
                            {
                                v.Cucop = (Int32)dr["id_cucop"];
                            }
                            vinculos.Add(v);
                        }
                    }
                }
            }
            return vinculos;
        }

        //objeto donde se almacenan las vinculaciones
        static private List<Vinculacion> AllVinculaciones = new List<Vinculacion>();

        //obtener los items del vinculos de los items

        //obtener vinculos por item
        static public List<Vinculacion> GetVinculacionesPorItem(int item)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<Vinculacion> vinculaciones = new List<Vinculacion>();
            foreach (Vinculacion v in Vinculacion.GetVinculaciones())
            {
                if (v.item == item && !yaAgregado.ContainsKey(v.Id))
                {
                    yaAgregado[v.Id] = true;
                    vinculaciones.Add(new Vinculacion(v.Id,v.item,v.Cucop,v.Carta,v.Created,v.Updated));
                }
            }
            return vinculaciones;
        }

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

        public Calendario(int id, int bases, DateTime publicacion, DateTime junta, DateTime apertura, DateTime fallo, DateTime firma, DateTime visita, DateTime creado, DateTime actualizado)
        {
            this.Id = id;
            this.Bases = bases;
            this.Publicacion = publicacion;
            this.Junta = junta;
            this.Apertura = apertura;
            this.Fallo = fallo;
            this.Firma = firma;
            this.Visita = visita;
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
                            c.Id = (Int32)dr["id"];
                            c.Bases = (Int32)dr["id_bases"];
                            c.Publicacion = (DateTime)dr["fecha_publicacion"];
                            c.Junta = (DateTime)dr["fecha_junta_aclaraciones"];
                            c.Apertura = (DateTime)dr["fecha_apertura"];
                            c.Fallo = (DateTime)dr["fecha_fallo"];
                            c.Firma = (DateTime)dr["fecha_firma"];
                            c.Visita = (DateTime)dr["fecha_visita"];
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
                    calendarios.Add(new Calendario(c.Id,c.Bases,c.Publicacion,c.Junta,c.Apertura,c.Fallo,c.Firma,c.Visita,c.Created,c.Updated));
                }
            }
            return calendarios;
        }
    }

}

