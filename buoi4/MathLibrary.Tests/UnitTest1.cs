using Bai1;
using MathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathLibrary.Tests
{
    [TestClass]
    public class PowerCalculatorTests
    {
        [TestMethod]
        public void TC01_Power_N_Equals_0()
        {
            double result = PowerCalculator.Power(2, 0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TC02_Power_N_Positive()
        {
            double result = PowerCalculator.Power(2, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TC03_Power_N_Equals_1()
        {
            double result = PowerCalculator.Power(5, 1);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TC04_Power_N_Negative()
        {
            double result = PowerCalculator.Power(2, -2);
            Assert.AreEqual(0.25, result, 0.0001);
        }

        [TestMethod]
        public void TC05_Power_X_Equals_1()
        {
            double result = PowerCalculator.Power(1, 100);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TC06_Power_X_Negative()
        {
            double result = PowerCalculator.Power(-2, 3);
            Assert.AreEqual(-8, result);
        }
    }
}
