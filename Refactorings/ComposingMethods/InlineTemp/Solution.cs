using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.InlineTemp2
{
    //Replace the references to the variable with the expression itself.
    class Order
    {
        public double BasePrice() { return 124.79; }
    }

    class Solution
    {
        bool HasDiscount(Order order)
        {
            return (order.BasePrice() > 1000);
        }
    }
}
