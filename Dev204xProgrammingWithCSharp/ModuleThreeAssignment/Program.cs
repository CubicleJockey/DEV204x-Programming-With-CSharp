using System;
using System.Text;

namespace ModuleThreeAssignment
{
    public class Program
    {
        #region Fields

        #region Student Variables

        private static string studentFirstName;
        private static string studentLastName;
        private static DateTime studentBirthday;
        private static string studentAddress;
        private static string studentAddress1;
        private static string studentCity;
        private static string studentState;
        private static string studentZip;
        private static string studentCountry;
        private static string studentNotes;


        #endregion Student Variables

        #region Professor Variables

        private static string professorPreFix;
        private static string professorFirstName;
        private static string professorLastName;
        private static string professorDepartment;

        #endregion Professor Variables

        #region University Degree Variables

        private static string universityDegreeLevel;
        private static string univeristyDegreeMajor;
        private static short univerisityDegreeRequiredCredits = 0;

        #endregion Univeristy Degree Variables

        #region University Program Variables

        private static string univserityProgramName;
        private static readonly string[] universityDegreesOffered = new string[3];
        private static string univeristyProgramDepartmentHead;

        #endregion University Program Variables

        #region A Course Variables

        private static string courseCode;
        private static string courseTitle;
        private static string courseDescription;
        private static short courseCreditHours;

        #endregion A Course Variables


        #endregion Fields
        
        public static void Main(string[] args)
        {
            /*
             * I am not calling the Print/Display methods because this 
             * goes against SOLID principles and is just bad practice.
             * 
             * Documentation: http://en.wikipedia.org/wiki/SOLID_%28object-oriented_design%29
             * */
            try
            {
                GetStudentInfo();
                DisplayStudentDetails();
                
                GetProfessorInfo();
                DisplayProfessorDetails();

                GetProgramInfo();
                DisplayProgramDetails();

                GetDegreeInfo();
                DisplayDegreeDetails();
                
                GetCourseInfo();
                DisplayCourseDetails();
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);

                Console.WriteLine("Please restart application.");
                Console.WriteLine("Press any key to close.");
                Console.ReadLine();
            }
        }

        #region Helper Methods

        #region GetInfo Methods

        private static void GetStudentInfo()
        {
            Console.WriteLine("Student Information Entry:");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("First Name: ");
            studentFirstName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Last Name: ");
            studentLastName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Birthday (dd/mm/yyyy or dd.mm.yyyy): ");
            try
            {
                studentBirthday = DateTime.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            catch(FormatException fx)
            {
                Console.WriteLine(fx.Message);
                throw;
            }

            Console.WriteLine("Address: ");
            studentAddress = Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine("Address1: ");
            studentAddress1 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("City: ");
            studentCity = Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine("State: ");
            studentState = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Zip: ");
            studentZip = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Country: ");
            studentCountry = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Notes: ");
            studentNotes = Console.ReadLine();
            Console.WriteLine();
        }

        private static void GetProfessorInfo()
        {
            Console.WriteLine("Professor Information Entry:");
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            Console.WriteLine("First Name: ");
            professorFirstName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Last Name: ");
            professorLastName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("PreFix: ");
            professorPreFix = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Department: ");
            professorDepartment = Console.ReadLine();
            Console.WriteLine();
        }

        private static void GetProgramInfo()
        {
            Console.WriteLine("Program Information Entry:");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("Program Name: ");
            univserityProgramName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Department Head: (First and Last Name):");
            univeristyProgramDepartmentHead = Console.ReadLine();
            Console.WriteLine();

            const string YES = "y";
            Console.WriteLine("Does this program have a Bachelors Degree (Y/N):");
            var answer = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(answer) && answer.ToLower() == YES)
            {
                universityDegreesOffered[0] = "Bachelors";
                answer = string.Empty;
            }

            Console.WriteLine("Does this program have a Masters Degree (Y/N):");
            answer = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(answer) && answer.ToLower() == YES)
            {
                universityDegreesOffered[1] = "Masters";
                answer = string.Empty;
            }

