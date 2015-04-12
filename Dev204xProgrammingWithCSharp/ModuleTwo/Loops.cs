using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModuleTwo
{
    [TestClass]
    public class Loops
    {
        [TestMethod]
        public void ForLoop()
        {
            //an array of numbers 1 through 100
            var numbers = Enumerable.Range(1, 100).ToArray();

            //loop over each item in the numbers array
            for (var index = 0; index < numbers.Length; index++)
            {
                //print out the value to the screen
                Console.WriteLine(numbers[index]);
            }
        }

        [TestMethod]
        public void ForeachLoop()
        {
            //an IEnumerable<int> loopable like an array or list, because array and list both inherit from iEnumerable<T>
            //That is just something to note for when we get into classes
            var numbers = Enumerable.Range(1, 100);

            //loop over each item in the enumerable of integers
            foreach (var number in numbers)
            {
                //print out the value to the screen
                Console.WriteLine(number);
            }
        }

        [TestMethod]
        public void WhileLoop()
        {
            //Setting up things a little different to expose to different
            //ways of doing the same thing

            const int MAXNUMBER = 100;
            var numbers = Enumerable.Range(1, MAXNUMBER);
            var currentNumber = 0;

            while (currentNumber < MAXNUMBER)
            {
                //print out the value to the screen
                //.ElementAt(int) is an extension method, syntactic sugar
                //Documentation here: https://msdn.microsoft.com/en-us/library/bb383977.aspx
                Console.WriteLine(numbers.ElementAt(currentNumber++));

                /*
                 * Incrementing numbers with the ++ or Decrementing with the -- operator
                 * 
                 * If the incrementor/decrementor is in front of the number like this
                 * ++currentNumber or --currentNumber this is saying increase or decrease value before using it
                 * 
                 * If the incrementor/decrementor is behind the number like this
                 * currentNumber++ or currentNumber-- it means use the value then after increase or decrease the value
                 */
            }

        }

        [TestMethod]
        public void DoWhileLoop()
        {
            var numbers = Enumerable.Range(1, 100).ToList();

            //do-while loops will ALWAYS run at least once
            do
            {
                //indexes always start at 0, off by one if you only use count
                //Also in this instance different from the other loops
                //Lets print the numbers out biggest to smallest
                var index = (numbers.Count - 1);
                var number = numbers[index];
                numbers.RemoveAt(index);

                //display number on the screen
                Console.WriteLine(number);
            } while (numbers.Count > 0);

        }
    }
}
