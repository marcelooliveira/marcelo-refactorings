using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.Conditionals.ConsolidateDuplicateConditionalFragments
{
    class Problem
    {
        private double price;
        private double total;

        public Problem()
        {
            if (IsSpecialDeal())
            {
                total = price * 0.95;
                Send();
            }
            else
            {
                total = price * 0.98;
                Send();
            }
        }

        private bool IsSpecialDeal()
        {
            throw new NotImplementedException();
        }

        private void Send()
        {
            throw new NotImplementedException();
        }
    }
}
