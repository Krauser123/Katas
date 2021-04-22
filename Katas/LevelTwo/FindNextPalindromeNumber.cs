using System.Linq;

namespace Katas.LevelOne
{
    /*
       Given a positive number, find the next smallest palindrome larger than the number.
        
        INPUT = 125 // OUTPUT = 131        
        INPUT = 19279 // OUTPUT = 19291
    */

    public class FindNextPalindromeNumber
    {        
        public int NextPalindromeNumber(int number)
        {
            int nextNumber = number;

            
            //Brute Force            
            do
            {
                nextNumber++;
            }
            while (!CheckPalindrome_Numeric(nextNumber));

            return nextNumber;
        }

        private bool CheckPalindrome_Numeric(int num)
        {
            bool isPalindrome = false;

            var forward = num.ToString().ToCharArray();
            var reversed = forward.Reverse();

            if (forward.SequenceEqual(reversed))
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }
    }
}