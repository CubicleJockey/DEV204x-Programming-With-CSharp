using System;

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
        private static short univerisityDegreeRequiredCredits;

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

        #endregion A Course Variables


        #endregion Fields
        
        public static void Main(string[] args)
        {
            try
            {
                //Get information
                GetStudentInfo();
                GetProfessorInfo();
                GetProgramInfo();
                GetDegreeInfo();
                GetCourseInfo();

                //Display information
                DisplayStudentDetails();
                DisplayProfessorDetails();
                DisplayProgramDetails();
                DisplayDegreeDetails();
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
            Console.WriteLine("--------------------------");
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

            

        }

        private static void GetCourseInfo()
        {
            throw new NotImplementedException("Oh noes n' stuff!");
        }

        #endregion GetInfo Methods

        #region DisplayInfo Methods


        private static void DisplayStudentDetails()
        {
            throw new NotImplementedException("Oh noes n' stuff!");
        }


        private static void DisplayProfessorDetails()
        {
            throw new NotImplementedException("Oh noes n' stuff!");
        }

        private static void DisplayProgramDetails()
        {
            throw new NotImplementedException("Oh noes n' stuff!");
        }

        private static void DisplayDegreeDetails()
        {
            throw new NotImplementedException("Oh noes n' stuff!");
        }

        private static void DisplayCourseDetails()
        {
            throw new NotImplementedException("Oh noes n' stuff!");
        }

        #endregion DisplayInfo Methods

        #endregion Helper Methods
    }
}