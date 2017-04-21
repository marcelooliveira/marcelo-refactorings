using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.ExtractMethod
{
    class Problem
    {
        string name;

        void PrintOwing()
        {
            PrintBanner();

            //print details
            Console.WriteLine("name: " + name);
            Console.WriteLine("amount: " + GetOutstanding());
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
