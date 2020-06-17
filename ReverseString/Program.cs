using System;
using System.Linq;

namespace ReverseString {

    class Program {

        string ReverseString (string input) {

            string s = "";

            foreach (var c in input.ToCharArray ()) {
                s = c + s;
            }

            return s;
        }

        string BetterReverseString (string input) {
            return new string (input.Reverse ().ToArray ());
        }

        static void Main (string[] args) {

            Console.Write ("Input a string: ");
            string userInput = Console.ReadLine ();

            var prog = new Program ();

            // Console.WriteLine (prog.ReverseString (userInput));
            Console.WriteLine (prog.BetterReverseString (userInput));
        }
    }
}