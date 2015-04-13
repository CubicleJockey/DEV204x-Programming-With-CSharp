using System;

namespace ModuleThreeAssignment
{
    public class Program
    {
        #region Fields


        #region Student Variables

        private string studentFirstName;
        private string studentLastName;
        private DateTime studentBirthday;
        private string studentAddress;
        private string studentAddress1;
        private string studentCity;
        private string studentState;
        private string studentZip;
        private string studentCountry;
        private string studentNotes;


        #endregion Student Variables

        #region Professor Variables

        private string professorPreFix;
        private string professorFirstName;
        private string professorLastName;
        private string professorDepartment;

        #endregion Professor Variables

        #region University Degree Variables

        private string universityDegreeLevel;
        private string univeristyDegreeMajor;
        private short univerisityDegreeRequiredCredits;

        #endregion Univeristy Degree Variables

        #region University Program Variables

        private string univserityProgramName;

        //Doing this as array to give a preview
        private string[] universityDegreesOffered;

        private string univeristyProgramDepartmentHead;

        #endregion University Program Variables

        #region A Course Variables

        private string courseCode;
        private string courseTitle;
        private string courseDescription;

        #endregion A Course Variables


        #endregion Fields
        
        public static void Main(string[] args)
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

        #region Helper Methods

        #region GetInfo Methods

        private static void GetStudentInfo()
        {
            throw new NotImplementedException("Oh noes n' stuff!");
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