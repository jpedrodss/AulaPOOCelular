namespace AulaPOOCelular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;
        public bool TraduzConsole(string condicao){
            if(condicao == "sim"){
                ligado = true;
            }else{
                ligado = false;
            }
            return ligado;
        }

    }
}