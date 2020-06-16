using System;

namespace Staircase {

    class Program {

        void ShowStaircase (int n) {

            for (int i = 1; i <= n; i++) {

                string step = "";

                // Pad spaces to match length of 'n'
                for (int j = 0; j < n - i; j++) {
                    step += " ";
                }

                // Add '#' sign to make the 'steps'
                for (int j = 0; j < i; j++) {
                    step += "#";
                }

                // Print the current 'step' plus a new line
                Console.WriteLine (step);
            }
        }
        static void Main (string[] args) {

            var prog = new Program ();

            Console.Write ("Enter a number: ");
            var userInput = Console.ReadLine ();

            prog.ShowStaircase (int.Parse (userInput));
        }
    }
}