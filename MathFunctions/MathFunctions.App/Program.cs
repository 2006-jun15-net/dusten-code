using System;

using MathFunctions.Library.Functions;

namespace MathFunctions.App {

    internal class Program {

        static void CallFunction (IFunction function, double x) {
            Console.WriteLine ($"{function.Name}({x}) = {function.Call (x)}");
        }

        static void Main (string[] args) {

            var sigmoid = new Logistic ();
            var squareSigmoid = new Logistic (2.0);

            Console.WriteLine ();

            CallFunction (new Quadratic (), 4.0);
            CallFunction (new Exponential (), 2.5);

            Console.WriteLine ();

            CallFunction (sigmoid, 0.9);
            CallFunction (squareSigmoid, 0.9);
        }
    }
}
