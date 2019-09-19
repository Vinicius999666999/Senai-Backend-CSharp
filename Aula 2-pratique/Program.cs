using System;

namespace Aula_2_pratique
{
    class Program
    {
        static void Main(string[] args)
        {
             string pedido;
             string resultado; 
            

            Console.WriteLine("Digite o Número do seu pedido");
            pedido = Console.ReadLine();

            switch(pedido){
                case "1":
                resultado = " Hamburguer";
                break;

                  case "2":
                resultado = "Cheese Salada";
                break;

                  case "3":
                resultado = " Cheese Burguer";
                break;

                  case "4":
                resultado = " Cheese Bacon";
                break;

                default:
                resultado = "pedido invaido";
                break;
            }

            Console.WriteLine(resultado);
              
              
              Console.WriteLine();

             















        }
    }
}
