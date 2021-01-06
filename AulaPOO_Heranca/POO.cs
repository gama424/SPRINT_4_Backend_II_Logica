using System;
using AulaPOOCelular.classes;
namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celular");

            Celular celular1 = new Celular();

             Console.WriteLine("Digite a cor do celular:");
             celular1.cor = Console.ReadLine();

             Console.WriteLine("Digite o modelo do celular:");
             celular1.modelo = Console.ReadLine();

             Console.WriteLine("Digite o tamanho do celular:");
             celular1.tamanho = Console.ReadLine();

              Console.WriteLine("Digite se o celular está ligado ou desligado s/n");
              string status = Console.ReadLine();
              if(status == "s")
              {
                celular1.ligado = true;
              }
              else
              {
                  celular1.ligado = false;
              }
              int Menu;
            do
            {
                Console.WriteLine("Escolha uma opção válida");
                Console.WriteLine("[1] Desligar");
                Console.WriteLine("[2] Fazer Ligação");
                Console.WriteLine("[3] Enviar Mensagem");
                Console.WriteLine("[0] Sair");
                Menu = int.Parse(Console.ReadLine());

                switch (Menu)
                {
                    case 1:
                    Console.WriteLine($"{celular1.Desligar(celular1.ligado)}");
                        break;
                    case 2:
                    Console.WriteLine($"{celular1.Fazerligação(celular1.ligado)}");
                    break;
                   
                string numero = Console.ReadLine();
                Ligar(numero);
                    default:
                        break;
                }
                

            } while (Menu != 0);
           
      static string Ligar(string numero)
    {
        return "Chamando...";
    }
        }
    }
}