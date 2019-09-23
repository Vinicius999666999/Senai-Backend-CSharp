using System;

namespace atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] produto = new string [12];
            string [] cor = new string [12];
            string [] tamanho = new string [12];
            double [] preco = new double [12];

            for(int i = 0 ; i <= 11 ; i++){
                Console.WriteLine("Nome do produto: ");
                produto[i] = (Console.ReadLine());

                Console.WriteLine("Cor do produto: ");
                cor[i] = (Console.ReadLine());

                Console.WriteLine("Tamanho do produto: ");
                tamanho[i] = (Console.ReadLine());

                Console.WriteLine("Preco do Produto: ");
                preco[i] = double.Parse(Console.ReadLine());
            }

            






        }
    }
}
