using System;

namespace sistemas_de_passagens
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis 
            string user ="";
            string senha = "";
            int opcao = 0;
            string []nomes = new string[5];
            string []destino = new string[5];
            string []origem = new string[5];
            string []data = new string[5];
            int contador = 0;
            string resp = "";

        Console.Clear();
        
        do{
            Console.WriteLine("digite seu usuario");
            user = Console.ReadLine();

            Console.WriteLine("digite sua senha!");
            senha = Console.ReadLine();

              if(senha != "123456" ){
                Console.WriteLine("senha invalida");
              }  else{
                  Console.Clear();
                  Console.WriteLine($"senha correta! \n Bem vindo {user} ");
              }
        }while( senha != "123456" );

        do{
            Console.Clear();
            Console.WriteLine($"usuario:{user} \n\n Menu Principal \n \n selecione una das opções abaixo \n14" );
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" [1] - para cadastrar passagem \n [2] - istar passagem \n [0] - sair");
            opcao = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            switch (opcao)
            {
                case 1:
                //cadastrar passagem
                do
                {
                    if(contador <5 ){
                    Console.WriteLine($"Digite o nome do {contador+1}º passageiro");
                    nomes[contador] = Console.ReadLine();
                    Console.WriteLine("dgite a Origem");
                    origem[contador] = Console.ReadLine();
                    Console.WriteLine("Digite o destino");
                    destino[contador] = Console.ReadLine();
                    Console.WriteLine("qual a data da viagem z?");
                    data[contador] = Console.ReadLine();
                    contador++;
                    }

                    Console.WriteLine("Gostaria de cadastrar outra passagem ? \n [s]-sim [n]-não");
                    resp = Console.ReadLine();
                              
                } while ( resp == "s");
                    Console.Clear();
                    break;

                case 2 :
                //listar passagem
                for (int i = 0; i <= 5; i++)
                {
                Console.WriteLine($"passageiro {i+1}: {nomes[i]} \n origem: {origem[i]}, \n Destino: {destino[i]}, \n data do voo: {data[i]}, ");
                Console.WriteLine("--------------------------||-------------------------");     
                }
                  break;

                case 0:
                //sair
                Console.WriteLine("Obrigado por viajar conosco ");
                break;    

                default:
                //opção invalida
                Console.WriteLine("opção invalidade");
                    break;
            }
            
        }while( opcao != 0 );
    
        }
        
    }
}
