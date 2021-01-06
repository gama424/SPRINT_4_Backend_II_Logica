using System;
using EX2.classes;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            
            produto1.Codigo = 1;
            produto1.Nome = "Tubaina";
            produto1.Descricao = "O mais refrescante";
            produto1.Estoque = 30;


               Console.WriteLine($"Produto 1 Código {produto1.Codigo}, nome {produto1.Nome} Descrição {produto1.Descricao}, Estoque {produto1.Estoque}");


               Produto produto2 = new Produto(10);

            Console.WriteLine($"Codigo Inserido {produto2.Codigo}, nome {produto2.Nome}");
        }
    }
}
