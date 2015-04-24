using System;
using System.Text;
using Module5Assignment.University;

namespace Module5Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* 
             * Since we don't need to display student information
             * I am using empty values.
             */
            Student student1 = new Student(string.Empty, string.Empty, DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            Student student2 = new Student(string.Empty, string.Empty, DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            Student student3 = new Student(string.Empty, string.Empty, DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);

            /*Don't need to display data using empty values*/
            Teacher teacher = new Teacher(string.Empty, string.Empty, string.Empty, string.Empty);

            Course course = new Course("Dev204x", "Programming with C#", "Programming", 5, teacher, new[]{ student1, student2, student3 });
            Degree degree = new Degree("Bachelor", "Computer Science", 400, course);
            University.Program program = new University.Program("Information Technology", new[]{"Bachelor", "Masters"}, teacher, degree);

            var sb = new StringBuilder();

            sb.AppendFormat("The {0} program contains the {1} of {2} degree", program.Name, program.Degree.Level, program.Degree.Major).AppendLine();
            sb.AppendLine();
            sb.AppendFormat("The {0} of {1} degree contains the course {2}", program.Degree.Level, program.Degree.Major, program.Degree.Course.Title).AppendLine();
            sb.AppendLine();
            sb.AppendFormat("The {0} course contains {1} student(s)", program.Degree.Course.Title, Student.NumberOfStudents).AppendLine();

            Console.WriteLine(sb.ToString());
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
