using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModuleSix.Abstract;

namespace ModuleSix
{
    [TestClass]
    public class AbstractClasses
    {
        [TestMethod]
        public void Main()
        {
            //Employee is abstract, there for you can instatiate with new keyword
            //Employee employee = new Employee();

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

            //If you go to the Manager class in Abstract folder
            //and uncomment the overriden Login method you will
            //see the message output change, when you run again.
            manager.Login();
            
            manager.Hire();
        }
    }
}
