using System;
using ProCSharp.Ch07;

namespace ProCSharp.Ch08
{
    public class Example
    {
        private delegate string GetAString();

        public static void Run()
        {
            /*int x = 40;
            GetAString firstStringMethod = new GetAString(x.ToString);
            Console.WriteLine("String is {0}", firstStringMethod());
            // With firstStringMethod initialized to x.ToString(),
            // the above statement is equivalent to saying
            // Console.WriteLine("String is {0}", x.ToString());*/

            int x = 40;
            GetAString firstStringMethod = x.ToString;
            Console.WriteLine("String is {0}", firstStringMethod());
            
            Currency balance = new Currency(34, 50);
            
            // firstStringMethod references an instance method
            firstStringMethod = balance.ToString;
            Console.WriteLine("String is {0}", firstStringMethod());
            
            // firstStringMethod references a static method
            firstStringMethod = new GetAString(Currency.GetCurrencyUnit);
            Console.WriteLine("String is {0}", firstStringMethod());
        }
    }
}