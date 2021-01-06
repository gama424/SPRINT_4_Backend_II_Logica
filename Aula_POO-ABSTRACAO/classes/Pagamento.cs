namespace abstracao.classes
{
    public class Pagamento
    {
             //atributos
        private System.DateTime data;

        protected float valor;

        //métodos

        public string cancelar(){
            return "";


        }
        public string Desconto(){
            
            if(valor>500){
                 return "Desconto 20%";

            }else{

            }
            
            return "Sem Desconto";
        }
    }
}
    
