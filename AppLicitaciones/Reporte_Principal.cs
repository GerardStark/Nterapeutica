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
    public partial class Reporte_Principal : UserControl
    {
        MainConfig mc = new MainConfig();
        
        public Reporte_Principal()
        {
            InitializeComponent();
            
            radAct.CheckedChanged += radioEstadosLicic;
            radConc.CheckedChanged += radioEstadosLicic;
        }

        private void radioEstadosLicic(object sender, EventArgs e)
        {

            var bases = Licitacion.GetBases();
            RadioButton rad = sender as RadioButton;
            if (rad.Name == "radAct")
            {
                for (int i = 0; i < bases.Count; i++)
                {
                    if (bases[i].Calendarios.Single().Firma > DateTime.Today)
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = bases[i].NumeroLicitacion;
                        item.Value = i + 1;
                        cmbNumLicit.Items.Add(item);
                    }
                }
            }
            else if (rad.Name == "radConc")
            {
                for (int i = 0; i < bases.Count; i++)
                {
                    if (bases[i].Calendarios.Single().Firma < DateTime.Today)
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = bases[i].NumeroLicitacion;
                        item.Value = i + 1;
                        cmbNumLicit.Items.Add(item);
                    }
                }
            }
        }
    }

    
}
