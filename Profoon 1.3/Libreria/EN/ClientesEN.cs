using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Libreria.CAD;

namespace Libreria.EN
{
    public class ClientesEN
    {
        public ClientesEN(string dni, string password, string email, string nombre, string apellidos)
        {
            this.dni = dni;
            this.password = password;
            this.email = email;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaAlta = DateTime.Now;
            this.tipo_cliente = 1;
            
        }

        private string dni;
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellidos;
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private DateTime fechaAlta;
        public DateTime FechaAlta
        {
            get { return fechaAlta; }
            set { fechaAlta = value; }
        }

        private int tipo_cliente;
        public int Tipo_cliente
        {
            get { return tipo_cliente; }
            set { tipo_cliente = value; }
        }
        

        public void AgregarCliente()
        {
            ClienteCAD c= new ClienteCAD();
            c.AgregarCliente(this);
        }

        public static bool clienteesta(string dni, string password)
        {
            return ClienteCAD.Clienteesta(dni, password);
        }

        public static ClientesEN clientelogueado(string dni)
        {
            return ClienteCAD.Clientelogueado(dni);
        }
        public static bool clientyaregistrado(string dni)
        {
            return ClienteCAD.Clientyaregistrado(dni);
        }
        

    }
}
