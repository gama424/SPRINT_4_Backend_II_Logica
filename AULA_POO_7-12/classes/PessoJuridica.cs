namespace AULA_POO_7_12.classes
{
    public class PessoJuridica : Pessoa           //HERANÇA ::::
    {
        public string cnpj;

        public string instriçaoEstadual;

        public bool validarCNJPJ(string documento){

            if(documento != ""){
                return true;
            }
                     return false;
        
        
        }  

    }
       

    
}