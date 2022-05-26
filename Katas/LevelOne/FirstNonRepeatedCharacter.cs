using System;

namespace Katas.LevelOne
{
    /*
     First Non-repeated character
     Write a function that accepts a single string input and returns the first non-repeated character.

    INPUT = "AABBC"
    OUTPUT = "C"
    -----
    INPUT = "AABBCCDEEFF"
    OUTPUT = "D"
     */
    public class FirstNonRepeatedCharacter
    {
        public string GetFirstNonRepeatedCharacter(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException("input");
            }

            var splitted = input.ToUpper().ToCharArray();
            var nonRepeatedChar = string.Empty;
                        
            for (int i = 0; i < splitted.Length; i++)
            {
                var current = splitted[i];
                if (input.IndexOf(current) == input.LastIndexOf(current))
                {
                    return current.ToString();
                }
            }
            
            return nonRepeatedChar;
        }
    }
}
