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
            //this.idLicitacion = idLicitacion;
            ////crea los nodos padre
            //this.tlv_partidas.CanExpandGetter = delegate (Object x) {
            //    return (x is Partida);
            //};

            ////crea los nodos hijo
            //this.tlv_partidas.ChildrenGetter = delegate (Object x) {
            //    if (x is Partida)
            //        return ((Partida)x).Procedimientos;        

            //    throw new ArgumentException("Debe ser Partida o Procedimiento");
            //};

            //this.tlv_partidas.SetObjects(Partida.GetPartidasPorBase(idLicitacion));
            this.idLicitacion = idLicitacion;
        }

        


        //obtener el id del procedimiento y mostrar los items en la OLV
    }

}
