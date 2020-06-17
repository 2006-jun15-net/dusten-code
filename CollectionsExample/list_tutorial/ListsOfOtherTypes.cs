using System;
using System.Linq;
using System.Collections.Generic;

namespace list_tutorial {

    class ListsOfOtherTypes {

        public void run () {

            // Lists of other types:

            // Step 1
            var fibonacciNumbers = new List<int> { 1, 1 };

            // Step 2
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add (previous + previous2);

            foreach (var item in fibonacciNumbers) {
                Console.WriteLine (item);
            }
        }

        public void challenge () {

            var fibonacciNumbers = new List<int> { 1, 1 };

            // We already have the first two, so to generate up to 20,
            // we only need 18 more fibonacci numbers
            for (int i = 0; i < 18; i++) {

                var previousSum = fibonacciNumbers.GetRange (fibonacciNumbers.Count - 2, 2).Sum ();

                fibonacciNumbers.Add (previousSum);
            }

            foreach (var item in fibonacciNumbers) {
                Console.WriteLine (item);
            }
        }
    }
}