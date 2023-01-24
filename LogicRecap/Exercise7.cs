using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicRecap
{
    public class Exercise7
    {
        public static void run()
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("PAR");
            } else
            {
                Console.WriteLine("ÍMPAR");
            }

        }
    }
}
