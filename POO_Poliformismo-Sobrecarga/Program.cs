using System;
using POO_Poliformismo_Sobrecarga.classes;

namespace POO_Poliformismo_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
           Funcionario fun = new Funcionario();

           fun.Mostrar();
           fun.Mostrar("Darth Vader");
            fun.Mostrar(3);

            Console.Beep();


        }
    }
}
