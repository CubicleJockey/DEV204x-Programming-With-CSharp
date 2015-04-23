using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModuleFive
{
    [TestClass]
    public class CreatingAClass
    {
        [TestMethod]
        public void Main()
        {
            DrinksMachine machine = new DrinksMachine();
            machine._location = "Kitchen";
            machine._make = "Starbucks thingy";
            machine._model = "AwesomeModel";

            Console.WriteLine("Location: {0}", machine._location);
            Console.WriteLine("Make: {0}", machine._make);
            Console.WriteLine("Model: {0}", machine._model);

            machine.MakeCappuccino();
            machine.MakeExpresso();
        }
    }

    /*Creating a Class*/

    public class DrinksMachine
    {
        #region Fields

        /*
         * This is bad encapsulation practices, will show in encapulsation domo 
         * how to do the propper way.
         */
        public string _location;
        public string _make;
        public string _model;

        #endregion Fields

        #region Methods

        public void MakeCappuccino()
        {
            Console.WriteLine("Cappuccino is made.");
        }

        public void MakeExpresso()
        {
            Console.WriteLine("Expresso is made.");
        }

        #endregion Methods
    }
}
