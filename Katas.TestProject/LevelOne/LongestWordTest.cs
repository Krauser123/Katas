using Katas.LevelOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Katas.TestProject.LevelOne
{
    [TestClass]
    public class LongestWordTest
    {
        [TestMethod]
        public void CheckLongestWord()
        {
            LongestWords longestWords = new LongestWords("You are just an old antidisestablishmentarian");
            string[] longestWord = longestWords.FindLongestWord();
            CollectionAssert.AreEqual(new string[] { "antidisestablishmentarian" }, longestWord);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PhraseIsNull()
        {
            LongestWords longestWords = new LongestWords(null);
        }

        [TestMethod]
        public void SameWordCaseSensitive()
        {
            LongestWords longestWords = new LongestWords("Buffalo buffalo Buffalo buffalo buffalo buffalo Buffalo buffalo");
            string[] longestWord = longestWords.FindLongestWord();
            CollectionAssert.AreEqual(new string[] { "buffalo" }, longestWord);
        }

        [TestMethod]
        public void SameLengthOfWord()
        {
            LongestWords longestWords = new LongestWords("I gave a present to my parents");
            string[] longestWord = longestWords.FindLongestWord();
            CollectionAssert.AreEqual(new string[] { "present", "parents" }, longestWord);
        }
    }
}
