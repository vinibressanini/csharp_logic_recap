using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicRecap
{
    public class Exercise10
    {
        public static void run()
        {
            double[] values = {4.00,4.50,4.99,2.00,1.50};

            int quantity, item;
            double finalPrice;

            Console.WriteLine("Informe qual o item desejado: ");
            item = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme a quantidade desejada: ");
            quantity = int.Parse(Console.ReadLine());

            finalPrice = values[item - 1] * quantity;

            Console.WriteLine("\nTotal: R$ " + Math.Round(finalPrice,2));
        }
    }
}
