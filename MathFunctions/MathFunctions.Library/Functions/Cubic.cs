using System;
using System.Collections.Generic;
using System.Text;

namespace MathFunctions.Library.Functions {
    public class Cubic : IFunction {

        private readonly double mA;
        private readonly double mB;
        private readonly double mC;
        private readonly double mD;

        public string Name {
            get => "Cubic";
        }

        public Cubic (double a, double b, double c, double d) {

            mA = a;
            mB = b;
            mC = c;
            mD = d;
        }

        public double Call (double x) =>
            mA * Math.Pow(x, 3.0) + (mB * x * x) + (mC * x) + mD;
        
        public double Prime (double x) => (3.0 * mA * x * x) + (2.0 * mB * x) + mC;
    }
}
