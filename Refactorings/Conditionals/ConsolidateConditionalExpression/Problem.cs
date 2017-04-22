using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.Conditionals.ConsolidateConditionalExpression
{
    class Problem
    {
        private bool isPartTime;
        private int monthsDisabled;
        private int seniority;

        double DisabilityAmount()
        {
            if (seniority < 2)
            {
                return 0;
            }
            if (monthsDisabled > 12)
            {
                return 0;
            }
            if (isPartTime)
            {
                return 0;
            }
            // compute the disability amount
            //...

            return 23.4;
        }
    }
}
