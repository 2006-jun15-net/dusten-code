using System;

/*
 Inline braces look better
 */
namespace ProceduralBasics {

    class Program {

        // Eagerly-summed fibonacci function:
        void ShowFib (long n) {

            if (n < 0) {
                return;
            }

            long prev = -1;
            long next = 1;

            for (long i = 0; i < n; i++) {

                long sum = prev + next;

                prev = next;
                next = sum;

                Console.WriteLine (sum);
            }
        }

        static void Main (string[] args) {

            var program = new Program ();
            program.ShowFib (long.Parse (args[0]));
        }
    }
}
