using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.Conditionals.IntroduceAssertion2
{
    class Solution
    {
        private decimal expenseLimit;

        public decimal NULL_EXPENSE { get; private set; }

        decimal GetExpenseLimit()
        {
            var primaryProject = new Project();

            Assert.IsTrue(expenseLimit != NULL_EXPENSE || primaryProject != null);

            return (expenseLimit != NULL_EXPENSE) ?
              expenseLimit :
              primaryProject.GetMemberExpenseLimit();
        }
    }

    internal class Project
    {
        public Project()
        {
        }

        internal decimal GetMemberExpenseLimit()
        {
            throw new NotImplementedException();
        }
    }

    internal class Assert
    {
        public Assert()
        {
        }

        internal static bool IsTrue(object p)
        {
            throw new NotImplementedException();
        }
    }
}
