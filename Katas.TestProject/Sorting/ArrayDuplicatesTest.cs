using Katas.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Katas.TestProject.Sorting
{
    [TestClass]
    public class ArrayDuplicatesTest
    {        
        [TestMethod]
        public void GetDuplicatesInArrayBasic()
        {
            var ocurrences = ArrayDuplicates.GetDuplicatesInArray(new int[] { 1, 2, 2, 2, 1, 3 });
            Assert.AreEqual(2, ocurrences[0]);
        }

        [TestMethod]
        public void GetDuplicatesInArrayBasicSecondNumber()
        {
            var ocurrences = ArrayDuplicates.GetDuplicatesInArray(new int[] { 1, 2, 2, 2, 1, 3 });
            Assert.AreEqual(1, ocurrences[1]);
        }

        [TestMethod]
        public void GetDuplicatesInArrayMedium()
        {
            var ocurrences = ArrayDuplicates.GetDuplicatesInArray(new int[] { 1, 2, 1, 3, 3, 2, 3, 2, 3, 1 });
            Assert.AreEqual(3, ocurrences[0]);
        }

        [TestMethod]
        public void GetDuplicatesInArrayHard()
        {
            var ocurrences = ArrayDuplicates.GetDuplicatesInArray(new int[] { 1, 2, 2, 2, 1, 1, 2, 2, 2, 11, 2, 2, 2, 11, 2, 2, 2, 11, 2, 2, 2, 1 });
            Assert.AreEqual(11, ocurrences[2]);
        }
    }
}