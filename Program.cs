using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = null;
            string enviarMensagem;

            Celular apple = new Celular();
            Console.WriteLine ("Qual a cor do celular?");
            apple.cor = Console.ReadLine();
            Console.WriteLine ("\nQual o modelo?");
            apple.cor = Console.ReadLine();
            Console.WriteLine ("\nQual tamanho do celular?\nPequeno\nMédio\nGrande");
            apple.cor = Console.ReadLine();

            do{
            Console.WriteLine("Digite sim para ligar o celular.");
            apple.ligado = apple.TraduzConsole(Console.ReadLine());
            }while(!apple.ligado);
                Console.WriteLine("\nligou em!!");


            do{
                Console.WriteLine("\nSelecione o que deseja fazer: \n");
                Console.WriteLine("1 - Fazer ligação");
                Console.WriteLine("2 - Enviar Mensagem");
                Console.WriteLine("0 - Desligar");
                resposta = Console.ReadLine();
            
                switch(resposta){
                    case "1":
                    Console.WriteLine("\nFazendo ligação...");
                    break;
                    case "2":
                    Console.WriteLine("\nO que deseja enviar?");
                    enviarMensagem = Console.ReadLine();
                    Console.WriteLine("\nSua mensagem escrito:\n"+enviarMensagem+"\nfoi enviada.");
                    break;
                    case "0":
                    Console.WriteLine("Desligando Celular.");
                    break;

                    default:
                    Console.WriteLine("Tente uma opção válida.");
                    break;
                }
            
            }while(resposta != "0");

        }
    }
}
