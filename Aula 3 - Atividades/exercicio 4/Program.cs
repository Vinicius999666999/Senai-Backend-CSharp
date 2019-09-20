using System;

namespace exercicio_4 {
    class Program {
        static void Main (string[] args) {
            int user;
            int cont;
            double contacm = 0, acm = 0, media = 0;

            for (cont = 1; cont <= 20; cont++) {
                Console.Write ("digite um numero: ");
                user = int.Parse (Console.ReadLine ());
                if (user < 0) {
                    contacm++;
                    acm = acm = user;

                } else {
                    Console.WriteLine ("o número é ppsitivo"user);
                }

            }
            media = acm / contacm;
            Console.WriteLine (media);
        }
    }
}