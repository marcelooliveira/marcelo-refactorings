using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.SubstituteAlgorithm
{
    class Solution
    {
        string FoundPerson(string[] people)
        {
            List<string> candidates = new List<string>() { "Don", "John", "Kent" };

            for (int i = 0; i < people.Length; i++)
            {
                if (candidates.Contains(people[i]))
                {
                    return people[i];
                }
            }

            return String.Empty;
        }
    }
}
