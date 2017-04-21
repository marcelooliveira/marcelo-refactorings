using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.InlineMethod
{
    //Replace calls to the method with the method's content and delete the method itself.
    class Solution
    {
        int numberOfLateDeliveries = 9;

        int GetRating()
        {
            return numberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}
