using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.Conditionals.ConsolidateDuplicateConditionalFragments
{
    class Solution
    {
        private double price;
        private double total;

        public Solution()
        {
            if (IsSpecialDeal())
            {
                total = price * 0.95;
            }
            else
            {
                total = price * 0.98;
            }
            Send();
        }

        private void Send()
        {
            throw new NotImplementedException();
        }

        private bool IsSpecialDeal()
        {
            throw new NotImplementedException();
        }
    }
}
