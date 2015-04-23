using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Module5Assignment.University
{
    public class Teacher
    {
         #region Properties

            public string PreFix { get; private set; }
            public string FirstName { get; private set; }
            public string LastName { get; private set; }

            public string Department { get; private set; }

            #endregion Properties

            public Teacher(string prefix, string firstName, string lastName, string department)
            {
                PreFix = prefix;
                FirstName = firstName;
                LastName = lastName;
                Department = department;
            }
    }
}
