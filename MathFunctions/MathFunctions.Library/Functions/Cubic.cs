using System;
using System.Collections.Generic;
using System.Text;

namespace MathFunctions.Library.Functions {
    public class Cubic : IFunction {

        public string Name {
            get => "Cubic";
        }

        public double Call (double x) => Math.Pow(x, 3.0);

        public double Prime (double x) => 3.0 * x * x;
    }
}
