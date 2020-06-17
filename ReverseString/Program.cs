using System;

namespace ReverseString {

    class Program {

        string ReverseString (string input) {

            string s = "";

            foreach (var c in input.ToCharArray ()) {
                s = c + s;
            }

            return s;
        }

        static void Main (string[] args) {

            Console.Write ("Input a string: ");
            string userInput = Console.ReadLine ();

            var prog = new Program ();

            Console.WriteLine (prog.ReverseString (userInput));
        }
    }
}