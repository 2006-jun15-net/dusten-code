using System;

namespace ProtectedOverrides {

    class Program {

        static void Main (string[] args) {

            var aa = new A ();
            var bb = new B ();
        }
    }

    class A {

        public A () {
            RunVirtualThing ();
        }

        protected virtual void RunVirtualThing () {
            Console.WriteLine ("A");
        }
    }

    class B : A {

        public B () : base () { }

        protected override void RunVirtualThing () {
            Console.WriteLine ("B");
        }
    }
}
