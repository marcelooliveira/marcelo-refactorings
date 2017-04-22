using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.ReplaceMethodWithMethodObject
{
    //Transform the method into a separate class so that the local variables become fields of the class. Then you can split the method into several methods within the same class.
    class Solution
    {
    }

    public class Order
    {
        //...
        public double Price()
        {
            return new PriceCalculator(this).Compute();
        }
    }

    public class PriceCalculator
    {
        public PriceCalculator(Order order)
        {
            // copy relevant information from order object.
            //...
        }

        public double Compute()
        {
            // long computation.
            //...
            return 112.34;
        }
    }
}
