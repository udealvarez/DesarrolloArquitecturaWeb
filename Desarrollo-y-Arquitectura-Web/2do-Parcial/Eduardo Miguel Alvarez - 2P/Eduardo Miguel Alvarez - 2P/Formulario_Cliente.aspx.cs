using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eduardo_Miguel_Alvarez___2P
{
    public partial class Formulario_Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelNombre.Text = Request.QueryString["nombre"];
            LabelFecha.Text = Request.QueryString["fecha"];
            LabelFactura.Text = Request.QueryString["factura"];
            LabelTotal.Text = Request.QueryString["precioTotal"];
        }
    }
}