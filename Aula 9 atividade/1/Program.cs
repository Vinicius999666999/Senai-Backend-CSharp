using System;

namespace Aula_9_atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            
          Console.WriteLine ("Digite o valor do produto");
          double Valoruser = double.Parse (Console.ReadLine () ) ;

          Console.WriteLine ("Digite o valor do desconto");
          double Porc = double.Parse (Console.ReadLine () ) ;  

          Console.WriteLine (contavinicius (Valoruser, Porc) );
           
        }

        static double contavinicius (double v1, double v2){
            double resultado =0;

            resultado = (v1 * v2) / 100;

            // resultado ;

            return resultado;
        }
    }
}
