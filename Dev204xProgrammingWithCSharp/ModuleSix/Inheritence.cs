using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModuleSix.Classes;

namespace ModuleSix
{
    [TestClass]
    public class Inheritence
    {
        [TestMethod]
        public void Main()
        {
            //Plain class
            Employee employee = new Employee
            {
                EmpNumber = "Ar2xtyalk",
                Address = "1234 Awesome Lane, Lacey WA 98516",
                Firstname = "Cubicle",
                LastName = "Jockey"
            };

            //Manager inherits and uses Employee as a BASE class
            Manager manager = new Manager();

            /*
             * We can see here that without defining EmpNumber, Address, FirstName and LastName
             * directly in the manager class we get them via inheriting from Employee class.
             */

            manager.Address = "I was inherited";
            manager.Firstname = "I was inherited";
            manager.LastName = "I was inherited";
            manager.EmpNumber = "I was inherited";

            manager.Department = "I was defined in Manager class";
        }
    }
}
