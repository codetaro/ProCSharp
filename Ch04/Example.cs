using System;
using ProCSharp.Ch04.JupiterBank;
using ProCSharp.Ch04.VenusBank;

namespace ProCSharp.Ch04
{
    public class Example
    {
        public static void Run()
        {
            //            GenericCustomer customer = new Nevermore60Customer("Arabel Jones");
            
            IBankAccount venusAccount = new SaverAccount();
            ITransferBankAccount jupiterAccount = new CurrentAccount();
            venusAccount.PayIn(200);
            jupiterAccount.PayIn(500);
            jupiterAccount.TransferTo(venusAccount, 100);
            Console.WriteLine(venusAccount.ToString());
            Console.WriteLine(jupiterAccount.ToString());

        }
    }
}