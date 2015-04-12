using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModuleThree
{
    [TestClass]
    public class Exceptions
    {
        [TestMethod]
        public void SafeDivision_Valid()
        {
            try
            {
                const double lhs = 5;
                const double rhs = 10;

                double result = SafeDivision(lhs, rhs);
                Console.WriteLine("{0} divided by {1} = {2}", lhs, rhs, result);
            }
            catch (DivideByZeroException dbzx)
            {
                //We will not get here or see this message
                Console.WriteLine(dbzx.Message);
            }
        }

        [TestMethod]
        public void SafeDivision_DivideByZero()
        {
            try
            {
                const double lhs = 67;
                const double rhs = 0;

                double result = SafeDivision(lhs, rhs);
                Console.WriteLine("We will not see this message");
            }
            catch (DivideByZeroException dbzx)
            {
                Console.WriteLine(dbzx.Message);
            }
        }

        #region Helper Methods

        public static double SafeDivision(double lhs, double rhs)
        {
            if (rhs == 0)
            {
                throw new DivideByZeroException();
            }
            return (lhs/rhs);
        }

        #endregion Helper Methods
    }
}
