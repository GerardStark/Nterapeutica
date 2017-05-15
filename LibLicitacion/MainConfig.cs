using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace LibLicitacion
{
    public class MainConfig
    {
        public String con = @"Data Source=DESKTOP-D0FVDPE\SQLEXPRESS;Initial Catalog=Licitaciones;Integrated Security=True";
        public bool ChecarTipoUsuario(int tipo_usuario)
        {
            if (tipo_usuario != 1)
            {
                return false; 
            }
            else
            {
                return true;
            }
        }
    }
}
