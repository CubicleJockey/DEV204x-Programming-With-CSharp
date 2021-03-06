﻿using System.Collections.Generic;

namespace ModuleSixAssignment.University
{
    public class Course
    {
        #region Properties

        public string Code { get; private set; }

        public string Title { get; private set; }

        public string Description { get; private set; }

        public short CreditHours { get; private set; }

        public Teacher Teacher { get; private set; }

        //IEnumerable<T> is the interface that Arrays and List<T> inherit from
        //This allows an array, a List<T> or any other item that inherits from
        //IEnumerable<T> to be passed to this property.
        //Documentation: https://msdn.microsoft.com/en-us/library/9eekhta0%28v=vs.110%29.aspx
        public IEnumerable<Student> Students { get; private set; } 

        #endregion Properties

        public Course(string code, string title, string description, short creditHours, Teacher teacher, IEnumerable<Student> students)
        {
            Code = code;
            Title = title;
            Description = description;
            CreditHours = creditHours;
            Teacher = teacher;
            Students = students;
        }
    }
}
