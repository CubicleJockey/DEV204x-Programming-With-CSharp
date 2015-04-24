using System;
using System.Text;

using ModuleSixAssignment.University;

namespace ModuleSixAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /*Leaving some fields with empty values to ease of assignment*/
            Student student1 = new Student("Carlo", "Poppa", DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            Student student2 = new Student("Super", "Commuter", DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            Student student3 = new Student("Kellee", "Maze", DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);

            /*Using some empty values for simplicity shake*/
            Teacher teacher = new Teacher("Dr.", "Madu", "Rao", DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "Information Technology");

            Course course = new Course("Dev204x", "Programming with C#", "Programming", 5, teacher, new[] { student1, student2, student3 });
            Degree degree = new Degree("Bachelor", "Computer Science", 400, course);
            University.Program program = new University.Program("Information Technology", new[] { "Bachelor", "Masters" }, teacher, degree);

            var sb = new StringBuilder();

            sb.AppendFormat("The {0} program contains the {1} of {2} degree", program.Name, program.Degree.Level, program.Degree.Major).AppendLine();
            sb.AppendLine();
            sb.AppendFormat("The {0} of {1} degree contains the course {2}", program.Degree.Level, program.Degree.Major, program.Degree.Course.Title).AppendLine();
            sb.AppendLine();
            sb.AppendFormat("Teacher: {0} {1} {2}", program.Degree.Course.Teacher.PreFix,
                                                    program.Degree.Course.Teacher.FirstName,
                                                    program.Degree.Course.Teacher.LastName).AppendLine();
            sb.AppendLine();
            sb.AppendFormat("The {0} course contains {1} student(s)", program.Degree.Course.Title, Student.NumberOfStudents).AppendLine();
            sb.AppendLine();
            sb.AppendLine(program.Degree.Course.Teacher.GiveTest());
            sb.AppendLine();
            sb.AppendLine("\tStudents: ");
            foreach(var student in program.Degree.Course.Students)
            {
                sb.AppendFormat("\t   {0}, {1} - They took a test: {2}", student.FirstName, student.LastName, student.TakeTest()).AppendLine();
            }

            Console.WriteLine(sb.ToString());
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
