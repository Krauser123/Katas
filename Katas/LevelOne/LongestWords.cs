using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas.LevelOne
{
    /*
     Write a function that returns the longest word(s) from a sentence. The function should not return any duplicate words (case-insensitive).

     Example
        longestWords("You are just an old antidisestablishmentarian") // ["antidisestablishmentarian"]
        longestWords("I gave a present to my parents") // ["present", "parents"]
        longestWords("Buffalo buffalo Buffalo buffalo buffalo buffalo Buffalo buffalo") // ["buffalo"] or ["Buffalo"]
     */

    public class LongestWords
    {
        string InputPhrase;
        string[] InputPhraseSplited;

        public LongestWords(string inputPhrase)
        {
            //Check if phrase is null
            this.InputPhrase = inputPhrase ?? throw new ArgumentException(inputPhrase);
        }

        public string[] FindLongestWord()
        {
            var longestWord = GetLongestWord();
            string[] longestWords = GetWordsWithSpecificLength(longestWord.Length);

            //Remove words if are the same
            longestWords = longestWords.Distinct().ToArray();

            return longestWords;
        }

        private string[] GetWordsWithSpecificLength(int length)
        {
            List<string> longestWords = new List<string>();

            for (int i = 0; i < this.InputPhraseSplited.Length; i++)
            {
                if (this.InputPhraseSplited[i].Length == length)
                {
                    longestWords.Add(this.InputPhraseSplited[i]);
                }
            }

            return longestWords.ToArray();
        }

        private string GetLongestWord()
        {
            string longestWord;
            int indexOfLongWord = 0;

            this.InputPhraseSplited = this.InputPhrase.ToLower().Split();
            int lastBigLength = 0;

            for (int i = 0; i < this.InputPhraseSplited.Length; i++)
            {
                if (this.InputPhraseSplited[i].Length > lastBigLength)
                {
                    lastBigLength = this.InputPhraseSplited[i].Length;
                    indexOfLongWord = i;
                }
            }

            longestWord = this.InputPhraseSplited[indexOfLongWord];

            return longestWord;
        }
    }
}
