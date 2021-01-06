using System;
using Encapsulamento;
namespace Encapsulamento.classes
{
    class Program
    {
        static void Main(string[] args)
        {
           Visa m = new Visa();

           m.Parcelas = 12;

           Console.WriteLine(m.Parcelas);
        }
    }
}
