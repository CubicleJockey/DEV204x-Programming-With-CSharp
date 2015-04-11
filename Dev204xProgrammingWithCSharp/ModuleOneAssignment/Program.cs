using System;

namespace ModuleOneAssignment
{
    /// <summary>
    /// Dev204x Programming with C#
    /// This is assignment 1 for Module 1
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Student Variables

            string studentFirstName = "André";
            string studentLastName = "Davis";
            DateTime studentBirthday = new DateTime(1982, 11, 11);
            string studentAddress = "1234 Awesome Ln Blvd";
            string studentAddress1 = "Apt #123";
            string studentCity = "Seattle";
            string studentState = "WA";
            string studentZip = "98102-6249";
            string studentCountry = "USA";
            string studentNotes = "Dis student be jammin'";


            #endregion Student Variables

            #region Professor Variables

            string professorPreFix = "Dr.";
            string professorFirstName = "Adam";
            string professorLastName = "West";
            string professorDepartment = "Sustainable Food Systems and Permaculture Design";
            

            #endregion Professor Variables

            #region University Degree Variables

            string universityDegreeLevel = "Masters";
            string univeristyDegreeMajor = "Permaculture Design and Sustainable Food Systems";
            short univerisityDegreeRequiredCredits = 160;

            #endregion Univeristy Degree Variables

            #region University Program Variables

            string univserityProgramName = "Whole Systems Design";
            
            //Doing this as array to give a preview
            string[] universityDegreesOffered = new[] {"Bachelor", "Masters", "Ph.d" };
            
            string univeristyProgramDepartmentHead = "Batman";

            #endregion University Program Variables

            #region A Course Variables

            string courseCode = "PC101";
            string courseTitle = "Introduction To Permaculture Design";
            short courseCreditHours = 5;
            string courseDescription = "This is an introductory course to learn the basic Prinicples that are the foundation of Permaculture.";

            #endregion A Course Variables

            #region Display to Console

            Console.WriteLine("Student Information");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("First Name: {0}", studentFirstName);
            Console.WriteLine("Last Name: {0}", studentLastName);
            Console.WriteLine("Birthday: {0}", studentBirthday.ToShortDateString());
            Console.WriteLine("Address: {0}", studentAddress);
            Console.WriteLine("Address1: {0}", studentAddress1);
            Console.WriteLine("City: {0}", studentCity);
            Console.WriteLine("State: {0}", studentState);
            Console.WriteLine("Country: {0}", studentCountry);
            Console.WriteLine("Notes: {0}", studentNotes);
            Console.WriteLine();
            Console.WriteLine("Professor");
            Console.WriteLine("---------");
            Console.WriteLine("Prefix: {0}", professorPreFix);
            Console.WriteLine("First Name: {0}", professorFirstName);
            Console.WriteLine("Last Name: {0}", professorLastName);
            Console.WriteLine("Department: {0}", professorDepartment);
            Console.WriteLine();
            Console.WriteLine("Degree");
            Console.WriteLine("------");
            Console.WriteLine("Level: {0}", universityDegreeLevel);
            Console.WriteLine("Major: {0}", univeristyDegreeMajor);
            Console.WriteLine("Credit Hours Required: {0}", univerisityDegreeRequiredCredits);
            Console.WriteLine();
            Console.WriteLine("Program");
            Console.WriteLine("-------");
            Console.WriteLine("Name: {0}", univserityProgramName);
            Console.WriteLine("Department Head: {0}", univeristyProgramDepartmentHead);
            Console.WriteLine("Degree's offered:");
            Console.WriteLine("\t{0}", universityDegreesOffered[0]);
            Console.WriteLine("\t{0}", universityDegreesOffered[1]);
            Console.WriteLine("\t{0}", universityDegreesOffered[2]);
            Console.WriteLine();
            Console.WriteLine("Current Course");
            Console.WriteLine("--------------");
            Console.WriteLine("Code: {0}", courseCode);
            Console.WriteLine("Title: {0}", courseTitle);
            Console.WriteLine("Credit Hours: {0}", courseCreditHours);
            Console.WriteLine("Description: {0}", courseDescription);

            #endregion Display to Console

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
