namespace ModuleSix.Interfaces
{
    public interface ILoyaltyCardHolder
    {
        int TotalPoints { get; }
        int AddPoints(decimal transactionValue);
        void ResetPoints();
    }
}