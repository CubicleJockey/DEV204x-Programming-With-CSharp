using System.Collections;

namespace ModuleSevenAssignment.University
{
    public class Program
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

        public Program(string name, IEnumerable degreesOffered, Teacher departmentHead, Degree degree)
        {
            Name = name;
            DegreesOffered = degreesOffered;
            DepartmentHead = departmentHead;
            Degree = degree;
        }
    }
}
