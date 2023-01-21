using System;
using System.Globalization;

namespace LogicRecap
{
    public class Exercise5
    {
        public static void run()
        {
            int codPeca = 1, qtdPecas;
            double valorTotal = 0.0, valorUnitario;

            do
            {
                Console.WriteLine("Informe o código da peça ( informe 0 para finalizar): ");
                codPeca = int.Parse(Console.ReadLine());
               if (codPeca != 0)
                {
                    Console.WriteLine("\nInforme a quantidade de peças: ");
                    qtdPecas = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nInforme o valor unitário da peça: ");
                    valorUnitario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    valorTotal += valorUnitario * qtdPecas;
                }
            } while (codPeca != 0);

            Console.WriteLine("O valor total é: R$ " + Math.Round(valorTotal,2));
        }
    }
}
