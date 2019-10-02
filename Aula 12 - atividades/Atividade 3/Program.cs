using System;
using System.Collections.Generic;
using Atividade_3.Controllers;
using Atividade_3.Models;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMC_Produtos> prod = new List<IMC_Produtos>();

            prod.Add(new IMC_Produtos("Blusa", "Branca", "NIKE", 35.99));
            prod.Add(new IMC_Produtos("Blusa", "Preta", "ADIDAS", 35.99));
            prod.Add(new IMC_Produtos("Blusa", "Branca", "ADIDAS", 35.99));
            prod.Add(new IMC_Produtos("Blusa", "Verde", "NIKE", 35.99));
            prod.Add(new IMC_Produtos("Blusa", "Laranja", "Gap", 35.99));

            foreach(IMC_Produtos p in prod){
                Console.WriteLine();
                Console.WriteLine(p.Nomeproduto);
                Console.WriteLine(p.Cor);
                Console.WriteLine(p.Marca);
                Console.WriteLine(p.Preco);
                Console.WriteLine();
            }

            Console.WriteLine(prod[2].Marca);
        }
    }
}
