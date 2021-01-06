namespace Encapsulamento.classes
{
    public class Cartao
    {
              private string numero;           //ATRIBUTOS

        private string bandeira;

        protected string token = "1234567";

        private string cvv;

        protected float limite = 5000;
         
         //METODOS
            public string RegistrarCompra(bool validado){

                return "";
            }
            private bool ValidarCompra(float saldo){

                return true;
            }


            protected string ValidarToken(string token){

                    return "";
            } 
                
        }  

       

    
}
    
