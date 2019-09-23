using System;

namespace atividade_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vetor1 = new int[10];
            int indice = 0;
            int maior = 0;
            int i = 0;

            for(i = 0 ; i <= 9 ; i++){
                Console.WriteLine("Insira um valor: ");
                vetor1[i] = int.Parse(Console.ReadLine());

                if (maior < vetor1[i]) {
                    indice = i;
                    maior = vetor1[i];
                }
            }

            Console.WriteLine(maior + "é maio número , indice =" + indice);





        }
    }
}
