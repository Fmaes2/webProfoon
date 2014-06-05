using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Libreria.CAD;

namespace Libreria.EN
{
    public class ArticulosEN
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private int stock;

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        private int stock_minimo;

        public int Stock_minimo
        {
            get { return stock_minimo; }
            set { stock_minimo = value; }
        }
        private int precio;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private string tipo_producto;

        public string Tipo_producto
        {
            get { return tipo_producto; }
            set { tipo_producto = value; }
        }
        private int valoracion;

        public int Valoracion
        {
            get { return valoracion; }
            set { valoracion = value; }
        }
        private string sistema_operativo;

        public string Sistema_operativo
        {
            get { return sistema_operativo; }
            set { sistema_operativo = value; }
        }
        private int destacado;

        public int Destacado
        {
            get { return destacado; }
            set { destacado = value; }
        }
        private string imagen;

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public ArticulosEN(int id, string nombre, string marca, string descripcion, int stock, int stock_minimo, int precio, string tipo_producto, int valoracion, string sistema_operativo, int destacado, string imagen)
        {
            this.id = id;
            this.nombre = nombre;
            this.marca = marca;
            this.descripcion = descripcion;
            this.stock = stock;
            this.stock_minimo = stock_minimo;
            this.precio = precio;
            this.tipo_producto = tipo_producto;
            this.valoracion = valoracion;
            this.sistema_operativo = sistema_operativo;
            this.destacado = destacado;
            this.imagen = imagen;

        }
        public ArticulosEN()
        {
            id = 0;
            nombre = "";
            marca = "";
            descripcion = "";
            stock = 0;
            stock_minimo = 0;
            precio = 0;
            tipo_producto = "";
            valoracion = 0;
            sistema_operativo = "";
            destacado = 0;
            imagen = "";

        }

        /*public static SqlDataReader articulosrecomendados()
        {
            return ArticuloCAD.Articulosrecomendados();
        }*/
        public static DataTable llenar()
        {
            return ArticuloCAD.Llenar();
        }
    }
}
