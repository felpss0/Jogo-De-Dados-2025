namespace JogoDeDados.ConsoleApp
{
    internal class Program
    {

        const int limiteLinhaChegada = 30;

        static void Main(string[] args)
        {
            

            while (true)
            {

                bool jogoEmAndamento = true;
                int posicaoUsuario = 0;
                int posicaoComputador = 0;

                while (jogoEmAndamento)
                {

                   posicaoUsuario = RodadaJogador( posicaoUsuario);
                    
                   posicaoComputador =  RodadaComputador( posicaoComputador);

                    if (posicaoComputador >= limiteLinhaChegada || posicaoUsuario >= limiteLinhaChegada)
                    {
                        jogoEmAndamento = false;
                        break;
                    }                    

                   Console.ReadLine();

                }


                Console.WriteLine("Deseja continuar? (S/N)");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }

        static int SortearDado()
        {
            int resultado;
            do
            {
                Random geradorNumeros = new Random();
                resultado = geradorNumeros.Next(1, 7);
                if (resultado == 6) 
                {
                    Console.WriteLine("Voce rolou um 6! jogue novamente");
                }
            
            
            } while (resultado == 6);
            return resultado;
        }

        static int RodadaJogador( int posicaoUsuario) 
        {
            

            //Cabeçalho do jogo
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Jogo dos dados");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Rodada do Usuario");
            Console.WriteLine("---------------------------");
            Console.Write("Pressione ENTER para lançar o dado...");
            Console.ReadLine();

            //Gerar numero do dado
            int resultadoUsuario = SortearDado();
            

            //mostra o numero "sorteado"
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"O valor sorteado foi: {resultadoUsuario}!");
            Console.WriteLine("------------------------------------");
            

            posicaoUsuario += resultadoUsuario;

            Console.WriteLine($"Voce está na posição: {posicaoUsuario} de {limiteLinhaChegada}");

            if (posicaoUsuario == 5 || posicaoUsuario == 10 || posicaoUsuario == 15 || posicaoUsuario == 25)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");

                posicaoUsuario += 3;

                Console.WriteLine($"Voce avançou para a posição: {posicaoUsuario}!");
            }
            else if (posicaoUsuario == 7 || posicaoUsuario == 13 || posicaoUsuario == 20)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");

                posicaoUsuario -= 2;

                Console.WriteLine($"Voce recuou para a posição: {posicaoUsuario}!");
            }


            if (posicaoUsuario >= limiteLinhaChegada)
            {

                Console.WriteLine("Parabens voce chegou na linha de chegada!");

                
                                
            }

           

            return posicaoUsuario;
        }

        static int RodadaComputador( int posicaoComputador) 
        {
            

            Console.WriteLine("Rodada do Computador");
            Console.WriteLine("---------------------------");
            Console.Write("Pressione ENTER para visualizar a rodada do computador...");
            Console.ReadLine();



            int resultadoComputador = SortearDado();

            //mostra o numero "sorteado"
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"O valor sorteado foi: {resultadoComputador}!");
            Console.WriteLine("------------------------------------");

            posicaoComputador += resultadoComputador;

            Console.WriteLine($"O computador está na posição: {posicaoComputador} de {limiteLinhaChegada}");

            if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15 || posicaoComputador == 25)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");

                posicaoComputador += 3;

                Console.WriteLine($"O Computador avançou para a posição: {posicaoComputador}!");
            }
            else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");

                posicaoComputador -= 2;

                Console.WriteLine($"O Computador recuou para a posição: {posicaoComputador}!");
            }


            if (posicaoComputador >= limiteLinhaChegada)
            {

                Console.WriteLine("Qeu pena o computador chegou na linha de chegada!");

                

                
            }

            return posicaoComputador;
        }
    }


   

    
}
