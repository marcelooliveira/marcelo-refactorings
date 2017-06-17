using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.Conditionals.RemoveControlFlag
{
    class Solution
    {
        public Solution()
        {
            IEnumerable<string> people = new List<string>();
            CheckSecurity(people);
        }

        private void CheckSecurity(IEnumerable<string> people)
        {
            string foundPerson = string.Empty;
            foundPerson = FindPerson(people);
            var p = foundPerson;
        }

        private static string FindPerson(IEnumerable<string> people)
        {
            foreach (var person in people)
            {
                if (person.Equals("Don"))
                {
                    SendAlert();
                    return person;
                }
                else if (person.Equals("John"))
                {
                    SendAlert();
                    return person;
                }
            }

            return string.Empty;
        }

        private static void SendAlert()
        {
            var blabla = 0;
        }
    }
}
