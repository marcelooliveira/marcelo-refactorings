﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.SubstituteAlgorithm
{
    //So you want to replace an existing algorithm with a new one?
    class Problem
    {
        string FoundPerson(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    return "Don";
                }
                if (people[i].Equals("John"))
                {
                    return "John";
                }
                if (people[i].Equals("Kent"))
                {
                    return "Kent";
                }
            }
            return String.Empty;
        }
    }
}
