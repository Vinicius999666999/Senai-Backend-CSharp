using System;

namespace Aula_5 {
    class Program {
        static void Main (string[] args) {

            string[] Nome =           new string[5];
            string[] Origem =         new string[5];
            string[] Destino =        new string[5];
            DateTime[] Data_ida  =   new DateTime[5];
            DateTime[] Data_volta = new DateTime[5];

            string sair = "";

            while(sair != "0"){

            Console.WriteLine("Bem vindo ao nosso sistema de passagem !");
            Console.WriteLine(
            @"Menu: 
            1 - Cadastrar
            2 - Listar passagem
            0 - Sair ");
            Console.WriteLine("");
            Console.WriteLine(""); 
            Console.WriteLine("");
            
            sair = Console.ReadLine();

            switch(sair){

            case "1":
                for(int i = 0 ; i <= 4 ; i++){

                    Console.Write("Entre com o nome do passageiro: ");
                    Nome[i] = Console.ReadLine(); 

                    Console.Write("Digite a UF de origem: ");
                    Origem[i] = Console.ReadLine();

                    Console.Write("Qual o seu destino: ");
                    Destino[i] = Console.ReadLine();

                    Console.Write("Data de IDA: ");
                    Data_ida[i] = DateTime.Parse(Console.ReadLine());

                    Console.Write("Data de VOLTA: ");
                    Data_ida[i] = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Dados cadastrados com sucesso, obrigado por voar conosco, boa viagem, vai com Deus, ate a proxima! :)");

                }
                break;

                case "2":
                    for(int i = 0 ; i  <= 4 ; i++){
                        // !=    significa diferente
                        if(
                        Nome[i] != "" && 
                        Origem[i] != ""  && 
                        Destino[i] != "" &&
                        Data_ida[i] != null &&
                        Data_volta[i] != null ){

                            Console.WriteLine();
                            Console.WriteLine("Passagem n° " + i+1);
                            
                            Console.WriteLine(Nome[i]);
                            Console.WriteLine(Origem[i]);
                            Console.WriteLine(Destino[i]);
                            Console.WriteLine(Data_ida[i]);
                            Console.WriteLine(Data_volta[i]);
                            Console.WriteLine();
                        }
                    }
                break;

                case"0":
                Console.WriteLine("Obrigado por ultiliza nosso sistema, boa viagem, vai com Deus, Volte sempre, muito obrigado pela preferencia, fiquei muito feliz! ;)");
                break;

                default:
                Console.WriteLine("Entrada inválida! :( ");
                break;







            }
            
            }












        }
    }
}