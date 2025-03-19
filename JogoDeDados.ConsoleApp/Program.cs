namespace JogoDeDados.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int limiteLinhaChegada = 30;

            while (true) 
            {
                int posicaoJogador = 0;
                bool jogoEmAndamento = true;

                while (jogoEmAndamento)
                {

                    //Cabeçalho do jogo
                    Console.Clear();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("Jogo dos dados");
                    Console.WriteLine("---------------------------");


                    Console.Write("Pressione ENTER para lançar o dado...");
                    Console.ReadLine();

                    //Gerar numero do dado
                    Random geradorNumeros = new Random();
                    int resultado = geradorNumeros.Next(1, 7);

                    //mostra o numero "sorteado"
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine($"O valor sorteado foi: {resultado}!");
                    Console.WriteLine("------------------------------------");

                    posicaoJogador += resultado;

                    if (posicaoJogador >= limiteLinhaChegada)
                    {
                        jogoEmAndamento = false;

                        Console.WriteLine("Parabens voce chegou na linha de chegada!");
                        Console.WriteLine("-------------------------------------");
                    }
                    else
                        Console.WriteLine($"Voce está na posição: {posicaoJogador} de {limiteLinhaChegada}");

                }


                Console.WriteLine("Deseja continuar? (S/N)");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S") 
                    break;
            }
        }
    }
}
