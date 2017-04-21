using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.ReplaceTempwithQuery
{
    //Move the entire expression to a separate method and return the result from it. Query the method instead of using a variable. Incorporate the new method in other methods, if necessary.
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
