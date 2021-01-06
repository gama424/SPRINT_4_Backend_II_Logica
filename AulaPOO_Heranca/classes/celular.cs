namespace AulaPOOCelular.classes
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;

        public string Desligar(bool ligado)
        {
            if(this.ligado)
            {
                return "desligando...";
            }
            else{
                return "O celular ja esta desligado";
            }
        }
        public string Fazerligação(bool ligado)
        {
            if(this.ligado)
            {
                return "Digite o número que deseja chamar";
            }
            else{
                return "O celular esta desligado";
            }
        }
      
    }
}