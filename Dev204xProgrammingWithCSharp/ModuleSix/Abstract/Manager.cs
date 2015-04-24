using System;

namespace ModuleSix.Abstract
{
    public class Manager : Employee
    {
        #region Properties

        public string Department { get; set; }

        #endregion Properties


        #region Overridden Methods

        //Login has implementation within Employee and is OPTIONAL to override
        //Uncomment code and run test again to see the difference in messages.
        //public override void Login()
        //{
        //    Console.WriteLine("Manager Login.");
        //}

        //Must provide implentation because it's abstract in Employee base class
        public override void Hire()
        {
            Console.WriteLine("Hired someone");
        }

        #endregion Overridden Methods
    }
}
