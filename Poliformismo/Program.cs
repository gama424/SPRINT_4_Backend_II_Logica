using System;
using Poliformismo;


namespace Poliformismo
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan jogador = new MegaMan();
          Console.WriteLine($"jogador 1 = {jogador.Correr()}");

          Zero jogador2 = new Zero();
         Console.WriteLine($"jogador 2 = {jogador.Correr()}");
        }
    }
}
