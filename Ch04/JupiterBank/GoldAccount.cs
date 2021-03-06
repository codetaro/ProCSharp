﻿using System;

namespace ProCSharp.Ch04.JupiterBank
{
    public class GoldAccount : IBankAccount
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
            return String.Format("Jupiter Bank Saver: Balance = {0, 6:C}", balance);
        }
    }
}