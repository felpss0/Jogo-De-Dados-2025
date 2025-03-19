namespace JogoDeDados.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();
                Console.WriteLine("---------------------------");
                Console.WriteLine("Jogo dos dados");
                Console.WriteLine("---------------------------");

                Console.Write("Pressione ENTER para lançar o dado...");
                Console.ReadLine();

                Random geradorNumeros = new Random();

                int resultado = geradorNumeros.Next(1, 7);

                Console.WriteLine("------------------------------------");
                Console.WriteLine($"O valor sorteado foi: {resultado}!");
                Console.WriteLine("------------------------------------");


                Console.WriteLine("Deseja continuar? (S/N)");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S") 
                    break;
            }
        }
    }
}
