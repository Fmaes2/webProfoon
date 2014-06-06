using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.ComponentModel;
using Libreria.EN;

namespace Libreria.CAD
{
    public class ArticuloCAD
    {
        private const string s = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Profoon.mdf;User Instance=true";


        public void buscador(string dni)
        {
            SqlConnection c = new SqlConnection(s);
            c.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Articulos", c);
            DataTable tb = new DataTable();
            da.Fill(tb);
            c.Close();
        }
        public static DataTable Llenar()
        {
            SqlConnection c = new SqlConnection(s);
            c.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Articulos where destacado=1", c);
            DataTable tb = new DataTable();
            da.Fill(tb);
            c.Close();

            return tb;
                 
        }
        public static DataTable Producto(int id)
        {
            SqlConnection c = new SqlConnection(s);
            c.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Articulos where id="+id, c);
            DataTable tb = new DataTable();
            da.Fill(tb);
            c.Close();

            return tb;

        }
    }
}
