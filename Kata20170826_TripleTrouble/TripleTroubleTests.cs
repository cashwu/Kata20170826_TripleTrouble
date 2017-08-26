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
            return "0123456789".Count(num => num1.ToString().Contains(new string(num, 3)) &&
                                      num2.ToString().Contains(new string(num, 2)));
        }
    }
}
