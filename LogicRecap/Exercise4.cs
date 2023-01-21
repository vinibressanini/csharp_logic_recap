using System;
using System.Globalization;

namespace LogicRecap
{
    public class Exercise4
    {
       public static void run()
        {
            int emplNumber, totalHours;
            float valuePerHour, payment;

            Console.WriteLine("Informe o número do funcionário: ");
            emplNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o total de horas trabalhadas: ");
            totalHours = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor por hora trabalhada: ");
            valuePerHour = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            payment = totalHours * valuePerHour;

            Console.WriteLine("\nFuncionário: " + emplNumber + "\nSalário: R$ " + payment.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
