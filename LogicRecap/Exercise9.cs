namespace LogicRecap
{
    public class Exercise9
    {
        public static void run()
        {
            int start, end;

            Console.WriteLine("Informe a hora de início do jogo: ");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme a hora do término do jogo: ");
            end = int.Parse(Console.ReadLine());


            if (start < end)
            {
                Console.WriteLine("\nO jogo durou " + (end - start) + " horas!");
            } else
            {
                Console.WriteLine("\nO jogo durou " + ((24 - start) + end) + " horas!");
            }
        }
    }
}
