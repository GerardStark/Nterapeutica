﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Text.RegularExpressions;

namespace LibLicitacion
{
    public class MainConfig
    {
        public string con = @"Data Source=192.168.1.85\SQLEXPRESS;Initial Catalog=Licitaciones;Integrated Security=false; User Id=user; Password=oirwbg6v23; ";  
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
        public string obtenernombrefabricante(int id_fabricante)
        {
            string nombre = "";
            if (id_fabricante != 0)
            {
                SqlConnection conec = new SqlConnection(con);
                conec.Open();
                SqlCommand cmd = new SqlCommand("Select * from fabricantes_titulares_distribuidores where id_ftd=@id", conec);
                cmd.Parameters.AddWithValue("@id", id_fabricante);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds, "fabricantes");
                conec.Close();
                if (ds.Tables["fabricantes"].Rows.Count > 0)
                {
                    nombre = ds.Tables["fabricantes"].Rows[0]["nombre"].ToString();
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
        public void crearDirectorios(string nombre_archivo, string archivo_origen, int id, string tipo_archivo)
        {
            //obtener la direccion donde se van a guardar los archivos
            string directorio = Path.GetDirectoryName(Application.ExecutablePath) + @"\DocumentosNT\"+tipo_archivo+@"\"+id+"";
            if (Directory.Exists(directorio))
            {
                if (archivo_origen != null)
                {
                    File.Copy(archivo_origen, Path.Combine(directorio, nombre_archivo));
                }
            }
            else
            {
                Directory.CreateDirectory(directorio);
                if (archivo_origen != null)
                {
                    File.Copy(archivo_origen, Path.Combine(directorio, nombre_archivo));
                }
            }
        }
        public void llenarcombobox(string[] items, ComboBox cmb)
        {
            for (int i = 0; i < items.Length; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = items[i];
                item.Value = i + 1;
                cmb.Items.Add(item);
            }
        }
        public int obtenervaluecomboitem(string text, ComboBox cmbox)
        {
            int value = 0;
            foreach (ComboboxItem item in cmbox.Items)
            {
                if (item.Text == text)
                {
                    value = Convert.ToInt32(item.Value);
                }
            }

            return value - 1;
        }

        public string obtenernombrepais(int idpais)
        {
            string nombre = "";
            if (idpais != 0)
            {
                SqlConnection conec = new SqlConnection(con);
                conec.Open();
                SqlCommand cmd = new SqlCommand("Select * from paises_origen where id_pais=@id", conec);
                cmd.Parameters.AddWithValue("@id", idpais);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds, "paises");
                conec.Close();
                if (ds.Tables["paises"].Rows.Count > 0)
                {
                    nombre = ds.Tables["paises"].Rows[0]["nombre"].ToString();
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

        public string obtenernumeroregistro(int id_registro)
        {
            string nombre = "";
            if (id_registro != 0)
            {
                SqlConnection conec = new SqlConnection(con);
                conec.Open();
                SqlCommand cmd = new SqlCommand("Select * from registros_sanitarios where id_registro=@id", conec);
                cmd.Parameters.AddWithValue("@id", id_registro);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds, "registros");
                conec.Close();
                if (ds.Tables["registros"].Rows.Count > 0)
                {
                    nombre = ds.Tables["registros"].Rows[0]["numero_registro"].ToString();
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

        public string obtenernombrecatalogo(int id_catalogo)
        {
            string nombre = "";
            if (id_catalogo != 0)
            {
                SqlConnection conec = new SqlConnection(con);
                conec.Open();
                SqlCommand cmd = new SqlCommand("Select * from catalogos_info_general where id_catalogo=@id", conec);
                cmd.Parameters.AddWithValue("@id", id_catalogo);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds, "catalogos");
                conec.Close();
                if (ds.Tables["catalogos"].Rows.Count > 0)
                {
                    nombre = ds.Tables["catalogos"].Rows[0]["nombre_catalogo"].ToString();
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

        public string obtenernumerocertificado (int id_certificado)
        {
            string nombre = "";
            if (id_certificado != 0)
            {
                SqlConnection conec = new SqlConnection(con);
                conec.Open();
                SqlCommand cmd = new SqlCommand("Select * from certificados_calidad where id_certificado=@id", conec);
                cmd.Parameters.AddWithValue("@id", id_certificado);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds, "certificados");
                conec.Close();
                if (ds.Tables["certificados"].Rows.Count > 0)
                {
                    nombre = ds.Tables["certificados"].Rows[0]["numero_identificador"].ToString();
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

        public string convertirasentencia(string original)
        {
            var sourcestring = original;
            // start by converting entire string to lower case
            var lowerCase = sourcestring.ToLower();
            // matches the first sentence of a string, as well as subsequent sentences
            var r = new Regex(@"(^[a-z])|\.\s+(.)", RegexOptions.ExplicitCapture);
            // MatchEvaluator delegate defines replacement of setence starts to uppercase
            var result = r.Replace(lowerCase, s => s.Value.ToUpper());
            return result;
        }

        public void buscarultimafilaeditada(string tabla, DataGridView dgv)
        {
            using (SqlConnection conect = new SqlConnection(con))
            {
                using (SqlCommand cmdlatest = new SqlCommand(@"SELECT MAX(actualizado_en) FROM "+tabla+"", conect))
                {
                    SqlDataAdapter adaptlatest = new SqlDataAdapter(cmdlatest);
                    DataTable dtlatest = new DataTable();
                    adaptlatest.Fill(dtlatest);
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.Cells["updatedColumn"].Value.ToString().Equals(dtlatest.Rows[0][0].ToString()))
                        {
                            dgv.FirstDisplayedScrollingRowIndex = row.Index;
                            dgv.Rows[row.Index].Selected = true;
                        }
                    }
                }

            }
            
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
