using Xunit;

using MathFunctions.Library.Functions;

namespace MathFunctions.Test {
    public class CubicTest {

        [Theory]
        [InlineData(1, 2, 3, 4)]
        [InlineData(12, 20, 2, 17)]
        public void CubicPrimeIsQuadratic (double a, double b, double c, double d) {

            // Cubic prime: 3ax^2 + 2bx + c 
            var cubic = new Cubic (a, b, c, d);
            var quad = new Quadratic (3 * a, 2 * b, c);

            Assert.Equal (quad.Call (1), cubic.Prime (1));
        }
    }
}
