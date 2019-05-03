using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeUI;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NonPalindromes_Return_False()
        {
            //var palTester = new PalindromeClass();
            bool result = PalindromeClass.CheckIfPalindrome("cat");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Palindromes_Return_True()
        {
            //var palTester = new PalindromeClass();
            bool result = PalindromeClass.CheckIfPalindrome("racecar");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Check_NonPalindrome_With_Spaces_False()
        {
            //var palTester = new PalindromeClass();
            bool result = PalindromeClass.CheckIfPalindrome("not palindrome");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Check_Palindrome_With_Spaces_True()
        {
            //var palTester = new PalindromeClass();
            bool result = PalindromeClass.CheckIfPalindrome("race car");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Check_Palindrome_With_SpecialCharacters_True()
        {
            //var palTester = new PalindromeClass();
            bool result = PalindromeClass.CheckIfPalindrome("race%$car");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Check_NonPalindrome_With_SpecialCharacters_False()
        {
            //var palTester = new PalindromeClass();
            bool result = PalindromeClass.CheckIfPalindrome("tyler!@barn");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Check_Alternate_Case_Still_Palindrome()
        {
            //var palTester = new PalindromeClass();
            bool result = PalindromeClass.CheckIfPalindrome("PALINDROMEeMoRDNILap");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Check_Integer_Palindrome_True()
        {
            //var palTester = new PalindromeClass();
            bool result = PalindromeClass.CheckIfPalindrome(12344321);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Check_Integer_NonPalindrome_False()
        {
            //var palTester = new PalindromeClass();
            bool result = PalindromeClass.CheckIfPalindrome(343463565);
            Assert.AreEqual(false, result);
        }
    }
}
