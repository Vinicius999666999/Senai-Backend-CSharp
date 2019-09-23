using System;

namespace atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] v1 = new string [15];
            string[] v2 = new string [15];
            string [] v3 = new string [30];

            for (int i = 0 ; i <= 14 ; i++){
                Console.WriteLine ("Digite palavras: ");
                v1[i] = (Console.ReadLine());
            }

              for (int i = 0 ; i <= 14 ; i++){
                Console.WriteLine ("Digite mas palavras: ");
                v2[i] = (Console.ReadLine());
            }

            for ( int i = 15 ; i <= 29 ; i++) {
                v3[i] = v1[i];
            }

            for(int i = 15 ; i <= 29 ; i++){
                v3[i] = v2[i];
            } 


            for(int i = 0 ; i <= 29 ; i++){
                Console.WriteLine (v3[i]);
            }








        }
    }
}
