using LibLicitacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLicitaciones
{
    public partial class Licitacion_Calendario : Form
    {
        MainConfig mc = new MainConfig();
        int idBases, idCalendario = -1;
        public Licitacion_Calendario()
        {
            InitializeComponent();
            chkCnet.CheckedChanged += common_check;
            chkDof.CheckedChanged += common_check;
            chkJA.CheckedChanged += common_check;
            chkApertura.CheckedChanged += common_check;
            chkFallo.CheckedChanged += common_check;
            chkFirma.CheckedChanged += common_check;
            chkVisita.CheckedChanged += common_check;
            chkMuestras.CheckedChanged += common_check;
            foreach (var d in this.Controls.OfType<DateTimePicker>())
            {
                d.Format = DateTimePickerFormat.Custom;
                d.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            }
            
           
        }

        public void pasaridbases(int idBases)
        {
            this.idBases = idBases;
        }

        public void mostrarFechasCalendario(int idBases)
        {
            this.idBases = idBases;
            try
            {
                var c = Calendario.GetCalendarioPorLicitacion(idBases).Single();
                this.idCalendario = c.Id;
                dtp_publicacion.Value = c.Publicacion;
                dtp_dof.Value = c.PublicacionDof;
                dtp_junta.Value = c.Junta;
                dtp_propuestas.Value = c.Apertura;
                dtp_fallo.Value = c.Fallo;
                dtp_firma.Value = c.Firma;
                dtp_visita.Value = c.Visita;
                dtp_muestras.Value = c.Muestras;

                PropertyInfo[] p = c.GetType().GetProperties();
                for (int i = 2; i < p.Length - 2; i++)
                {
                    if ((DateTime)p[i].GetValue(c) == DateTimePicker.MinimumDateTime)
                    {
                        switch (p[i].Name)
                        {
                            case "Publicacion":
                                chkCnet.Checked = true;
                                break;
                            case "PublicacionDof":
                                chkDof.Checked = true;
                                break;
                            case "Junta":
                                chkJA.Checked = true;
                                break;
                            case "Apertura":
                                chkApertura.Checked = true;
                                break;
                            case "Fallo":
                                chkFallo.Checked = true;
                                break;
                            case "Firma":
                                chkFirma.Checked = true;
                                break;
                            case "Visita":
                                chkVisita.Checked = true;
                                break;
                            case "Muestras":
                                chkMuestras.Checked = true;
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is InvalidOperationException)
                {

                }
                
            }

        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    if (idCalendario != -1)
                    {
                        using (SqlCommand cmd = new SqlCommand("licitaciones_calendario_update", con))
                        {
                            con.Open();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idCalendario", idCalendario);
                            cmd.Parameters.AddWithValue("@junta", dtp_junta.Value);
                            cmd.Parameters.AddWithValue("@apertura", dtp_propuestas.Value);
                            cmd.Parameters.AddWithValue("@fallo", dtp_fallo.Value);
                            cmd.Parameters.AddWithValue("@firma", dtp_firma.Value);
                            cmd.Parameters.AddWithValue("@visita", dtp_visita.Value);
                            cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                            cmd.Parameters.AddWithValue("@publicacion", dtp_publicacion.Value);
                            cmd.Parameters.AddWithValue("@dof", dtp_dof.Value);
                            cmd.Parameters.AddWithValue("@muestras", dtp_muestras.Value);
                            Int32 newId = cmd.ExecuteNonQuery();
                            if (newId > 0)
                            {
                                
                            }
                        }
                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand("licitaciones_calendario_insert", con))
                        {
                            con.Open();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idbases", idBases);
                            cmd.Parameters.AddWithValue("@junta", dtp_junta.Value);
                            cmd.Parameters.AddWithValue("@apertura", dtp_propuestas.Value);
                            cmd.Parameters.AddWithValue("@fallo", dtp_fallo.Value);
                            cmd.Parameters.AddWithValue("@firma", dtp_firma.Value);
                            cmd.Parameters.AddWithValue("@visita", dtp_visita.Value);
                            cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                            cmd.Parameters.AddWithValue("@publicacion", dtp_publicacion.Value);
                            cmd.Parameters.AddWithValue("@dof", dtp_dof.Value);
                            cmd.Parameters.AddWithValue("@muestras", dtp_muestras.Value);
                            Int32 newId = cmd.ExecuteNonQuery();
                        }
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Licitacion_Calendario_Load(object sender, EventArgs e)
        {
            
        }

        private void common_check(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;

            switch (chk.Name)
            {
                case "chkCnet":
                    dtp_publicacion.Enabled = (chk.CheckState == CheckState.Unchecked);
                    dtp_publicacion.Value = dtp_publicacion.MinDate;
                    break;
                case "chkDof":
                    dtp_dof.Enabled = (chk.CheckState == CheckState.Unchecked);
                    dtp_dof.Value = dtp_dof.MinDate;
                    break;
                case "chkJA":
                    dtp_junta.Enabled = (chk.CheckState == CheckState.Unchecked);
                    dtp_junta.Value = dtp_junta.MinDate;
                    break;
                case "chkApertura":
                    dtp_propuestas.Enabled = (chk.CheckState == CheckState.Unchecked);
                    dtp_propuestas.Value = dtp_propuestas.MinDate;
                    break;
                case "chkFallo":
                    dtp_fallo.Enabled = (chk.CheckState == CheckState.Unchecked);
                    dtp_fallo.Value = dtp_fallo.MinDate;
                    break;
                case "chkFirma":
                    dtp_firma.Enabled = (chk.CheckState == CheckState.Unchecked);
                    dtp_firma.Value = dtp_firma.MinDate;
                    break;
                case "chkVisita":
                    dtp_visita.Enabled = (chk.CheckState == CheckState.Unchecked);
                    dtp_visita.Value = dtp_visita.MinDate;
                    break;
                case "chkMuestras":
                    dtp_muestras.Enabled = (chk.CheckState == CheckState.Unchecked);
                    dtp_muestras.Value = dtp_muestras.MinDate;
                    break;
            }
        }
    }
}