            Console.WriteLine("Does this program have a Doctoral Degree (Y/N):");
            answer = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(answer) && answer.ToLower() == YES)
            {
                universityDegreesOffered[2] = "Doctorate";
                answer = string.Empty;
            }
        }

        private static void GetDegreeInfo()
        {
            Console.WriteLine("Degree Information Entry:");
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            Console.WriteLine("Level (Enter 1,2 or 3): ");
            Console.WriteLine("\t 1. Bachelors");
            Console.WriteLine("\t 2. Masters");
            Console.WriteLine("\t 3. Doctorate");

            int choice = 0;
            try
            {
                int.TryParse(Console.ReadLine(), out choice);
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }

            switch(choice)
            {
                case 1:
                    universityDegreeLevel = "Bachelors";
                    break;
                case 2:
                    universityDegreeLevel = "Masters";
                    break;
                case 3:
                    universityDegreeLevel = "Doctorate";
                    break;
                default:
                    Console.WriteLine("You failed to pick a choice within the bounds of 1,2 or 3");
                    throw new ArgumentOutOfRangeException();
            }


            Console.WriteLine("Major: ");
            univeristyDegreeMajor = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Credit Hours:");
            short.TryParse(Console.ReadLine(), out univerisityDegreeRequiredCredits);
        }

        private static void GetCourseInfo()
        {
            Console.WriteLine("Get Course Information Entry: ");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            Console.WriteLine("Code:");
            courseCode = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Title:");
            courseTitle = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Credit Hours:");
            short.TryParse(Console.ReadLine(), out courseCreditHours);
        }

        #endregion GetInfo Methods

        #region DisplayInfo Methods


        private static void DisplayStudentDetails()
        {
            /*
             * I am using the built-in .NET library StringBuilder to expose
             * whom ever grades my assignment to memory efficient ways to deal 
             * with strings.
             * 
             * Documentation: https://msdn.microsoft.com/en-us/library/system.text.stringbuilder%28v=vs.110%29.aspx
             */
            var sb = new StringBuilder();
            sb.AppendLine("Collected Student Information");
            sb.AppendLine("-----------------------------");
            sb.AppendFormat("First Name: {0}", studentFirstName).AppendLine();
            sb.AppendFormat("Last Name: {0}", studentLastName).AppendLine();
            sb.AppendFormat("Birthday: {0}", studentBirthday.ToShortDateString()).AppendLine();
            sb.AppendFormat("Address: {0}", studentAddress).AppendLine();
            sb.AppendFormat("Address1: {0}", studentAddress1).AppendLine();
            sb.AppendFormat("City: {0}", studentCity).AppendLine();
            sb.AppendFormat("State: {0}", studentState).AppendLine();
            sb.AppendFormat("Country: {0}", studentCountry).AppendLine();
            sb.AppendFormat("Notes: {0}", studentNotes).AppendLine();
            sb.AppendLine();

            Console.WriteLine(sb.ToString());
        }


        private static void DisplayProfessorDetails()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Collected Professor Information");
            sb.AppendLine("-------------------------------");
            sb.AppendFormat("Prefix: {0}", professorPreFix).AppendLine();
            sb.AppendFormat("First Name: {0}", professorFirstName).AppendLine();
            sb.AppendFormat("Last Name: {0}", professorLastName).AppendLine();
            sb.AppendFormat("Department: {0}", professorDepartment).AppendLine();
            sb.AppendLine();

            Console.WriteLine(sb.ToString());
        }

        private static void DisplayProgramDetails()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Collected Program Information");
            sb.AppendLine("-----------------------------");
            sb.AppendFormat("Name: {0}", univserityProgramName).AppendLine();
            sb.AppendFormat("Department Head: {0}", univeristyProgramDepartmentHead).AppendLine();
            sb.AppendFormat("Degree's offered:").AppendLine();

            foreach(var degree in universityDegreesOffered)
            {
                if(!string.IsNullOrWhiteSpace(degree))
                {
                    sb.AppendFormat("\t{0}", degree).AppendLine();
                }
            }
            sb.AppendLine();

            Console.WriteLine(sb.ToString());
        }

        private static void DisplayDegreeDetails()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Collected Degree Information");
            sb.AppendLine("----------------------------");
            sb.AppendFormat("Level: {0}", universityDegreeLevel);
            sb.AppendFormat("Major: {0}", univeristyDegreeMajor);
            sb.AppendFormat("Credit Hours Required: {0}", univerisityDegreeRequiredCredits);
            sb.AppendLine();

            Console.WriteLine(sb.ToString());
        }

        private static void DisplayCourseDetails()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Current Course");
            sb.AppendLine("--------------");
            sb.AppendFormat("Code: {0}", courseCode).AppendLine();
            sb.AppendFormat("Title: {0}", courseTitle).AppendLine();
            sb.AppendFormat("Credit Hours: {0}", courseCreditHours).AppendLine();
            sb.AppendFormat("Description: {0}", courseDescription).AppendLine();
            sb.AppendLine();

            Console.WriteLine(sb.ToString());
        }

        #endregion DisplayInfo Methods

        #endregion Helper Methods
    }
}