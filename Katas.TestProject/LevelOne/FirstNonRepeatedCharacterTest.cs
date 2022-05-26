using Katas.LevelOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Katas.TestProject.LevelOne
{
    [TestClass]
    public class FirstNonRepeatedCharacterTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentEmpty()
        {
            FirstNonRepeatedCharacter firstNonRepeatedCharacter = new FirstNonRepeatedCharacter();
            firstNonRepeatedCharacter.GetFirstNonRepeatedCharacter("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNull()
        {
            FirstNonRepeatedCharacter firstNonRepeatedCharacter = new FirstNonRepeatedCharacter();
            firstNonRepeatedCharacter.GetFirstNonRepeatedCharacter(null);
        }

        [TestMethod]
        public void TestShortString()
        {
            FirstNonRepeatedCharacter firstNonRepeatedCharacter = new FirstNonRepeatedCharacter();
            var nonRepeatedChar = firstNonRepeatedCharacter.GetFirstNonRepeatedCharacter("AABBC");
            Assert.AreEqual("C", nonRepeatedChar);
        }

        [TestMethod]
        public void TestStandardString()
        {
            FirstNonRepeatedCharacter firstNonRepeatedCharacter = new FirstNonRepeatedCharacter();
            var nonRepeatedChar = firstNonRepeatedCharacter.GetFirstNonRepeatedCharacter("AABBCCDEEFF");
            Assert.AreEqual("D", nonRepeatedChar);
        }

        [TestMethod]
        public void TestLongString()
        {
            FirstNonRepeatedCharacter firstNonRepeatedCharacter = new FirstNonRepeatedCharacter();
            var nonRepeatedChar = firstNonRepeatedCharacter.GetFirstNonRepeatedCharacter("AABBCAABBCCDHEEFFCDEEFFEEFFCDEEFFEEFFCDEEFFAAAAAEEFFCDEEFF");
            Assert.AreEqual("H", nonRepeatedChar);
        }

        [TestMethod]
        public void TestStringAllCharsAppearsTwice()
        {
            FirstNonRepeatedCharacter firstNonRepeatedCharacter = new FirstNonRepeatedCharacter();
            var nonRepeatedChar = firstNonRepeatedCharacter.GetFirstNonRepeatedCharacter("AABBCAABBCCDD");
            Assert.AreEqual(string.Empty, nonRepeatedChar);
        }
    }
}