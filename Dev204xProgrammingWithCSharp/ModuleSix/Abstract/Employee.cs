using System;

namespace ModuleSix.Abstract
{
    public abstract class Employee
    {
        #region Properties

        public string EmpNumber { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }

        #endregion Properties


        #region Methods

        public virtual void Login()
        {
            Console.WriteLine("Employee Logged In!");
        }

        public abstract void Hire();

        #endregion Methods
    }
}
