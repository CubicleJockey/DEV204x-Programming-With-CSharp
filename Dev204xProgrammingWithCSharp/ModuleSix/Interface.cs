using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModuleSix.Interfaces;

namespace ModuleSix
{
    [TestClass]
    public class Interface
    {
        [TestMethod]
        public void Main()
        {
            //The type can be either Customer or ILoyaltyCardHolder
            //Depending on purpose, same works for all inheritence
            Customer customer1 = new Customer();
            ILoyaltyCardHolder customer2 = new Customer();

            customer1.AddPoints(14.5m); //m makes it a decimal instead of a double
            customer1.AddPoints(2.50m);

            Assert.AreEqual(16, customer1.TotalPoints); //Conversion lost of decimal point
            customer1.ResetPoints();
            Assert.AreEqual(0, customer1.TotalPoints);

            customer2.AddPoints(4.6m);
            customer2.AddPoints(1m);

            Assert.AreEqual(5, customer2.TotalPoints);
            customer2.ResetPoints();
            Assert.AreEqual(0, customer2.TotalPoints);

        }
    }
}
