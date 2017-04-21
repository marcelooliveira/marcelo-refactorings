using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.ExtractMethod
{
    class Solution
    {
        string name;

        void PrintOwing()
        {
            PrintBanner();
            PrintDetails(GetOutstanding());
        }

        void PrintDetails(double outstanding)
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("amount: " + outstanding);
        }

        void PrintBanner()
        {

        }

        double GetOutstanding()
        {
            return 0d;
        }
    }
}
