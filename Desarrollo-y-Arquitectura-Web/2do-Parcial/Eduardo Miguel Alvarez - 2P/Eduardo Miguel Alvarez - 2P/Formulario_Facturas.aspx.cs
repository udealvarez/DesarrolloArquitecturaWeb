using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eduardo_Miguel_Alvarez___2P
{
    public partial class Formulario_Facturas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Web.UI.ValidationSettings.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string nombre = textboxNombre.Text;
            string fecha = textboxFecha.Text;
            string factura = textboxNumeroFactura.Text;

            int cantidad = int.Parse(textboxCantidad.Text);
            decimal precio = decimal.Parse(textboxPrecio.Text);

            decimal precioTotal = precio * cantidad;

            Response.Redirect($"Formulario_Cliente.aspx?nombre={nombre}&fecha={fecha}&factura={factura}&precioTotal={precioTotal}");
        }
    }
}