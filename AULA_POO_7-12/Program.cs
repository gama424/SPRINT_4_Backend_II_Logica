using System;
using AULA_POO_7_12.classes;


namespace AULA_POO_7_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //SUB CLASSES
            
         PessoaFisica pf = new PessoaFisica();
         
         
         //PŔOPRIEDADE SUB CLASSES
         pf.nome = "Darth  Vader";



         //SAUDAÇAO
         Console.WriteLine(pf.DarBoasVIndas(pf.nome));
        }
    }
}
