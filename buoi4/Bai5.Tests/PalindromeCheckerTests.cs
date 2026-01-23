using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bai5;
using System;

namespace Bai5.Tests
{
    [TestClass]
    public class PalindromeCheckerTests
    {
        [TestMethod]
        public void TC01_Palindrome_Normal()
        {
            bool result = PalindromeChecker.IsPalindrome("madam");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TC02_Palindrome_Ignore_Case()
        {
            bool result = PalindromeChecker.IsPalindrome("Madam");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TC03_Palindrome_With_Space()
        {
            bool result = PalindromeChecker.IsPalindrome("nurses run");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TC04_Not_Palindrome()
        {
            bool result = PalindromeChecker.IsPalindrome("hello");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TC05_Empty_String()
        {
            bool result = PalindromeChecker.IsPalindrome("");
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TC06_Null_String()
        {
            PalindromeChecker.IsPalindrome(null);
        }
    }
}
