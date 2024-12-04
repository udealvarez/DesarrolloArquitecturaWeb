using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alvarez
{
    public class Libro
    {
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Edicion { get; set; }

        public Libro() { }

        public Libro(string nombre, string autor, string edicion)
        {
            Nombre = nombre;
            Autor = autor;
            Edicion = edicion;
        }
    }
}