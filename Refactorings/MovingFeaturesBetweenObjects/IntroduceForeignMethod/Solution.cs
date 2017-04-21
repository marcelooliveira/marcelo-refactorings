using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.MovingFeaturesBetweenObjects.IntroduceForeignMethod
{
    class Solution
    {
        DateTime previousEnd = DateTime.Now;

        //...
        void SendReport()
        {
            DateTime nextDay = NextDay(previousEnd);
            //...
        }
        private static DateTime NextDay(DateTime date)
        {
            return date.AddDays(1);
        }
    }
}
