using System;

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
         int n = 0;
         int total = 0;
         int numero = 1;

         for(int i=1 ; i <= 100; i++){
             Console.Write("digite o" + i + "o número: ");
             n = int.Parse(Console.ReadLine());

             if(n >0){
                 if(n % 2 != 0){
                     total = total + n;
                 }
                 if (n % 3 == 0){

                 }
             }
         }

         Console.WriteLine("a soma de todos n° impar é! + "  + total);
         Console.WriteLine("todos n° múltiplos de 3 maior que 0 são : " + numero);
         
         
            
        }
    }
}
