
using System.Globalization;

namespace LogicRecap
{
    public class Exercise11
    {
        public static void run()
        {
            double number;

            Console.WriteLine("Informe um número:");
            number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (number > 0 && number <= 25)
            {
                Console.WriteLine("\nIntervalo [0 - 25]");
            } else if (number > 25 && number <= 50)
            {
                Console.WriteLine("\nIntervalo [25 - 50]");
            } else if (number > 50 && number <= 75)
            {
                Console.WriteLine("\nIntervalo [50 - 75]");
            } else if (number > 75 && number <= 100)
            {
                Console.WriteLine("\nIntervalo [75 - 100]");
            } else
            {
                Console.WriteLine("\nFora do intervalo!");
            }
        }
    }
}
