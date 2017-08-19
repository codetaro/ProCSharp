namespace ProCSharp.Ch04
{
    public interface IBankAccount
    {
        void PayIn(decimal amount);
        bool Withdraw(decimal amount);

        decimal Balance { get; }
    }
}