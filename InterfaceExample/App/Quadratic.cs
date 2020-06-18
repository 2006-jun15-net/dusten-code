namespace InterfaceExample.App {

    public class Quadratic : IFunction {

        public string Name {
            get => "Quadratic";
        }

        public double Call (double x) {
            return x * x;
        }
    }
}