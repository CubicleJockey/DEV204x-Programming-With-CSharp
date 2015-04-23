using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModuleFive.Encapulation
{
    [TestClass]
    public class Encapsulation
    {
        [TestMethod]
        public void Main()
        {
            DrinksMachine machine = new DrinksMachine("Kitchen", "Thingy", "StuffVersion");

            Console.WriteLine("Location: {0}", machine.Location);
            Console.WriteLine("Make: {0}", machine.Make);
            Console.WriteLine("Model: {0}", machine.Model);

            machine.MakeCappuccino();
            machine.MakeExpresso();
        }
    }

    public class DrinksMachine
    {
        #region Fields

        public string Location { get; set; } //auto-property style
        

        //With backing field style
        private string _model;
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        //Auto property in readonly style
        public string Make { get; private set; }

        #endregion Fields

        #region Constructors

        public DrinksMachine(string location, string model, string make)
        {
            /*
             * this. operator is only necessary if names are exactly the same
             * if the Property was location, the constrcutor would be able to 
             * tell the difference between the parameter location and Property location
             * 
             * You would then assign like below:
             * this.location = location
             */
            Location = location;
            Model = model;
            Make = make;
        }

        #endregion Constructors


        public void MakeCappuccino()
        {
            Console.WriteLine("Cappuccino is made.");
        }

        public void MakeExpresso()
        {
            Console.WriteLine("Expresso is made.");
        }
    }
}
