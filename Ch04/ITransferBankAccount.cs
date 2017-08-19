namespace ProCSharp.Ch04
{
    public interface ITransferBankAccount : IBankAccount
    {
        bool TransferTo(IBankAccount destination, decimal amount);
    }
}