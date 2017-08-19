using System;

namespace ProCSharp.Ch04.JupiterBank
{
    public class CurrentAccount : ITransferBankAccount
    {
        private decimal balance;

        public void PayIn(decimal amount)
        {
            balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            Console.WriteLine("Withdrawal attempt failed.");
            return false;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
        }

        public bool TransferTo(IBankAccount destination, decimal amount)
        {
            bool result;
            result = Withdraw(amount);
            if (result)
            {
                destination.PayIn(amount);
            }
            return result;
        }

        public override string ToString()
        {
            return String.Format("Jupiter Bank Current Account: Balance = {0,6:C}", balance);
        }
    }
}