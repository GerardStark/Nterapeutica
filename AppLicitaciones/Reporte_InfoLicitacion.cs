using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLicitacion;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AppLicitaciones
{
    public partial class Reporte_InfoLicitacion : UserControl
    {
        public Reporte_InfoLicitacion()
        {
            InitializeComponent();
        }

        private void prueba()
        {
            Reporte.InfoLicitacion x = new Reporte.InfoLicitacion();
            x.Contenido();            
        }
    }
}
