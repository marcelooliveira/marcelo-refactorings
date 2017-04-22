using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.Conditionals.ReplaceNestedConditionalwithGuardClauses
{
    class Solution
    {
        private bool isDead;
        private bool isSeparated;
        private bool isRetired;

        public double GetPayAmount()
        {
            if (isDead)
            {
                return DeadAmount();
            }
            if (isSeparated)
            {
                return SeparatedAmount();
            }
            if (isRetired)
            {
                return RetiredAmount();
            }
            return NormalPayAmount();
        }

        private double NormalPayAmount()
        {
            throw new NotImplementedException();
        }

        private double RetiredAmount()
        {
            throw new NotImplementedException();
        }

        private double SeparatedAmount()
        {
            throw new NotImplementedException();
        }

        private double DeadAmount()
        {
            throw new NotImplementedException();
        }
    }
}
