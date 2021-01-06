using System;

namespace POO_Poliformismo_Sobrecarga.classes
{
    public class Funcionario
    {
        public string[] lista = {"Darth, Luke, R2D2, Kylo"};

        public void Mostrar(){

            //busca no array
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;

                
                if (item == busca ){}
                 Console.WriteLine("Resultado da Busca :" + item);
                {
                    
                }
               
                Console.ResetColor();
            }
        }

        public void Mostrar(int indice){


            //mostrando dados array

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(lista[indice]);
             Console.ResetColor();
        }

        public void Mostrar(string busca){

        }
    }
}