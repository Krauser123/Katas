
namespace Katas.LevelOne
{
   public class WordWeight
    {
        /* Given a string, write a method that return the weight of each letter. This weight is its position in the alphabet. Ignore not alphabetic chars */
        /* Hi! = H(8) + I(9) + !(0) = 17 */
        public int CalcWordWeight(string word)
        {
            int wordWeight = 0;

            //We only check not null strings
            if (word != null)
            {
                word = word.ToUpper();
                for (int i = 0; i < word.Length; i++)
                {
                    //Get the letter to check
                    char letterToCalc = word[i];

                    //Otherwise the value is 0
                    if (char.IsLetter(letterToCalc))
                    {                        
                        var weight = (letterToCalc - 'A') + 1; //Other option: (var weight = letterToCalc - 64;) In ASCII, A=65
                        wordWeight += weight;
                    }
                }
            }

            return wordWeight;
        }
    }
}
