using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.SplitTemporaryVariable
{
    class Solution
    {
        private int height;
        private int width;

        public Solution()
        {
            double perimeter = 2 * (height + width);
            Console.WriteLine(perimeter);
            double area = height * width;
            Console.WriteLine(area);
        }
    }
}
