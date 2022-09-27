using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calcular.Areas
{
    /// <summary>
    /// Descripción breve de CalculadorAreas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculadorAreas : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public decimal cuadrado(decimal n1)
        {
            Calculo c = new Calculo();
            return c.cuadrado(n1);
        }

        [WebMethod]
        public decimal triangulo(decimal n1, decimal n2)
        {
            Calculo c = new Calculo();
            return c.triangulo(n1, n2);
        }

        [WebMethod]
        public double circulo(double n1)
        {
            Calculo c = new Calculo();
            return c.circulo(n1);
        }
    }
}
