﻿using System;

namespace Aula_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
           
           // Definimos as variáveis que ultilizaremos para fazer o cálculo
            float nota1, nota2, nota3, média;
            string resultado;

            Console.Write("Digite a primeiro nota: ");
            nota1 = float.Parse( Console.ReadLine);

            Console.Write("Digite a segunda nota: ");
            nota2 = float.Parse( Console.ReadLine);

            Console.Write("Digite a terceira nota: ");
            nota3 = float.Parse( Console.ReadLine);

            media = (nota1 + nota2 + nota3) / 3;

            if(media >=6){
               resultado = "Aprovado";
           
           
            } else if(Media < 6 && media >=4){
                resultado = "Recuperação";

            }

            {else{
                resultado = "reprovado";
            }

            Console.WriteLine($"media: {media} - aluno {resultado}");

        }
    }
}
