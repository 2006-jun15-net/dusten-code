namespace MathFunctions.Library.Functions {

    public class Quadratic : IFunction {

        private double mA;
        private double mB;
        private double mC;

        public string Name {
            get => "Quadratic";
        }

        public Quadratic (double a, double b, double c) {

            mA = a;
            mB = b;
            mC = c;
        }

        public double Call (double x) => (mA * x * x) + (mB * x) + mC;

        public double Prime (double x) => (2.0 * mA * x) + mB;
    }
}
