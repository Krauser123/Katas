
namespace Katas.LevelOne
{
    public class LoopsInNumber
    {
        /*
         Calculate the number of "loops" in a number. A number has a loop when it has a closed circle when you draw it.
         So 0, 6 and 9 has one loop, 1 has no loop and 8 has two loops.
         IE: 2876 has three loops
         */

        public int CountLoopsInNumber(int number)
        {
            int numberOfLoops = 0;

            foreach (char digit in number.ToString())
            {                
                switch (digit)
                {
                    case '0':
                        numberOfLoops++;
                        break;
                    case '6':
                        numberOfLoops++;
                        break;
                    case '8':
                        numberOfLoops += 2;
                        break;
                    case '9':
                        numberOfLoops++;
                        break;
                    default:
                        break;
                }
            }

            return numberOfLoops;
        }
    }
}
