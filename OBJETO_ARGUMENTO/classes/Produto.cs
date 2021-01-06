namespace OBJETOARGUMENTO.classes
{
    public class Produto
    {

        public int Codigo { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }
        

        public Produto(){

        }
        
        public Produto(int _codigo, string _nome, float _preco)       //GET STRUTURE   ATALHO FACIL
        {
            Codigo = _codigo;
            Nome = _nome;
            Preco = _preco;
        }
        
        
    }
}