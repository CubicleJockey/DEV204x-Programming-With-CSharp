using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModuleFour
{
    [TestClass]
    public class Arrays
    {
        [TestMethod]
        public void ArrayBasics()
        {
            //Declare array of size 10
            int[] numbers = new int[10];

            //initialize values
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
            numbers[5] = 6;
            numbers[6] = 7;
            numbers[7] = 8;
            numbers[8] = 9;
            numbers[9] = 10;

            //Declare and initialize
            int[] numbers2 = {1, 2, 3, 4, 5}; //Size of 5 elements

            for (var counter = 0; counter < numbers2.Length; counter++)
            {
                Console.WriteLine("Number: {0}", counter);    
            }
        }

        [TestMethod]
        public void TwoDimensionalArray()
        {
            int[,] twoDimArray = { {3,2}, {4,5}, {5,6}};

            for (var i = 0; i < twoDimArray.GetLength(0); i++)
            {
                for (var j = 0; j < twoDimArray.GetLength(1); j++)
                {
                    var currentValue = twoDimArray[i, j];
                    Console.WriteLine(currentValue);
                }
            }
        }
    }
}
