using LibLicitacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLicitaciones
{
    public partial class Licitacion_Visualizar : Form
    {
        int idLicit;
        MainConfig mc = new MainConfig();
        public Licitacion_Visualizar()
        {
            InitializeComponent();
        }

        public void mostrarInfoBases(int idLicitacion)
        {
            this.idLicit = idLicitacion;
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM licitacion_bases WHERE id_bases = @idBases",con))
                {
                    cmd.Parameters.AddWithValue("@idBases", idLicitacion);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        
                        lbl_numero.Text = dt.Rows[0]["numero_licitacion"].ToString();
                        lbl_unidad.Text = dt.Rows[0]["unidad_compradora"].ToString();
                        lbl_entidad.Text = obtenerNombreEntidadFederativa((Int32)dt.Rows[0]["entidad_federativa"]);//obtener texto
                        //lbl_spec.Text = dt.Rows[0]["especialidad"].ToString();
                        lbl_tipocontrato.Text = dt.Rows[0]["tipo_contratacion"].ToString();
                        lbl_durcontrato.Text = dt.Rows[0]["duracion_contrato"].ToString();
                        lbl_numexped.Text = dt.Rows[0]["expediente"].ToString();
                        lbl_tipoexp.Text = obtenerTipoExpediente((Int32)dt.Rows[0]["tipo_expediente"]);//obtener texto
                        lbl_operador.Text = dt.Rows[0]["operador_nombre"].ToString();
                        lbl_correo.Text = dt.Rows[0]["operador_correo"].ToString();
                        lbl_desc.Text = dt.Rows[0]["descripcion"].ToString();
                        lbl_archivo.Text = dt.Rows[0]["dir_archivo"].ToString();
                        obtenercalendario(idLicit);
                    }
                }
            }
        }
        public void obtenercalendario(int idlicit)
        {
            var bases = Licitacion.GetBases().Where(x => x.Id == idlicit).Single();
            var c = bases.Calendarios.Single();
            lblCnet.Text = c.Publicacion.ToString();
            lblDof.Text = c.PublicacionDof.ToString();
            lblJA.Text = c.Junta.ToString();
            lblApertura.Text = c.Apertura.ToString();
            lblFallo.Text = c.Fallo.ToString();
            lblFirma.Text = c.Firma.ToString();
            lblVisita.Text = c.Visita.ToString();

            PropertyInfo[] p = c.GetType().GetProperties();
            for (int i = 2; i < p.Length - 2; i++)
            {
                

                if ((DateTime)p[i].GetValue(c) == DateTimePicker.MinimumDateTime)
                {
                    switch (p[i].Name)
                    {
                        case "Publicacion":
                            lblCnet.Text = "No aplica";
                            break;
                        case "PublicacionDof":
                            lblDof.Text = "No aplica";
                            break;
                        case "Junta":
                            lblJA.Text = "No aplica";
                            break;
                        case "Apertura":
                            lblApertura.Text = "No aplica";
                            break;
                        case "Fallo":
                            lblFallo.Text = "No aplica";
                            break;
                        case "Firma":
                            lblFirma.Text = "No aplica";
                            break;
                        case "Visita":
                            lblVisita.Text = "No aplica";
                            break;
                    }
                }
            }
            

        }
        private string obtenerNombreEntidadFederativa(int id)
        {
            string nombre = "";
            if (id != 0)
            {
                SqlConnection conec = new SqlConnection(mc.con);
                conec.Open();
                SqlCommand cmd = new SqlCommand("Select * from aux_entidades_federativas where id=@id", conec);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds, "entidades");
                conec.Close();
                if (ds.Tables["entidades"].Rows.Count > 0)
                {
                    nombre = ds.Tables["entidades"].Rows[0]["nombre_estado"].ToString();
                }
                else
                {
                    nombre = "(Vacio)";
                }
            }
            else
            {
                nombre = "(Vacio)";
            }
            return nombre;
        }

        private string obtenerTipoExpediente(int id)
        {
            string nombre = "";
            if (id != 0)
            {
                SqlConnection conec = new SqlConnection(mc.con);
                conec.Open();
                SqlCommand cmd = new SqlCommand("Select * from aux_tipos_expediente where id=@id", conec);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds, "expedientes");
                conec.Close();
                if (ds.Tables["expedientes"].Rows.Count > 0)
                {
                    nombre = ds.Tables["expedientes"].Rows[0]["tipo_expediente"].ToString();
                }
                else
                {
                    nombre = "(Vacio)";
                }
            }
            else
            {
                nombre = "(Vacio)";
            }
            return nombre;
        }

        private void btn_archivo_Click(object sender, EventArgs e)
        {
            string newpath = Path.GetDirectoryName(Application.ExecutablePath) + @"\DocumentosNT\Licitaciones\";
            string pathanexos = newpath + "\\" + idLicit + "\\" + lbl_archivo.Text;

            if (lbl_archivo.Text != "(Vacio)")
            {
                try
                {
                    System.Diagnostics.Process.Start(pathanexos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_reg_guardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_reg_editar_Click(object sender, EventArgs e)
        {
            Licitacion_Editar form = new Licitacion_Editar();
            form.llenarFormularioEdicionLicitacion(idLicit);
           
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.mostrarInfoBases(idLicit);
            }
        }

        private void btn_reg_borrar_Click(object sender, EventArgs e)
        {
            Licitacion licit = Licitacion.GetBases().Where(x => x.Id == idLicit).Single();
            using (SqlConnection con = new SqlConnection(mc.con))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    DialogResult result = MessageBox.Show("Borrar Licitacion: "+licit.NumeroLicitacion+"?","Borrar Licitacion",MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            cmd.Connection = con;
                            foreach (Acta a in licit.Actas)
                            {
                                cmd.CommandText = "DELETE FROM licitacion_actas WHERE id=" + a.Id;
                                cmd.ExecuteNonQuery();

                            }

                            foreach (Calendario c in licit.Calendarios)
                            {
                                cmd.CommandText = "DELETE FROM licitacion_calendario WHERE id_calendario=" + c.Id;
                                cmd.ExecuteNonQuery();
                            }

                            foreach (Partida p in licit.Partidas)
                            {
                                foreach (Procedimiento q in p.Procedimientos)
                                {
                                    foreach (Item i in q.Items)
                                    {
                                        foreach (Pregunta r in i.Preguntas)
                                        {
                                            cmd.CommandText = "DELETE FROM licitacion_preguntas WHERE id=" + r.Id;
                                            cmd.ExecuteNonQuery();
                                        }

                                        foreach (CucopVinculos v in i.Vinculos)
                                        {
                                            
                                            cmd.CommandText = "DELETE FROM licitacion_vinculacion WHERE id_vinculacion = " + v.Id;
                                            cmd.ExecuteNonQuery();
                                        }
                                        cmd.CommandText = "DELETE FROM licitacion_items WHERE id_item = " + i.Id;
                                        cmd.ExecuteNonQuery();
                                    }
                                    cmd.CommandText = "DELETE FROM licitacion_subpar_proce WHERE id=" + q.Id;
                                    cmd.ExecuteNonQuery();
                                }
                                cmd.CommandText = "DELETE FROM licitacion_partidas WHERE id=" + p.Id;
                                cmd.ExecuteNonQuery();
                            }
                            cmd.CommandText = "DELETE FROM licitacion_bases WHERE id_bases = " + licit.Id;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Borrado");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void Licitacion_Visualizar_Load(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
