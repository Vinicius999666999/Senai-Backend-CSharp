namespace Atividade_3.Models
{
    public class IMC_Produtos
    {
        public string Nomeproduto {get; set; }

        public string Cor {get; set; }

        public string Marca {get; set; }

        public double Preco {get; set; }

        public IMC_Produtos(){

        }

        public IMC_Produtos(string nomeproduto, string cor, string marca, double preco){

            this.Nomeproduto = nomeproduto;
            this.Cor = cor;
            this.Marca = marca;
            this.Preco = preco;

        }


    }
}