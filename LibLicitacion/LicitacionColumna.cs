using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibLicitacion
{
    public class LicitacionColumna
    {
        public int numero { get; set; }
        public string nombre { get; set; }
        public int padre { get; set; }
        public override string ToString()
        {
            return nombre.ToString();
        }
    }
}
