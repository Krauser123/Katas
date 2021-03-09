using Katas.LevelOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Katas.TestProject.LevelOne
{
    [TestClass]
    public class PalindromeTest
    {        
        [TestMethod]
        public void IsPalindromeNum()
        {
            Palindrome pal = new Palindrome();
            var isPalindrome = pal.CheckPalindrome_Numeric(550055);
            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void NotIsPalindromeNum()
        {
            Palindrome pal = new Palindrome();
            var isPalindrome = pal.CheckPalindrome_Numeric(123);

            Assert.IsFalse(isPalindrome);
        }

        [TestMethod]
        public void IsPalindromeNum_Zero()
        {
            Palindrome pal = new Palindrome();
            var isPalindrome = pal.CheckPalindrome_Numeric(0);
            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void IsPalindromeNum_Negative()
        {
            Palindrome pal = new Palindrome();
            var isPalindrome = pal.CheckPalindrome_Numeric(-1);
            Assert.IsFalse(isPalindrome);
        }

        [TestMethod]
        public void IsPalindromeNum_BigNegative()
        {
            Palindrome pal = new Palindrome();
            var isPalindrome = pal.CheckPalindrome_Numeric(-1444444441);
            Assert.IsFalse(isPalindrome);
        }

        [TestMethod]
        public void IsPalindromeString()
        {
            Palindrome pal = new Palindrome();
            var isPalindrome = pal.CheckPalindrome_Word("kayak");
            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void NotIsPalindromeString()
        {
            Palindrome pal = new Palindrome();
            var isPalindrome = pal.CheckPalindrome_Word("Prerotator");
            Assert.IsFalse(isPalindrome);
        }

        [TestMethod]
        public void IsPalindromeString_UpperCases()
        {
            Palindrome pal = new Palindrome();
            var isPalindrome = pal.CheckPalindrome_Word("KaYaK");
            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void IsPalindromeString_Number()
        {
            Palindrome pal = new Palindrome();
            var isPalindrome = pal.CheckPalindrome_Word("455554");
            Assert.IsTrue(isPalindrome);
        }
    }
}
