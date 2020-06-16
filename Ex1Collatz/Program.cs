using System;

namespace Ex1Collatz {
    class Program {
        void Collatz (uint n) {

            Console.WriteLine (n);

            // Base case when n=1
            if (n == 1) {
                return;
            }

            // If n is even, divide by two
            if (n % 2 == 0) {
                Collatz (n / 2);
            }

            // If n is odd, multiply by three and then add one
            else {
                Collatz (n * 3 + 1);
            }
        }
        static void Main (string[] args) {

            var prog = new Program ();
            prog.Collatz (uint.Parse (args[0]));
        }
    }
}
