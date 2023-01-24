using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicRecap
{
    public class Exercise12
    {
        public static void run()
        {
            double x, y;
            Console.WriteLine("Informe o valor de X: ");
            x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("\nInforme o valor de Y: ");
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(x == 0 && y == 0)
            {
                Console.WriteLine("\nOrigem");
            } else if (x== 0)
            {
                Console.WriteLine("\nEixo X");
            } else if (y == 0)
            {
                Console.WriteLine("\nEixo Y");
            } else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("\nQ1");
            } else if (x > 0.0 && y < 0.0)
            {
                Console.WriteLine("\nQ4");
            } else if (x < 0.0 && y >0.0)
            {
                Console.WriteLine("\nQ2");
            } else if (x <0.0 && y < 0.0)
            {
                Console.WriteLine("\nQ3");
            }
        }
    }
}
