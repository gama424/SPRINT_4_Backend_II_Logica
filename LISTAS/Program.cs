using System;
using System.Collections.Generic;
using LISTAS.classes;

namespace LISTAS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            Produto cafe = new Produto(2, "Café pequeno", 2.5f);

            produtos.Add(new Produto(1, "pao que o diabo amassou", 6.6f));
           produtos.Add(cafe);
           produtos.Add(new Produto(3, "mistao quente", 6.0f));
           produtos.Add(new Produto(4, "tubaina", 7.9f));



            foreach (Produto item in produtos)
            {
                    Console.WriteLine($"item codigo{item.Codigo} Nome {item.Nome} Preço {item.Preco}");
            }
        }
    }
}
