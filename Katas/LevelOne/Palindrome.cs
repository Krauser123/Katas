using System.Linq;

namespace Katas.LevelOne
{
   public class Palindrome
    {
        /* Given a int check if is a palindrome or not */
        public bool CheckPalindrome_Numeric(int num)
        {
            bool isPalindrome=false;
            
            var forward = num.ToString().ToCharArray();
            var reversed = forward.Reverse();

            if (forward.SequenceEqual(reversed))
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }


        /* Given a string check if is a palindrome or not */
        public bool CheckPalindrome_Word(string wordToCheck)
        {
            bool isPalindrome = false;

            var forward = wordToCheck.ToCharArray();
            var reversed = forward.Reverse();

            if (forward.SequenceEqual(reversed))
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }
    }
}
