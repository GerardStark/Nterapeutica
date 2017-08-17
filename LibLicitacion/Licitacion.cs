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
                if (this.id != 0)
                    this.partidas = Partida.GetPartidasPorBase(this.id);
                return this.partidas;
            }
        }

        private List<Partida> partidas;
    }    

    public class Partida
    {
        public Partida()
        {

        }

        //clase principal de las partidas
        public Partida(int id, int idBases, int numPartida, string nombPartida, string spec, DateTime created, DateTime updated)
        {
            this.Id = id;
            this.IdBases = idBases;
            this.Numero = numPartida;
            this.Nombre = nombPartida;
            this.Spec = spec;
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

        public string Spec
        {
            get { return spec; }
            set { spec = value; }
        }

        private string spec;

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
        static  List<Partida> GetPartidas()
        {
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
                if (p.idBases == idBases && !yaAgregado.ContainsKey(p.id))
                {
                    yaAgregado[p.id] = true;
                    partidas.Add(new Partida(p.Id, p.IdBases, p.Numero, p.Nombre, p.Spec, p.Created, p.Updated));
                }
            }
            return partidas;
        }

        //obtener los procedimientos correspondientes a cada partida
        public List<Procedimiento> Procedimientos
        {
            get
            {
                if (this.id != 0)
                    this.procedimientos = Procedimiento.GetProcedimientosPorPartidas(this.id);
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
        static  List<Procedimiento> GetProcedimientos()
        {
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
                if (p.partida == partida && !yaAgregado.ContainsKey(p.id))
                {
                    yaAgregado[p.id] = true;
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
                if (this.id != 0)
                    this.items = Item.GetItemsPorProcedimiento(this.id);
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
        public Item(int id, int procedimiento, string descripcion, string unidad, DateTime created, DateTime updated)
        {
            this.Id = id;
            this.Procedimiento = procedimiento;
            this.Nombre = descripcion;
            this.Unidad = unidad;
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
        static  List<Item> GetItems()
        {
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
                if (i.procedimiento == proce && !yaAgregado.ContainsKey(i.id))
                {
                    yaAgregado[i.id] = true;
                    items.Add(new Item(i.Id, i.Procedimiento, i.Nombre, i.Unidad, i.Created, i.Updated));
                }
            }
            return items;
        }

        //obtener los items del vinculos de los items
        public List<Vinculacion> Vinculos
        {
            get
            {
                if (this.id != 0)
                    this.vinculos = Vinculacion.GetVinculacionesPorItem(this.id);
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
        static  List<Vinculacion> GetVinculaciones()
        {
            if (Vinculacion.AllVinculaciones.Count == 0)
                Vinculacion.AllVinculaciones = Vinculacion.InicializarVinculaciones();
            return Vinculacion.AllVinculaciones;
        }

        //crea el objeto con las vinculaciones 
        //llenar con un query
        static private List<Vinculacion> InicializarVinculaciones()
        {
            List<Vinculacion> vinculos = new List<Vinculacion>();
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
                if (v.item == item && !yaAgregado.ContainsKey(v.id))
                {
                    yaAgregado[v.id] = true;
                    vinculaciones.Add(new Vinculacion(v.Id,v.item,v.Cucop,v.Carta,v.Created,v.Updated));
                }
            }
            return vinculaciones;
        }
    }

}
