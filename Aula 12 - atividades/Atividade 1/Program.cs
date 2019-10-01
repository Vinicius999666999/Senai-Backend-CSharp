using System;
using Atividade_1.Controllers;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IMC_Controllers imccon = new IMC_Controllers();
        
            imccon.Aluno();
        
        }
    }
}
