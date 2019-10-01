using System;
using Atividade_2.Models;

namespace Atividade_2.Controllers {
    public class IMC_Controllers {
        IMC_Models Celular = new IMC_Models ();

        public void Cadastrarcel () {
            try {
                System.Console.WriteLine ("Qual a Cor do seu celular?:   ");
                Celular.Cor = Console.ReadLine ();

                System.Console.WriteLine ("Qual o modelo do seu celular? : ");
                Celular.Modelo = Console.ReadLine ();

                System.Console.WriteLine ("Digite o Tamanho do seu celular: ");
                Celular.Tamanho = double.Parse (Console.ReadLine ());
            } catch (Exception) {
                Console.WriteLine ("Erro");
            }

        }

        public void Ligar () {
            try {
                Celular.Ligado = true;
                System.Console.WriteLine ("Celular ligado!");
            } catch (Exception) {
                Console.WriteLine ("Erro");
            }

        }

        public void Desligar () {
            try {
                System.Console.WriteLine ("Celular desligado!");
            } catch (Exception) {
                Console.WriteLine ("Erro");
            }

            Celular.Ligado = false;

        }

        public void Ligacao () {
            try {
                if (Celular.Ligado == true) {
                    System.Console.WriteLine ("Celular fazendo ligação!!");
                } else {
                    System.Console.WriteLine ("Celular não está ligado, Impossivel de fazer uma ligação!");
                }
            } catch (Exception) {
                Console.WriteLine ("Erro");
            }

        }

        public void Mensagens () {
            try {
                if (Celular.Ligado == true) {
                    System.Console.WriteLine ("Mandando Mensagem...");
                } else {
                    System.Console.WriteLine ("O celular não est ligado! ");
                }
            } catch (Exception) {
                Console.WriteLine ("Erro");
            }

        }
    }
}