using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModuleFive
{
    [TestClass]
    public class AnonymousClasses
    {
        [TestMethod]
        public void Main()
        {
            var anonymous = new { Name = "Batman", Age = 42 };
            Console.WriteLine("Name: {0} Age: {1}", anonymous.Name, anonymous.Age);
        }
    }
}
