using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModuleFive
{
    [TestClass]
    public class StaticClasses
    {
        [TestMethod]
        public void Main()
        {
            /*Generally used as utility classes*/

            Console.WriteLine(Math.Pow(2, 8));

            /*For those who are sharped eyed you will realize Console is a static class. :)*/
        }
    }
}
