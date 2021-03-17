using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.LevelOne
{
/*    Text Analytics
You're a newly hired engineer for a brand-new company that's building a "killer Word-like application". You've been specifically assigned to implement a tool that gives the user some details on common word usage, letter usage, and some other analytics for a given document! More specifically, you must read a given text file (no special formatting, just a plain ASCII text file) and print off the following details:

Number of words
Number of letters
Number of symbols(any non-letter and non-digit character, excluding white spaces)
Top three most common words(you may count "small words", such as "it" or "the")
Top three most common letters

Author: nint22

Formal Inputs & Outputs
Input Description
As an argument to your program on the command line, you will be given a text file location(such as "C:\Users\nint22\Document.txt" on Windows or "/Users/nint22/Document.txt" on any other sane file system). This file may be empty, but will be guaranteed well-formed(all valid ASCII characters). You can assume that line endings will follow the UNIX-style new-line ending(unlike the Windows carriage-return & new-line format ).

Output Description
For each analytic feature, you must print the results in a special string format.Simply you will print off 6 to 8 sentences with the following format:

"A words", where A is the number of words in the given document
"B letters", where B is the number of letters in the given document
"C symbols", where C is the number of non-letter and non-digit character, excluding white spaces, in the document
"Top three most common words: D, E, F", where D, E, and F are the top three most common words
"Top three most common letters: G, H, I", where G, H, and I are the top three most common letters
*/
public class TextAnalytics
    {
        TextStadistics textStadistics = new TextStadistics();
        Dictionary<string, int> dictWords = new Dictionary<string, int>();
        Dictionary<char, int> dictLetters = new Dictionary<char, int>();

        public TextAnalytics()
        {

        }

        public void StartAnalyze()
        {
            //Read document
            string text = System.IO.File.ReadAllText(@".\Document.txt");

            NumberOfWords(text);
            NumberOfLetters(text);

            SearchMostCommonLetters();
            SearchMostCommonWords();

            //Print
            PrintResults();
        }

        private void NumberOfWords(string text)
        {
            var allTextArray = text.Split(' ');
            textStadistics.numberOfWords = allTextArray.Length;

            for (int i = 0; i < allTextArray.Length; i++)
            {
                if (dictWords.ContainsKey(allTextArray[i]))
                {
                    dictWords[allTextArray[i]]++;
                }
                else
                {
                    dictWords.Add(allTextArray[i], 1);
                }
            }

            //Sort
            dictWords = dictWords.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        private void NumberOfLetters(string text)
        {
            textStadistics.numberOfLetters = text.Replace(" ", "").Replace(",", "").Replace(".", "").Replace(";", "").Length;
            text = text.Replace(" ", "");

            foreach (char item in text)
            {
                if (Char.IsPunctuation(item) || Char.IsSymbol(item))
                {
                    textStadistics.numberOfSymbols++;
                }
                else
                {
                    if (dictLetters.ContainsKey(item))
                    {
                        dictLetters[item]++;
                    }
                    else
                    {
                        dictLetters.Add(item, 1);
                    }
                }
            }

            //Sort
            dictLetters = dictLetters.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        private void SearchMostCommonLetters()
        {
            var partial = dictLetters.Take(3).ToList();

            for (int i = 0; i < partial.Count; i++)
            {
                //Asign
                textStadistics.mostCommonLetters[i] = "Letter : " + partial[i].Key + " appears " + partial[i].Value.ToString() + " times";
            }
        }

        private void SearchMostCommonWords()
        {
            var partial = dictWords.Where(o => o.Key.Length > 1).Take(3).ToList();

            for (int i = 0; i < partial.Count; i++)
            {
                //Asign
                textStadistics.mostCommonWords[i] = "Word: " + partial[i].Key + " appears:" + partial[i].Value.ToString() + " times";
            }
        }


        private void PrintResults()
        {
            Console.WriteLine(string.Format("{0} words", textStadistics.numberOfWords));
            Console.WriteLine(string.Format("{0} letters", textStadistics.numberOfLetters));
            Console.WriteLine(string.Format("{0} symbols", textStadistics.numberOfSymbols));
            Console.WriteLine("\n");
            Console.WriteLine(string.Format("Top three most common words: \n {0} \n {1} \n {2}", textStadistics.mostCommonWords[0], textStadistics.mostCommonWords[1], textStadistics.mostCommonWords[2]));
            Console.WriteLine("\n");
            Console.WriteLine(string.Format("Top three most common letters: \n {0} \n {1} \n {2}", textStadistics.mostCommonLetters[0], textStadistics.mostCommonLetters[1], textStadistics.mostCommonLetters[2]));
        }
    }

    internal class TextStadistics
    {
        /// <summary>
        /// Number of words in the given document
        /// </summary>
        public int numberOfWords;

        /// <summary>
        /// Number of letters in the given document
        /// </summary>
        public int numberOfLetters;

        /// <summary>
        /// Number of non-letter and non-digit character, excluding white spaces, in the document
        /// </summary>
        public int numberOfSymbols;

        /// <summary>
        /// Top three most common words in text
        /// </summary>
        public string[] mostCommonWords = new string[3];

        /// <summary>
        /// Top three most common letters in text
        /// </summary>
        public string[] mostCommonLetters = new string[3];

        public TextStadistics()
        {

        }
    }
}
