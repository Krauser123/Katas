﻿

using System;

namespace Katas.LevelOne
{
    /*
     Function that receives an array of single digit ints representing a longer
     integer, such as [8, 7, 9, 9] representing 8,799, and increments it by 1
     returning the result also in an array format.
     Input = [8, 7, 9, 9]
     Output= [8, 8, 0, 0]
     */
    public class IncrementNumberInArray
    {
        public int[] IncrementNumber(int[] arrayToInc)
        {
            string numbr = string.Empty;
            for (int i = 0; i < arrayToInc.Length; i++)
            {
                numbr += arrayToInc[i];
            }

            var as2 = Convert.ToInt32(numbr);
            as2++;

            int[] newGuess = new int[as2.ToString().Length];
            for (int i = 0; i < as2.ToString().Length; i++)
            {
                newGuess[i] = as2.ToString()[i] - '0';
            }

            return newGuess;
        }
    }
}
