using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcularTriangulo_XY
{
    class Triangulo
    {
        private double a;
        private double b;
        private double c;
        private double areax;
        private double areay;

        #region Construtor

        public Triangulo(double A, double B, double C)
        {
            //Triângulo X
            this.a = A;
            this.b = B;
            this.c = C;

            //Triângulo Y
            //this.yA = YA;
            //this.yb = YB;
            //this.yc = YC;
        }

        public Triangulo(double AreaX, double AreaY) 
        {
            this.areax = AreaX;
            this.areay = AreaY;
        }

        #endregion

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

        public string maiorArea() 
        {
            string msg = string.Empty;

            if (areax > areay)
            {
                return msg = "X";
            }
            else
            {
                return msg = "Y";
            }
        }

        #endregion
    }
}
