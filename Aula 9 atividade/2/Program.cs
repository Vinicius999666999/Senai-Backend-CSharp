using System;

namespace _2 {
    class Program {
        static void Main (string[] args) {
            ImprimiDataHora ();
        }

        static void ImprimiDataHora () {
            DateTime hoje = DateTime.Today;

            Console.WriteLine(hoje.DayOfWeek);
        }

    }
}