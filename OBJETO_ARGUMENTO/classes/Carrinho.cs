using System;
using System.Collections.Generic;

namespace OBJETOARGUMENTO.classes
{
    public class Carrinho
    {
           public float ValorTotal { get; set; }



            List<Produto> listaDeProdutos = new List<Produto>();      //LISTAS

           public void AdicionarProduto(Produto produto){
               listaDeProdutos.Add(produto);
                }



               public void RemoverProduto(Produto produto){
                   listaDeProdutos.Remove(produto)

               }


               public void MostrarProduto(){
                   if(listaDeProdutos != null){
                       foreach (var item in listaDeProdutos);
                   }

                   {
                            Console.ForegroundColor = ConsoleColor.Green;
                            
                            Console.WriteLine($"R${item.Preco.ToString("n2")} - Nome {item.Nome}");
                            Console.ResetColor();

                   }else
                   {
                       Console.WriteLine("Nenhum Produto Encontrado");
                   }

               }

               public void AlterarItem(int _codigo, Produto _produtoNovo)
               {

                   if(_produtoNovo.Nome != null)
                   {
                    listaDeProdutos.Find(x => x.Codigo == _codigo).Nome = _produtoNovo.Nome;
                   }
                
                    if(_produtoNovo.Preco != null){

                    listaDeProdutos.Find(x => x.Codigo == _codigo).Preco = _produtoNovo.Preco;
                    }
               }
    }
}