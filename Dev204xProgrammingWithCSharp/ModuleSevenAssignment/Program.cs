using System;
using System.Collections;
using ModuleSevenAssignment.University;

namespace ModuleSevenAssignment
{
    public class Program
    {
        public static void Main(string[] args)
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
            University.Program program = new University.Program("Information Technology", new ArrayList { "Bachelor", "Masters" }, teacher, degree);

            program.Degree.Course.ListStudents();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
