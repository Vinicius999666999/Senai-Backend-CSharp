using System;
using Atividade_3.Controllers;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IMC_Controllers Vinicius = new IMC_Controllers();

            Vinicius.Cadastrarproduto();
            Vinicius.Reservacao();
        }
    }
}
