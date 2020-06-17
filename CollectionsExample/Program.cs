using list_tutorial;

namespace MainProgram {
    class Program {

        static void Main (string[] args) {

            var tutorial1 = new BasicListExample ();
            var tutorial2 = new ListsOfOtherTypes ();

            tutorial1.run ();
            tutorial2.run ();
            tutorial2.challenge ();
        }
    }
}