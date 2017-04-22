using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.Conditionals.ConsolidateConditionalExpression
{
    class Solution
    {
        double DisabilityAmount()
        {
            if (IsNotEligableForDisability())
            {
                return 0;
            }
            // compute the disability amount
            //...

            return 23.4;
        }

        private bool IsNotEligableForDisability()
        {
            throw new NotImplementedException();
        }
    }
}
