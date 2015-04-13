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

        //Doing this as array to give a preview
        private static string[] universityDegreesOffered;

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
            Console.WriteLine("First Name: ");
            studentFirstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            studentLastName = Console.ReadLine();

            Console.WriteLine("Birthday (dd/mm/yyyy or dd.mm.yyyy): ");
            try
            {
                studentBirthday = DateTime.Parse(Console.ReadLine());
            }
            catch(FormatException fx)
            {
                Console.WriteLine(fx.Message);
                throw;
            }

            Console.WriteLine("Address: ");
            studentAddress = Console.ReadLine();
            
            Console.WriteLine("Address1: ");
            studentAddress1 = Console.ReadLine();

            Console.WriteLine("City: ");
            studentCity = Console.ReadLine();
            
            Console.WriteLine("State: ");
            studentState = Console.ReadLine();

            Console.WriteLine("Zip: ");
            studentZip = Console.ReadLine();

            Console.WriteLine("Country: ");
            studentCountry = Console.ReadLine();

            Console.WriteLine("Notes: ");
            studentNotes = Console.ReadLine();
        }

        private static void GetProfessorInfo()
        {
            throw new NotImplementedException("Oh noes n' stuff!");
        }

        private static void GetProgramInfo()
        {
            throw new NotImplementedException("Oh noes n' stuff!");
        }

        private static void GetDegreeInfo()
        {
            throw new NotImplementedException("Oh noes n' stuff!");
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