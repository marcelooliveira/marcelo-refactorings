using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.Conditionals.ReplaceNestedConditionalwithGuardClauses
{
    class Problema
    {
        private bool isDead;
        private bool isSeparated;
        private bool isRetired;

        public double GetPayAmount()
        {
            double result;

            if (isDead)
            {
                result = DeadAmount();
            }
            else
            {
                if (isSeparated)
                {
                    result = SeparatedAmount();
                }
                else
                {
                    if (isRetired)
                    {
                        result = RetiredAmount();
                    }
                    else
                    {
                        result = NormalPayAmount();
                    }
                }
            }

            return result;
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
