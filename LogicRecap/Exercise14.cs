
namespace LogicRecap
{
    public class Exercise14
    {
        public static void run()
        {
            string senha;
            do
            {
                Console.WriteLine("\nInforme a senha");
                senha = Console.ReadLine();
                if (senha != "2022") Console.WriteLine("\nSenha Incorreta!");
            } while (senha != "2022");

            Console.WriteLine("\nAcesso Permitido!");
        }
    }
}
