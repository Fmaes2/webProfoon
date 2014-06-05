using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Libreria.EN;


namespace Libreria.CAD
{
    public class ClienteCAD
    {
        private const string s = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Profoon.mdf;User Instance=true";


        public void AgregarCliente(ClientesEN clientes)
        {
            ClientesEN cliente = clientes;
            SqlConnection c = new SqlConnection(s);
            c.Open();
            string f = String.Format("{0:yyyy-MM-dd HH:mm:ss}", cliente.FechaAlta);
            SqlCommand com = new SqlCommand("INSERT into Clientes VALUES (" + cliente.Dni + ", '" + cliente.Email + "', '" + cliente.Password +
                    "', '" + cliente.Nombre + "', '" + cliente.Apellidos + "', '" + cliente.FechaAlta + "','" + cliente.Tipo_cliente + "' )", c);
            com.ExecuteNonQuery();
            c.Close();
 
        }
        public static bool Clienteesta(string dni, string password)
        {
            bool esta = false;

            SqlConnection c = new SqlConnection(s);
            c.Open();
            SqlCommand com = new SqlCommand("SELECT * FROM Clientes WHERE (dni = '"+dni+"') AND (password = '"+password+"')", c);
            SqlDataReader dr = com.ExecuteReader();
            esta = dr.HasRows;

            dr.Close();
            c.Close();

            return esta;
        }
        public static bool Clientyaregistrado(string dni)
        {
            bool esta = false;

            SqlConnection c = new SqlConnection(s);
            c.Open();
            SqlCommand com = new SqlCommand("Select * from Clientes where dni='" + dni + "'", c);
            SqlDataReader dr = com.ExecuteReader();
            esta = dr.HasRows;

            dr.Close();
            c.Close();

            return esta;
        }
        public static ClientesEN Clientelogueado(string dni)
        {

            SqlConnection c = new SqlConnection();
            c.Open();
            SqlCommand com = new SqlCommand("Select * from Clientes where dni ='" + dni + "'", c);
            SqlDataReader leer = com.ExecuteReader();
            
                ClientesEN cliente = new ClientesEN(leer["dni"].ToString(), leer["email"].ToString(),leer["password"].ToString(), leer["nombre"].ToString(), leer["apellidos"].ToString());
            
            leer.Close();
            c.Close();

            return cliente;            
        }
    }
}
