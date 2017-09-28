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
    public partial class Cucop_Vincular_General : Form
    {
        MainConfig mc = new MainConfig();
        public int idActual = 0;
       
        public int idVinculo = 0;
        public Cucop_Vincular_General()
        {
            InitializeComponent();
        }
        public void mostrarvinculoscucop(int id)
        {
            this.idActual = id;
            tabOpciones.TabPages.Clear();
            try
            {
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT * From cucop_vinculos WHERE id_item = @item", con);
                    cmd.Parameters.AddWithValue("@item", id);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //buscar opciones, y sus vinculaciones ya establecidas
                        int current = i + 1;
                        TabPage opcion = new TabPage();
                        opcion.Text = "Opcion " + current;
                        NuevaOpcion opt = new NuevaOpcion();
                        opcion.Controls.Add(opt);
                        tabOpciones.TabPages.Add(opcion);
                        opt.pasardatosvinculo(idActual, current, Convert.ToInt32(dt.Rows[i]["id_vinculacion"]));
                        if (dt.Rows[i]["carta_apoyo"] != DBNull.Value && dt.Rows[i]["nombre"] != DBNull.Value)
                        {
                            opt.mostrarNombreProducto(dt.Rows[i]["nombre"].ToString(), Convert.ToInt32(dt.Rows[i]["carta_apoyo"]));
                        }
                        
                        opt.buscarRegistros(Convert.ToInt32(dt.Rows[i]["id_vinculacion"]));
                        opt.buscarCatalogos(Convert.ToInt32(dt.Rows[i]["id_vinculacion"]));
                        opt.buscarCertificados(Convert.ToInt32(dt.Rows[i]["id_vinculacion"]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    con.Open();
                    int cont = tabOpciones.TabPages.Count;
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO cucop_vinculos (opcion,id_item,actualizado_en) OUTPUT INSERTED.id_vinculacion
                    VALUES (@opt,@cucop,@update)", con);
                    cmd.Parameters.AddWithValue("@opt", cont + 1);
                    cmd.Parameters.AddWithValue("@cucop", idActual);
                    cmd.Parameters.AddWithValue("@update", DateTime.Now);
                    //cmd.Parameters.AddWithValue("@nombre");
                    Int32 newId = (Int32)cmd.ExecuteScalar();
                    mostrarvinculoscucop(idActual);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Cucop_Vinculos_Eliminar cve = new Cucop_Vinculos_Eliminar();
            cve.mostrarvinculoscucop(idActual);
            DialogResult result = cve.ShowDialog();
            if (result == DialogResult.OK)
            {
                mostrarvinculoscucop(idActual);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Buscar_Cucops_Vinculacion form = new Buscar_Cucops_Vinculacion();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                var origen = CucopVinculos.GetVinculacionesPorItem(form.idCucop).ToList();
                
                using (SqlConnection con = new SqlConnection(mc.con))
                {
                    con.Open();                   
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (CucopVinculos c in origen)
                        {                      
                            cmd.CommandText = @"cucop_vinculos_insert";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@opt", c.Opcion);
                            cmd.Parameters.AddWithValue("@cucop", idActual);
                            cmd.Parameters.AddWithValue("@nombre", c.Nombre );
                            cmd.Parameters.AddWithValue("@carta", c.CartaApoyo);
                            cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                            cmd.Parameters.AddWithValue("@tipo", 1);
                            Int32 idVinc = (Int32)cmd.ExecuteScalar();
                            foreach (VinculoRegistros re in c.Registros)
                            {
                                cmd.CommandText = @"cucop_vinculos_registros_insert";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@idVinculo", idVinc);
                                cmd.Parameters.AddWithValue("@idRegistro", re.Nombre);
                                cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                                Int32 idVincReg = (Int32)cmd.ExecuteScalar();
                                foreach (vinculoRegistroReferencia rerf in re.Referencias)
                                {
                                    cmd.CommandText = @"cucop_vinculos_registros_referencias_insert";
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@idVincReg", idVincReg);
                                    cmd.Parameters.AddWithValue("@idRef", rerf.Referencia);
                                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            foreach (VinculoCatalogos ca in c.Catalogos)
                            {
                                cmd.CommandText = @"cucop_vinculos_catalogos_insert";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@idVinculo", idVinc);
                                cmd.Parameters.AddWithValue("@idCatalogo", ca.Catalogo);
                                cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                                Int32 idVincCat = (Int32)cmd.ExecuteScalar();
                                foreach (vinculoCatalogoReferencia carf in ca.Referencias)
                                {
                                    cmd.CommandText = @"cucop_vinculos_catalogos_referencias_insert";
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@idVincCat", idVincCat);
                                    cmd.Parameters.AddWithValue("@idRef", carf.Referencia);
                                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            foreach (VinculoCertificados ce in c.Certificados)
                            {
                                cmd.CommandText = @"cucop_vinculos_certificados_insert";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@idVinculo", idVinc);
                                cmd.Parameters.AddWithValue("@idCertificado", ce.Nombre);
                                cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                mostrarvinculoscucop(idActual);
            }
        }
    }  
}
