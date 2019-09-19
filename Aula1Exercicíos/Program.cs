using System;

namespace Aula1Exercicíos
{
    class Program
    {
        static void Main(string[] args)
        {
           
           int numdousu;
            int resultado;

            Console.WriteLine("Digite um número");
            numdousu = int.Parse(Console.ReadLine());

            resultado = numdousu * 3 ;

            Console.WriteLine ("O resultado é" + resultado);


        }
    }
}
