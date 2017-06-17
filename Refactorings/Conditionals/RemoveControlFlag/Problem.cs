using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.Conditionals.RemoveControlFlag
{
    class Problema
    {
        public Problema()
        {
            IEnumerable<string> people = new List<string>();
            CheckSecurity(people);
        }

        private void CheckSecurity(IEnumerable<string> people)
        {
            bool foundPerson = false;
            foreach (var person in people)
            {
                if (person.Equals("Don"))
                {
                    SendAlert();
                    foundPerson = true;
                }
                if (person.Equals("John"))
                {
                    SendAlert();
                    foundPerson = true;
                }
            }
        }

        private static void SendAlert()
        {
            var blabla = 0;
        }
    }
}
