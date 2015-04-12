using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModuleThree
{
    [TestClass]
    public class Methods
    {
        public static readonly Random _random = new Random();

        [TestMethod]
        public void SimplestMethod()
        {
            PrintSomething();
        }

        [TestMethod]
        public void MethodWithParametersAndReturnType()
        {
            const int number1 = 5;
            const int number2 = 4;

            //C# only returns one value
            int result = Sum(number1, number2);

            //result is the return type captured in a local variable
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        [Description("Out parameters do not require the variable to be initialized.")]
        public void MethodWithOutParameters()
        {
            int number;
            string message;

            UsingOutParameters(out number, out message);

            Assert.AreEqual(42, number);
            Assert.AreEqual("I be a string of knowledge yo.", message);
        }

        [TestMethod]
        [Description("Ref parameters required the variable to be initialized.")]
        public void MethodWithRefParameters()
        {
            int number = 0;
            string message = string.Empty;

            UsingRefParameters(ref number, ref message);
            Assert.AreEqual(69, number);
            Assert.AreEqual("I be that other string of knowledge yo.", message);
        }

        [TestMethod]
        public void NamedParameters()
        {
            //int Sum(int lhs, int rhs) <--lhs is first then, rhs side
            //Named parameters can be used to change the order

            const int lhs = 6;
            const int rhs = 3;

            //here we have flipped the variables around
            var result = Sum(rhs: rhs, lhs: lhs);

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void OptionalParamaters()
        {
            const int lhs = 3;
            const int rhs = 4;

            UsingOptionalParameters(lhs, rhs);

            Console.WriteLine("-----------------");

            UsingOptionalParameters(lhs, rhs, "Change the text!");
        }

        #region Methods


        /// <summary>
        /// Prints something.
        /// 
        /// No parameters are taken in by this method
        /// 
        /// Return type is void, nothing is returned
        /// </summary>
        private static void PrintSomething()
        {
            Console.WriteLine("PrintSomething() was called!");
        }
        
        /// <summary>
        /// Sums two numbers together
        /// </summary>
        /// <param name="lhs">The left hand side value.</param>
        /// <param name="rhs">The right hand side value.</param>
        /// <returns>Return the sum as a type int</returns>
        private static int Sum(int lhs, int rhs)
        {
            return lhs + rhs;
        }

        public static void UsingOutParameters(out int lhs, out string rhs)
        {
            lhs = 42;
            rhs = "I be a string of knowledge yo.";
        }

        public static void UsingRefParameters(ref int lhs, ref string rhs)
        {
            lhs = 69;
            rhs = "I be that other string of knowledge yo.";
        }

        public static void UsingOptionalParameters(int one, int two, string s = "Default Text")
        {
            Console.WriteLine("{0} {1} {2}", one, two, s);
        }

        #endregion Methods
    }
}