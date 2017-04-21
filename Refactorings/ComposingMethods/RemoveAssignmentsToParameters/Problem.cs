using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.RemoveAssignmentsToParameters
{
    class Problem
    {
        int Discount(int inputVal, int quantity)
        {
            if (inputVal > 50)
            {
                inputVal -= 2;
            }
            //...

            return inputVal;
        }
    }
}
