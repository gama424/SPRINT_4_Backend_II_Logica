using System;

namespace AulaPOO_ProjetoDeProdutos.classes
{
    public class Usuario

    {

        public Usuario(){
            Cadastrar();
        }



        public Usuario (int _codigo, string _nome, string _email, string _senha){
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.UtcNow;
        }

        int Codigo { get; set; }


        public string Nome { get; set; }

         public string Email { get; set; }

       public  string Senha { get; set; }


        DateTime DataCadastro { get; set; }


        public void Cadastrar(){
            Nome = "Darth Vader";
            Email = "darth@vader";
            Senha = "6464";
        }

        public void Deletar(){
            Nome = "";
            Email = "";
            Senha = "";

            DataCadastro = DateTime.Parse("00 00 00");

        }


    }
}