using System;
using System.Collections;

namespace ModuleSevenAssignment.TurnInVersion
{
    public class Program
    {
        //Add static before copying into forum
        public void Main(string[] args)
        {
            /*Leaving some fields with empty values to ease of assignment*/
            Student student1 = new Student("Carlo", "Poppa", DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            student1.AddGrade("A");
            student1.AddGrade("B");
            student1.AddGrade("C");
            student1.AddGrade("D");
            student1.AddGrade("F");

            Student student2 = new Student("Super", "Commuter", DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            student2.AddGrade("A");
            student2.AddGrade("A");
            student2.AddGrade("A");
            student2.AddGrade("B");
            student2.AddGrade("A");

            Student student3 = new Student("Kellee", "Maze", DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            student2.AddGrade("C");
            student2.AddGrade("A");
            student2.AddGrade("A");
            student2.AddGrade("B");
            student2.AddGrade("A");


            /*Using some empty values for simplicity shake*/
            Teacher teacher = new Teacher("Dr.", "Madu", "Rao", DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "Information Technology");

            //ArrayList created inline of Course constructor
            //Using object initalizer rather than .Add() methods
            //Documentation: https://msdn.microsoft.com/en-us/library/bb384062.aspx
            Course course = new Course("Dev204x", "Programming with C#", "Programming", 5, teacher, new ArrayList { student1, student2, student3 });
            Degree degree = new Degree("Bachelor", "Computer Science", 400, course);

            //ArrayList created inline of Course constructor
            //Using object initalizer rather than .Add() methods
            //Documentation: https://msdn.microsoft.com/en-us/library/bb384062.aspx
            UProgram program = new UProgram("Information Technology", new ArrayList { "Bachelor", "Masters" }, teacher, degree);

            program.Degree.Course.ListStudents();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        #region Classes


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
            public IEnumerable Students { get; private set; }

            #endregion Properties

            public Course(string code, string title, string description, short creditHours, Teacher teacher, IEnumerable students)
            {
                Code = code;
                Title = title;
                Description = description;
                CreditHours = creditHours;
                Teacher = teacher;
                Students = students;
            }

            #region Students

            public void ListStudents()
            {
                foreach (var student in Students)
                {
                    var castStudent = (Student)student;
                    Console.WriteLine("{0} {1}", castStudent.FirstName, castStudent.LastName);
                }
            }

            #endregion Students
        }

        public class Degree
        {
            #region Properties

            public string Level { get; private set; }

            public string Major { get; private set; }

            //Shorts Max value is 32767 never heard of a degree program going higher than this EVER
            public short RequiredCredits { get; private set; }

            public Course Course { get; private set; }

            #endregion Properties

            /*
       * The Program object should be able to contain degrees and the degrees should be 
       * able to contain courses as well but for the purposes of this assignment, 
       * just ensure you have a single variable in UProgram to hold a Degree and 
       * single variable in Degree to hold a Course.  
       */
            public Degree(string level, string major, short requiredCredits, Course course)
            {
                Level = level;
                Major = major;
                RequiredCredits = requiredCredits;
                Course = course;
            }
        }

        public abstract class Person
        {
            public string FirstName { get; protected set; }
            public string LastName { get; protected set; }
            public DateTime Birthday { get; protected set; }
            public string Address { get; protected set; }
            public string Address1 { get; protected set; }
            public string City { get; protected set; }
            public string State { get; protected set; }
            public string Zip { get; protected set; }
            public string Country { get; protected set; }
        }

        public class UProgram
        {
            #region Properties

            public string Name { get; private set; }

            //IEnumerable<T> is the interface that Arrays and List<T> inherit from
            //This allows an array, a List<T> or any other item that inherits from
            //IEnumerable<T> to be passed to this property.
            //Documentation: https://msdn.microsoft.com/en-us/library/9eekhta0%28v=vs.110%29.aspx
            public IEnumerable DegreesOffered { get; private set; }

            public Teacher DepartmentHead { get; private set; }

            public Degree Degree { get; private set; }

            #endregion Properties

            public UProgram(string name, IEnumerable degreesOffered, Teacher departmentHead, Degree degree)
            {
                Name = name;
                DegreesOffered = degreesOffered;
                DepartmentHead = departmentHead;
                Degree = degree;
            }
        }

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

            public Stack Grades { get; private set; }

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

                Grades = new Stack();

                NumberOfStudents++;
            }

            #region Methods

            public void AddGrade(string grade)
            {
                Grades.Push(grade);
            }

            public bool TakeTest()
            {
                return (_random.Next(2) % 2) == 0;
            }

            #endregion Methods
        }

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

        #endregion Classes
    }
}
