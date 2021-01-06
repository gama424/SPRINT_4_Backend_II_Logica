namespace EXT.classes
{
    public class Pessoa
    {
        private string sobreNome;

        public string SobreNome{
            get{return sobreNome;}
            set{sobreNome = value;}
        }

        private string nome;
        
        public string Nome{
           get{return nome;}
            set{nome = value;}
        }

        public Pessoa(string firstName, string lastName){
            sobreNome = lastName;
            nome = firstName;

        }
    }
}