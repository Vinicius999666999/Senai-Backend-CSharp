using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        float  precomercadoria;
        Double resultado;
        float porcentagem;

        Console.WriteLine("preco da mercadoria");
        precomercadoria = float.Parse(Console.ReadLine());

        Console.WriteLine("coloca ai parça");
        porcentagem = float.Parse(Console.ReadLine());
        
        resultado = (porcentagem / 100) * precomercadoria + precomercadoria;

        Console.WriteLine(resultado);

        






        }
    }
}
