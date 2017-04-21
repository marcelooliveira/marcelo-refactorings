using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.InlineMethod
{
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
