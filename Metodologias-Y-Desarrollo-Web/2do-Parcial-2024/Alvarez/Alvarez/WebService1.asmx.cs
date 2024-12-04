using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;

namespace Alvarez
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
      
        public List<Libro> ObtenerLibros()
        {
            List<Libro> Libros = new List<Libro>();
            String Path = Server.MapPath("~/LIBROS.xml");
            XDocument doc = XDocument.Load(Path);
            var libros = doc.Root.Elements("Libro");
            foreach (var libro in libros)
            {
                String nombre = libro.Element("Nombre").Value;
                String autor = libro.Element("Autor").Value;
                String edicion = libro.Element("Edicion").Value;
                //double edicion = Convert.ToDouble(libro.Element("Edicion").Value.ToString());
                //Double edicion = Convert.ToDouble(libro.Element("Edicion").Value.ToString());

                Libro Libro = new Libro(nombre, autor, edicion);
                Libros.Add(Libro);
            }

            return Libros;
        }
    }
}
