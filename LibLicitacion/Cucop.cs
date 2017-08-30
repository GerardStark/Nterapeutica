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

        //obtener los items del vinculos de los items

        //obtener vinculos por item
        static public List<CucopVinculos> GetVinculacionesPorItem(int item)
        {
            Dictionary<int, bool> yaAgregado = new Dictionary<int, bool>();
            List<CucopVinculos> vinculaciones = new List<CucopVinculos>();
            foreach (CucopVinculos v in CucopVinculos.GetVinculaciones())
            {
                if (v.IdCucop == item && !yaAgregado.ContainsKey(v.id))
                {
                    yaAgregado[v.id] = true;
                    vinculaciones.Add(new CucopVinculos(v.Id, v.Opcion, v.IdCucop, v.Nombre, v.CartaApoyo, v.Created, v.Updated));
                }
            }
            return vinculaciones;
        }
    }
}
