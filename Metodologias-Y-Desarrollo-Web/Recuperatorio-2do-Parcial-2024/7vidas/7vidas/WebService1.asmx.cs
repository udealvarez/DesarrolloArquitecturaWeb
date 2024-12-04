using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;

namespace _7vidas
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Producto> obtenerProducto()
        {
            List<Producto> listaProducto = new List<Producto>();
            String path = Server.MapPath("~/Productos.xml");
            XDocument doc = XDocument.Load(path);
            var productos = doc.Root.Elements("Producto");

            foreach (var producto in productos)
            {
                String Nombre = producto.Element("Nombre").Value;
                Double Precio = Convert.ToDouble(producto.Element("Precio").Value.ToString());
                Int32 Cantidad = Convert.ToInt32(producto.Element("Cantidad").Value);

                Producto producto1 = new Producto(Nombre, Precio, Cantidad);
                listaProducto.Add(producto1);            
            }
            return listaProducto;
        }
    }
}
