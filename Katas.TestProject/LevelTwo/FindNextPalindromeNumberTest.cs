using Katas.LevelOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Katas.TestProject.LevelTwo
{
    [TestClass]
    public class FindNextPalindromeNumberTest
    {
        [TestMethod]
        public void FindNextPalindromeNumber()
        {
            FindNextPalindromeNumber findPalindrome = new FindNextPalindromeNumber();
            var newPal = findPalindrome.NextPalindromeNumber(125);
            Assert.AreEqual(131, newPal);
        }

        [TestMethod]
        public void FindNextPalindromeNumber_Big()
        {
            FindNextPalindromeNumber findPalindrome = new FindNextPalindromeNumber();
            var newPal = findPalindrome.NextPalindromeNumber(1932379);
            Assert.AreEqual(1932391, newPal);
        }
    }
}
