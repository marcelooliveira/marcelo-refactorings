using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.ReplaceMethodWithMethodObject
{
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
