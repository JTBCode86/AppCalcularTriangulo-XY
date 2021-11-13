using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcularTriangulo_XY
{
    class Triangulo
    {
        private double xa;
        private double xb;
        private double xc;

        private double yA;
        private double yb;
        private double yc;

        #region Construtor


        public Triangulo(double XA, double XB, double XC,double YA, double YB, double YC)
        {
            //Triângulo X
            this.xa = XA;
            this.xb = XB;
            this.xc = XC;

            //Triângulo Y
            this.yA = YA;
            this.yb = YB;
            this.yc = YC;
        }

        #endregion

        #region Métodos

        private double calculaValorP(double A, double B, double C)
        {
            double p = (A + B + C) / 2;
            return p;
        }

        public double calcularValorTrianguloX()
        {
            double p = calculaValorP(xa, xb, xc);
            double area = Math.Sqrt(p * (p - xa) * (p - xb) * (p - xc));
            return area;
        }

        public double calcularValorTrianguloY()
        {
            double p = calculaValorP(yA, yb, yc);
            double area = Math.Sqrt(p * (p - yA) * (p - yb) * (p - yc));
            return area;
        }

        public string maiorArea() 
        {
            double areax = calcularValorTrianguloX();
            double areay = calcularValorTrianguloY();
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
