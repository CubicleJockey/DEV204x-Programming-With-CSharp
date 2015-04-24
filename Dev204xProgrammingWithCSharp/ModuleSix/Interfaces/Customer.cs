using System;

namespace ModuleSix.Interfaces
{
    public class Customer : ILoyaltyCardHolder
    {
        public int TotalPoints { get; private set; }

        public int AddPoints(decimal transactionValue)
        {
            int points = Decimal.ToInt32(transactionValue);
            TotalPoints += points;
            return TotalPoints;
        }

        public void ResetPoints()
        {
            TotalPoints = 0;
        }
    }
}
