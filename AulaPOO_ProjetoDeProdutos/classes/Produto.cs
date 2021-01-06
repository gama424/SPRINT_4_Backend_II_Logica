using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.classes
{
    public class Produto
    {
        public int Codigo { get; set; }

         public string NomeProduto { get; set; }


        public float Preco { get; set; }


        public DateTime DataCadastro { get; set; }

        public Marca Marca { get; set; }

        public Usuario CadastradoPor { get; set; }

        public List<Produto> ListaDeProdutos  = new List<Produto>();


        public void Cadastrar(){
            Produto novoProduto = new Produto();

            Console.WriteLine("digite o codigo do produto");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o no medo produto");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine("digite o preço do produto");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            DataCadastro = DateTime.UtcNow;

            Marca = Marca.CadastrarMarca();

            CadastradoPor = new Usuario();

            
        }


            public void Listar(){
                Console.ForegroundColor = ConsoleColor.Blue;
                foreach (var item in ListaDeProdutos)
                {
                    
                    Console.WriteLine($"Código: {item.Codigo}");

                    Console.WriteLine($"Produto: {item.NomeProduto}");

                    Console.WriteLine($"Preço: {item.Preco}");

                    Console.WriteLine($"Data Cadastro: {item.DataCadastro}");


                    Console.WriteLine($"Marca {item.Marca.NomeMarca}");

                    Console.WriteLine($"Cadastro por {item.CadastradoPor.Nome}");

                    Console.ResetColor();
                }
            }
            public void Deletar(int cod){
            }               


            }
}

