using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.SplitTemporaryVariable
{
    //You have a local variable that is used to store various intermediate values inside a method (except for cycle variables).
    class Problem
    {
        private int height;
        private int width;

        public Problem()
        {
            double temp = 2 * (height + width);
            Console.WriteLine(temp);
            temp = height * width;
            Console.WriteLine(temp);
        }
    }
}
