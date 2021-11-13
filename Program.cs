using System;
using System.Globalization;

namespace AppCalcularTriangulo_XY
{
    /// <summary>
    /// Exercicios lives - C#
    /// Programa para calcular os valores de dois trianguls X e Y.
    /// </summary>
    class Program
    {
        public static string maiorArea(double areaX,double areaY) 
        {
            string msg = string.Empty;

            if (areaX > areaY)
            {
                return msg = "X";
            }
            else
            {
                return msg = "Y";
            }
        }

        static void Main(string[] args)
        {
            Triangulo X = new Triangulo();
            Triangulo Y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            string[] vetX = Console.ReadLine().Split(" ");
            X.a = double.Parse(vetX[0]);
            X.b = double.Parse(vetX[1]);
            X.c = double.Parse(vetX[2]);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            string[] vetY = Console.ReadLine().Split(" ");
            Y.a = double.Parse(vetY[0]);
            Y.b = double.Parse(vetY[1]);
            Y.c = double.Parse(vetY[2]);

            double areaX = X.calcularValorTriangulo();
            double areaY = Y.calcularValorTriangulo();
            string msg = maiorArea(areaX, areaY);

            Console.Clear();
            Console.WriteLine("Abaixo resultados entre os triângulos de X e Y: ");
            Console.WriteLine("Area de X = {0}", areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = {0}", areaY.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior area: {0}", msg);

            Console.ReadLine();
        }
    }
}
