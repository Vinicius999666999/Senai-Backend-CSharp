using System;
using System.Collections.Generic;
using Atividade_2.Controllers;
using Atividade_2.Models;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMC_Models> Iphone = new List<IMC_Models>();

            Iphone.Add(new IMC_Models("Preto", "7 Plus", 3.000, true, true, true, true ));
            Iphone.Add(new IMC_Models("Preto", "8 Plus", 3.000, true, true, true, true ));
            Iphone.Add(new IMC_Models("Preto", "9 Plus", 3.000, true, true, true, true ));
            Iphone.Add(new IMC_Models("Preto", "10 Plus", 3.000, true, true, true, true ));
            Iphone.Add(new IMC_Models("Preto", "11 Plus", 3.000, true, true, true, true ));
       
            foreach(IMC_Models p in Iphone){
                Console.WriteLine();
                Console.WriteLine(p.Cor);
                Console.WriteLine(p.Modelo);
                Console.WriteLine(p.Tamanho);
                Console.WriteLine(p.Ligacao);
                Console.WriteLine(p.Desligado);
                Console.WriteLine(p.Ligacao);
                Console.WriteLine(p.Mensagem);
                Console.WriteLine();
            }

            Console.WriteLine(Iphone[1].Modelo);
        }
    }
}
