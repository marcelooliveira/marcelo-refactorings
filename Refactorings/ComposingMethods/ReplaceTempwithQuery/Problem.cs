using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.ReplaceTempwithQuery
{
    class Problem
    {
        int quantity = 10;
        double itemPrice = 12.3;

        double CalculateTotal()
        {
            double basePrice = quantity * itemPrice;

            if (basePrice > 1000)
            {
                return basePrice * 0.95;
            }
            else
            {
                return basePrice * 0.98;
            }
        }
    }
}
