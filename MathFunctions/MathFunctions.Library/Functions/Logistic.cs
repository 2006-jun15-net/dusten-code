using System;

namespace MathFunctions.Library.Functions {

    public class Logistic : IFunction {

        private double mAlpha;

        public string Name {
            get => "Logistic[alpha=" + mAlpha + "]";
        }

        public Logistic () : this (1.0) { }

        public Logistic (double alpha) {
            mAlpha = alpha;
        }

        public double Call (double x) => Math.Pow (1.0 + Math.Exp (-x), -mAlpha);

        public double Prime (double x) {

            var sigmoid = Math.Pow (1.0 + Math.Exp (-x), -mAlpha - 1.0);
            return mAlpha * Math.Exp (-x) * sigmoid;
        }
    }
}