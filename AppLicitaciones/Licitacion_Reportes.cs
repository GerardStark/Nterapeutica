﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLicitaciones
{
    public partial class Licitacion_Reportes : Form
    {
        int idBases;
        public Licitacion_Reportes()
        {
            InitializeComponent();
        }

        public void pasaridBases(int idBases)
        {
            this.idBases = idBases;
        }
    }
}
