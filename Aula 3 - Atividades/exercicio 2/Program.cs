using System;

namespace exercicio_2 {
    class Program {
        static void Main (string[] args) {
            int user;
            int tab;
            int cont = 1;

            Console.Write ("Digite um número: ");
            user = int.Parse (Console.ReadLine ());

            for (cont = 1; cont <= 10; cont++) {
                tab = user * cont;

                Console.WriteLine ($"{user} x {cont} = {tab}");
            }
        }
    }
}