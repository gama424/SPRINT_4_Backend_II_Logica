using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.classes
{
    public class Marca
    {
        int  Codigo { get; set; }

        public string NomeMarca { get; set; }

        DateTime DataCadastro { get; set; }

        List<Marca> Marcas  = new List<Marca>();


        public Marca CadastrarMarca(){

                Marca novaMarca = new Marca();
            
            Console.WriteLine("digite o codigo da marca");
            Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o nome da marca");
            NomeMarca = (Console.ReadLine());

            DataCadastro = DateTime.UtcNow;

            Marcas.Add(novaMarca);

            return novaMarca;
        }

        public void Listar(){

            Console.WriteLine("Marcas Cadastradas");
            foreach (Marca item in Marcas)
            {
                
                Console.WriteLine($"Código {item.Codigo}");
                  Console.WriteLine($"Marca {item.NomeMarca}");
                    Console.WriteLine($"DataCadastro  {item.DataCadastro}");


            }

        }
        
        public void Deletar(int cod){

            Marca marcaDelete = Marcas.Find(m => m.Codigo == cod);
            Marcas.Remove(marcaDelete);

        }
    
    
    }





}