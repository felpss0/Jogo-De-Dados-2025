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

                    Console.WriteLine($"Voce está na posição: {posicaoJogador} de {limiteLinhaChegada}");

                    if (posicaoJogador == 5 || posicaoJogador == 10 || posicaoJogador == 15 || posicaoJogador == 25)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");

                        posicaoJogador += 3;

                        Console.WriteLine($"Voce avançou para a posição: {posicaoJogador}!");
                    } 
                    else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20) 
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");

                        posicaoJogador -= 2;

                        Console.WriteLine($"Voce recuou para a posição: {posicaoJogador}!");
                    }

                    if (posicaoJogador >= limiteLinhaChegada)
                    {
                        jogoEmAndamento = false;

                        Console.WriteLine("Parabens voce chegou na linha de chegada!");
                        Console.WriteLine("-------------------------------------");
                    }
                   
                        

                }


                Console.WriteLine("Deseja continuar? (S/N)");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S") 
                    break;
            }
        }
    }
}
