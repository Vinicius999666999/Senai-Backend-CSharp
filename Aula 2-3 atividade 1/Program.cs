using System;

namespace Aula_2_3_atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario;
            float despesa;
            float media;
            String resultado;


            Console.WriteLine("digite seu sálario");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Despesa");
            despesa = float.Parse(Console.ReadLine());

            media = salario - despesa; 

            if(media <0){
                resultado = "Déficit";
            }else{
                resultado = "superávit";}
                Console.WriteLine(resultado);
            
        }
    }
}
