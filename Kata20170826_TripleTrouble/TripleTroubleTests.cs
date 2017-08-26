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

        [TestMethod]
        public void input_451999277_41177722899_should_return_1()
        {
            TripleDoubleShouldBe(1, 451999277, 41177722899);
        }

        [TestMethod]
        public void input_1222345_12345_should_return_0()
        {
            TripleDoubleShouldBe(0, 1222345, 12345);
        }

        [TestMethod]
        public void input_12345_12345_should_return_0()
        {
            TripleDoubleShouldBe(0, 12345, 12345);
        }

        [TestMethod]
        public void input_666789_12345667_should_return_1()
        {
            TripleDoubleShouldBe(1, 666789, 12345667);
        }

        [TestMethod]
        public void input_10560002_100_should_return_1()
        {
            TripleDoubleShouldBe(1, 10560002, 100);
        }

        [TestMethod]
        public void input_606423252_873741212_should_return_0()
        {
            TripleDoubleShouldBe(0, 606423252, 873741212);
        }

        private static void TripleDoubleShouldBe(int expected, long num1, long num2)
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
            var num1Array = num1.ToString().Select(char.GetNumericValue).ToList();
            var tripleNumber = default(int?);
            for (var i = 0; i <= num1Array.Count - 2; i++)
            {
                if (num1Array[i] == num1Array[i + 1] && num1Array[i + 1] == num1Array[i + 2])
                {
                    tripleNumber = (int?)num1Array[i];
                    break;
                }
            }

            var num2Array = num2.ToString().Select(char.GetNumericValue).ToList();
            var isTripleDouble = num2Array.Where((a, i) => a == tripleNumber && a == num2Array[i + 1]).Any();
            return isTripleDouble ? 1 : 0;
        }
    }
}
