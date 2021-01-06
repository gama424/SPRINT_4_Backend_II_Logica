using System;
using POO_interface.classes;
namespace POO_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto();
            p1.Codigo = 123;
            p1.Nome = "Dreamcast";
            p1.Preco = 399;

            
            Produto p2 = new Produto();
            p1.Codigo = 120;
            p1.Nome = "Playstation 2";
            p1.Preco = 199;



            Produto p3 = new Produto();
            p1.Codigo = 69;
            p1.Nome = "Mega Drive";
            p1.Preco = 899;



            carrinho.Cadastrar(p1);
            carrinho.Listar();
            carrinho.Cadastrar(p2);

            Console.ForegroundColor = ConsoleColor.Green;

            carrinho.Alterar(p1.Codigo , p3);
            carrinho.Listar();

            Console.ResetColor();
        }
    }
}
