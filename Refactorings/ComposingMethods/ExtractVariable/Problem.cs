using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.ExtractVariable
{
    //You have an expression that is hard to understand.
    class Problem
    {
        string platform;
        string browser;
        int resize = 7;
        bool wasInitialized() { return false; }

        void RenderBanner()
        {
            if ((platform.ToUpper().IndexOf("MAC") > -1) &&
                 (browser.ToUpper().IndexOf("IE") > -1) &&
                  wasInitialized() && resize > 0)
            {
                // do something
            }
        }
    }
}
