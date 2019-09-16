using System;

namespace aula_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //deixamos declarada como falsa por padão
            bool entrada = false;
            int idade;
            string retorno = "entrada não permitida";

            Console.WriteLine("digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade > 17 ){
                entrada = true;
            }

            if (entrada == true){
                retorno = "entrada permitida !!!";
            }else{
                retorno = "entrada não permitida :(";
            }
            
            Console.WriteLine(retorno);

        }
    }
}
