using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.MovingFeaturesBetweenObjects.IntroduceForeignMethod
{
    //A utility class does not contain the method that you need and you cannot add the method to the class.
    class Problem
    {
        DateTime previousEnd = DateTime.Now;
        //...
        void SendReport()
        {
            DateTime nextDay = previousEnd.AddDays(1);
            //...
        }
    }
}
