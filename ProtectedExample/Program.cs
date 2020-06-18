using System;

namespace ProtectedExample {

    class Program {

        static void PrintShapeName (Shape shape) {
            Console.WriteLine ($"{shape.Name}");
        }

        static void Main (string[] args) {

            // Output should be:
            // 
            // Circle
            // Square
            // Generic Shape
            // 
            PrintShapeName (new Circle ());
            PrintShapeName (new Square ());
            PrintShapeName (new Shape ());
        }
    }

    class Shape {

        protected string mName;

        public string Name {
            get => mName;
        }

        public Shape () {
            mName = "Generic Shape";
        }
    }

    class Circle : Shape {

        public Circle () {
            mName = "Circle";
        }
    }

    class Square : Shape {

        public Square () {
            mName = "Square";
        }
    }
}
