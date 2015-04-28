using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModuleSeven
{
    [TestClass]
    public class Collections
    {
        //Just two types of collection example
        //May comback and add them all.

        [TestMethod]
        public void ArrayLists()
        {
            ArrayList thingies = new ArrayList();
            
            Thingy thingy1 = new Thingy(1, "Stuff");

            //Items are implicitly cast to the Object type when you add them
            thingies.Add(thingy1);
            thingies.Add(new Thingy(2, "Different"));


            //Items must be explicitly cast to original type on get
            Thingy getBackThingy1 = (Thingy) thingies[0];
            Thingy getBackThingy2 = (Thingy) thingies[1];

            Assert.AreEqual(1, getBackThingy1.Id);
            Assert.AreEqual("Stuff", getBackThingy1.Name);

            Assert.AreEqual(2, getBackThingy2.Id);
            Assert.AreEqual("Different", getBackThingy2.Name);
        }

        [TestMethod]
        public void HastTable()
        {
            //Create a new hashtable collection, key/value pair
            Hashtable ingredients = new Hashtable();

            ingredients.Add(1, "Beans");
            ingredients.Add(2, "Beyond beef");
            ingredients.Add(3, "Olive Oil");
            ingredients.Add(4, "Seasoning");
            ingredients.Add(5, "Greens");

            //Can check for a key
            Assert.IsTrue(ingredients.ContainsKey(2));

            //Can check for values
            Assert.IsTrue(ingredients.ContainsValue("Beans"));

            //Interations
            foreach(int key in ingredients.Keys)
            {
                Console.WriteLine(ingredients[key]);
            }
        }
    }

    #region Classes

    public class Thingy
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Thingy(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    #endregion Classes
}
