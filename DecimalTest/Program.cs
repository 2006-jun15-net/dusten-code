using System;

namespace DecimalTest {
    class Program {
        static void Main (string[] args) {

            // Whole numbers default to 'int', even if they are small,
            // Because C# is optimized for 32-bit systems ('short' is slower)
            var i = 5;

            // Real numbers default to 'double' for similar reasons
            var d = 0.5;

            // You can enforce types using an additional letter at the end
            // of the number
            var f = 0.5f;
            var dec = 0.5m;

            // Decimals are more precise and have a smaller range than 'double's
            // because they store a numerator and a denominator
        }
    }
}
