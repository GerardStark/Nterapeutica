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

namespace LibLicitacion
{
    public class MainConfig
    {
        public String con = @"Data Source=APOYO3-LAP\SQLEXPRESS;Initial Catalog=Licitaciones;Integrated Security=True";
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
            string directorio = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DocumentosNT\"+tipo_archivo+@"\"+id+"";
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

    public class ListViewItemWithId
    {
        public string Text { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return Text.ToString();
        }
    }
}
