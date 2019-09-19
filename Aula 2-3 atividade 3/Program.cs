using System;

namespace Aula_2_3_atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2; 
            string resultado;

            Console.WriteLine("digite um numero");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("digite outro numero");
            numero2 = float.Parse(Console.ReadLine());

            if(numero1 > numero2){
                resultado = "O primeiro número é maior";
            }else{
                resultado = "o segunda numero  é maior";
            }
                Console.WriteLine(resultado);
            
        }
    }
}

