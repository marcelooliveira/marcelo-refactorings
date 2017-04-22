using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.Conditionals.IntroduceNullObject
{
    class Solution
    {
        void DoSomething()
        {
            Plan plan;
            Order order = null;
            Customer customer = null;

            // Replace null values with Null-object.
            customer = order.Customer ?? new NullCustomer();

            // Use Null-object as if it's normal subclass.
            plan = customer.GetPlan();
        }
    }

    class Order
    {
        internal NullCustomer Customer;
    }

    public sealed class NullCustomer : Customer
    {
        public override bool IsNull
        {
            get { return true; }
        }

        public override Plan GetPlan()
        {
            return new NullPlan();
        }
        // Some other NULL functionality.
    }

    public sealed class NullPlan : Plan
    {

    }
}
