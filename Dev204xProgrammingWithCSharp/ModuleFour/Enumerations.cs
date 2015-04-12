using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModuleFour
{
    [TestClass]
    public class Enumerations
    {
        private enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        private enum Days2
        {
            Sunday = 1,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        private enum Answers : long
        {
            Yes,
            No,
            Maybe
        }
        
    

    [TestMethod]
        public void Basics()
        {
            Console.WriteLine("{0} : Represented Value: {1}", Days.Sunday, (int)Days.Sunday);
            Console.WriteLine("{0} : Represented Value: {1}", Days.Friday, (int)Days.Friday);
        }

        [TestMethod]
        public void Basics2()
        {
            Console.WriteLine("{0} : Represented Value: {1}", Days2.Sunday, (int)Days2.Sunday);
            Console.WriteLine("{0} : Represented Value: {1}", Days2.Friday, (int)Days2.Friday);
        }

        [TestMethod]
        public void DifferentUnderlyingDataType()
        {
            long yes = (long) Answers.Yes;
            Console.WriteLine(yes);
        }
    }
}
