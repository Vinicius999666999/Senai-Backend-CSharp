namespace Atividade_2.Models
{
    public class IMC_Models
    {
        public string Cor {get; set; }

        public string Modelo {get; set; }

        public double Tamanho {get; set; }

        public bool Ligado {get; set; }

        public bool Desligado {get; set; }

        public bool Ligacao {get; set; }

        public bool Mensagem {get; set; }

        public IMC_Models (){

        }

        public IMC_Models (string cor, string modelo, double tamanho, bool ligado, bool desligado, bool ligacao, bool mensagem){

        this.Cor = cor;
        this.Modelo = modelo;
        this.Tamanho = tamanho;
        this.Ligado = ligado;
        this.Desligado = desligado;
        this.Ligacao = ligacao;
        this.Mensagem = mensagem;

        }
    }
}