using System;
using Atividade_3.Models;

namespace Atividade_3.Controllers {
    public class IMC_Controllers {
        IMC_Produtos produtos = new IMC_Produtos ();
        IMC_Reserva Reservar = new IMC_Reserva ();

        public void Cadastrarproduto () {

            try {

                System.Console.WriteLine ("Nome do produto: ");
                produtos.Nomeproduto = Console.ReadLine ();

                System.Console.WriteLine ("Cor do produto: ");
                produtos.Cor = Console.ReadLine ();

                System.Console.WriteLine ("Marca do Produto: ");
                produtos.Marca = Console.ReadLine ();

                System.Console.WriteLine ("Preço do Produto: ");
                produtos.Preco = double.Parse (Console.ReadLine ());

            } catch (Exception) {
                Console.WriteLine ("ERRO");
            }

        }

        public void Reservacao () {

            try {
                System.Console.WriteLine ("Quer reservar o produto? [True/False] ");
                Reservar.Reverva = bool.Parse (Console.ReadLine ());

                if (Reservar.Reverva == true) {
                    System.Console.WriteLine ("Seu produto foi reservado como Sucesso :) ");
                } else {
                    System.Console.WriteLine ("SEu produto não foi reservado! :)");
                }
            } catch (Exception) {
                Console.WriteLine ("ERRO");
            }

        }
    }
}