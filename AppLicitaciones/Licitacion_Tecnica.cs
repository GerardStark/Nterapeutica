using LibLicitacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLicitaciones
{
    public partial class Licitacion_Tecnica : Form
    {
        int idLicitacion;
        MainConfig mc = new MainConfig();
        public Licitacion_Tecnica()
        {
            InitializeComponent();
        }
        public void mostrarListadoLicitacion(int idLicitacion)
        {
            //Muestra el listado de item de la licitacion
            this.idLicitacion = idLicitacion;
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                using (SqlCommand cmd = new SqlCommand("",con))
                {
                    
                }
            }
        }

        
    }

}
