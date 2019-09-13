using System;

namespace Aula_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //somente declaramos, sem atribuir valor
            int num1;

            //declaramos atribuindo um valor
            int num2 = 5;

            //declaramos diversas variáveis de mesmo tipo
            int num3, num4, num5 = 7;

            //variável do tipo decimal (real)
            float media;

            //variável do tipo lógico(booleana)
            bool resultado = false;

            //variavel do tipo texto (caracteres)
            string nomeAluno;

            //quebra linha
            Console.WriteLine();

            Console.WriteLine("Bem vindo á nossa primeiro aplicação");

            //continua escrevendo na mesma linha
            Console.Write("Digite");
            Console.Write("seu nome: ");

            //capituro o dado digitado pelo usuário e salvo na variável
            nomeAluno = Console.ReadLine();

            //concatenação
            Console.WriteLine(nomeAluno + ", agora digite sua primeira nota:");

            // converto o texto capturado para o tipo inteiro
            num3 = int.Parse(Console.ReadLine());

            //interpolação
            Console.WriteLine($"Sua primeira nota é {num3}");


            Console.WriteLine("Digite sua segunda nota");
            num4 = int.Parse(  Console.ReadLine()  );
           
            Console.WriteLine("Digite sua terceira nota: ");
            num5 = int.Parse(   Console.ReadLine()  );


            media = (num3 + num4 + num5) / 3;


            Console.WriteLine("Sua media é:"  +  media);


        }
    }
}

