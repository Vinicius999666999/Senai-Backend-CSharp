using System;
using System.Collections.Generic;
using Aula_13_POO_Listas_Construtor.Models;

namespace Aula_13_POO_Listas_Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instaciamos nossa classe com o metodo construtur passando os parâmetros
            Produtomodel produto = new Produtomodel(1, "Maça" , "Verde" , 3.5);

            //Chamamos um atributo do objeto instanciado
            Console.WriteLine(produto.Nomeproduto);

            //INstaciamos nossa classe sem passar parâmetros utilizando sobrecarga
            Produtomodel produto_sobrecarga = new Produtomodel();

            //Alimentamos nosso objeto que estava vazio
            produto_sobrecarga.IdProduto = 1 ;
            produto_sobrecarga.Nomeproduto = "Melão" ;
            produto_sobrecarga.Descricao = "Amarelo" ; 
            produto_sobrecarga.Preco = 5.50 ;

            //Chamamos a nossa lista que vai ser do objeto Produtomodel
            List<Produtomodel> prod = new List<Produtomodel>();

            //adicionamos objetos instanciados e atribuidos em nossa lista
            prod.Add(new Produtomodel(1, "Cenoura", "Laranja", 2.30 ) );
            prod.Add(new Produtomodel(2, "Mamão", "Laranja", 2.30 ) );
            prod.Add(new Produtomodel(3, "Churras no palitinho", "Laranja", 2.30 ) );
            prod.Add(new Produtomodel(4, "Pastel", "Laranja", 2.30 ) );
            prod.Add(new Produtomodel(5, "lanche", "Laranja", 2.30 ) );
            prod.Add(new Produtomodel(6, "Abacaxi", "Amarela", 2.30 ) );

            //Lemos os dados so nossa lista
            foreach(Produtomodel p in prod){
                Console.WriteLine();
                Console.WriteLine(p.IdProduto);
                Console.WriteLine(p.Nomeproduto);
                Console.WriteLine(p.Descricao);
                Console.WriteLine(p.Preco);
                Console.WriteLine();
            }

            //Chamamos através do indice um atributo específico
            Console.WriteLine(prod[4].Nomeproduto);

        }
    }
}
