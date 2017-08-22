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
    public partial class Licitacion_Partidas_Principal : Form
    {
        MainConfig mc = new MainConfig();
        int idBases, idPartida;
        public Licitacion_Partidas_Principal()
        {
            InitializeComponent();
        }

        public void mostrarPartidasLicitacion(int idBases)
        {
            this.idBases = idBases;
            dgvPartidas.Rows.Clear();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT id,numero_partida,nombre_partida,especialidad,id_bases FROM licitacion_partidas WHERE id_bases = @idBases", con))
                {
                    cmd.Parameters.AddWithValue("@idBases",idBases);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0 )
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            dgvPartidas.Rows.Add(row.ItemArray);
                        }
                    }
                }
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Licitacion_Partidas_Nuevo form = new Licitacion_Partidas_Nuevo();
            form.pasarIdBases(idBases);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                mostrarPartidasLicitacion(idBases);
            }
        }

        private void dgvPartidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idPartida = (Int32)dgvPartidas.Rows[e.RowIndex].Cells["idColumn"].Value;
        }

        private void dgvPartidas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.dgvPartidas.Columns[e.ColumnIndex].Name)
            {
                case "idBasesColumn":
                    if (e.Value != null && e.Value != DBNull.Value && Convert.ToInt32(e.Value) > 0)
                    {
                        if (Convert.ToInt32(e.Value) > 0)
                        {
                            int idlicit = Convert.ToInt32(dgvPartidas.Rows[e.RowIndex].Cells["idBasesColumn"].Value);
                            e.Value = mc.obtenernumerolicitacion(idlicit);
                        }
                    }
                    else
                    {
                        e.Value = "(Vacio)";
                    }
                    break;
            }
        }

        private void btn_tecnica_Click(object sender, EventArgs e)
        {
            if (idPartida != 0)
            {
                Licitacion_Tecnica form = new Licitacion_Tecnica();
                form.MostrarProcedimientosPorPartida(idPartida);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    mostrarPartidasLicitacion(idBases);
                }
            }
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            if (idPartida != 0)
            {
                Licitacion_Partidas_Editar form = new Licitacion_Partidas_Editar();
                form.pasarInfoPartidas(idPartida);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    mostrarPartidasLicitacion(idBases);
                }
            }
        }
    }
}
