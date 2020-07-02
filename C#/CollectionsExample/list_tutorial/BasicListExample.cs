using System;
using System.Collections.Generic;

namespace list_tutorial {

    class BasicListExample {

        public void run () {

            // A basic list example:

            // Step 1
            var names = new List<string> { "Dusten", "Ana", "Felipe" };

            foreach (var name in names) {
                Console.WriteLine ($"Hello {name.ToUpper ()}!");
            }

            Console.WriteLine ();

            // Step 2
            names.Add ("Maria");
            names.Add ("Bill");
            names.Remove ("Ana");

            foreach (var name in names) {
                Console.WriteLine ($"Hello {name.ToUpper ()}!");
            }

            // Step 3
            Console.WriteLine ($"My name is {names[0]}");
            Console.WriteLine ($"I've added {names[2]} and {names[3]} to the list");

            // Step 4
            Console.WriteLine ($"The list has {names.Count} people in it");

            // Step 5
            var index = names.IndexOf ("Felipe");

            if (index == -1) {
                Console.WriteLine ($"When an item is not found, IndexOf returns {index}");
            }

            else {
                Console.WriteLine ($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf ("Not Found");

            if (index == -1) {
                Console.WriteLine ($"When an item is not found, IndexOf returns {index}");
            }

            else {
                Console.WriteLine ($"The name {names[index]} is at index {index}");

            }

            // Step 6
            names.Sort ();

            foreach (var name in names) {
                Console.WriteLine ($"Hello {name.ToUpper ()}!");
            }
        }
    }
}