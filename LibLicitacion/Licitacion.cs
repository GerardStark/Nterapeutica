using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibLicitacion
{
    class Licitacion
    {

    }

    public class Bases
    {
        public Bases()
        {

        }

        public Bases(int id, string numLicit, string unidadComp, int entiFedr, string spec, string durContr, string tipoContr,
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
    }

    public class Partida
    {
        public Partida()
        {

        }

        public Partida(int id, int idBases, int numPartida, string nombPartida, string spec, DateTime created, DateTime updated)
        {
            this.Id = id;
            this.IdBases = idBases;
            this.NumPartida = numPartida;
            this.NombPartida = nombPartida;
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

        public int NumPartida
        {
            get { return numPartida; }
            set { numPartida = value; }
        }

        private int numPartida;

        public string NombPartida
        {
            get { return nombPartida; }
            set { nombPartida = value; }
        }

        private string nombPartida;

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

    }

    public class Procedimiento
    {
        public Procedimiento()
        {

        }

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

    }

    public class Item
    {
        public Item()
        {

        }

        public Item(int id, int procedimiento, string descripcion, string unidad, DateTime created, DateTime updated)
        {
            this.Id = id;
            this.Procedimiento = procedimiento;
            this.Descripcion = descripcion;
            this.UnidadVenta = unidad;
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

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private string descripcion;

        public string UnidadVenta
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
    }

}
