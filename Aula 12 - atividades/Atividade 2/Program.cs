using System;
using Atividade_2.Controllers;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IMC_Controllers Cel = new IMC_Controllers ();

            Console.Clear();

            
            Cel.Desligar();
            Cel.Mensagens();
            Cel.Ligacao();
            
        }
    }
}
