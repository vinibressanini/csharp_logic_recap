using System;
using System.Globalization;

namespace LogicRecap
{
    public class Exercise6
    {
        public static void run()
        {
           double valorA, valorB, valorC, triangulo, circulo, trapezio, quadrado, retangulo;

            Console.WriteLine("Informe o valor A: ");
            valorA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("\nInforme o valor B: ");
            valorB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("\nInforme o valor C: ");
            valorC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            triangulo = (valorA * valorC) / 2;
            circulo = Math.PI * (valorC * valorC);
            trapezio = ((valorA + valorB) * valorC) / 2;
            quadrado = valorB * valorB;
            retangulo = valorA * valorB;

            Console.WriteLine("Triângulo: " + Math.Round(triangulo,2));
            Console.WriteLine("\nCírculo: " + Math.Round(circulo,2));
            Console.WriteLine("\nTrapézio: " + Math.Round(trapezio, 2));
            Console.WriteLine("\nQuadrado: " + quadrado);
            Console.WriteLine("\nRetângulo: " + retangulo);
        }
    }
}
