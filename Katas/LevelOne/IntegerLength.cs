
namespace Katas.LevelOne
{
    /*
     Write a function that takes an integer as input and returns the number of digits in that integer.
     */

    public class IntegerLength
    {
        public int CountIntegerDigits(int number)
        {
            int numberOfDigits = 0;


            numberOfDigits = number.ToString().Length;


            return numberOfDigits;
        }
    }
}
