using System.Collections.Generic;
using System.Linq;

namespace Katas.Sorting
{
    /*
     Given an array of numbers, return the list of numbers that are repeated, sorted by occurrence of the repetition

    [1, 2, 4, 4, 3, 3, 1, 5, 3, 9]  ==>  [4, 3, 1]
    [0, 1, 2, 3, 4, 5]                ==>  []
     */

    public class ArrayDuplicates
    {        
        public static int[] GetDuplicatesInArray(int[] numbers)
        {
            Dictionary<int, int> numberOcurrences = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];
                if (numberOcurrences.ContainsKey(currentNumber))
                {
                    numberOcurrences[currentNumber] = numberOcurrences[currentNumber] + 1;
                }
                else
                {
                    numberOcurrences.Add(currentNumber, 1);
                }
            }

            var sorted = numberOcurrences.OrderByDescending(o => o.Value).Select(o => o.Key).ToArray();

            return sorted;
        }
    }
}
