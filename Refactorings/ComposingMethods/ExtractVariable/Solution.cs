using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.ExtractVariable
{
    //Place the result of the expression or its parts in separate variables that 
    //are self-explanatory.
    class Solution
    {
        string platform;
        string browser;
        int resize = 7;

        bool wasInitialized() { return false; }

        void RenderBanner()
        {
            bool isMacOs = platform.ToUpper().IndexOf("MAC") > -1;
            bool isIE = browser.ToUpper().IndexOf("IE") > -1;
            bool wasResized = resize > 0;

            if (isMacOs && isIE && wasInitialized() && wasResized)
            {
                // do something
            }
        }
    }
}
