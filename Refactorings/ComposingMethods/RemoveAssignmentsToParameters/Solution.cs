using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.RemoveAssignmentsToParameters
{
    class Solution
    {
        int Discount(int inputVal, int quantity)
        {
            int result = inputVal;

            if (inputVal > 50)
            {
                result -= 2;
            }
            //...

            return result;
        }
    }
}
