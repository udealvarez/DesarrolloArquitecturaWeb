using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _10diegote
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
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        public double Calcular_Promedio(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public double Calcular_NotaMenor(double nota1, double nota2, double nota3)
        {
            return Math.Min(nota1, Math.Min(nota2, nota3));
        }


        public string Calcular_Condicion(double promedio)
        {
            return promedio < 4 ? "No aprobado" : "Aprobado";
        }
    }
}
