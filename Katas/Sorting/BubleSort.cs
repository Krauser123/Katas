
namespace Katas.Sorting
{
    public class BubbleSort
    {
        public static int[] BubbleSortedArray(int[] arrayToSort)
        {
            int arrayToSortLength = arrayToSort.Length;

            for (int i = 0; i < arrayToSortLength - 1; i++)
            {
                for (int j = 0; j < arrayToSortLength - i - 1; j++)
                {
                    if (arrayToSort[j] > arrayToSort[j + 1])
                    {
                        int temp = arrayToSort[j];
                        arrayToSort[j] = arrayToSort[j + 1];
                        arrayToSort[j + 1] = temp;
                    }
                }
            }

            return arrayToSort;
        }
    }
}
