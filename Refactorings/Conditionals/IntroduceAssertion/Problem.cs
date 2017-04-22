using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.Conditionals.IntroduceAssertion
{
    class Problema
    {
        private double expenseLimit;

        public double NULL_EXPENSE { get; private set; }

        double GetExpenseLimit()
        {
            // should have either expense limit or a primary project
            return (expenseLimit != NULL_EXPENSE) ?
              expenseLimit :
              primaryProject.GetMemberExpenseLimit();
        }
    }

    internal class primaryProject
    {
        internal static double GetMemberExpenseLimit()
        {
            throw new NotImplementedException();
        }
    }
}
