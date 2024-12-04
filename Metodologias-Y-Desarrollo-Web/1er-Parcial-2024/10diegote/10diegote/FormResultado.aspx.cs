using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace _10diegote
{
    public partial class FormResultado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string nombre = Request.Form["txtAlumno"];
                double nota1 = Convert.ToDouble(Request.Form["txtNota1"]);
                double nota2 = Convert.ToDouble(Request.Form["txtNota2"]);
                double nota3 = Convert.ToDouble(Request.Form["txtNota3"]);

                WebService1 service = new WebService1();

                double promedio = service.Calcular_Promedio(nota1, nota2, nota3);
                double notaMenor = service.Calcular_NotaMenor(nota1, nota2, nota3);
                string condicion = service.Calcular_Condicion(promedio);

                lblAlumno.Text = nombre;
                lblPromedio.Text = promedio.ToString("F2");
                lblNotaMenor.Text = notaMenor.ToString("F2");
                lblCondicion.Text = condicion;

                ViewState["Nota1"] = nota1;
                ViewState["Nota2"] = nota2;
                ViewState["Nota3"] = nota3;
            }
        }

        protected void btnDescargarXML_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement element = doc.CreateElement("Alumno");

            XmlElement nombre = doc.CreateElement("Nombre");
            nombre.InnerText = lblAlumno.Text;
            element.AppendChild(nombre);

            XmlElement nota1 = doc.CreateElement("Nota1");
            nota1.InnerText = ViewState["Nota1"].ToString();
            element.AppendChild(nota1);

            XmlElement nota2 = doc.CreateElement("Nota2");
            nota2.InnerText = ViewState["Nota2"].ToString();
            element.AppendChild(nota2);

            XmlElement nota3 = doc.CreateElement("Nota3");
            nota3.InnerText = ViewState["Nota3"].ToString();
            element.AppendChild(nota3);

            XmlElement promedio = doc.CreateElement("Promedio");
            promedio.InnerText = lblPromedio.Text;
            element.AppendChild(promedio);

            XmlElement condicion = doc.CreateElement("Condicion");
            condicion.InnerText = lblCondicion.Text;
            element.AppendChild(condicion);

            XmlElement notaMenor = doc.CreateElement("NotaMenor");
            notaMenor.InnerText = lblNotaMenor.Text;
            element.AppendChild(notaMenor);

            doc.AppendChild(element);

            Response.Clear();
            Response.ContentType = "text/xml";
            Response.AddHeader("Content-Disposition", "attachment; filename=resultado.xml");
            doc.Save(Response.Output);
            Response.End();

        }
    }
}