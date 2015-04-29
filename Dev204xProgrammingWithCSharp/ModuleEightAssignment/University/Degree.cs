namespace ModuleEightAssignment.University
{
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
}
