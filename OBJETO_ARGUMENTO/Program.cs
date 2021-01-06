using System;
using OBJETOARGUMENTO.classes;

namespace OBJETOARGUMENTO
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto(1,"Playstantion 2", 499);

            Produto produto2 = new Produto(2,"Dreamcast", 699);

             Produto produto3 = new Produto(3,"Nintnedo 64", 289);

             Carrinho carrinho = new Carrinho();     //INSTANCIAR


             carrinho.AdicionarProduto(produto1);
             carrinho.AdicionarProduto(produto2);
             carrinho.AdicionarProduto(produto3);



            // carrinho.RemoverProduto(produto2);   //REMOVER

            Produto produtoNovo = new Produto();
            produtoNovo.Nome = "Memory Card";

            carrinho.AlterarItem(2, produtoNovo);

            produtoNovo.Preco = 400;

             carrinho.MostrarProduto();



        }
    }
}
