namespace POO_interface.classes
{
    public interface ICarrinho
    {
         //CRUD 
         //CREATE
        void Cadastrar( Produto produto );

         //READ - LER
        void Listar();


        //UPDATE / ALTERAR
        void Alterar( int cod, Produto produto );

         //DELETE 
         void Deletar( Produto produto );
    }
}