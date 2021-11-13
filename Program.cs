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
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            string[] vetX = Console.ReadLine().Split(" ");
            double XA = double.Parse(vetX[0]);
            double XB = double.Parse(vetX[1]);
            double XC = double.Parse(vetX[2]);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            string[] vetY = Console.ReadLine().Split(" ");
            double YA = double.Parse(vetY[0]);
            double YB = double.Parse(vetY[1]);
            double YC = double.Parse(vetY[2]);

            Triangulo trianguloX = new Triangulo(XA, XB, XC);
            Triangulo trianguloY = new Triangulo(YA, YB, YC);
           
            double X = trianguloX.calcularValorTriangulo();
            double Y = trianguloY.calcularValorTriangulo();

            Triangulo objArea = new Triangulo(X, Y);
            string maiorArea = objArea.maiorArea();

            Console.Clear();
            Console.WriteLine("Abaixo resultados entre os triângulos de X e Y: ");
            Console.WriteLine("Area de X = {0}", X.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = {0}", Y.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior area: {0}", maiorArea);

            Console.ReadLine();
        }
    }
}
