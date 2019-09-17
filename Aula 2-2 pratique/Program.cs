using System;

namespace Aula_2_2_pratique
{
    class Program
    {
        static void Main(string[] args)
        {
         String numero;
         double peso;
         double resultado;
         String planeta;

         Console.Write("Digite seu peso: ");
         peso = double.Parse(Console.ReadLine());

         Console.Write("Digite o número do  planeta: ");
         numero = Console.ReadLine();

         switch(numero){
            case"1":
            resultado = (peso/10)* 0.37;
            Console.WriteLine(resultado);
            break;

            case"2":
            resultado = (peso/10)*0.88;
            Console.WriteLine(resultado);
            break;

            case"3":
            resultado = (peso/10)*0.38;
            Console.WriteLine(resultado);
            break;

              case"4":
            resultado = (peso/10)* 2.64;
            Console.WriteLine(resultado);
            break;

            case"5":
            resultado = (peso/10)*1.15;
            Console.WriteLine(resultado);
            break;

            case"6":
            resultado = (peso/10)*1.17;
            Console.WriteLine(resultado);
            break;
         }   





        }
    }
}
