using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bai3;
using System;

namespace Bai3.Tests
{
    [TestClass]
    public class RadixConverterTests
    {
        [TestMethod]
        public void TC01_Convert_To_Binary()
        {
            string result = RadixConverter.Convert(10, 2);
            Assert.AreEqual("1010", result);
        }

        [TestMethod]
        public void TC02_Convert_To_Octal()
        {
            string result = RadixConverter.Convert(8, 8);
            Assert.AreEqual("10", result);
        }

        [TestMethod]
        public void TC03_Convert_To_Hex()
        {
            string result = RadixConverter.Convert(255, 16);
            Assert.AreEqual("FF", result);
        }

        [TestMethod]
        public void TC04_Convert_N_Equals_Zero()
        {
            string result = RadixConverter.Convert(0, 2);
            Assert.AreEqual("0", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TC05_Base_Less_Than_2()
        {
            RadixConverter.Convert(10, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TC06_Base_Greater_Than_16()
        {
            RadixConverter.Convert(10, 17);
        }
    }
}
