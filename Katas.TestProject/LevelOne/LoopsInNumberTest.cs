using Katas.LevelOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Katas.TestProject.LevelOne
{
    [TestClass]
    public class LoopsInNumberTest
    {
        [TestMethod]
        public void LoopsInNumber_None()
        {
            LoopsInNumber loopsInNmb = new LoopsInNumber();
            var nmbOfLoops = loopsInNmb.CountLoopsInNumber(111);
            Assert.AreEqual(0, nmbOfLoops);
        }

        [TestMethod]
        public void LoopsInNumber_IronMaiden()
        {
            LoopsInNumber loopsInNmb = new LoopsInNumber();
            var nmbOfLoops = loopsInNmb.CountLoopsInNumber(666);
            Assert.AreEqual(3, nmbOfLoops);
        }

        [TestMethod]
        public void LoopsInNumber_MoreLoops()
        {
            LoopsInNumber loopsInNmb = new LoopsInNumber();
            var nmbOfLoops = loopsInNmb.CountLoopsInNumber(689689);
            Assert.AreEqual(8, nmbOfLoops);
        }

        [TestMethod]
        public void LoopsInNumber_Negative()
        {
            LoopsInNumber loopsInNmb = new LoopsInNumber();
            var nmbOfLoops = loopsInNmb.CountLoopsInNumber(-1689);
            Assert.AreEqual(4, nmbOfLoops);
        }
    }
}
