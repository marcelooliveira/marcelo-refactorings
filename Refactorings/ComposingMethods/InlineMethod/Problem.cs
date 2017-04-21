using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.InlineMethod
{
    //When a method body is more obvious than the method itself, use this technique.
    class Problem
    {
        int numberOfLateDeliveries = 9;

        int GetRating()
        {
            return MoreThanFiveLateDeliveries() ? 2 : 1;
        }
        bool MoreThanFiveLateDeliveries()
        {
            return numberOfLateDeliveries > 5;
        }
    }
}
