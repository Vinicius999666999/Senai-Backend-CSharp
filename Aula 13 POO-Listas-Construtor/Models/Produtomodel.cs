namespace Aula_13_POO_Listas_Construtor.Models
{
    public class Produtomodel
    {
        public int IdProduto {get;set; }

        public string Nomeproduto {get; set; }

        public string Descricao {get; set; }

        public double Preco {get; set; }

        public Produtomodel(){
            
        }

        public Produtomodel(int idproduto, string nomeproduto, string descricao, double preco){

            this.IdProduto = idproduto;
            this.Nomeproduto = nomeproduto;
            this.Descricao = descricao;
            this.Preco = preco;

        }
    }
}