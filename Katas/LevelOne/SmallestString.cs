using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.LevelOne
{
    public class SmallestString
    {

        //Given a int 'weight' return the smallest string, all chars have a weight equal to its position on ABC.

        public string GetSmallestString(int weight)
        {
            string word = string.Empty;

            for (int i = 26; i > 0; i--)
            {
                while (weight > i)
                {
                    char letter = GetLetterByWeight(i);
                    word += letter;
                    weight -= i;
                }
            }

            return word;
        }

        private char GetLetterByWeight(int weight)
        {
            var index = (char)(weight + 64);
            return index;
        }
    }
}
