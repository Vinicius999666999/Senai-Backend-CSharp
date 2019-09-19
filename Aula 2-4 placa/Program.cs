using System;

namespace Aula_2_4_placa
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa;
            string final;
            string resultado;

            Console.Write("Digite a placa do seu carro: ");
            placa = Console.ReadLine();

            //contamos  quantodade de caracteres de um elemento 
            int caracteres = placa.Length;

            //pegamos o ultimo digito
            //com o metodo substring
            final = placa.Substring(caracteres -1));

            if(final == "1" || final == "2" ){
                resultado = "IF/ELSE - Seu rodízio é na Segunda-feira";
            }else if(final == "3" || final == "4"){
                resultado = "IF/ELSE - Seu rodízia é na Terça-feira";
            }else if(final =="5" || final == "6" ){
                resultado ="IF/ELSE - Seu rodízia é na Quarta-feira";
            }else if(final == "7" || final == "8"){
                resultado ="IF/ELSE - Seu rodízia é na Quinta-feira";
            }else if(final == "9" || final == "0" ){
                resultado ="IF/ELSE - Seu rodízio é na Sexta-feira";
            }else{
                resultado = "placa invalida";
            }
            Console.WriteLine(resultado);

            switch(final){
                case "1":
                resultado = "switch - Segunda-feira";
                break;

                  case "2":
                resultado = "switch - Terça-feira";
                break;

                  case "3":
                resultado = "switch - Terça-feira";
                break;

                  case "4":
                resultado = "switch - Terça-feira";
                break;

                  case "5":
                resultado = "switch - Quarta-feira";
                break;

                  case "6":
                resultado = "switch - Quarta-feira";
                break;

                  case "7":
                resultado = "switch - Quinta-feira";
                break;

                  case "8":
                resultado = "switch -Quinta-feira";
                break;

                  case "9":
                resultado = "switch - Sexta-feira";
                break;

                  case "0":
                resultado = "switch - Sexta-feira";
                break;
            
                default:
                resultado = "switch - Entrada inválida :(";
                break;

            }

                Console.WriteLine(resultado);

        }
    }
}
