using System;

namespace ProCSharp.Ch04.VenusBank
{
    public class SaverAccount : IBankAccount
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

        public override string ToString()
        {
            return String.Format("Venus Bank Saver: Balance = {0, 6:C}", balance);
        }
    }
}