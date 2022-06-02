using Katas.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Katas.TestProject.Sorting
{
    [TestClass]
    public class BubleSortTest
    {
        [TestMethod]
        public void SortArrayWithBubble()
        {
            var sorted = BubbleSort.BubbleSortedArray(new int[] { 9, 2, 3, 5, 16, 1 });
            CollectionAssert.AreEqual(new int[] { 1, 2 ,3, 5, 9, 16}, sorted);
        }

        [TestMethod]
        public void SortArrayWithBubbleRepeat()
        {
            var sorted = BubbleSort.BubbleSortedArray(new int[] { 9, 9, 9, 2, 3, 5, 16, 1 });
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 5, 9, 9, 9, 16 }, sorted);
        }
    }
}