using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int user ;
            int cont ;
            int tab; 

            Console.WriteLine("Digite o intervalo");
            user = int.Parse (Console.ReadLine());

            for(cont= 1 ; cont<= user ; cont++) {
            tab = user * cont ;

            Console.WriteLine ($"{5} x {cont} = {tab}");
            
            }

        }
    }
}
