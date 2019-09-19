using System;

namespace Aula_3 {
    class Program {
        static void Main (string[] args) {

            // //Laço contado - FOR - Incremento (+)
            // for (int cont = 1; cont <= 100; cont++) {

            //     // verificamos se o número é diferente de par
            //     if (cont % 2 != 0) {
            //         Console.WriteLine ("FOR 0-100" + cont);
            //     }
            // }

            // //Laço contado - FOR - Decremento (-)
            // for (int cont = 100; cont >= 0; cont--) {

            //     // verificamos se o número é diferente de par
            //     if (cont % 2 != 0) {
            //         Console.WriteLine ("FOR 100-0" + cont);

            //     }

            // }

            //LAÇO CONDICIONAL - WHILE - Condicional

            double acumuladora = 0;
            double nota = 0;
            int cont = 0;
            string sair = "";

            //sempre para sair se usa string , então se não for string usamos ToString

            while (sair != "sim"){

                Console.WriteLine ("digite a nota de um aluno: ");
                nota = double.Parse (Console.ReadLine ());

                acumuladora += nota;
                cont++;

                Console.Write("Deseja sair da aplicação? sim/não");
                sair = Console.ReadLine().ToLower();
            }

            Console.WriteLine("média das notas : "+(acumuladora / cont) );


        }
    }
}