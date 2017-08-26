using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170826_TripleTrouble
{
    [TestClass]
    public class TripleTroubleTests
    {
        [TestMethod]
        public void input_123_123_should_return_0()
        {
            TripleDoubleShouldBe(0, 123, 123);
        }

        private static void TripleDoubleShouldBe(int expected, int num1, int num2)
        {
            var kata = new Kata();
            var actual = kata.TripleDouble(num1, num2);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int TripleDouble(long num1, long num2)
        {
            return 0;
        }
    }
}
