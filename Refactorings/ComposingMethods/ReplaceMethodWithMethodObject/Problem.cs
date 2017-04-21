using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.ReplaceMethodWithMethodObject
{
    //You have a long method in which the local variables are so intertwined that you cannot apply [Extract Method].
    class Problem
    {
        //...
        public double Price()
        {
            double primaryBasePrice = 100;
            double secondaryBasePrice = 100;
            double tertiaryBasePrice = 100;
            // long computation.
            //...

            return primaryBasePrice + secondaryBasePrice + tertiaryBasePrice;
        }
    }
}
