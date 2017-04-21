using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.RemoveAssignmentsToParameters
{
    //Some value is assigned to a parameter inside method's body.
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
