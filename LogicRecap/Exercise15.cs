
namespace LogicRecap
{
    public class Exercise15
    {
        public static void run()
        {
            double x, y;
            do
            {
                Console.WriteLine("\nInforme o valor de X: ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("\nInforme o valor de Y: ");
                y = double.Parse(Console.ReadLine());
                Console.WriteLine(verifyPosition(x, y));
            } while (x != 0 && y != 0);
        }

        private static string verifyPosition (double x, double y)
        {
            if (x > 0.0 && y > 0.0)
            {
                return ("Q1");
            }
            else if (x > 0.0 && y < 0.0)
            {
                return ("Q4");
            }
            else if (x < 0.0 && y > 0.0)
            {
                return ("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                return ("Q3");
            } else
            {
                return ("");
            }
        }
    }
}
