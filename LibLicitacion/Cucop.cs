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
}
