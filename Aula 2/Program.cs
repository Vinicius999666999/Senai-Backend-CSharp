using System;

namespace Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos as notas  que ultilizamos
            double nota1, nota2, nota3, media;

            //capturamos a 1° nota
            Console.Write("digite sua primeiro nota: ");
            nota1 = double.Parse(Console.ReadLine());

            //capturamos a 2° nota
            Console.WriteLine("Digite sua segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

             //capturamos a 3° nota
            Console.WriteLine("Digite sua terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            //calculamos a média das notas
            media = (nota1 + nota2 +nota3) / 3;

            //verificamos se a média do aluno é maior ou igual á 6
            if(media >= 6){
                Console.WriteLine($"Média: {media} Aulono aprovado!");
            } else {
                Console.WriteLine($"Média: {media} reprovado !");
             }

             









        }
    }
}
