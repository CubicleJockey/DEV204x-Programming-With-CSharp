using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModuleEight
{
    [TestClass]
    public class GenericClasses
    {
        [TestMethod]
        public void GenericList()
        {
            const string bev1 = "Latte";
            const string bev2 = "Espresso";
            const string bev3 = "Americano";
            const string bev4 = "Cappuccion";
            const string bev5 = "Mocha";
            
            //Add the items to a strongly-typed collection List<T>
            var beverages = new List<String>();

            beverages.Add(bev1);
            beverages.Add(bev2);
            beverages.Add(bev3);
            beverages.Add(bev4);
            beverages.Add(bev5);

            //Object initializer instantiation
            var beverages2 = new List<string>
            {
                bev1,
                bev2,
                bev3,
                bev4,
                bev5
            };

            foreach(var beverage in beverages)
            {
                Console.WriteLine(beverage);
            }
        }

        [TestMethod]
        public void GenericListCoffeee()
        {
            var coffee1 = new Coffee { Name = "Espresso" };
            var coffee2 = new Coffee {Name = "Latte" };

            var coffees = new List<Coffee>
            {
                coffee1,
                coffee2
            };

            //because the Generic list is strong-typed
            //you don't need an explicit cast like with ArrayList
            foreach(var coffee in coffees)
            {
                Console.WriteLine(coffee.Name);
            }
        }

        [TestMethod]
        public void GenericDictionary()
        {
            //Dictionaries check for duplicate keys
            IDictionary<string, string> coffeeCodes = new Dictionary<string, string>();

            coffeeCodes.Add("CAL", "Café Au Lait");
            coffeeCodes.Add("CSM", "Cinommon Spice Machine");
            coffeeCodes.Add("ER", "Espresso Romano");
            coffeeCodes.Add("RM", "Raspberry Mocha");
            coffeeCodes.Add("IC", "Iced Coffee");

            //iterate through available keys
            foreach(var key in coffeeCodes.Keys)
            {
                Console.WriteLine("Key: {0}, Value: {1}", key, coffeeCodes[key]);
            }

            
            //safe way to try to get a value
            //Change this variable to a key from above to see
            //else clause execute
            const string searchKey = "DoesntExistsKey";

            var value = string.Empty;
            if(coffeeCodes.TryGetValue(searchKey, out value))
            {
                Console.WriteLine("Key: {0} isn't in the dictionary", searchKey);
            }
            else
            {
                Console.WriteLine("Value: {0} was found for Key: {1}", value, searchKey);
            }

        }
    }

    #region Classes

    public class Coffee
    {
        public string Name { get; set; }
    }

    #endregion Classes
}
