using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModuleTen
{
    [TestClass]
    public class RestrictionOperators
    {
        [TestMethod]
        public void WhereClause()
        {
            var numbers = new[] {5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNumbers = from number in numbers
                             where number < 5
                             select number;

            Console.WriteLine("Numbers < 5:");
            foreach(var number in lowNumbers)
            {
                Console.WriteLine(number);
            }
        }

        [TestMethod]
        public void WhereClause2()
        {
            var products = CreateProducts();

            var soldOutProducts = from product in products
                                  where product.UnitsInStock == 0
                                  select product;

            Console.WriteLine("Sold out products:");
            foreach(var product in soldOutProducts)
            {
                Console.WriteLine("'{0}' is sold out!", product.Name);
            }
        }

        [TestMethod]
        public void OrderBy()
        {
            var words = new[] { "cherry", "apple", "blueberry" };

            var sortedWords = from word in words
                              orderby word
                              select word;

            Console.WriteLine("The sorted list of words:");
            foreach(var word in sortedWords)
            {
                Console.WriteLine(word);
            }
        }

        [TestMethod]
        [Description("Short by word length")]
        public void OrderBy2()
        {
            var words = new[] { "cherry", "apple", "blueberry" };

            var sortedWords = from word in words
                              orderby word.Length
                              select word;

            Console.WriteLine("The sorted list of words:");
            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }
        }

        #region Helper Methods

        private static IEnumerable<Product> CreateProducts()
        {
            return new List<Product>
            {
                new Product {Id = 1, Name = "Chai", Category = "Beverage", UnitPrice = 12.3m, UnitsInStock = 12 },
                new Product {Id = 2, Name = "Chang", Category = "Beverage", UnitPrice = 6.6m, UnitsInStock = 2 },
                new Product {Id = 3, Name = "Aniseed Syrup", Category = "Additive", UnitPrice = 1.5m, UnitsInStock = 11 },
                new Product {Id = 4, Name = "Chef Anton's Cajun Seasoning", Category = "Additive", UnitPrice = 12.3m, UnitsInStock = 0 },
                new Product {Id = 5, Name = "Espresso", Category = "Beverage", UnitPrice = 2.5m, UnitsInStock = 0 }
            };
        } 

        #endregion Helper Methods
    }

    #region Classes

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }

    #endregion Classes
}
