using System;

namespace LogicRecap
{
    public class Exercise3
    {
        public static void run()
        {
            int number1, number2, number3, number4, result;

            Console.WriteLine("Informe 4 números");

            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            number3 = int.Parse(Console.ReadLine());
            number4 = int.Parse(Console.ReadLine());

            result = (number1 * number2) - (number3 * number4);

            Console.WriteLine("A diferença dos produtos é de: " + result);
        }
    }

}
