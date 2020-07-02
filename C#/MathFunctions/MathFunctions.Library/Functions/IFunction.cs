namespace MathFunctions.Library.Functions {

    public interface IFunction {

        string Name {
            get;
        }

        double Call (double x);
        double Prime (double x);
    }
}
