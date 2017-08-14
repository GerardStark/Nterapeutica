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


}
