namespace MathFunctions.Library.Functions {

    public class Quadratic : IFunction {

        public string Name {
            get => "Quadratic";
        }

        public double Call (double x) => x * x;

        public double Prime (double x) => 2.0 * x;
    }
}
