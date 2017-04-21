using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.InlineMethod
{
    class Solution
    {
        int numberOfLateDeliveries = 9;

        int GetRating()
        {
            return numberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}
