using Katas.LevelOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Katas.TestProject.LevelOne
{
    [TestClass]
    public class ReverseWordsInAStringTest
    {
        [TestMethod]
        public void IsReverseRight()
        {
            ReverseWordsInAString reverseWordsInAString = new ReverseWordsInAString();
            string reversedPhrase = reverseWordsInAString.ReverseWords("Interviews are awesome!");
            Assert.AreEqual("awesome! are Interviews", reversedPhrase);
        }

        [TestMethod]
        public void ReversedPhraseIsNotNull()
        {
            ReverseWordsInAString reverseWordsInAString = new ReverseWordsInAString();
            string reversedPhrase = reverseWordsInAString.ReverseWords("Interviews are awesome!");
            Assert.IsNotNull(reversedPhrase);
        }

        [TestMethod]
        public void RemoveWhiteSpaces()
        {
            ReverseWordsInAString reverseWordsInAString = new ReverseWordsInAString();
            string reversedPhrase = reverseWordsInAString.ReverseWords("  Hi  ");
            Assert.AreEqual("Hi", reversedPhrase);
        }

        [TestMethod]
        public void MultipleWhiteSpaces()
        {
            ReverseWordsInAString reverseWordsInAString = new ReverseWordsInAString();
            string reversedPhrase = reverseWordsInAString.ReverseWords("  Hi      Test    Method   ");
            Assert.AreEqual("Method Test Hi", reversedPhrase);
        }

        [TestMethod]
        public void PhraseIsNull()
        {
            ReverseWordsInAString reverseWordsInAString = new ReverseWordsInAString();
            string reversedPhrase = reverseWordsInAString.ReverseWords(null);
            Assert.IsNull(reversedPhrase);
        }
    }
}
