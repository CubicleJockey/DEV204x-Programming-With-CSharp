using System;

namespace ModuleSixAssignment.University
{
    public class Teacher : Person
    {
        #region Properties

        public string PreFix { get; private set; }

        public string Department { get; private set; }

        #endregion Properties

        public Teacher(string prefix, string fName, string lName, DateTime bDay, string address, string address1,
                       string city, string state, string zip, string country, string department)
        {
            PreFix = prefix;
            Department = department;

            #region Set Inherited Properties

            FirstName = fName;
            LastName = lName;
            Birthday = bDay;
            Address = address;
            Address1 = address1;
            City = city;
            State = state;
            Zip = zip;
            Country = country;

            #endregion Set Inherited Properties
        }

        public string GiveTest()
        {
            return string.Format("Teacher {0} gave test.", LastName);
        }
    }
}
