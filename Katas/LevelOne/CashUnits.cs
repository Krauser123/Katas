using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.LevelOne
{
    public class CashUnits
    {
 /*
         Write a function that returns the number of each cash-unit that fits into the given input, triying to return the minimum units posible.
        Given cash units are:
        500
        200
        100
        50
        20
        10
        5
        2
        1
        0.5
        0.2
        0.1
        0.05
        0.02
        0.01

        Expected output for 700.08€:
        1 unit of 500
        1 unit of 200
        0 unit of 100
        0 unit of 50
        0 unit of 20
        0 unit of 10
        0 unit of 5
        0 unit of 2
        0 unit of 1
        0 unit of 0.5
        0 unit of 0.2
        0 unit of 0.1
        1 unit of 0.05
        1 unit of 0.02
        1 unit of 0.01
         */

        public void CashUnitCalc(double quantityToWithdraw)
        {
            double[] availableMoneyUnits = { 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01};
            string phraseToPrint = "{0} unit of {1}";

            Console.WriteLine("The minimun quantity for " + quantityToWithdraw + " is:");
            for (int i = 0; i < availableMoneyUnits.Length; i++)
            {
                int units = 0;

                if (quantityToWithdraw >= availableMoneyUnits[i])
                {
                    units = ((int)(quantityToWithdraw / availableMoneyUnits[i]));
                    quantityToWithdraw = quantityToWithdraw - (units * availableMoneyUnits[i]);
                }

                Console.WriteLine(String.Format(phraseToPrint, units,availableMoneyUnits[i]));
            }            
        }
    }
}
