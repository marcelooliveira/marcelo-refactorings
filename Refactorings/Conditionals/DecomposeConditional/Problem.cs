using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.Conditionals.DecomposeConditional
{
    class Problema
    {
        private int charge;
        private int date;
        private int quantity;
        private int summerRate;
        private int SUMMER_END;
        private int SUMMER_START;
        private int winterRate;
        private int winterServiceCharge;

        public void DoSomething()
        {
            if (date < SUMMER_START || date > SUMMER_END)
            {
                charge = quantity * winterRate + winterServiceCharge;
            }
            else
            {
                charge = quantity * summerRate;
            }
        }
    }
}
