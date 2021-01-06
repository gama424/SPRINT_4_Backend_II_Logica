namespace AULA_POO_7_12.classes
{
    public class PessoaFisica : Pessoa
    {
        public string cpf;

        public string rg;

        public bool validarCPF(string documento){
            
                if(documento != ""){
                          return true;
                
                }
                  return false;
          
        }
    }
}