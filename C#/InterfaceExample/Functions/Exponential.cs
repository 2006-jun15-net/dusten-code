using System;

namespace InterfaceExample.Functions {

    public class Exponential : IFunction {

        public string Name {
            get => "Exponential";
        }

        public double Call (double x) {
            return Math.Exp (x);
        }

        public double Prime (double x) {
            return Math.Exp (x);
        }
    }
}