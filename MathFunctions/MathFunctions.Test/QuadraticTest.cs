using Xunit;

using MathFunctions.Library.Functions;

namespace MathFunctions.Test {

    public class QuadraticTest {

        [Fact]
        public void HasAccurateZeros () {

            var quad = new Quadratic (2, 5, -3);

            Assert.Equal (0.0, quad.Call (-3));
            Assert.Equal (0.0, quad.Call (0.5));
        }
    }
}
