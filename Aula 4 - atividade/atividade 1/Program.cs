using System;

namespace atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numero = new double [10];

            //para acum numeros do vetor
            for(int i = 0 ; i <= 9; i++){
                Console.WriteLine("Digite um valor");
                numero[i] =double.Parse(Console.ReadLine());

            }

            for(int i = 0; i <= 9 ; i++){
                Console.WriteLine(numero[i]);

            }

            Console.WriteLine(numero[9] * 5);
            
            

        






        }
    }
}
