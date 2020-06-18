using System;

namespace InterfaceExample.App {

    public class Exponential : IFunction {

        public string Name {
            get => "Exponential";
        }

        public double Call (double x) {
            return Math.Exp (x);
        }
    }
}