using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Alvarez
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //UnobtrusiveValidationMode= UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Autor = txtAutor.Text;
            string Edicion = txtEdicion.Text;           

            if (Nombre == "" | Autor == "" | Edicion == "")
            {
                mostarError("Los datos del libro no son validos");
                return;

            }

            Libro NuevoLibro = new Libro(Nombre, Autor, Edicion);

            cargarLibro(NuevoLibro);

            ScriptManager.RegisterStartupScript(this, GetType(), "EjecutarCargarLibros", "cargarLibros()", true);
        }

        private void cargarLibro(Libro Libro)
        {
          
            string Path = Server.MapPath("~/LIBROS.xml");
            try
            {
                XDocument doc = XDocument.Load(Path);

                XElement ElementLibro = new XElement("Libro",
                                                                new XElement("Nombre", Libro.Nombre),
                                                                new XElement("Autor", Libro.Autor),
                                                                new XElement("Edicion", Libro.Edicion) );

                doc.Root.Add(ElementLibro);
                doc.Save(Path);

            }
            catch
            {
                mostarError("Falla al guardar en el XML");
                return;
            }
        }

        private void mostarError(string error)
        {
            Response.Write("<script>alert('" + error + "');</script>");
        }
    }
}