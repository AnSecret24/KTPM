using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bai4;
using System;

namespace Bai4.Tests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void TC01_Fib_Zero()
        {
            int result = Fibonacci.Fib(0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TC02_Fib_One()
        {
            int result = Fibonacci.Fib(1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TC03_Fib_Five()
        {
            int result = Fibonacci.Fib(5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TC04_Fib_Ten()
        {
            int result = Fibonacci.Fib(10);
            Assert.AreEqual(55, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TC05_Fib_Negative()
        {
            Fibonacci.Fib(-1);
        }
    }
}
