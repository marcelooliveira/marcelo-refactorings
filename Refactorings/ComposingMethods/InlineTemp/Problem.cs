using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.InlineTemp
{
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
