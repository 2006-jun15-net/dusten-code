namespace InterfaceExample.Functions {

    public class Quadratic : IFunction {

        public string Name {
            get => "Quadratic";
        }

        public double Call (double x) {
            return x * x;
        }

        public double Prime (double x) {
            return 2.0 * x;
        }
    }
}