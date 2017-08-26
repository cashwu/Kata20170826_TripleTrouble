using System;
using System.Linq;
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

        [TestMethod]
        public void input_111_113_should_return_1()
        {
            TripleDoubleShouldBe(1, 111, 113);
        }

        [TestMethod]
        public void input_222_221_should_return_1()
        {
            TripleDoubleShouldBe(1, 222, 221);
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
            var tripleNumber = num1.ToString().GroupBy(char.GetNumericValue).FirstOrDefault(a => a.Count() == 3)?.Key;
            var isTripleDouble = num2.ToString().Count(a => char.GetNumericValue(a) == tripleNumber) == 2;
            return isTripleDouble ? 1 : 0;
        }
    }
}
