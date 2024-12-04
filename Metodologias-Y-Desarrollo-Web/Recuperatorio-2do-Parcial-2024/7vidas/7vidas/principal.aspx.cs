using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace _7vidas
{
    public partial class principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                actualizarPantalla();
            }
        }

        private void actualizarPantalla()
        {
            cargarProductos();
            cargarCantidadProductos();
            cargarPrecioTotal();
        }

        private void cargarPrecioTotal()
        {
            WebService1 webService1 = new WebService1();

            List<Producto> productos = webService1.obtenerProducto();
            Double precioTotal = productos.Sum(Producto => Producto.Cantidad * Producto.Precio);
            lblPrecioTotal.Text = "El precio total es $" + precioTotal.ToString("F2");
        }

        private void cargarCantidadProductos()
        {
            int cantProductos = GridView1.Rows.Count;
            lblCantidad.Text = "La cantidad de productos es "+ cantProductos;
        }

        private void cargarProductos()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Nombre");    
            dataTable.Columns.Add("Precio");    
            dataTable.Columns.Add("Cantidad");  
            
            WebService1 webService1 = new WebService1();
            List<Producto> listProduct = webService1.obtenerProducto();

            foreach (Producto producto in listProduct) 
            {
                DataRow fila = dataTable.NewRow();
                fila["Nombre"] = producto.Nombre;
                fila["Precio"] = producto.Precio;
                fila["Cantidad"] = producto.Cantidad;
            
                dataTable.Rows.Add(fila);
            
            }
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        protected void altaProducto_Click(object sender, EventArgs e)
        {
            String Nombre = txtNombre.Text;
            Double Precio = Convert.ToDouble(txtPrecio.Text);
            Int32 Cantidad = Convert.ToInt32(txtCantidad.Text);

            Producto nuevoProducto = new Producto(Nombre, Precio, Cantidad);

            productoLoad(nuevoProducto);
            actualizarPantalla();
        }

        private void productoLoad(Producto nuevoProducto)
        {
            String path = Server.MapPath("~/Productos.xml");
            XDocument doc = XDocument.Load(path);
            XElement elemento = new XElement("Producto",
                                new XElement("Nombre", nuevoProducto.Nombre),
                                new XElement("Precio", nuevoProducto.Precio.ToString("F2")),
                                new XElement("Cantidad", nuevoProducto.Cantidad.ToString()));

            doc.Root.Add(elemento);
            doc.Save(path);

        }

        protected void descargaXML_Click(object sender, EventArgs e)// no funca, creo
        {
            Response.Clear();
            Response.ContentType = "type/xml";
            Response.AppendHeader("Content-Disposition", "attachment; filename=Productos.xml");
            Response.TransmitFile("Productos.xml");
            Response.End();
        }
    }
}