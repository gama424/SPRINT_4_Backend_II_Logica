using System;
using EXT.classes;

namespace EXT
{
    class Program
    {
        static void Main(string[] args)
        {
         Pessoa p = new Pessoa("DarthVader", "Boladão");


         Console.WriteLine($"Saudações {p.Nome} {p.SobreNome}");


        }
    }
}
