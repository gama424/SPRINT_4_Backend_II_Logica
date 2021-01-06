using System;

namespace atributos_e_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem1 = new Personagem();

            objetoPersonagem1.nome = "darth";
            objetoPersonagem1.idade = 99;
            objetoPersonagem1.equipamento = "sabre de luz";



                 Personagem objetoPersonagem2 = new Personagem();


                 
            objetoPersonagem2.nome = "luke";
            objetoPersonagem2.idade = 45;
            objetoPersonagem2.equipamento = "sabre de luz";

            
            Console.WriteLine($"Personagem 1 = {objetoPersonagem1.nome} - {objetoPersonagem1.Atacar()}");
            
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem1.Defender()}");
    }
}
}
