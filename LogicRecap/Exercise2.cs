using System;

namespace LogicRecap
{
    public class Exercise2
    {
        public static void run()
        {
            Console.WriteLine("Informe o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());

            double area = 3.14159 * (raio * raio);

            Console.WriteLine("A área do círculo é: " + Math.Round(area,4));
        }
    }
}
