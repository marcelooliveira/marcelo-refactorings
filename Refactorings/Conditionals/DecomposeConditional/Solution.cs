using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.Conditionals.DecomposeConditional
{
    class Solution
    {
        private object charge;
        private object date;
        private object quantity;

        public void DoSomething()
        {
            if (NotSummer(date))
            {
                charge = WinterCharge(quantity);
            }
            else
            {
                charge = SummerCharge(quantity);
            }
        }

        private object SummerCharge(object quantity)
        {
            throw new NotImplementedException();
        }

        private object WinterCharge(object quantity)
        {
            throw new NotImplementedException();
        }

        private bool NotSummer(object date)
        {
            throw new NotImplementedException();
        }
    }
}
