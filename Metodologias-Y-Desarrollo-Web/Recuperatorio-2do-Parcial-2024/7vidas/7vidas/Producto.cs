using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _7vidas
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public Producto()
        {
        }

        public Producto(string nombre, double precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}