using System;
using Atividade_1.Models;

namespace Atividade_1.Controllers {
    public class IMC_Controllers {
        IMC_Models pessoa = new IMC_Models ();

        public void Aluno () {
            try{
                 System.Console.WriteLine ("Digite seu nome: ");
            pessoa.Nomepessoa = Console.ReadLine ();

            System.Console.WriteLine ("Digite o nome do seu curso: ");
            pessoa.Cursopessoa = Console.ReadLine ();

            System.Console.WriteLine ("Digite sua idade: ");
            pessoa.Idadepessoa = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite o Número do seu RG: ");
            pessoa.RGpessoa = double.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Você é bolsista ?  [True/False]: ");
            pessoa.Bolsista = bool.Parse (Console.ReadLine ());

            if (pessoa.Bolsista == true) {
                System.Console.WriteLine ("Você é bolsista :)");
            } else {
                System.Console.WriteLine ("Você não é bolsista :)");
            }
            }catch(Exception){
                Console.WriteLine("Erro");
            }
           

        }

    }
}