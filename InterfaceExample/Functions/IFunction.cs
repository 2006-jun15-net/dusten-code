namespace InterfaceExample.Functions {

    public interface IFunction {

        string Name {
            get;
        }

        double Call (double x);
    }
}