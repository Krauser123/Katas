using Katas.LevelOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Katas.TestProject.LevelOne
{
    [TestClass]
    public class IncrementNumberInArrayTest
    {
        [TestMethod]
        public void NewYear()
        {
            IncrementNumberInArray incrementNumber = new IncrementNumberInArray();
            var incrementedArray = incrementNumber.IncrementNumber(new[] {1,9,9,9 });
            CollectionAssert.AreEqual(new[] { 2, 0, 0, 0 }, incrementedArray);
        }

        [TestMethod]
        public void BigNumber()
        {
            IncrementNumberInArray incrementNumber = new IncrementNumberInArray();
            var incrementedArray = incrementNumber.IncrementNumber(new[] { 2, 0, 0, 0, 0, 0, 0 });
            CollectionAssert.AreEqual(new[] { 2, 0, 0, 0, 0, 0, 1 }, incrementedArray);
        }

        [TestMethod]
        public void NegativeNumber()
        {
            IncrementNumberInArray incrementNumber = new IncrementNumberInArray();
            var incrementedArray = incrementNumber.IncrementNumber(new[] { -1 });
            CollectionAssert.AreEqual(new[] { 0 }, incrementedArray);
        }
    }
}