using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.Conditionals.IntroduceNullObject
{
    class Problema
    {
        void DoSomething()
        {
            Plan plan;
            Customer customer = null;

            if (customer == null)
            {
                plan = BillingPlan.Basic();
            }
            else
            {
                plan = customer.GetPlan();
            }
        }
    }

    public class Plan
    {

    }

    public class Customer
    {
        public virtual bool IsNull
        {
            get { return true; }
        }

        public virtual Plan GetPlan()
        {
            throw new NotImplementedException();
        }
    }

    internal class BillingPlan
    {
        internal static Plan Basic()
        {
            throw new NotImplementedException();
        }
    }
}
