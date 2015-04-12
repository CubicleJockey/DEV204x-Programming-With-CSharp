using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModuleTwo
{
    [TestClass]
    public class Conditionals
    {
        private readonly Random _random = new Random();

        [TestMethod]
        public void If()
        {
            //if(condition is true)

            bool condition = true;
            if (condition)
            {
                Console.WriteLine("Condition was met you will see this message in your output");
            }

            bool condition2 = false;
            if (condition2)
            {
                Console.WriteLine("Condition was NOT net you will NOT see this message in your output");
            }

        }

        [TestMethod]
        public void IfElse()
        {
            const string NAME = "CubicleJockey";

            if (NAME == "Batman")
            {
                Console.WriteLine("This person is obviously Batman");
            }
            else
            {
                Console.WriteLine("This person is obviously NOT Batman");
            }
        }

        [TestMethod]
        public void IfElseIfElse()
        {
            //get a random number with a max of 3
            var number = _random.Next(3);

            if (number == 1)
            {
                Console.WriteLine("Number was One");
            }
            else if (number == 2)
            {
                Console.WriteLine("Number was Two");
            }
            else
            {
                Console.WriteLine("Number was Three");
            }
        }

        [TestMethod]
        public void IfElseOperator()
        {
            //This is exactly the same ability as a regular if/else it's just written in operator form
            bool randomBoolean = (_random.NextDouble() >= 0.5);

            //? = if and : = else
            var result = randomBoolean ? "Was True" : "Was False"; 
            Console.WriteLine(result);
        }

        [TestMethod]
        public void SwitchStatement()
        {

            var number = _random.Next(4);
            switch (number)
            {
                case 0:
                    Console.WriteLine("Number was Zero");
                    break;
                case 1:
                    Console.WriteLine("Number was One");
                    break;
                case 2:
                    Console.WriteLine("Number was Two");
                    break;
                case 3:
                    Console.WriteLine("Number was Three");
                    break;
                case 4:
                    Console.WriteLine("Number was Four");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(string.Format("Unexpected value was generated. {0}", number));
            }
        }
    }
}
