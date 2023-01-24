

namespace LogicRecap
{
    public class Exercise8
    {
        public static void run()
        {
            int number1, number2;

            Console.WriteLine("Informe dois números para descobrir se são múltiplos entre si");

            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                if (number1 % number2 == 0)
                {
                    Console.WriteLine("\nSão múltiplos");
                }
                else
                {

                    Console.WriteLine("\nNão são múltiplos");
                }
            }
            else
            {
                if (number2 % number1 == 0)
                {
                    Console.WriteLine("\nSão múltiplos");
                }
                else
                {
                    Console.WriteLine("\nNão são múltiplos");

                }
            }
        }
    }
}
