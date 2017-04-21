using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.ReplaceTempwithQuery
{
    class Solution
    {
        int quantity = 10;
        double itemPrice = 12.3;

        double CalculateTotal()
        {
            if (BasePrice() > 1000)
            {
                return BasePrice() * 0.95;
            }
            else
            {
                return BasePrice() * 0.98;
            }
        }
        double BasePrice()
        {
            return quantity * itemPrice;
        }
    }
}
