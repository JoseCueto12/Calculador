using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calcular.Areas
{
    public class Calculo
    {
        public decimal numero1 { get; set; }
        public decimal numero2 { get; set; }

        public decimal cuadrado(decimal n1)
        {
            decimal area;
            area = n1 * n1;
            return area;
        }

        public decimal triangulo(decimal n1, decimal n2)
        {
            decimal ba = n1;
            decimal al = n2;
            decimal area;
            area = (ba * al) / 2;
            return area;
        }

        public double circulo(double n1)
        {
            double radio = n1;
            double area;
            area = (radio * radio) * 3.1416;
            return area;
        }

        
    }
}