using System;
using System.Linq;

namespace Katas.LevelOne
{
    /*
     Reverse Words in a String
    Given an input string, reverse all the words. To clarify, input: "Interviews are awesome!" output: "awesome! are Interviews".
    Consider all consecutive non-whitespace characters as individual words. If there are multiple spaces between words reduce them to a single white space. 
    Also remove all leading and trailing whitespaces. So, the output for " CS degree", "CS degree", "CS degree ", or " CS degree " are all the same: "degree CS"
     */
    public class ReverseWordsInAString
    {
        public string ReverseWords(string phrase)
        {
            string reversed = null;
            if (!string.IsNullOrEmpty(phrase))
            {
                //Remove leading and trailing whitespaces
                phrase = phrase.Trim();

                //Split and reverse
                var splittedPhrase = phrase.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s)).Reverse();

                reversed = String.Join(" ", splittedPhrase);
            }

            return reversed;
        }
    }
}
