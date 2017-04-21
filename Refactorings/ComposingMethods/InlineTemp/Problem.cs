using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.InlineTemp1
{
    //You have a temporary variable that is assigned the result of a simple expression and nothing more.
    class Order
    {
        public double BasePrice() { return 124.79; }
    }

    class Problem
    {
        bool HasDiscount(Order order)
        {
            double basePrice = order.BasePrice();
            return (basePrice > 1000);
        }
    }
}
