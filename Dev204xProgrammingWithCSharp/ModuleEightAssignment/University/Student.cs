using System;
using System.Collections.Generic;

namespace ModuleEightAssignment.University
{
    public class Student : Person
    {
        private static readonly Random _random = new Random();

        #region Static 

        //I disagree with this, if you have an array of students
        //you can just use length, this is sloppy
        public static int NumberOfStudents { get; private set; }

        #endregion Static

        #region Properties

        public string Notes { get; private set; }


        private readonly Stack<string> _grades;

        //This returns IEnumerable<T> to not expose the
        //Stack<T> methods per encapsulation principle
        public IEnumerable<string> Grades
        {
            get { return _grades.ToArray(); }
        }

        #endregion Properties

        public Student(string fName, string lName, DateTime bDay, string address, string address1,
                       string city, string state, string zip, string country, string notes)
        {
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

            Notes = notes;

            _grades = new Stack<string>();

            NumberOfStudents++;
        }

        #region Methods

        public void AddGrade(string grade)
        {
            _grades.Push(grade);
        }

        public bool TakeTest()
        {
            return (_random.Next(2) % 2) == 0;
        }

        #endregion Methods
    }
}
