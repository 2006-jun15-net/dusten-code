using System;

using InterfaceExample.Functions;

namespace InterfaceExample {
    class Program {

        static void CallFunction (IFunction function, double x) {
            Console.WriteLine ($"{function.Name}({x}) = {function.Call (x)}");
        }

        static void Main (string[] args) {

            CallFunction (new Quadratic (), 4.0);
            CallFunction (new Exponential (), 2.5);
        }
    }
}
