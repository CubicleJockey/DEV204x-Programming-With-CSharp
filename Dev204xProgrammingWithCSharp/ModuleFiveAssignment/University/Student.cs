using System;

namespace Module5Assignment.University
{
    public class Student
    {
        #region Static 

        //I disagree with this, if you have an array of students
        //you can just use length, this is sloppy
        public static int NumberOfStudents { get; private set; }

        #endregion Static

        #region Properties

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime Birthday { get; private set; }
        public string Address { get; private set; }
        public string Address1 { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Zip { get; private set; }
        public string Country { get; private set; }
        
        #endregion Properties

        public Student(string fName, string lName, DateTime bDay, string address, string address1,
                       string city, string state, string zip, string country, string notes)
        {
            FirstName = fName;
            LastName = lName;
            Birthday = bDay;
            Address = address;
            Address1 = address1;
            City = city;
            State = state;
            Zip = zip;
            Country = country;

            NumberOfStudents++;
        }
    }
}
