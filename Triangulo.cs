using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcularTriangulo_XY
{
    class Triangulo
    {
        public double a;
        public double b;
        public double c;

        #region Métodos

        private double calculaValorP(double A, double B, double C)
        {
            double p = (A + B + C) / 2;
            return p;
        }

        public double calcularValorTriangulo()
        {
            double p = calculaValorP(a, b, c);
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        #endregion
    }
}
