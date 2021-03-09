using Katas.LevelOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Katas.TestProject.LevelOne
{
    [TestClass]
    public class WordWeightTest
    {
        [TestMethod]
        public void WordWeight_OneLetter()
        {
            WordWeight ww = new WordWeight();
            var weight = ww.CalcWordWeight("C");
            Assert.AreEqual(3, weight);
        }

        [TestMethod]
        public void WordWeight_SampleWord()
        {
            WordWeight ww = new WordWeight();
            var weight = ww.CalcWordWeight("Hi!");
            Assert.AreEqual(17, weight);
        }

        [TestMethod]
        public void WordWeight_SampleWordTwo()
        {
            WordWeight ww = new WordWeight();
            var weight = ww.CalcWordWeight("Hello World!!");
            Assert.AreEqual(124, weight);
        }

        [TestMethod]
        public void WordWeight_NullWord()
        {
            WordWeight ww = new WordWeight();
            var weight = ww.CalcWordWeight(null);
            Assert.AreEqual(0, weight);
        }
    }
}
