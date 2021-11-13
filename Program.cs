using System;
using System.Globalization;

namespace AppCalcularTriangulo_XY
{
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

            Triangulo triangulo = new Triangulo(XA, XB, XC, YA, YB, YC);
            double triangulox = triangulo.calcularValorTrianguloX();
            double trianguloY = triangulo.calcularValorTrianguloY();
            string maiorArea = triangulo.maiorArea();

            Console.Clear();
            Console.WriteLine("Abaixo resultados entre X e Y: ");
            Console.WriteLine("Area de X = {0}", triangulox.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = {0}", trianguloY.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior area = {0}", maiorArea);

            Console.ReadLine();
        }
    }
}
