using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev204xProgrammingWithCSharp
{
    [TestClass]
    public class VariablesOperatorsExpressions
    {
        [TestMethod]
        public void Basics()
        {
            #region Variables

            /*
             *A statement declaring a variable using a data type
             *int and assigning it a value
             *
             * (int = integer, the int keyword is an alias to the Struct System.Int32)
             */
            int myVar = 2;

            /*
             * A statement declaring another int variable
             * Assignment takes place on another line
             */
            int secondVar;
            secondVar = 10;

            #endregion Variables

            #region Operators

            int sum = myVar + secondVar;
            int product = myVar * secondVar;
            int remainder = (myVar % secondVar);

            Assert.AreEqual(12, sum);
            Assert.AreEqual(20, product);
            Assert.AreEqual(2, remainder);



            /*
             * Explicit conversion:
             *      3 different versions all yielding the same result
             */
            double value = (double)myVar / secondVar;
            double value2 = myVar/(double) secondVar;
            double value3 = (double) myVar/(double) secondVar;

            const double EXPECTED = 0.2;

            Assert.AreEqual(EXPECTED, value);
            Assert.AreEqual(EXPECTED, value2);
            Assert.AreEqual(EXPECTED, value3);


            //Operator overloading where the + concats screens and doesn't do math
            string firstName = "Bat";
            string lastName = "Man";

            const string EXPECTEDNAME = "Bat Man";

            string fullName = firstName + " " + lastName;
            Assert.AreEqual(EXPECTEDNAME, fullName);

            //String place holders
            string fullName2 = string.Format("{0} {1}", firstName, lastName);
            Assert.AreEqual(EXPECTEDNAME, fullName2);

            #endregion Operators



            #region Expression





            #endregion Expression
        }
    }
}
