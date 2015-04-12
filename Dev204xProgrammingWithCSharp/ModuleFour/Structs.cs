using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModuleFour
{
    [TestClass]
    public class Structs
    {
        [TestMethod]
        public void Basics()
        {
            Coffee coffee = new Coffee();
            coffee.Name = "Fourth Coffee Place";
            coffee.CountryOfOrigin = "Indonesia";
            coffee.Strength = 3;
            coffee.Bean = "Mister"; //Chuckle here at my terrible joke.

            Console.WriteLine(coffee.ToString());
        }

        [TestMethod]
        public void BasicsObjectInitializer()
        {
            //Documentation: https://msdn.microsoft.com/en-us/library/bb384062.aspx
            Coffee coffee = new Coffee
            {
                Name = "Fourth Coffee Place",
                CountryOfOrigin = "Indonesia",
                Strength = 3,
                Bean = "Mister"
            };
            //Chuckle here at my terrible joke.

            Console.WriteLine(coffee.ToString());
        }

        [TestMethod]
        public void StructWithConstructor()
        {
            Apple apple = new Apple("Golden", 3);
            Assert.AreEqual("Golden", apple.Name);
            Assert.AreEqual(3, apple.Weight);
        }
    }

    public struct Coffee
    {
        public string Name { get; set; }
        public string Bean { get; set; }
        public string CountryOfOrigin { get; set; }
        public int Strength { get; set; }

        //Overriding methods is a later concept
        //Using here for ease of use in output
        //Documentation: https://msdn.microsoft.com/en-us/library/ebca9ah3.aspx
        //Best practices you should always override ToString(), otherwise it just prints out the type name
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("Name: {0}", Name).AppendLine();
            sb.AppendFormat("CountryOfOrigin: {0}", CountryOfOrigin).AppendLine();
            sb.AppendFormat("Bean: {0}", Bean).AppendLine();
            sb.AppendFormat("Strength: {0}", Strength).AppendLine();

            return sb.ToString();
        }
    }

    public struct Apple
    {
        #region Properties

        public string Name { get; private set; }
        public int Weight { get; private set; }

        #endregion Properties

        public Apple(string name, int weight) : this()
        {
            Name = name;
            Weight = weight;
        }
    }
}