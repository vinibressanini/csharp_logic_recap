
using System.Globalization;

namespace LogicRecap
{
    public class Exercise13
    {
        public static void run()
        {
            double tax = 0.0;
            Console.WriteLine("Informe o seu salário: ");
            double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if(salary <= 2000.00)
            {
                Console.WriteLine("\nIsento");
            } else if (salary > 2000.00 && salary <= 3000.00)
            {
                salary = salary - 2000;

                tax = salary * 0.08;
            } else if (salary > 3000.00 && salary <= 4500.00)
            {
                salary = salary - 2000;

                tax = 1000.00 * 0.08;

                salary = salary - 1000;

                tax += salary * 0.18;
            } else
            {
                salary = salary - 2000;

                tax = 1000.00 * 0.08;

                salary = salary - 1000;

                tax += 1500.00 * 0.18;

                salary = salary - 1500;

                tax += salary * 0.28;
            }
            Console.WriteLine("O total de imposto que você deve pagar é: " + tax.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
