using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bai2;
using System;
using System.Collections.Generic;

namespace Bai2.Tests
{
    [TestClass]
    public class PolynomialTests
    {
        [TestMethod]
        public void TC01_Polynomial_Valid()
        {
            Polynomial p = new Polynomial(2, new List<int> { 1, 2, 3 });
            int result = p.Cal(1);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TC02_Polynomial_N_Zero()
        {
            Polynomial p = new Polynomial(0, new List<int> { 5 });
            int result = p.Cal(10);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TC03_Polynomial_X_Zero()
        {
            Polynomial p = new Polynomial(2, new List<int> { 1, 2, 3 });
            int result = p.Cal(0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TC04_Polynomial_Missing_Coefficient()
        {
            new Polynomial(2, new List<int> { 1, 2 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TC05_Polynomial_N_Negative()
        {
            new Polynomial(-1, new List<int>());
        }
    }
}
